using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint.Net
{
    public class Item
    {
        public ItemType Type { get; set; }
        public ItemStatus Status { get; set; }

        public Product Product { get; set; }

        [JsonProperty(propertyName:"created_by")]
        public User CreatedBy { get; set; }

        [JsonProperty(propertyName:"assigned_to")]
        public User AssignedTo { get; set; }



        public string Description { get; set; }
        public bool Archived { get; set; }
        public string Title { get; set; }

        public List<string> Tags { get; set; }

        public int Number { get; set; }

        public string Score { get; set; }

    }

  

}
