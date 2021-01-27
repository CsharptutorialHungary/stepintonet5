using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetDemo.Backend.Model
{
    public record Todo
    {
        public long Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Name { get; set; }

        public Todo()
        {
            Name = "Példa";
        }
    }
}
