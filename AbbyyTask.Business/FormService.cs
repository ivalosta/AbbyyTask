using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbbyyTask.Business.Models;

namespace AbbyyTask.Business
{
    public class FormService
    {
        public string GetJson(Form form)
        {
            return form.ToString();
        }


        public static IEnumerable<string> Cardinalities { get; } = new[]
        {
            "0..1",
            "0..*",
            "1",
            "1..*"
        };


        public static IEnumerable<string> Types { get; } = new[]
        {
            "integer",
            "number",
            "string",
            "boolean",
            "enum",
            "datetime"
        };

    }
}
