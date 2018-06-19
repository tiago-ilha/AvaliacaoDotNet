using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC.CadastroExterno.ModeloDeDominio.SCEs.Entidades
{
	public class Email : Entidade
	{
		protected Email() { }
		private Email(string endereco)
		{
			Endereco = endereco;
		}

		public string Endereco { get; private set; }

		public static Email Criar(string endereco)
		{
			return new Email(endereco);
		}
	}
}
