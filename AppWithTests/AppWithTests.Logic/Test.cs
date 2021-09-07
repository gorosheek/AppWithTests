using System;
using System.Collections.Generic;

namespace AppWithTests.Logic
{
    public enum Types
    {
        Choice, Input
    }
    public class Test
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public Types Type { get; set; }
        public List<Question> Questions { get; set; }
        public void ChooseType(int i)
        {
            if (i == 0)
                Type = Types.Choice;
            else
                Type = Types.Input;
        }
        
    }
}
