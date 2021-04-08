using IderisBulkUpdater.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace IderisBulkUpdater
{
    public class IderisDataHandler
    {
        public static async Task<IEnumerable<ProdutoIderis>> GetAllProducts(int offset)
        {
            string url = $"http://api.ideris.com.br/produto?offset={offset}";
            using HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string iderisResponse = await response.Content.ReadAsStringAsync();
                var products = Deserialize(iderisResponse);
                return products;
            }
            else throw new Exception(response.ReasonPhrase);
        }

        public static async Task<ProdutoIderis> PutProduct(ProdutoIderis product)
        {
            string url = $"http://api.ideris.com.br/produto";
            var productJsonString = JsonConvert.SerializeObject(product);
            var content = new StringContent(productJsonString, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                var products = Deserialize(jsonString);
                return products.FirstOrDefault();
            }
            else
            {
                var responseMessage = await response.Content.ReadAsStringAsync();
                throw new Exception(responseMessage);
            }
        }
        private static IEnumerable<ProdutoIderis> Deserialize(string jsonString)
        {
            List<ProdutoIderis> products = new List<ProdutoIderis>();
            JObject retornoIderis = JObject.Parse(jsonString);
            IList<JToken> results = retornoIderis.SelectToken("result").ToList();
            foreach (JToken result in results)
            {
                var jsSerializer = new JsonSerializer();
                jsSerializer.Culture = CultureInfo.GetCultureInfo("pt-BR"); //Necesssário para serializar decimais corretamente.
                ProdutoIderis produto = result.ToObject<ProdutoIderis>(jsSerializer);
                products.Add(produto);
            }
            return products;
        }

        public static async Task<JwtToken> LogIn(IderisApiToken apiToken)
        {
            string URI = $"http://api.ideris.com.br/Login";
            var httpClient = new HttpClient();

            var iderisApiToken = new IderisApiToken(apiToken.Login_token);
            var serializedProduto = JsonConvert.SerializeObject(iderisApiToken);
            var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(URI, content);
            if (response.IsSuccessStatusCode)
            {
                var jwtTokenString = await response.Content.ReadAsStringAsync();
                return new JwtToken(jwtTokenString);
            }
            else
            {
                var responseBodyMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"{response.ReasonPhrase}\n{responseBodyMessage}");
            }
        }
    }
}