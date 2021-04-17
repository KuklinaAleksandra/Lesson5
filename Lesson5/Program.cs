using System;
using System.IO;

namespace Lesson5
{
    class lesson5
    {
        static void Main(string[] args)
        {
            // {
            //    Console.WriteLine("введите данные для сохланения");
            //     var path = Console.ReadLine();
            //     if (string.IsNullOrEmpty(path))
            //     {
            //         Console.WriteLine("некорректные данные");
            //         return;
            //      }
            //      if (!path.EndsWith(" .txt")) path += ".txt";
            //     using var fs = new FileStream(path, File.Exists(path) ? FileMode.Append : FileMode.OpenOrCreate);
            //   }


            //     using var sw = File.AppendText("startup.txt");
            //     var time = DateTime.Now.ToString("HH:mm:ss tt");
            //     sw.WriteLine(time);
            //      Console.WriteLine($"добавлено время {time}");
            //  }

            //const string file = "Test.bin";

            // Console.WriteLine("Введите число от 0 до 255 через пробел");
            // var input = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //
            // if (input is null)
            // {
            //      Console.WriteLine("некорректные данные");
            //      return;
            //  }
            //
            //  var array = new byte[input.Length];
            //      for(var i=0;i< array.Length;i++)
            //  {
            //      if (!byte.TryParse(input[i], out var number))
            //     {
            //         Console.WriteLine($"некорректное значение  {input[i]} ");
            //          return;
            //      }
            //      array[i] = number;
            //  }

            //  using (var bw = new BinaryWriter(File.OpenWrite(file)))
            //  {
            //      bw.Write(array);
            //      bw.Flush();
            //  }


            Employee[] employees =
                {
                new Employee ("Андрей", "Викторович", "Безруков", "+799933352", 1965),
                new Employee ("Сергей", "Викторович", "Безруков", "+799933352", 1985),
                new Employee ("Елисей", "Викторович", "Безруков", "+799933352", 1945),
                new Employee ("Матвей", "Викторович", "Безруков", "+799933352", 2000),

            };
            for (int i=0; i<employees.Length; i++)
            {
                if (employees[i].getAge() > 40)
                    Console.WriteLine(employees[i].GetFullInfo());
            }
            Console.WriteLine("_______________________________");
            for (int i = 0; i < employees.Length; i++)
            {
                
                    Console.WriteLine(employees[i].GetFullInfo());
            }
            Console.WriteLine("_______________________________");


        }
    }
}

