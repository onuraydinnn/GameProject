using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class GamerManager : IGamerService
    {

        private IGamerCheckService _isGamer;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _isGamer = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_isGamer.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " registered");
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " removed");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " updated");
        }
    }
}
