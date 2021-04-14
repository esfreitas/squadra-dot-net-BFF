using B3.Bordas.Repositorio;
using B3.DTO.Ativo.AdicionarAtivo;
using B3.Entities;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B3.Repositorios
{
    public class RepositorioAtivos : IRepositorioAtivos
    {
       
        public int Add(AdicionarAtivoRequest request)
        {
            try
            {
                var client = new RestClient("viacep.com.br/ws/01001000/json/");
                client.Timeout = -1;
                var requestCliente = new RestRequest(Method.POST);
                IRestResponse response = client.Execute(requestCliente);
                var ReponseAtivo = JsonConvert.DeserializeObject<Ativo>(response.Content);
                Console.WriteLine(response.Content);
                return 1;

            }
            catch
            {
                throw new System.Exception("Sistema indisponível no momento, favor testar mais tarde");
            }
         }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
