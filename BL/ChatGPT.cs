using System;
using System.Configuration;
using Entities;
using Newtonsoft.Json;

namespace BL
{
    public class ChatGPT

    {
        public static void Consulta(string input)
        {
            string url = ConfigurationManager.AppSettings["ApiUrl"];
            string token = ConfigurationManager.AppSettings["ApiToken"];

            var data = new Chat
            {
                model = "gpt-3.5-turbo",
                messages = new List<Message>
                {
                    new Message
                    {
                        role = "user",
                        content = input
                    }
                },
                temperature = 0.2f
            };

            string content = JsonConvert.SerializeObject(data, Formatting.Indented);

            (bool ok, string respuestaJson) = Request.RequestApis(HttpMethod.Post, url, token, content);

            if (ok || !string.IsNullOrEmpty(respuestaJson))
            {
                var respuesta = JsonConvert.DeserializeObject<Rootobject>(respuestaJson);
                Console.WriteLine("\nChatGPT: " + respuesta.choices[0].message.content + "\n");
            }
            else
            {
                Console.WriteLine("Error en la solicitud.");
                Console.WriteLine(respuestaJson);
            }
        }
    }
}
