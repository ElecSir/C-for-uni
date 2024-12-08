using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = GetInputFilePath(); // Запрашиваем путь к входному файлу
        string outputFilePath = "attendance_results.txt"; // Файл, куда будут записаны результаты
        CalculateAttendance(inputFilePath, outputFilePath);
    }

    static string GetInputFilePath()
    {
        string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt"); // Получаем все текстовые файлы в текущей директории

        if (files.Length == 0)
        {
            Console.WriteLine("Нет доступных файлов для обработки.");
            return null; // Если нет файлов, возвращаем null
        }

        Console.WriteLine("Выберите файл для обработки: ");
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Path.GetFileName(files[i])}"); // Выводим список файлов без полного пути
        }

        Console.Write("Введите номер файла: ");
        int fileNumber;
        if (int.TryParse(Console.ReadLine(), out fileNumber) && fileNumber > 0 && fileNumber <= files.Length)
        {
            return files[fileNumber - 1]; // Возвращаем полный путь к выбранному файлу
        }
        else
        {
            Console.WriteLine("Некорректный ввод, выбираю первый файл по умолчанию.");
            return files[0]; // Возвращаем первый файл по умолчанию
        }
    }

    static void CalculateAttendance(string inputFilePath, string outputFilePath)
    {
        // Словарь для хранения данных о посещаемости
        Dictionary<string, (int present, int total)> attendanceData = new Dictionary<string, (int, int)>();

        // Считываем данные из входного файла
        foreach (var line in File.ReadLines(inputFilePath))
        {
            // Разделяем строку по запятой
            string[] data = line.Split(',');

            // Проверяем, что строка содержит три элемента
            if (data.Length < 3) continue;

            string studentName = data[0].Trim(); // Имя студента
            string date = data[1].Trim(); // Дата, которая пока не используется
            int attendanceStatus;

            // Проверяем годность статуса посещаемости
            if (!int.TryParse(data[2].Trim(), out attendanceStatus)) continue; // Проверяем, является ли статус числом

            // Если студента еще нет в словаре, добавляем его
            if (!attendanceData.ContainsKey(studentName))
            {
                attendanceData[studentName] = (0, 0); // Инициализируем количество присутствий и общее количество
            }

            // Обновляем общее количество записей
            attendanceData[studentName] = (
                attendanceData[studentName].present + attendanceStatus,
                attendanceData[studentName].total + 1); // Увеличиваем количество присутствий и общее количество
        }

        // Записываем результаты в выходной файл
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            foreach (var student in attendanceData)
            {
                string studentName = student.Key; // Имя студента
                int present = student.Value.present; // Количество присутствий
                int total = student.Value.total; // Общее количество записей
                double attendancePercentage = total > 0 ? (double)present / total * 100 : 0; // Вычисляем процент посещаемости

                // Записываем в файл
                writer.WriteLine($"Студент: {studentName}, Процент посещаемости: {attendancePercentage:F2}%");
            }
        }

        Console.WriteLine("Результаты посещаемости записаны в файл " + outputFilePath);
    }
}
