using GC.CadastroExterno.ModeloDeDominio.SCEs;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace GC.CadastroExterno.Servico
{
	[ServiceContract]
	public interface ISolicitarScePFServico
	{
		[OperationContract]
		void Salvar(SolicitarScePF solicitacao);

		[OperationContract]
		IList<SCE> Listar();
	}


	[DataContract]
	public class SolicitarScePF
	{
		//	public SolicitarScePF()
		//	{
		//		this.Telefones = new List<TelefoneViewModel>();
		//		this.Emails = new List<EmailViewModel>();
		//		this.Enderecos = new List<EnderecoViewModel>();
		//	}

		[DataMember]
		public bool IndicaAvulso { get; set; }

		[DataMember]
		public string NomeCompleto { get; set; }

		[DataMember]
		public string Cpf { get; set; }

		[DataMember]
		public DateTime DataDeNascimento { get; set; }

		[DataMember]
		public string Sexo { get; set; }

		[DataMember]
		public IList<TelefoneViewModel> Telefones { get; set; }

		[DataMember]
		public IList<EmailViewModel> Emails { get; set; }

		[DataMember]
		public IList<EnderecoViewModel> Enderecos { get; set; }
	}

	[DataContract]
	public class TelefoneViewModel
	{
		[DataMember]
		public string Numero { get; set; }
	}

	[DataContract]
	public class EmailViewModel
	{
		[DataMember]
		public string Endereco { get; set; }
	}

	[DataContract]
	public class EnderecoViewModel
	{
		[DataMember]
		public string TipoEndereco { get; set; }

		[DataMember]
		public string Cep { get; set; }

		[DataMember]
		public string Logradouro { get; set; }

		[DataMember]
		public string Numero { get; set; }

		[DataMember]
		public string Complemento { get; set; }

		[DataMember]
		public string Bairro { get; set; }

		[DataMember]
		public string Cidade { get; set; }

		[DataMember]
		public string Estado { get; set; }
	}
}
