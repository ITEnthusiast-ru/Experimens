using Tables;

class Constructor : IRow, IColumns
{
    const char ANGLE = '+';
    const char LINE_SIMBOL = '-';
    readonly int[] columnWidths;
    readonly string[] columnTitles;
    readonly string[][] columnDataRows; // Теперь храним массив строк данных

    public Constructor(Table table)
    {
        columnTitles = table.Titles;
        var inputData = table.Data;

        // Разбиваем данные на строки таблицы
        columnDataRows = OrganizeDataIntoRows(columnTitles, inputData);

        // Рассчитываем ширину колонок
        columnWidths = CalculateColumnWidths(columnTitles, columnDataRows);
    }

    private string[][] OrganizeDataIntoRows(string[] titles, string[] inputData)
    {
        var result = new List<string[]>();
        int titlesCount = titles.Length;

        // Разбиваем данные на строки по titlesCount элементов
        for (int i = 0; i < inputData.Length; i += titlesCount)
        {
            var rowData = inputData
                .Skip(i)
                .Take(titlesCount)
                .ToArray();

            // Дополняем последнюю строку пустыми значениями если нужно
            if (rowData.Length < titlesCount)
            {
                rowData = rowData
                    .Concat(Enumerable.Repeat(string.Empty, titlesCount - rowData.Length))
                    .ToArray();
            }

            result.Add(rowData);
        }

        // Если нет данных вообще, добавляем одну пустую строку
        if (result.Count == 0)
        {
            result.Add(Enumerable.Repeat(string.Empty, titlesCount).ToArray());
        }

        return result.ToArray();
    }

    private int[] CalculateColumnWidths(string[] titles, string[][] dataRows)
    {
        var widths = new int[titles.Length];

        // Инициализируем ширинами заголовков
        for (int i = 0; i < titles.Length; i++)
        {
            widths[i] = titles[i].Length;
        }

        // Обновляем, если данные шире
        foreach (var row in dataRows)
        {
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i].Length > widths[i])
                {
                    widths[i] = row[i].Length;
                }
            }
        }

        return widths;
    }

    public void PrintColumns()
    {
        // Печать заголовков
        PrintRowData(columnTitles);

        // Печать всех строк данных
        foreach (var row in columnDataRows)
        {
            PrintRowData(row);
        }
    }

    private void PrintRowData(string[] row)
    {
        Console.Write('|');
        for (int i = 0; i < columnWidths.Length; i++)
        {
            Console.Write((i < row.Length ? row[i] : "").PadRight(columnWidths[i]));
            Console.Write('|');
        }
        Console.WriteLine();
    }

    public void PrintRow()
    {
        Console.Write(ANGLE);
        for (int i = 0; i < columnWidths.Length; i++)
        {
            Console.Write(new string(LINE_SIMBOL, columnWidths[i]));
            Console.Write(ANGLE);
        }
        Console.WriteLine();
    }

    public void PrintTable()
    {
        PrintRow();
        PrintColumns();
        PrintRow();
    }
}