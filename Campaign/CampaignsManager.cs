using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class CampaignsManager : IGamerCampaignService
    {
        public void Add()
        {
            Console.WriteLine("Campaign's Information has been added.");
        }

        public void Delete()
        {
            Console.WriteLine("Campaign's Information has been deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Campaign's Information has been updated.");
        }
    }
}
