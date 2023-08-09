using Game.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class GamerManager: IGamerService
    {
        MernisReferenceAdapter _mernisReferenceAdapter;

        public GamerManager(MernisReferenceAdapter mernisReferenceAdapter)
        {
            _mernisReferenceAdapter = mernisReferenceAdapter;
        }

        public void Add(Gamer gamer)
        {
            if(_mernisReferenceAdapter.CheckIfRealPerson(gamer))
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
