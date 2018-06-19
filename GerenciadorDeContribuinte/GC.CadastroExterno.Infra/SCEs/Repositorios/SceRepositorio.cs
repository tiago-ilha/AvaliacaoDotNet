using GC.CadastroExterno.ModeloDeDominio.SCEs;
using GC.CadastroExterno.ModeloDeDominio.SCEs.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace GC.CadastroExterno.Infra.SCEs.Repositorios
{
	public class SceRepositorio : ISceRepositorio
	{
		private IList<SCE> SCes = new List<SCE>();

		public void Salvar(SCE sce)
		{
			this.SCes.Add(sce);
		}

		public IList<SCE> Listar()
		{
			return this.SCes.ToList();
		}
	}
}
