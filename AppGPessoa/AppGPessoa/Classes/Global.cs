using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Json;

namespace AppGPessoa.Classes
{
    public class Global
    {
        /// <summary>
        /// Constante com o valor de parte da URL para consumo da API
        /// </summary>
        private const string uri = "http://localhost:50310/funcionarios";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Codigo">Código de paramêtro para consumo de API</param>
        /// <returns></returns>
        public static List<FuncionarioModel> APIListaFuncionarios(string Codigo = null)
        {
            List<FuncionarioModel> funcionario = new List<FuncionarioModel>();
            string novaUri = string.Empty;

            if (string.IsNullOrEmpty(Codigo))
                novaUri = string.Format(uri, "/list");
            else
                novaUri = string.Format(uri, $"/show/{Codigo}");

            WebRequest request = WebRequest.Create(novaUri);
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            if (!string.IsNullOrEmpty(responseFromServer))
                funcionario = JsonConvert.DeserializeObject<List<FuncionarioModel>>(responseFromServer);

            reader.Close();
            dataStream.Close();
            response.Close();

            return funcionario;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Caminho">Caminho de complemento para consumo da API</param>
        /// <param name="Codigo">Código de paramêtro para consumo de API</param>
        /// <returns></returns>
        public static FuncionarioModel APIFuncionarios(string Caminho, string Codigo)
        {
            FuncionarioModel funcionario = new FuncionarioModel();
            string novaUri = string.Format(uri, $"{Caminho}{Codigo}");

            WebRequest request = WebRequest.Create(novaUri);
            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            if (!string.IsNullOrEmpty(responseFromServer))
                funcionario = JsonConvert.DeserializeObject<FuncionarioModel>(responseFromServer);

            reader.Close();
            dataStream.Close();
            response.Close();

            return funcionario;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="Caminho"></param>
        /// <param name="Codigo"></param>
        /// <returns></returns>
        public static string APIFuncionariosCDU(FuncionarioModel item, string Caminho)
        {
            string msg = string.Empty;
            string novaUri = string.Empty;
            var dados = Encoding.UTF8.GetBytes(ConverteObjectParaJSon<FuncionarioModel>(item));
            
                novaUri = string.Format(uri, $"{Caminho}");

            WebRequest request = WebRequest.Create(novaUri);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Method = "POST";
            request.ContentLength = dados.Length;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            dataStream.WriteAsync(dados, 0, dados.Length);
            dataStream.Close();

            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            if (!string.IsNullOrEmpty(responseFromServer))
                msg = JsonConvert.DeserializeObject<string>(responseFromServer);

            reader.Close();
            response.Close();

            return msg;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public static EnderecoModel BuscaEnderecoViaCEP(string cep)
        {
            string URL = string.Format("https://viacep.com.br/ws/{0}/json/", cep);

            WebClient wc = new WebClient();
            var dados = wc.DownloadString(URL);

            EnderecoModel item = JsonConvert.DeserializeObject<EnderecoModel>(dados);
            return item;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public static bool ValidaCEP(string cep)
        {
            if (cep.Length == 8)
                cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);

            return Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public static bool ValidaCPF(string CPF)
        {
            int[] CalcARR = null;
            int Sum = 0;
            int DV1 = 0;
            int DV2 = 0;

            CPF = (CPF.Replace(".", null)).Replace("-", null);

            if (string.IsNullOrEmpty(CPF))
            {
                return true;
            }

            if (long.Parse(CPF) == 0)
            {
                return false;
            }

            if (CPF.Length != 11)
            {
                CPF = string.Format("{0:D11}", long.Parse(CPF));
            }

            CalcARR = new int[11];

            for (int x = 0; x < CalcARR.Length; x++)
            {
                CalcARR[x] = int.Parse(CPF[x].ToString());
            }

            Sum = 0;

            for (int x = 1; x <= 9; x++)
            {
                Sum += CalcARR[x - 1] * (11 - x);
            }

            Math.DivRem(Sum, 11, out DV1);
            DV1 = 11 - DV1;
            DV1 = DV1 > 9 ? 0 : DV1;

            if (DV1 != CalcARR[9])
            {
                return false;
            }

            Sum = 0;

            for (int x = 1; x <= 10; x++)
            {
                Sum += CalcARR[x - 1] * (12 - x);
            }

            Math.DivRem(Sum, 11, out DV2);
            DV2 = 11 - DV2;
            DV2 = DV2 > 9 ? 0 : DV2;

            if (DV2 != CalcARR[10])
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ConverteObjectParaJSon<T>(T obj)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream();
                ser.WriteObject(ms, obj);
                string jsonString = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                return jsonString;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static T ConverteJSonParaObject<T>(string jsonString)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                T obj = (T)serializer.ReadObject(ms);
                return obj;
            }
            catch
            {
                throw;
            }
        }
    }
}