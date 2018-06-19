using GC.CadastroExterno.ModeloDeDominio.SCEs;
using GC.CadastroExterno.ModeloDeDominio.SCEs.Repositorios;
using GC.CadastroExterno.ModeloDeDominio.SCEs.Servicos;

namespace GC.CadastroExterno.ServicoDeDominio.SCEs.Servicos
{
	public class SolicitarSCEPFAutonomo : ISolicitarSCE
	{
		private readonly ISceRepositorio _repositorio;

		public SolicitarSCEPFAutonomo(ISceRepositorio repositorio)
		{
			_repositorio = repositorio;
		}

		public void Executar(SCE sce)
		{
			//AddNotifications(sce);

			//if (Valid)
			//{
				_repositorio.Salvar(sce);
			//}
		}
	}
}
