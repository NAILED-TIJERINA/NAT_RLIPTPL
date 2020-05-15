namespace AnalizadorLexico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSubcadena = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.lblTokens = new System.Windows.Forms.Label();
            this.lblCantRenglones = new System.Windows.Forms.Label();
            this.txtSubcadena = new System.Windows.Forms.TextBox();
            this.txtEvaluacion = new System.Windows.Forms.TextBox();
            this.txtCantRenglones = new System.Windows.Forms.TextBox();
            this.btnCargarInstruccion = new System.Windows.Forms.Button();
            this.txtInstruccion = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtTokens = new System.Windows.Forms.TextBox();
            this.dtgIde = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgConu = new System.Windows.Forms.DataGridView();
            this.lblIde = new System.Windows.Forms.Label();
            this.lblConu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubcadena
            // 
            this.lblSubcadena.AutoSize = true;
            this.lblSubcadena.Location = new System.Drawing.Point(21, 216);
            this.lblSubcadena.Name = "lblSubcadena";
            this.lblSubcadena.Size = new System.Drawing.Size(113, 13);
            this.lblSubcadena.TabIndex = 0;
            this.lblSubcadena.Text = "Subcadena a Evaluar:";
            this.lblSubcadena.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(21, 277);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(106, 13);
            this.lblToken.TabIndex = 1;
            this.lblToken.Text = "Evaluacion o Token:";
            this.lblToken.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTokens
            // 
            this.lblTokens.AutoSize = true;
            this.lblTokens.Location = new System.Drawing.Point(21, 337);
            this.lblTokens.Name = "lblTokens";
            this.lblTokens.Size = new System.Drawing.Size(102, 13);
            this.lblTokens.TabIndex = 2;
            this.lblTokens.Text = "Archivos de Tokens";
            this.lblTokens.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCantRenglones
            // 
            this.lblCantRenglones.AutoSize = true;
            this.lblCantRenglones.Location = new System.Drawing.Point(355, 100);
            this.lblCantRenglones.Name = "lblCantRenglones";
            this.lblCantRenglones.Size = new System.Drawing.Size(83, 13);
            this.lblCantRenglones.TabIndex = 3;
            this.lblCantRenglones.Text = "# de Renglones";
            // 
            // txtSubcadena
            // 
            this.txtSubcadena.Location = new System.Drawing.Point(24, 232);
            this.txtSubcadena.Name = "txtSubcadena";
            this.txtSubcadena.Size = new System.Drawing.Size(301, 20);
            this.txtSubcadena.TabIndex = 5;
            // 
            // txtEvaluacion
            // 
            this.txtEvaluacion.Location = new System.Drawing.Point(24, 302);
            this.txtEvaluacion.Name = "txtEvaluacion";
            this.txtEvaluacion.Size = new System.Drawing.Size(301, 20);
            this.txtEvaluacion.TabIndex = 6;
            // 
            // txtCantRenglones
            // 
            this.txtCantRenglones.Location = new System.Drawing.Point(358, 128);
            this.txtCantRenglones.Name = "txtCantRenglones";
            this.txtCantRenglones.Size = new System.Drawing.Size(53, 20);
            this.txtCantRenglones.TabIndex = 8;
            // 
            // btnCargarInstruccion
            // 
            this.btnCargarInstruccion.Location = new System.Drawing.Point(356, 36);
            this.btnCargarInstruccion.Name = "btnCargarInstruccion";
            this.btnCargarInstruccion.Size = new System.Drawing.Size(142, 48);
            this.btnCargarInstruccion.TabIndex = 9;
            this.btnCargarInstruccion.Text = "&Cargar";
            this.btnCargarInstruccion.UseVisualStyleBackColor = true;
            this.btnCargarInstruccion.Click += new System.EventHandler(this.btnCargarInstruccion_Click);
            // 
            // txtInstruccion
            // 
            this.txtInstruccion.Location = new System.Drawing.Point(23, 12);
            this.txtInstruccion.Multiline = true;
            this.txtInstruccion.Name = "txtInstruccion";
            this.txtInstruccion.Size = new System.Drawing.Size(302, 187);
            this.txtInstruccion.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(340, 10);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(274, 20);
            this.txtdireccion.TabIndex = 11;
            // 
            // txtTokens
            // 
            this.txtTokens.Location = new System.Drawing.Point(24, 366);
            this.txtTokens.Multiline = true;
            this.txtTokens.Name = "txtTokens";
            this.txtTokens.Size = new System.Drawing.Size(301, 174);
            this.txtTokens.TabIndex = 13;
            // 
            // dtgIde
            // 
            this.dtgIde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIde.Location = new System.Drawing.Point(358, 366);
            this.dtgIde.Name = "dtgIde";
            this.dtgIde.Size = new System.Drawing.Size(243, 174);
            this.dtgIde.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // dtgConu
            // 
            this.dtgConu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConu.Location = new System.Drawing.Point(646, 366);
            this.dtgConu.Name = "dtgConu";
            this.dtgConu.Size = new System.Drawing.Size(240, 174);
            this.dtgConu.TabIndex = 17;
            // 
            // lblIde
            // 
            this.lblIde.AutoSize = true;
            this.lblIde.Location = new System.Drawing.Point(435, 327);
            this.lblIde.Name = "lblIde";
            this.lblIde.Size = new System.Drawing.Size(104, 13);
            this.lblIde.TabIndex = 18;
            this.lblIde.Text = "IDENTIFICADORES";
            // 
            // lblConu
            // 
            this.lblConu.AutoSize = true;
            this.lblConu.Location = new System.Drawing.Point(699, 327);
            this.lblConu.Name = "lblConu";
            this.lblConu.Size = new System.Drawing.Size(147, 13);
            this.lblConu.TabIndex = 19;
            this.lblConu.Text = "CONSTANTES NUMERICAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 579);
            this.Controls.Add(this.lblConu);
            this.Controls.Add(this.lblIde);
            this.Controls.Add(this.dtgConu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgIde);
            this.Controls.Add(this.txtTokens);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtInstruccion);
            this.Controls.Add(this.btnCargarInstruccion);
            this.Controls.Add(this.txtCantRenglones);
            this.Controls.Add(this.txtEvaluacion);
            this.Controls.Add(this.txtSubcadena);
            this.Controls.Add(this.lblCantRenglones);
            this.Controls.Add(this.lblTokens);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.lblSubcadena);
            this.Name = "Form1";
            this.Text = "formap";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubcadena;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label lblTokens;
        private System.Windows.Forms.Label lblCantRenglones;
        private System.Windows.Forms.TextBox txtSubcadena;
        private System.Windows.Forms.TextBox txtEvaluacion;
        private System.Windows.Forms.TextBox txtCantRenglones;
        private System.Windows.Forms.Button btnCargarInstruccion;
        private System.Windows.Forms.TextBox txtInstruccion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtTokens;
        private System.Windows.Forms.DataGridView dtgIde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgConu;
        private System.Windows.Forms.Label lblIde;
        private System.Windows.Forms.Label lblConu;
    }
}

