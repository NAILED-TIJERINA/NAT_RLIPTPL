using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.Sql;


namespace AnalizadorLexico
{
    public partial class Form1 : Form
    {
        List<Identificador> miListaIDEN = new List<Identificador>();
        List<ConstanteNumerica> miListaCONU = new List<ConstanteNumerica>();
        Identificador miIde;
        ConstanteNumerica miConu = new ConstanteNumerica();
        Random r = new Random();
        int IDEN = 0, CONU = 0; 
        
        public Form1()
        {
            InitializeComponent();
            txtInstruccion.ReadOnly = true;
            txtCantRenglones.ReadOnly = true;
            dtgIde.Columns.Add("SIMBOLO", "SIMBOLO");
            dtgIde.Columns.Add("TOKEN", "TOKEN");
            dtgIde.ReadOnly = true;
            dtgConu.ReadOnly = true;
            dtgConu.Columns.Add("SIMBOLO","SIMBOLO");
            dtgConu.Columns.Add("TOKEN", "TOKEN");
            dtgIde.AllowUserToAddRows = false;
            dtgConu.AllowUserToAddRows = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //miConexion.Abrir();
         
        }

        private void btnCargarInstruccion_Click(object sender, EventArgs e)
        {
            try
            {
                //El dialogo solo Muetra los Archivos .txt
                openFileDialog1.Filter = "Archivos txt| *.txt";
                //Nombre del Archivo Seleccionado
                openFileDialog1.FileName = "Seleccione un archivo de Texto";
                // Nombre del Programa
                openFileDialog1.Title = "Lector de Archivo de Texto";
                //Directorio Inicial
                openFileDialog1.InitialDirectory = "C:/";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    //Coloca la dirección del Archivo
                    this.txtdireccion.Text = openFileDialog1.FileName;
                }

                System.IO.StreamReader sr = new System.IO.StreamReader(@txtdireccion.Text, System.Text.Encoding.Default);

                string texto;
                texto = sr.ReadToEnd();
                sr.Close();
                txtInstruccion.Text = texto;
                txtCantRenglones.Text = (txtInstruccion.GetLineFromCharIndex(txtInstruccion.TextLength) + 1).ToString();
            }
            catch (Exception Ex)
            {

                MessageBox.Show("Error " + Ex.Message);
            }
            
            string Estado = "0";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = PC-NAILED\SQLEXPRESS; Initial Catalog = OINKLANGUAGE; Integrated Security = True";
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            //
            int intIndicadorSaltoLinea = 0;
            int i;
            bool llave = false;

