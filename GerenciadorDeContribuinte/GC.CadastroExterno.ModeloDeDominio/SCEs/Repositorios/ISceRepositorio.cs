using System.Collections.Generic;

namespace GC.CadastroExterno.ModeloDeDominio.SCEs.Repositorios
{
	public interface ISceRepositorio
	{
		void Salvar(SCE sce);
		IList<SCE> Listar();
	}
}
