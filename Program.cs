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

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer);


        }
    }
}
