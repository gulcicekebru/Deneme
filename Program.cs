using System;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Tc = "70693052440";
            gamer.GamerName = "Ebru";
            gamer.GamerSurname = "Gülçiçek";
            gamer.DateOfBirth = new DateTime(1999, 3, 22);

            Campaigns campaigns = new Campaigns();
            campaigns.CampaignId = 1;
            campaigns.CampaignName = "Sepette %30 indirim";

           

            GamerManager gamerManager = new GamerManager(new Adapter.MernisReferenceAdapter());
            gamerManager.Add(gamer);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer, campaigns);

            CampaignsManager campaignsManager = new CampaignsManager();
            campaignsManager.Add();

        }
    }
}
