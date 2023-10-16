using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4
{
    internal class FlowerBouquetController
    {
        private Bouquet<Flower> flowerContainer = new Bouquet<Flower>();
        public void AddFlower(Flower flower)
        {
            flowerContainer.AddItem(flower);
        }
        public void RemoveFlower(Flower flower)
        {
            flowerContainer.RemoveItem(flower);
        }
        public void PrintFlower()
        {
            flowerContainer.PrintItems();
        }
        public void SortFlowers()
        {
            List<Flower> sortedFlowers = new List<Flower>();
            sortedFlowers = flowerContainer.GetItems().OrderBy(f => f.Name).ToList();
            flowerContainer.SetItems(sortedFlowers);
        }
        public Flower FindFlower(string color)
        {
            if (color.Any(char.IsDigit))
            {
                throw new ExpString($"Error color has numbers {color}", color);
            }
            return flowerContainer.GetItems().FirstOrDefault(f => f.color.ToLower() == color.ToLower());
        }
    }
}
