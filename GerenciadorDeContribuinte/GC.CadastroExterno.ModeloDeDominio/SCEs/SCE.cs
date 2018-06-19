using GC.CadastroExterno.ModeloDeDominio.SCEs.Entidades;
using GC.CadastroExterno.ModeloDeDominio.SCEs.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GC.CadastroExterno.ModeloDeDominio.SCEs
{
	public class SCE : Agregador
	{
		private List<ServicoAutorizado> _servicosAutorizados;

		public SCE(Pessoa pessoa)
		{
			this.Pessoa = pessoa;
			this._servicosAutorizados = new List<ServicoAutorizado>();
		}

		public long? Numero { get; protected set; }
		public Pessoa Pessoa { get; protected set; }

		public DateTime? DataDeSolicitacao { get; protected set; }
		public DateTime? DataDeConferencia { get; protected set; }
		public DateTime? DataDeAprovacao { get; protected set; }
		public DateTime? DataDeRejeicao { get; protected set; }

		public ICollection<ServicoAutorizado> ServicosAutorizados 
		{
			get
			{
				return _servicosAutorizados.ToArray();
			}
		}

		public TipoSituacaoSCEENum Situacao { get; protected set; }

		public static SCE Criar(Pessoa pessoa)
		{
			return new SCE(pessoa);
		}

		public void AdicionarServicosAutorizados(IList<ServicoAutorizado> servicosAutorizados)
		{
			servicosAutorizados.ToList().ForEach(x => _servicosAutorizados.Add(x));
		}

		public void Solicitar()
		{
			this.Situacao = TipoSituacaoSCEENum.Solicitado;
			this.DataDeSolicitacao = DateTime.Now;
		}

		public void Conferir()
		{
			//if (PodeConferir())
			//{
			//	AddNotification("Situacao", $"Não é permitiro conferir um SCE com situação {this.Situacao}. Apenas solicitado ou previamente conferido.");
			//}

			this.Situacao = TipoSituacaoSCEENum.Conferido;
			this.DataDeConferencia = DateTime.Now;
		}


		public void Aprovar()
		{
			this.Situacao = TipoSituacaoSCEENum.Aprovado;
			this.DataDeAprovacao = DateTime.Now;
		}

		public void Rejeitar()
		{
			this.Situacao = TipoSituacaoSCEENum.Rejeitado;
			this.DataDeRejeicao = DateTime.Now;
		}

		private bool PodeConferir()
		{
			return this.Situacao.Equals(TipoSituacaoSCEENum.Solicitado) ||
				   this.Situacao.Equals(TipoSituacaoSCEENum.Conferido);
		}
	}
}
