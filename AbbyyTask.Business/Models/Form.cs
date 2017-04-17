using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbyyTask.Business.Models
{
    public class Form
    {
        public Form()
        {
            Concepts = new List<Concept>();
        }

        public IEnumerable<Concept> Concepts { get; set; }

        public override string ToString()
        {
            var result = "{";
            result += String.Join(",", Concepts);
            result += "}";
            return result;
        }
    }
}