using GC.CadastroExterno.Console.SolicitarScePFServico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC.CadastroExterno.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new SolicitarScePFServicoClient();
			client.Open();

			SolicitarScePF solicitacao = new SolicitarScePF();

			solicitacao.IndicaAvulso = true;
			solicitacao.NomeCompleto = "Tiago";
			solicitacao.Cpf = "123214334";
			solicitacao.DataDeNascimento = new DateTime(1989, 03, 15);
			solicitacao.Sexo = "M";

			client.Salvar(solicitacao);

			var 

			client.Close();

		}
	}
}
