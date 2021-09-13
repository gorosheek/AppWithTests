using System;
using System.Collections.Generic;
using System.Globalization;

namespace AppWithTests.Logic
{
    public enum TestTypes
    {
        Choice, Input
    }
    public class Test
    {
        public Test(string testName, string genre, TestTypes type)
        {
            Name = testName.ToLower();
            Genre = genre.ToLower();
            Type = type;
        }
        public string Name { get; set; }
        public string Genre { get; set; }
        public TestTypes Type { get; set; }
        public List<Question> Questions { get; set; }

    }
}
