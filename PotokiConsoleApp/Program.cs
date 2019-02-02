using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PotokiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Zapuskator();
        }


        public static void Zapuskator()
        {
            RabPotoki rabPotoki = new RabPotoki();


            // rabPotoki.TekThead(); // Получение статуса потока
            RabPotoki.SosdanieDelegataAndZapuskThread();


        }
    }


    /// <summary>
    /// Работаем с потоками
    /// </summary>
    class RabPotoki
    {
        string nameClass = "Класс для раьоты с потоком 1";

        //
        public void TekThead()
        {
            // получаем текущий поток
            Thread t = Thread.CurrentThread;
            t.Name = "Тестовый поток";
            Console.WriteLine(t.Name);

            // получаем домен приложения
            Console.WriteLine("Домен приложения: {0}", Thread.GetDomain().FriendlyName);
            Console.ReadKey();
        }

        public static void SosdanieDelegataAndZapuskThread()
        {
            int count = 0;
        /// Делегат для запуска в метода в потоке.
         ThreadStart writeSecond = new ThreadStart(WriteSecond);

        // конкретный поток для запуска( из под делегата)
        Thread thread = new Thread(writeSecond);
            thread.Start();

            while (true)
            {
                if (count != 50)
                {
                    //break;
                   // continue;
                
                Console.WriteLine($"hПоток {count}");
                count++;
                Thread.Sleep(100);

                }

                else
                {
                    // Console.WriteLine("Конец потока");
                    break;
                    //continue;
                }
               // continue;
            }
            
        }


        public static void WriteSecond()
        {
            Console.WriteLine("Работает поток № 1");
        } //Тестовой метод для визуализации работы потока

    }
}  



