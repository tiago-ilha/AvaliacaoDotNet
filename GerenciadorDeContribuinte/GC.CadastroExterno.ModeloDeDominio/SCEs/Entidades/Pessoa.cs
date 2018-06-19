using System.Collections.Generic;
using System.Linq;

namespace GC.CadastroExterno.ModeloDeDominio.SCEs.Entidades
{
	public abstract class Pessoa : Entidade
	{
		private IList<Telefone> _telefones;
		private List<Email> _emails;
		private List<Endereco> _enderecos;

		public Pessoa()
		{
			_telefones = new List<Telefone>();
			_emails = new List<Email>();
			_enderecos = new List<Endereco>();
		}

		public ICollection<Telefone> Telefones
		{
			get { return _telefones.ToArray(); }
		}

		public ICollection<Email> Emails
		{
			get
			{
				return _emails.ToArray();
			}
		}
		public ICollection<Endereco> Enderecos
		{
			get
			{
				return _enderecos.ToArray();
			}
		}

		public void AdicionarTelefones(IList<Telefone> listaDeTelefones)
		{
			//if (listaDeTelefones.Count == 0)
			//{
			//	AddNotification("Telefones", "Informe pelo menos 1 Telefone.");
			//	return;
			//}

			listaDeTelefones.ToList().ForEach(x => _telefones.Add(x));
		}

		public void AdicionarEmails(IList<Email> listaDeEmails)
		{
			//if (listaDeEmails.Count == 0)
			//{
			//	AddNotification("Emails", "Informe pelo menos 1 E-mail.");
			//	return;
			//}

			listaDeEmails.ToList().ForEach(x => _emails.Add(x));
		}

		public void AdicionarEnderecos(IList<Endereco> listaDeEnderecos)
		{
			// PodeAdicinarEnderecos(listaDeEnderecos);

			listaDeEnderecos.ToList().ForEach(x => _enderecos.Add(x));
		}

		// private void PodeAdicinarEnderecos(IList<Endereco> listaDeEnderecos)
		// {
		//     if (listaDeEnderecos.Count == 0)
		//     {
		//         AddNotification("Enderecos", "A lista de endereços é de preenchimento obrigatório.");
		//     }
		//     else
		//     {
		//         var temResidencial = PossuiEnderecoDoTipo(listaDeEnderecos, TipoEnderecoEnum.Residencial);
		//         var temCorrespondencia = PossuiEnderecoDoTipo(listaDeEnderecos, TipoEnderecoEnum.Correspondencia);
		//         var temProfissional = PossuiEnderecoDoTipo(listaDeEnderecos, TipoEnderecoEnum.Profissional);

		//         if (!temResidencial || !temCorrespondencia || !temProfissional)
		//         {
		//             AddNotification("Enderecos", "Você deve informar o endereço de Correspondência, Residencial e Profissional.");
		//         }
		//     }

		//     var possuiTipoEnderecoInformado = PossuiEnderecoDoTipo(listaDeEnderecos, TipoEnderecoEnum.NaoInformado);

		//     if (possuiTipoEnderecoInformado)
		//         AddNotification("Enderecos", "Não é permitido inserir endereço com tipo Não Informado.");

		//     // var logradouroNaoCadastrado = _pessoaFisica.Enderecos.Any(x => x.Logradouro.Nome == null || x.Bairro.Nome.Contains("Não informado") && x.Logradouro.Nome.Contains("(Localidade)"));

		//     // if (logradouroNaoCadastrado)
		//     // {
		//     // 	_msgRetorno.AdicionarSubMensagem(Mensagem.Criar("Logradouro não cadastrado no sistema para maiores informações entre em contato com o município.", "tabelaEnderecos", MensagemEnum.ERRO));
		//     // }
		// }

		// private bool PossuiEnderecoDoTipo(IList<Endereco> listaDeEnderecos, TipoEnum tipoEndereco) => 
		//     listaDeEnderecos.Any(x => x.TipoEndereco == tipoEndereco);
	}
}
