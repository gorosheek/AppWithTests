using System.IO;
using Newtonsoft.Json;
namespace AppWithTests.Logic
{
    public static class FileWorker
    {
        public static DirectoryInfo Saves
        {
            get
            {
                if (!Directory.Exists("Saves"))
                    return Directory.CreateDirectory("Saves");
                return new DirectoryInfo("Saves");
            }
        }
        public static void SaveTest(Test test)
        {
            var json = JsonConvert.SerializeObject(test);
            File.WriteAllText($"{Saves}//{test.Name}", json);
        }
        public static Test GetTest(string testName)
        {
            return JsonConvert.DeserializeObject<Test>($"{Saves}//{testName}");
        }
    }
}
