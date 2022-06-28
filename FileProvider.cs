
using System.Text;

namespace _2048WinFormsApp
{
    public class FileProvider
    {
        public static void Append(string path, string data)
        {
            var writer = new StreamWriter(path, true);
            writer.WriteLine(data);
            writer.Close();
        }
        public static void Replace(string path, string line)
        {
            var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.WriteLine(line);
            writer.Close();
        }

        public static string Get(string path)
        {
            var streamReader = new StreamReader(path);
            var value = streamReader.ReadToEnd();
            streamReader.Close();
            return value;
        }

        public static bool Exist(string path)
        {
            FileInfo file = new FileInfo(path);
            return file.Exists;
        }
    }
}
