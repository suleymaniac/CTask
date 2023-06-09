using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // Пример вызова процедуры InvertIntFile для трех файлов
        InvertIntFile("Name1.txt");
        InvertIntFile("Name2.txt");
        InvertIntFile("Name3.txt");
    }

    private static void InvertIntFile(string Name)
    {
        var absolutePath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\");
        var outputPath = Path.Combine(absolutePath, Name);
        
        // Проверка существования файла
        if (!File.Exists(Name))
        {
            Console.WriteLine("Файл не существует: " + Name);
            return;
        }

        // Чтение содержимого файла
        var lines = File.ReadAllLines(Name);

        // Проверка количества элементов в файле
        if (lines.Length < 2)
        {
            Console.WriteLine("Файл содержит менее двух элементов: " + Name);
            return;
        }
        
        // Инвертирование порядка элементов
        Array.Reverse(lines);

        // Запись обратного порядка в файл
        File.WriteAllLines(outputPath, lines);
        
        Console.WriteLine("Файл успешно обработан: " + Name);
    }
}