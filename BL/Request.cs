using System;
using System.Net.Http.Headers;
using System.Text;

namespace BL
{
    public static class Request
    {
        public static (bool, string) RequestApis(HttpMethod metodo, string url, string token, string bodyjson)
        {
            bool ok = false;
            string contenido = "";

            try
            {
                HttpRequestMessage request = new HttpRequestMessage(metodo, url);
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.Headers.Add("Authorization", token);

                if (!string.IsNullOrEmpty(bodyjson))
                    request.Content = new StringContent(bodyjson, Encoding.UTF8, "application/json");

                HttpClient cliente = new HttpClient();

                HttpResponseMessage respuesta = cliente.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result;

                if (respuesta.StatusCode == System.Net.HttpStatusCode.OK || respuesta.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    ok = true;
                    contenido = respuesta.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return (ok, contenido);
        }
    }
}
