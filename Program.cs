using System;
using RFK.Game.Directing;
using RFK.Game.Casting;
using RFK.Game.Services;

namespace RFK
{
   class Program
   {
      static void Main(string[] args)
      {
         Cast cast = new Cast();
         KeyboardService keyboardService = new KeyboardService(800);
         VideoService videoService = new VideoService("Hello World", 800, 800, 50, 30, true);
         Director director = new Director(keyboardService, videoService);
         director.StartGame(cast);
      }
   }
}