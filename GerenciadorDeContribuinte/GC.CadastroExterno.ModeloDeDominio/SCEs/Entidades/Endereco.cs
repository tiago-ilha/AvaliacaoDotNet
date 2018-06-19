using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC.CadastroExterno.ModeloDeDominio.SCEs.Entidades
{
	public class Endereco : Entidade
	{
		protected Endereco() { }
		private Endereco(string tipoLogradouro, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado)
		{
			TipoLogradouro = tipoLogradouro;
			Cep = cep;
			Logradouro = logradouro;
			Numero = numero;
			Complemento = complemento;
			Bairro = bairro;
			Cidade = cidade;
			Estado = estado;
		}

		public string TipoLogradouro { get; private set; }
		public string Cep { get; private set; }
		public string Logradouro { get; private set; }
		public string Numero { get; private set; }
		public string Complemento { get; private set; }
		public string Bairro { get; private set; }
		public string Cidade { get; private set; }
		public string Estado { get; private set; }

		public static Endereco Criar(string tipoLogradouro, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado)
		{
			return new Endereco(tipoLogradouro, cep, logradouro, numero, complemento, bairro, cidade, estado);
		}
	}
}
