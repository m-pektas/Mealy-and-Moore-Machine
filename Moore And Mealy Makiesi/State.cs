using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moore_And_Mealy_Makiesi
{
    class State
    {
        public String Name { get; set; }
        public Dictionary<string, State> map = new Dictionary<string, State>();
        public Dictionary<string, Edge> edgeMap = new Dictionary<string, Edge>();
        public string output { get; set; }

        public State(string name) { this.Name = name; }

        public static string getRealStateAndInput(int state,int input)
        {
            string[] States = Moore.states;
            string[] Alphabet = Moore.alphabet;
            return Alphabet[input]+"-"+States[state]; 
        }


    }
}
