using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC.CadastroExterno.ModeloDeDominio.SCEs.Entidades
{
	public class Telefone : Entidade
    {
        protected Telefone() {}
        private Telefone(string numero)
        {
            Numero = numero;
        }

        public string Numero { get; private set; }

		public static Telefone Criar(string numero)
		{
			return new Telefone(numero);
		}
    }
}
