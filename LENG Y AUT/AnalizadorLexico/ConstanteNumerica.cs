using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class ConstanteNumerica : IEquatable<ConstanteNumerica>
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
		public bool Equals(ConstanteNumerica miConu)
		{
			return (this.Simbolo == miConu.Simbolo);
		}
	}
}
