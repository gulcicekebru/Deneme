using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class SaleManager
    {
        public void Sale(Gamer gamer, Campaigns campaign)
        {
            Console.WriteLine(gamer.GamerName + " has " + campaign.CampaignName + " campaign");
        }
    }
}
