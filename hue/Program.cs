using Q42.HueApi;
using Q42.HueApi.Interfaces;
//using Q42.HueApi.ColorConverters.Original;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.HSB;
using System.Threading;

namespace hue
{
    class Program
    {
        static void Main(string[] args)
        { 
            LightInterface.alive = true;
            LightInterface.BombActive();
            Thread.Sleep(30000);
            LightInterface.alive = false;
            Console.WriteLine("bomb active complete");
            LightInterface.BombDefused().Wait();
            LightInterface.TurnLightOff().Wait();
            Console.WriteLine("sequence complete");
            Console.ReadKey();
        }
    }
}
