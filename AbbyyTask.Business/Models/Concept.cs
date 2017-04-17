using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyTask.Business.Models
{
    public class Concept
    {
        public Concept()
        {
            Properties = new List<Property>();
        }

        public string Name { get; set; }

        public string Cardinality { get; set; }
        

        public IEnumerable<Property> Properties { get; set; }


        public override string ToString()
        {
            var result = $"\"{Name}\":{{";
            result += $"\"_cardinality\":\"{Cardinality}\"";
            if (Properties.Any())
                result += ",";
            result += String.Join(",", Properties);
            result += "}";
            return result;
        }

    }
}
