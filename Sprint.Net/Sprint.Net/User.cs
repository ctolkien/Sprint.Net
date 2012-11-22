using Newtonsoft.Json;

namespace Sprint.Net
{
    public class User
    {
        [JsonProperty(propertyName: "first_name")] 
        public string FirstName { get; set; }

        [JsonProperty(propertyName: "last_name")]
        public string LastName { get; set; }

        public string Email { get; set; }
    }
}