            //Ver cuanto mide la cadena completa
            label1.Text = txtInstruccion.TextLength.ToString();
            for (i = 0; i <= txtInstruccion.Text.Length; i++)
            {
                if (i != txtInstruccion.Text.Length)
                {
                    label2.Text = i.ToString();
                    if (txtInstruccion.Text.Substring(i, 1) == " " || intIndicadorSaltoLinea > 1)
                    {
                        FinCadena(Estado, cn, command, intIndicadorSaltoLinea, i, llave);
                        Estado = "0";
                        if (intIndicadorSaltoLinea > 1)
                        {
                            i--;
                            //
                        }
                        intIndicadorSaltoLinea = 0;
                        i++;
                    }
                    if (txtInstruccion.Text.Substring(i, 1) == "\r" || txtInstruccion.Text.Substring(i, 1) == "\n")
                    {
                    //lblprueba.Text = lblprueba.Text + 1 ; --------> ????
                    intIndicadorSaltoLinea++;
                    }
                    else
                    {
                        MessageBox.Show("Se capturó " + txtInstruccion.Text.Substring(i, 1));
                        txtSubcadena.Text = txtSubcadena.Text + txtInstruccion.Text.Substring(i, 1);
                        command.CommandText = "SELECT [C" + txtInstruccion.Text.Substring(i, 1) + "] FROM MATRIZDETRANSICION WHERE ESTADO =" + Estado;
                        DataTable data = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(data);
                        foreach (DataRow d in data.Rows)
                        {
                            foreach (DataColumn c in data.Columns)
                            {
                                Estado = d[c].ToString();
                            }
                        }
                        MessageBox.Show("Pausa");
                    }

                }
                else
                {
                    llave = true;
                    FinCadena(Estado, cn, command, intIndicadorSaltoLinea, i, llave);
                }
                ///Comparo si es delimitador o llegó a un fin de linea
            }
        }
      
       
        public void FinCadena(string Estado, SqlConnection cn, SqlCommand command, int intIndicadorSaltoLinea, int i, bool llave)
        {
            command.CommandText = "SELECT DEL FROM MATRIZDETRANSICION WHERE ESTADO = " + Estado;
            DataTable data1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter(command);
            adapter1.Fill(data1);
            foreach (DataRow d in data1.Rows)
            {
                foreach (DataColumn c in data1.Columns)
                {
                    Estado = d[c].ToString();
                }
            }

            command.CommandText = "SELECT TOKEN FROM MATRIZDETRANSICION WHERE ESTADO=" + Estado;
           
            DataTable data4 = new DataTable();
            SqlDataAdapter adapter4 = new SqlDataAdapter(command);
            adapter4.Fill(data4);
            
            foreach (DataRow d in data4.Rows)
            {
                foreach (DataColumn c in data4.Columns)
                {
                    Estado = d[c].ToString();
                }
            }
            //No eso no está bien
            miIde = new Identificador();
            miConu = new ConstanteNumerica();
            miIde.Simbolo = txtSubcadena.Text;
            miConu.Simbolo = txtSubcadena.Text;
            
            //AQUI VA EL METODO
            int n;
            int m;
            bool bandera = false;
            if (Estado == "IDEN")
            {
                //a ver           
              
                if (miListaIDEN.Count >= 1)
                {
                   //foreach(IDentificador ide in miListaIde)

                    for(n = 0; n < dtgIde.Rows.Count ; n++)
                    {
                        //if(miIde.Simbolo.Equals(ide.Simbolo))
                        if (miIde.Simbolo == dtgIde.Rows[n].Cells["SIMBOLO"].Value.ToString())
                        {
                            MessageBox.Show("Error: No pueden existir SIMBOLOS DUPLICADOS", "DUPLICADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Estado = dtgIde.Rows[n].Cells["TOKEN"].Value.ToString();
                            bandera = true;
                            continue;
                            
                        }
                        
                       
                    
                    }
                    if (bandera == false)
                    {
                        miIde.Simbolo = txtSubcadena.Text;
                        miIde.Token = "IDE" + IDEN;
                        IDEN++;
                        Estado = miIde.Token;
                        miListaIDEN.Add(miIde);
                        
                        MostrarDatos(1);
                    }
                    else
                        bandera = false;
                }
                else if (miListaIDEN.Count == 0)
                {
                    miIde.Simbolo = txtSubcadena.Text;
                    miIde.Token = "IDE" + IDEN;
                    IDEN++;
                    Estado = miIde.Token;
                    miListaIDEN.Add(miIde);
                    
                   MostrarDatos(1);
                }
            }
            //aqui?
            else if (Estado == "CONU")
            {
                if (miListaCONU.Count >= 1)
                {

                    for (m = 0; m < dtgConu.Rows.Count; m++)
                    {
                        if (miConu.Simbolo == dtgConu.Rows[m].Cells["SIMBOLO"].Value.ToString())
                        {
                            MessageBox.Show("Error: No pueden existir SIMBOLOS DUPLICADOS", "DUPLICADO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Estado = dtgConu.Rows[m].Cells["TOKEN"].Value.ToString();
                            bandera = true;
                            
                        }
                        
                    }
                    if (bandera == false)
                    {
                        miConu.Simbolo = txtSubcadena.Text;
                        miConu.Token = "CON" + CONU;
                        CONU++;
                        Estado = miConu.Token;
                        miListaCONU.Add(miConu);
                        MostrarDatos(2);
                    }
                    else
                        bandera = false;
                }
                else if (miListaCONU.Count == 0)
                {
                    miConu.Simbolo = txtSubcadena.Text;
                    miConu.Token = "CON" + CONU;
                    CONU++;
                    Estado = miConu.Token;
                    miListaCONU.Add(miConu);
                    MostrarDatos(2);
                }
            }
            else if (Estado == "ERROR")
            {
                MessageBox.Show("Lo que ingreso es invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.Close();
            }

            if (Estado != null)
            {
                txtEvaluacion.Text = txtEvaluacion.Text + Estado + " "; //devuelve el token PR12
                label1.Text = txtInstruccion.TextLength.ToString();
            }
            else
            {
                throw new Exception("Error 2");
            }
            ///Reinicio Subcadena a evaluar
            //Reiniciar estado
            Estado = "0";
            txtSubcadena.Clear();
            if (intIndicadorSaltoLinea > 1 || llave)
            {
                //Reinicio evaluacion del token
                //vaciar a archivo de token                        
                txtTokens.Text = txtTokens.Text + txtEvaluacion.Text + " " + "\r\n";
                txtSubcadena.Clear();
                txtEvaluacion.Clear();
                i--;
            }
            intIndicadorSaltoLinea = 0;
            MessageBox.Show("Llegó un DEL o fin de linea");
            i++;
        }
        public void MostrarDatos(int tabla)
        {
            switch (tabla)
            {
                case 1:
                    dtgIde.Rows.Clear();
                    foreach (Identificador ide in miListaIDEN)
                    {
                        dtgIde.Rows.Add(ide.Simbolo, ide.Token);
                    }
                    break;
                case 2:
                    dtgConu.Rows.Clear();
                    foreach (ConstanteNumerica conu in miListaCONU)
                    {
                        dtgConu.Rows.Add(conu.Simbolo, conu.Token);
                    }
                    break;
            }
        }
    }
}

