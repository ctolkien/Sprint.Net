using Newtonsoft.Json;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Sprint.Net
{
    public class SprintlyJsonDeserializer : IDeserializer
    {

        private readonly Newtonsoft.Json.JsonSerializer _serializer;

        public SprintlyJsonDeserializer()
        {
            ContentType = "application/json";
            _serializer = new Newtonsoft.Json.JsonSerializer
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Include,
                DefaultValueHandling = DefaultValueHandling.Include
            };
        }

        /// <summary>
        /// Unused for JSON Serialization
        /// </summary>
        public string DateFormat { get; set; }
        /// <summary>
        /// Unused for JSON Serialization
        /// </summary>
        public string RootElement { get; set; }
        /// <summary>
        /// Unused for JSON Serialization
        /// </summary>
        public string Namespace { get; set; }
        /// <summary>
        /// Content type for serialized content
        /// </summary>
        public string ContentType { get; set; }


        public T Deserialize<T>(RestSharp.IRestResponse response)
        {

            using(var textStream = new StringReader(response.Content)) {
                var reader = new JsonTextReader(textStream);
                return _serializer.Deserialize<T>(reader);
            }

        }
    }
}
