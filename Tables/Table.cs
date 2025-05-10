using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
     class Table
    {
        string[] titleStrings = GetTitles();
         public string[] GetTitles()
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
         public string[] GetData()
        {
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
            if (titleStrings.Length != allData.Count)
            {
                for (int i = 0; i < allData.Count; i++)
                {
                    allData.Add(string.Empty);
                }

            }
            return allData.ToArray();
        }
    }
}
