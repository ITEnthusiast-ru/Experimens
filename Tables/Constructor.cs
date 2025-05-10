using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
     class Constructor : IRow, IColumns
    {
       const char ANGLE = '+';
       const  char LINE_SIMBOL = '-';
       readonly int[] columnWidths; // Получаем из другого класса или метода 
       readonly string[] columnTitles;
       readonly string[] columnData;

        public Constructor()
        {
            columnTitles = new Table().GetTitles();
            columnData = new Table().GetData();
            // Выравниваем количество данных по заголовкам
            columnData = AlignDataToTitles(columnTitles, columnData);
            columnWidths = new int[columnTitles.Length];
            // Рассчитываем ширину каждой колонки (максимум из заголовка и данных)
            for (int i = 0; i < columnTitles.Length; i++)
            {
                columnWidths[i] = Math.Max(
                    columnTitles[i].Length,
                    columnData[i].Length
                );
            }
        }
        private string[] AlignDataToTitles(string[] titles, string[] data)
        {
            // Если данных меньше чем заголовков - дополняем пустыми строками
            if (data.Length < titles.Length)
            {
                var alignedData = new List<string>(data);
                while (alignedData.Count < titles.Length)
                {
                    alignedData.Add(string.Empty);
                }
                return alignedData.ToArray();
            }
            // Если данных больше - обрезаем
            return data.Take(titles.Length).ToArray();
        }

        // Печать колонок
         void PrintColumns()
        {
            Console.Write('|');
            for (int i = 0; i < columnWidths.Length; i++)
            {
                
                Console.Write(columnTitles[i].PadRight(columnWidths[i]));// Выравниваем заголовок по ширине колонки
                Console.Write('|');
            }
            Console.WriteLine();

            Console.Write('|');
            for (int i = 0; i < columnWidths.Length; i++)
            {
                
                Console.Write(columnData[i].PadRight(columnWidths[i]));// Выравниваем данные по ширине колонки
                Console.Write('|');
            }
            Console.WriteLine();
        }

        //Печать вехней и нижней линии
        void PrintRow()
        {
            Console.Write(ANGLE);

            for (int i = 0; i < columnWidths.Length; i++)
            {
                Console.Write(new string(LINE_SIMBOL, columnWidths[i]));
                Console.Write(ANGLE);
            }

            Console.WriteLine();
        }

        // Печать всей таблицы
        public void PrintTable()
        {
            PrintRow();
            PrintColumns();
            PrintRow();
        }     
    }
}
