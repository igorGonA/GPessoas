using System.Collections.Generic;
﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.Models;

namespace WebApi.Controllers
{
    [RoutePrefix("funcionarios")]
    public class FuncionarioController : ApiController
    {
        private static List<Funcionarios> listaFuncionarios = new List<Funcionarios>();

        [AcceptVerbs("POST")]
        [Route("create")]
        public string CadastrarFuncionario(Funcionarios funcionarios)
        {
            listaFuncionarios.Add(funcionarios);
            return "Usuário cadastrado com sucesso!";
        }

        [AcceptVerbs("PUT")]
        [Route("update")]
        public string AlterarFuncionarios(Funcionarios funcionarios)
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
            Funcionarios funcionarios = listaFuncionarios.Where(n => n.Codigo == codigo)
                                                .Select(n => n)
                                                .First();

            listaFuncionarios.Remove(funcionarios);

            return "Registro excluido com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("show/{codigo}")]
        public Funcionarios ConsultarFuncionarioPorCodigo(int codigo)
        {
            Funcionarios funcionario = listaFuncionarios.Where(n => n.Codigo == codigo)
                                                .Select(n => n)
                                                .FirstOrDefault();
            return funcionario;
        }

        [AcceptVerbs("GET")]
        [Route("list")]
        public List<Funcionarios> ConsultarUsuarios()
        {
            return listaFuncionarios;
        }
    }
}