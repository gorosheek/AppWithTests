using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithTests.Logic
{
    public class Question
    {
        public string Wording { get; set; }
        public string Answer { get; set; }
        public string[] Variants { get; set; } = new string[4];
        public int Number { get; set; }
    }
}
