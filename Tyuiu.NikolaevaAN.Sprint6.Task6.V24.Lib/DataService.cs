using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NikolaevaAN.Sprint6.Task6.V24.Lib
{
    public class DataService : ISprint6Task6V24
    {
        public string CollectTextFromFile(string str, string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(str))
                    {
                        resStr = resStr + line.Split()[0] + " ";
                    }
                    /*foreach (char c in line)
                    {
                        while (c != ' ')
                        {
                            resStr = resStr + c;
                        }
                        break;
                    }
                    resStr = resStr + " ";*/
                }
            }
            return resStr;
        }
    }
}
