using GildedRose;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit.Sdk;

namespace GildedRose.Tests
{
    [TestClass]
    public class ShopTests
    {
        private Shop shop;

        [TestInitialize]
        public void Setup()
        {

            var path = @"C:\\Users\\pc\\OneDrive - Ifag Paris\\Bureau\\EPSI COUR 4eme\\cv architecture  applicatives\\seance 1 le 02-11-2022\\gilded-rose-main\\csharpcore\\GildedRose\\File.txt";
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            Console.WriteLine(lines[0]);
          

            List<Item> items = new List<Item>()
            {
                new GenericItem("Generic",10,10),
                new GenericItem("Generic",0,10),
                new GenericItem("Generic",5,0),
                new AgedItem("Aged Brie",5,5),
                new AgedItem("Aged Brie",5,50),
                new LegendaryItem("Sulfuras",5,80),
                new BackstagePasses("Backstage passes",15,5),
                new BackstagePasses("Backstage passes",10,5),
                new BackstagePasses("Backstage passes",5,5),
                new BackstagePasses("Backstage passes",0,5),

            };
            this.shop = new Shop(items);

        }

        [TestMethod]
        public void ShouldUpdateItems()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(9, this.shop.items[0].SellIn);
            Assert.AreEqual(9, this.shop.items[0].Quality);
        }



        [TestMethod]
        public void ShouldDecreaseQualityFaster()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(8, this.shop.items[1].Quality);
        }

        [TestMethod]
        public void ShouldNotHaveNegativeQuality()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(0, this.shop.items[2].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseAgedBrieQuality()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(6, this.shop.items[3].Quality);
        }

        [TestMethod]
        public void ShouldNotHaveQualityHaveOver50()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(50, this.shop.items[4].Quality);
        }

        [TestMethod]
        public void ShouldNotChangeSulfurasQuality()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(80, this.shop.items[5].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseBackstagepassesQuality()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(6, this.shop.items[6].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseBackstagepassesQualityFaster()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(7, this.shop.items[7].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseBackstagepassesQualityMoreFaster()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(8, this.shop.items[8].Quality);
        }

        [TestMethod]
        public void ShouldUpdateBackstagepassesQualityTo0()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(0, this.shop.items[9].Quality);
        }

    }
}