using System;
using System.Threading;
using GameConsoleSimulator.Models;

namespace GameConsoleSimulator
{
    
    internal static class Program
    {
        public static void Main()
        {
            var ps4 = new PlayStation4();
            ps4.ShowWelcomeScreen();
            Thread.Sleep(TimeSpan.FromSeconds(20));
        }
    } 
    
}
