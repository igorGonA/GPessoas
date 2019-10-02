using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("funcionarios")]
    public class FuncionariosController : ApiController
    {
        private static List<FuncionarioModel> listaFuncionarios = new List<FuncionarioModel>();

        [AcceptVerbs("POST")]
        [Route("create")]
        public string CadastrarFuncionario(FuncionarioModel funcionarios)
        {
            listaFuncionarios.Add(funcionarios);
            return "Usuário cadastrado com sucesso!";
        }

        [AcceptVerbs("PUT")]
        [Route("update/{codigo}")]
        public string AlterarFuncionarios(FuncionarioModel funcionarios)
        {

            listaFuncionarios.Where(n => n.Codigo == funcionarios.Codigo)
                         .Select(s =>
                         {
                             s.Codigo = funcionarios.Codigo;
                             s.NomeCompleto = funcionarios.NomeCompleto;
                             s.NomeSocial = funcionarios.NomeSocial;
                             s.CPF = funcionarios.CPF;
                             s.RegistroGeral = funcionarios.RegistroGeral;
                             s.NomeMae = funcionarios.NomeMae;
                             s.NomePai = funcionarios.NomePai;
                             s.DataAdmissao = funcionarios.DataAdmissao;
                             s.DataDemissao = funcionarios.DataDemissao;
                             s.MotivoDemissao = funcionarios.MotivoDemissao;
                             s.CriadoPor = funcionarios.CriadoPor;
                             s.CriadoEm = funcionarios.CriadoEm;
                             s.ModificadoPor = funcionarios.ModificadoPor;
                             s.ModificadoEm = funcionarios.ModificadoEm;

                             return s;

                         }).ToList();

            return "Usuário alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("destroy/{codigo}")]
        public string ExcluirFuncionario(int codigo)
        {
            FuncionarioModel funcionarios = listaFuncionarios.Where(n => n.Codigo == codigo)
                                                .Select(n => n)
                                                .First();

            listaFuncionarios.Remove(funcionarios);

            return "Registro excluido com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("show/{codigo}")]
        public FuncionarioModel ConsultarFuncionarioPorCodigo(int codigo)
        {
            FuncionarioModel funcionario = listaFuncionarios.Where(n => n.Codigo == codigo)
                                                .Select(n => n)
                                                .FirstOrDefault();
            return funcionario;
        }

        [AcceptVerbs("GET")]
        [Route("list")]
        public List<FuncionarioModel> ConsultarFuncionarios()
        {
            return listaFuncionarios;
        }
    }
}