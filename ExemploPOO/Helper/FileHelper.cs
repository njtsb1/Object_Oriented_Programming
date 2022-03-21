using System.Collections.Generic;
using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public FileHelper() { }

        public FileHelper(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void ListDirectories(string path)
        {
            var returnPath = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            foreach (var returns in returnPath)
            {
                System.Console.WriteLine(returns);
            }
        }

        public void ListFilesDirectories(string path)
        {
            var returnFiles = Directory.GetFiles(path, "*2*", SearchOption.AllDirectories);

            foreach (var returns in returnFiles)
            {
                System.Console.WriteLine(returns);
            }
        }

        public void CreateDirectory(string path)
        {
            var returns = Directory.CreateDirectory(path);
            System.Console.WriteLine(returns.FullName);
        }

        public void DeleteDirectory(string path, bool deleteFiles)
        {
            Directory.Delete(path, deleteFiles);
        }

        public void CreateTextFile(string path, string content)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, content);
            }
        }

        public void CreateFileTextStream(string path, List<string> content)
        {
            using (var stream = File.CreateText(path))
            {
                foreach (var line in content)
                {
                    stream.WriteLine(line);
                }
            }
        }

        public void AddText(string path, string content)
        {
            File.AppendAllText(path, content);
        }

        public void AddTextStream(string path, List<string> content)
        {
            using (var stream = File.AppendText(path))
            {
                foreach (var line in content)
                {
                    stream.WriteLine(line);
                }
            }
        }

        public void ReadFile(string path)
        {
            var content = File.ReadAllLines(path);

            foreach (var line in content)
            {
                System.Console.WriteLine(line);
            }
        }

        public void ReadFileStream(string path)
        {
            string line = string.Empty;

            using (var stream = File.OpenText(path))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                }
            }
        }

        public void MoveFile(string path, string newway, bool overwrite)
        {
            if (File.Exists(path) && File.Exists(newway))
            {
                File.Move(path, newway, overwrite);
            }
        }

        public void CopyFile(string path, string newway, bool overwrite)
        {
            if (File.Exists(path) && File.Exists(newway))
            {
                File.Copy(path, newway, overwrite);
            }
        }

        public void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}