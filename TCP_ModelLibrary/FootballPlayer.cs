using System;
using System.Reflection.Metadata.Ecma335;

namespace TCP_ModelLibrary
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ShirtNumber { get; set; }

        public FootballPlayer()
        {
            
        }
        public FootballPlayer(int id, string name, double price, int shirtNumber)
        {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;
        }
    }
}
