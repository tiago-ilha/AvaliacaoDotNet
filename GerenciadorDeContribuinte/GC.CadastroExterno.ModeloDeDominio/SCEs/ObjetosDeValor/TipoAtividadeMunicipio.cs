
namespace GC.CadastroExterno.ModeloDeDominio.SCEs.ObjetosDeValor
{
	public class TipoAtividadeMunicipio
	{
		private TipoAtividadeMunicipio(string identificador, string descricao)
		{
			this.Identificador = identificador;
			this.Descricao = descricao;
		}

		public string Identificador { get; private set; }
		public string Descricao { get; private set; }

		public static TipoAtividadeMunicipio Criar(string identificador, string descricao)
		{
			return new TipoAtividadeMunicipio(identificador, descricao);
		}
	}
}
