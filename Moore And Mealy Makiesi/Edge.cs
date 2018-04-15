using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moore_And_Mealy_Makiesi
{
    class Edge
    {
        public State OldState { get; set; }
        public State NewState { get; set; }
        public string output { get; set; }
        public string input { get; set; }
    }
}
