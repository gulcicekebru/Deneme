using Game.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class GamerManager:MernisReferenceAdapter
    {
        
        public virtual void Add(Gamer gamer)
        {
            if(CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Gamer is valid");
            }
            else
            {
                Console.WriteLine("Gamer is invalid");
            }
        }

        public void Update()
        {
            Console.WriteLine("Campaign's Information has been updated.");
        }

        public void Delete()
        {
            Console.WriteLine("Campaign's Data has been deleted.");
        }


    }
}
