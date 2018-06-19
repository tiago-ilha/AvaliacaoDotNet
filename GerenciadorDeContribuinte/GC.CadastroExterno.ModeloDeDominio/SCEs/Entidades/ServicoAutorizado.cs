using GC.CadastroExterno.ModeloDeDominio.SCEs.ObjetosDeValor;
using System;

namespace GC.CadastroExterno.ModeloDeDominio.SCEs.Entidades
{
	public class ServicoAutorizado : Entidade
	{
		public ServicoAutorizado(TipoAtividadeMunicipio tipoAtividadeMunicipio, DateTime dataInicio, DateTime dataFim)
		{
			this.TipoAtividadeMunicipio = tipoAtividadeMunicipio;
			this.DataInicio = dataInicio;
			this.DataFim = DataFim;
		}
		
		public TipoAtividadeMunicipio TipoAtividadeMunicipio { get; private set; }
		public DateTime DataInicio { get; private set; }
		public DateTime DataFim { get; set; }
	}
}
