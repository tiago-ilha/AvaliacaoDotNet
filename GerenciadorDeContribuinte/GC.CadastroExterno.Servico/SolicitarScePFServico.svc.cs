using GC.CadastroExterno.Infra.SCEs.Repositorios;
using GC.CadastroExterno.ModeloDeDominio.SCEs;
using GC.CadastroExterno.ModeloDeDominio.SCEs.Entidades;
using GC.CadastroExterno.ModeloDeDominio.SCEs.Repositorios;
using GC.CadastroExterno.ModeloDeDominio.SCEs.Servicos;
using GC.CadastroExterno.ServicoDeDominio.SCEs.Servicos;
using System.Collections.Generic;

namespace GC.CadastroExterno.Servico
{
	public class SolicitarScePFServico : ISolicitarScePFServico
	{
		private ISolicitacaoScePF _verificar;
		private ISceRepositorio _repositorio;

		public SolicitarScePFServico()
		{
			_repositorio = new SceRepositorio();
			_verificar = new SolicitacaoScePF(_repositorio);
		}

		public void Salvar(SolicitarScePF solicitacao)
		{
			Pessoa pessoaFisica = GerarPessoaFisica(solicitacao);

			var sce = SCE.Criar(pessoaFisica);

			var casoDeUso = _verificar.Verificar(solicitacao.IndicaAvulso);

			casoDeUso.Executar(sce);
		}

		private Pessoa GerarPessoaFisica(SolicitarScePF solicitacao)
		{
			IList<Telefone> listaDeTelefones;
			IList<Email> listaDeEmails;
			IList<Endereco> listaDeEnderecos;

			GerarListaDeTelefones(solicitacao.Telefones, out listaDeTelefones);
			GerarListDeEmails(solicitacao.Emails, out listaDeEmails);
			GerarListDeEnderecos(solicitacao.Enderecos, out listaDeEnderecos);

			var pessoaFisica = PessoaFisica.CriarComTodosOsDados
			(
				solicitacao.NomeCompleto,
				solicitacao.Cpf,
				solicitacao.DataDeNascimento,
				solicitacao.Sexo,
				listaDeTelefones,
				listaDeEmails,
				listaDeEnderecos
			);

			return pessoaFisica;
		}

		private void GerarListDeEmails(IList<EmailViewModel> emails, out IList<Email> listaDeEmails)
		{
			listaDeEmails = new List<Email>();

			if (emails.Count > 0)
			{
				foreach (var item in emails)
					listaDeEmails.Add(Email.Criar(item.Endereco));
			}
		}

		private void GerarListaDeTelefones(IList<TelefoneViewModel> telefones, out IList<Telefone> listaDeTelefones)
		{
			listaDeTelefones = new List<Telefone>();

			if (telefones.Count > 0)
			{
				foreach (var item in telefones)
					listaDeTelefones.Add(Telefone.Criar(item.Numero));
			}
		}

		private void GerarListDeEnderecos(IList<EnderecoViewModel> enderecos, out IList<Endereco> listaDeEnderecos)
		{
			listaDeEnderecos = new List<Endereco>();

			if (enderecos.Count > 0)
			{
				foreach (var item in enderecos)
				{
					listaDeEnderecos.Add
					(
						Endereco.Criar(item.TipoEndereco, item.Cep, item.Logradouro, item.Numero, item.Complemento, item.Bairro, item.Cidade, item.Estado)
					);
				}
			}
		}
	}
}
