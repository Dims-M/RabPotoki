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
        /// Делегат для запуска в метода в потоке.
         ThreadStart writeSecond = new ThreadStart(WriteSecond);

        // конкретный поток для запуска( из под делегата)
        Thread thread = new Thread(writeSecond);
            thread.Start();

        }


        public static void WriteSecond()
        {
            Console.WriteLine("Работает поток № 1");
        } //Тестовой метод для визуализации работы потока

    }
}  



