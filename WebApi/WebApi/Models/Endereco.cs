using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    /// <summary>
    /// Classe Modelo para Cadastro Básico de Endereços
    /// </summary>
    public class Endereco
    {
        public short CodInterno { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Unidade { get; set; }
        public string IBGE { get; set; }
        public string GIA { get; set; }
        public DateTime DataCadastro { get; set; }

        /// <summary>
        /// Construtor de Classe
        /// </summary>
        public Endereco()
        {

        }

        /// <summary>
        /// Construtor de Classe com paramêtro
        /// </summary>
        /// <param name="item"></param>
        public Endereco(Endereco item)
        {
            this.CodInterno = item.CodInterno;
            this.Cep = item.Cep;
            this.Logradouro = item.Logradouro;
            this.Complemento = item.Complemento;
            this.Bairro = item.Bairro;
            this.Localidade = item.Localidade;
            this.UF = item.UF;
            this.Unidade = item.Unidade;
            this.IBGE = item.IBGE;
            this.GIA = item.GIA;
            this.DataCadastro = item.DataCadastro;
        }
    }
}