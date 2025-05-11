using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
     class Table
    {
        private string[] titles;

        public string[] Titles
        {       
            get
            {
                List<string> titles = new List<string>();
                int count = 1;

                while (true)
                {
                    Console.WriteLine($"Введите заголовок {count} (оставьте пустым для завершения):");
                    string? title = Console.ReadLine();

                    if (string.IsNullOrEmpty(title))
                        break;

                    titles.Add(title);
                    count++;
                }

                return titles.ToArray();
            }
            set { titles = value; }
        }

        private string[] data;

        public string[] Data
        {
            get {
                List<string> allData = new List<string>();
                int count = 1;

                while (true)
                {
                    Console.WriteLine($"Введите данные {count} колнки (оставьте пустым для завершения):");
                    string? data = Console.ReadLine();

                    if (string.IsNullOrEmpty(data))
                        break;

                    allData.Add(data);
                    count++;
                }

                return allData.ToArray();
            }
            set { data = value; }
        }

       
    }
}
