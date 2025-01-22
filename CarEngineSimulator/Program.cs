using System;
using System.Collections.Generic;

namespace CarEngineSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            float I = 0.1f;
            List<int> M = new List<int>{ 20, 75, 100, 105, 75, 0 };
            List<int> V = new List<int>{ 0, 75, 150, 200, 250, 300 };
            float T = 110;
            float Hm = 0.01f;
            float Hv = 0.0001f;
            float C = 0.1f;

            Engine engine = new ICE(I, M, V, T, Hm, Hv, C);
            ICEStand stand = new ICEStand(ref engine);

            Console.Write("Введите температуру воздуха: ");
            float res = stand.StartSimulation(float.Parse(Console.ReadLine()));

            if (res < stand.MaxWorkTime)
                Console.WriteLine($"Двигатель перегрелся, проработав {res} секунд");
            else
                Console.WriteLine("Двигатель прошел тест!");
        }
    }
}
