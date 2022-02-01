using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson8
{

    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            foreach (var process in processes)
                Console.WriteLine($"{nameof(Process.ProcessName)}: {process.ProcessName}, \t\t {nameof(Process.Id)}: {process.Id}");

            Console.WriteLine("Я вывел процессы которые ты можешь убить:):) указав лишь ID процесса или его название ( указав название ты завершишь всю ветку процесса ).");
            Console.WriteLine("Значит вот список, теперь давай выберем, как именно хочешь ты убить процесс.");
            Console.WriteLine("1 - Убить процесс по имени(Помни! Данный метод убивает всю ветку )");
            Console.WriteLine("2 - убить процесс по ID");
            
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1 || x == 2)
            {
                try
                {
                    if (x == 1)
                    {
                        Console.WriteLine("Укажите корректное название процесса");
                        string stage = Console.ReadLine();
                        foreach (Process process in Process.GetProcessesByName(stage))
                            process.Kill();
                        Console.WriteLine($"Процесс {stage} был убит!");
                        Properties.Settings.Default.stringKill = stage;
                        Properties.Settings.Default.Save();
                        Console.ReadKey();
                    }
                    else if (x == 2)
                    {
                        Console.WriteLine("Укажите ID процесса");
                        string processId = Console.ReadLine();
                        int processIdInt = Convert.ToInt32(processId);
                        Process proc = Process.GetProcessById(processIdInt);                        
                        proc.Kill();
                        Console.WriteLine($"Процесс {processIdInt} был убит!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректные данные.");
                        return;
                    }
                }
                catch
                {
                    _ = x != 1 && x != 2;
                    Console.WriteLine("Данные были введены некорректно.");
                    return;
                }
            }
            else
                Console.WriteLine("Нужно указать 1 или 2");
            
            
        }       
     
    }
}


    

    
