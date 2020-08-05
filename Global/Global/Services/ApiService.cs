using Global.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Global.Services
{
    public class ApiService
    {
        public async Task<Response> Login(string codper)
        {      
            try
            {
                var lgperson = new Lgperson
                {
                    CodPer = codper,
                };
                var request = JsonConvert.SerializeObject(lgperson);
                var content = new StringContent(request, Encoding.UTF8, "application/json");
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://192.168.0.62:8082");
                var url = "/api/Lgperons/";
                var response = await client.PostAsync(url, content);

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        isSuccess = false,
                        Message = "Usuario no encontrado, por favor revise",

                    };
                }
                var result = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<Lgperson>(result);
                return new Response
                {
                    isSuccess = true,
                    Message = "Login OK",
                    Result = user,
                };

            }
            catch(Exception ex)
            {
                return new Response
                {
                    isSuccess = false,
                    Message = ex.Message,

                };
            }
        }
    }
}
