using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TGVEDataAccess
{
      public class TGVEDataAccess
      {
                public static async Task<List<dynamic>> GetEntityAsync(string path)
            {
                  HttpClient client = new HttpClient();
                  client.BaseAddress = new Uri("http://localhost:51306");

                  string product = "";

                  HttpResponseMessage response = await client.GetAsync(path);
                  if (response.IsSuccessStatusCode)
                  {
                        product = await response.Content.ReadAsStringAsync();
                  }

                  var ListOfProduts = JsonConvert.DeserializeObject<List<dynamic>>(product);

                  return ListOfProduts;
            }
      }
}
