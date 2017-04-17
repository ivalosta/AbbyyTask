using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyTask.Business.Models
{
    public class Property
    {
        public string Name { get; set; }

        public string Cardinality { get; set; }


        public string Type { get; set; }

        public override string ToString()
        {
            var result = $"\"{Name}\":{{";
            result += $"\"_cardinality\":\"{Cardinality}\"";
            if (Type != "string")
                result += $",\"_type\":\"{Type}\"";
            result += "}";
            return result;
        }
    }
}