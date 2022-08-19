using System;
using System.Collections.Generic;

namespace Massiv_hw
{
    class Program


    {
        static void Main(string[] args)
        {
            while (true)
            {

                int count = Uchastniki.vod_age("Введите кол-во участников: ");
                List<Uchastniki> uchastniki = new List<Uchastniki>();
                for (int i = 0; i < count; i++)
                {
                    uchastniki.Add(new Uchastniki(i + 1));
                }

                void vyvod()
                {
                    Console.WriteLine("Все участники: ");
                    foreach (var item in uchastniki)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }


                Console.WriteLine("\nВсе участники: ");
                foreach (var item in uchastniki)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("" +
                    "[1] Добавить участника\n" +
                    "[2] Удалитьт участника\n" +
                    "[3] Редактировать возраст участника\n" +
                    "[4] Редактировать имя учстника");
                switch (Console.ReadLine())
                {
                    case "1":
                        uchastniki.Add(new Uchastniki(uchastniki.Count + 1));
                        vyvod(); break;
                    case "2":
                        Console.WriteLine("Введит ID участника: ");
                        uchastniki.RemoveAt(Uchastniki.vod_age("") - 1);
                        vyvod(); break;
                    case "3":
                        Console.WriteLine("Введит ID участника: ");
                        int index_age = (int.Parse(Console.ReadLine()) - 1);
                        Console.WriteLine("Введите новый возраст: ");
                        (uchastniki.ElementAt(index_age)).Age = int.Parse(Console.ReadLine());
                        vyvod(); break;
                    case "4":
                        Console.WriteLine("Введит ID участника: ");
                        int index_name = (int.Parse(Console.ReadLine()) - 1);
                        Console.WriteLine("Введите новое имя: ");
                        uchastniki.ElementAt(index_name).Name = String.Format(Console.ReadLine());
                        vyvod(); break;
                    default: break;

                }

            }
        }
    }
}

