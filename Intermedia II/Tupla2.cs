using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedia_II
{
    public class Tupla2
    {
        public string Name { get; set; }
        public string Kind { get; set; }

        public int Replicas { get; set; }
        public bool Run { get; set; }
        public Tupla2(string name, string kind, int replicas, bool run)
        {
            Name = name;
            Kind = kind;
            Replicas = replicas;
            Run = run;
        }
    }
}
