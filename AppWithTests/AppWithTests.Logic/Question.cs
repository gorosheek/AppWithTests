using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithTests.Logic
{
    public class Question
    {
        public Question(string wording, string answer)
        {
            Wording = wording;
            Answer = answer;
        }
        public Question(string wording, string[] variants)
        {
            Wording = wording;
            Variants = variants;
        }
        public string Wording { get; set; }
        public string Answer { get; set; }
        public string[] Variants { get; set; } = new string[4];
    }
}
