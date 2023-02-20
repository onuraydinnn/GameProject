using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    internal interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Remove(Game game);
        void Sell(Gamer gamer, Game game);
    }
}
