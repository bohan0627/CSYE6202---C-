using System;
using System.Collections.Generic;
using System.IO;
namespace Bo_Han_Assignment2
{
    public class FileUtil : IWriteable, IReadable
    {
        public FileUtil()
        {
        }

        public void WriteAll(string fileName, List<string> data)
        {
            using (StreamWriter sw = new StreamWriter(fileName + ".csv"))
            {
                foreach (string d in data)
                {
                    sw.WriteLine(d);
                }

            }
        }

        public List<string> ReadAll(string fileName)
        {
            List<string> res = new List<string>();
            string line = "";
            using (StreamReader sr = new StreamReader(fileName + ".csv"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    res.Add(line);
                   //Console.WriteLine(line);
                }
            }
            return res;
        }
    }
}
