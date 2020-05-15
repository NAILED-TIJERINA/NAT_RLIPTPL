using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico 
{
    class Identificador : IEquatable<Identificador>
	{
		private string _strSimbolo;

		public string Simbolo
		{
			get { return _strSimbolo; }
			set { _strSimbolo = value; }
		}
		private string _strToken;

		public string Token
		{
			get { return _strToken; }
			set { _strToken = value; }
		}
		public bool Equals(Identificador miIde)
		{
			return (this.Simbolo == miIde.Simbolo);
		}
	}
}
