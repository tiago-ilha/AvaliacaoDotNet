using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC.CadastroExterno.ModeloDeDominio.SCEs.Entidades
{
	public class PessoaFisica : Pessoa
    {
        protected PessoaFisica() {}
        public PessoaFisica(
            string nomeCompleto, 
            string cpf, 
            DateTime dataDeNascimento, 
            string sexo, 
            IList<Telefone> telefones,
            IList<Email> emails,
            IList<Endereco> enderecos) : base()
        {
            this.DataDeNascimento = dataDeNascimento;
            this.Sexo = sexo;

            this.AdicionarTelefones(telefones);
            this.AdicionarEmails(emails);
            this.AdicionarEnderecos(enderecos);
        }

        public string NomeCompleto { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public string Sexo { get; private set; }
        // public Logotipo Logotipo { get; private set; }

        public static PessoaFisica CriarComTodosOsDados(
            string nomeCompleto, 
            string cpf, 
            DateTime dataDeNascimento, 
            string sexo, 
            IList<Telefone> telefones,
            IList<Email> emails,
            IList<Endereco> enderecos)
		{
			return new PessoaFisica(nomeCompleto, cpf, dataDeNascimento, sexo, telefones, emails, enderecos);
		}

        // public void AssociarLogotipo(Logotipo logotipo)
        // {
        //     this.Logotipo = logotipo;

        //     this.AddNotifications(this.Logotipo.Notifications);
        // }
    }
}
