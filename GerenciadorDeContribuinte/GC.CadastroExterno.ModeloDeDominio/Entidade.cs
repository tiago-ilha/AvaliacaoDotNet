using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC.CadastroExterno.ModeloDeDominio
{
	public abstract class Entidade
	{
		public Entidade()
		{
			this.Id = Guid.NewGuid();
		}

		public Guid Id { get; private set; }
	}
}
