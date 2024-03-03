using Microsoft.VisualBasic;
using System.Text;
using System.Text.Json;

namespace Sales.WEB.Repositories
{
    public class Repository : IRepository
    {
        private readonly HttpClient _httpClient;

        private JsonSerializerOptions _jsonDefaultOptions => new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        public Repository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task< HttpReponseWrapper<T>> Get<T>(string url)
        {
            var responseHttp = await _httpClient.GetAsync(url);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await UnserializeAnswer<T>(responseHttp, _jsonDefaultOptions);
                return new HttpReponseWrapper<T>(response, false, responseHttp);
            }

            return new HttpReponseWrapper<T>(default, true, responseHttp);
        }

        public async Task<HttpReponseWrapper<object>> Post<T>(string url, T model)
        {
            var mesageJSON = JsonSerializer.Serialize(model);
            var messageContet = new StringContent(mesageJSON, Encoding.UTF8, "application/json");
            var responseHttp = await _httpClient.PostAsync(url, messageContet);
            return new HttpReponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public async Task<HttpReponseWrapper<TResponse>> Post<T, TResponse>(string url, T model)
        {
            var messageJSON = JsonSerializer.Serialize(model);
            var messageContet = new StringContent(messageJSON, Encoding.UTF8, "application/json");
            var responseHttp = await _httpClient.PostAsync(url, messageContet);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await UnserializeAnswer<TResponse>(responseHttp, _jsonDefaultOptions);
                return new HttpReponseWrapper<TResponse>(response, false, responseHttp);
            }
            return new HttpReponseWrapper<TResponse>(default, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        private async Task<T> UnserializeAnswer<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var respuestaString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(respuestaString, jsonSerializerOptions)!;
        }

        public async Task<HttpReponseWrapper<object>> Delete(string url)
        {
            var reponseHTTP = await _httpClient.DeleteAsync(url);
            return new HttpReponseWrapper<object>(null,!reponseHTTP.IsSuccessStatusCode, reponseHTTP)!;
        }

        public async Task<HttpReponseWrapper<object>> Put<T>(string url, T mode)
        {
            var messageJSON = JsonSerializer.Serialize(mode);
            var messageContent = new StringContent(messageJSON,Encoding.UTF8, "application/json");
            var reponseHTTP = await _httpClient.PutAsync(url, messageContent);
            return new HttpReponseWrapper<object>(null, !reponseHTTP.IsSuccessStatusCode, reponseHTTP);
        }

        public async Task<HttpReponseWrapper<TReponse>> Put<T, TReponse>(string url, T mode)
        {
            var messageJSON = JsonSerializer.Serialize(mode);
            var messageContent = new StringContent(messageJSON, Encoding.UTF8, "application/json");
            var reponseHttp = await _httpClient.PutAsync(url, messageContent);
            if (reponseHttp.IsSuccessStatusCode)
            {
                var reponse = await UnserializeAnswer<TReponse>(reponseHttp, _jsonDefaultOptions);
                return new HttpReponseWrapper<TReponse>(reponse, false, reponseHttp);
            }
            return new HttpReponseWrapper<TReponse>(default, !reponseHttp.IsSuccessStatusCode, reponseHttp);
        }
    }
}
