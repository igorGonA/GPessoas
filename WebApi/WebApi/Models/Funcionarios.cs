using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    /// <summary>
    /// Classe Modelo para Cadastro Básico de Funcionários
    /// </summary>
    public class Funcionarios
    {
        public short Codigo { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeSocial { get; set; }
        public string CPF { get; set; }
        public string RegistroGeral { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public string MotivoDemissao { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? ModificadoEm { get; set; }

        /// <summary>
        /// Construtor de Classe
        /// </summary>
        public Funcionarios()
        {
            this.Enderecos = new List<Endereco>();
        }

        /// <summary>
        /// Construtor de Classe com paramêtros 
        /// </summary>
        /// <param name="item"></param>
        public Funcionarios(Funcionarios item)
        {
            this.Codigo = item.Codigo;
            this.NomeCompleto = item.NomeCompleto;
            this.NomeSocial = item.NomeSocial;
            this.CPF = item.CPF;
            this.RegistroGeral = item.RegistroGeral;
            this.NomeMae = item.NomeMae;
            this.NomePai = item.NomePai;
            this.DataAdmissao = item.DataAdmissao;
            this.DataDemissao = item.DataDemissao;
            this.MotivoDemissao = item.MotivoDemissao;
            this.Enderecos = item.Enderecos;
            this.CriadoPor = item.CriadoPor;
            this.CriadoEm = item.CriadoEm;
            this.ModificadoPor = item.ModificadoPor;
            this.ModificadoEm = item.ModificadoEm;
            this.Enderecos = new List<Endereco>();
        }
    }
}