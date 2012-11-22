using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint.Net
{
    public class Sprintly
    {

        readonly RestClient client;

        public Sprintly()
        {
            client = new RestSharp.RestClient("https://sprint.ly/api");
            client.Authenticator = new HttpBasicAuthenticator("email", "api key");
            client.RemoveHandler("application/json");
            client.AddHandler("application/json", new SprintlyJsonDeserializer());
        }

        public IEnumerable<Item> Items()
        {
            var request = new RestRequest("/products/6102/items.json");

            

            var response = client.Execute<List<Item>>(request);

            return response.Data;
        }


    }
}
