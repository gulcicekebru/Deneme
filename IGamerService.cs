using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal interface IGamerCampaignService: IGamerCheckService
    {
        void Add();
        void Update();

        void Delete();
    }
}
