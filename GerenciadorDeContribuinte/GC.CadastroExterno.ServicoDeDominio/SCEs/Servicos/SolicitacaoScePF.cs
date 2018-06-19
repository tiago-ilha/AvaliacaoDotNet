using GC.CadastroExterno.ModeloDeDominio.SCEs.Repositorios;
using GC.CadastroExterno.ModeloDeDominio.SCEs.Servicos;

namespace GC.CadastroExterno.ServicoDeDominio.SCEs.Servicos
{
	public class SolicitacaoScePF : ISolicitacaoScePF
	{
		private readonly ISceRepositorio _repositorio;

		public SolicitacaoScePF(ISceRepositorio repositorio)
		{
			_repositorio = repositorio;
		}

		public ISolicitarSCE Verificar(bool indicaAvulso)
		{
			if (indicaAvulso)
				return new SolicitarSCEPFAvulsa(_repositorio);
			else
				return new SolicitarSCEPFAutonomo(_repositorio);
		}
	}
}
