using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Consrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("oyun Eklendi :  " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("oyun silindi :  " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("oyun guncellendi :  " + game.GameName);
        }
    }
}
