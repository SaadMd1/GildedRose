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
        private ItemsRepository itemsRepository;

        [TestInitialize]
        public void Setup()
        {

            /*var path = @"C:\\Users\\pc\\OneDrive - Ifag Paris\\Bureau\\EPSI COUR 4eme\\cv architecture  applicatives\\seance 1 le 02-11-2022\\gilded-rose-main\\csharpcore\\GildedRose\\File.txt";
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            Console.WriteLine(lines[0]);*/
          

           /* this.itemsRepository = new InMemoryItemsRepository();
            this.shop = new Shop(this.itemsRepository);*/

            this.itemsRepository = new FileItemsRepository();
            this.shop = new Shop(this.itemsRepository);

        }

        [TestMethod]
        public void ShouldUpdateItems()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(9, this.itemsRepository.GetInventory()[0].SellIn);
            Assert.AreEqual(9, this.itemsRepository.GetInventory()[0].Quality);
        }



        [TestMethod]
        public void ShouldDecreaseQualityFaster()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(8, this.itemsRepository.GetInventory()[1].Quality);
        }

        [TestMethod]
        public void ShouldNotHaveNegativeQuality()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(0, this.itemsRepository.GetInventory()[2].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseAgedBrieQuality()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(6, this.itemsRepository.GetInventory()[3].Quality);
        }

        [TestMethod]
        public void ShouldNotHaveQualityHaveOver50()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(50, this.itemsRepository.GetInventory()[4].Quality);
        }

        [TestMethod]
        public void ShouldNotChangeSulfurasQuality()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(80, this.itemsRepository.GetInventory()[5].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseBackstagepassesQuality()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(6, this.itemsRepository.GetInventory()[6].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseBackstagepassesQualityFaster()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(7, this.itemsRepository.GetInventory()[7].Quality);
        }

        [TestMethod]
        public void ShouldIncreaseBackstagepassesQualityMoreFaster()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(8, this.itemsRepository.GetInventory()[8].Quality);
        }

        [TestMethod]
        public void ShouldUpdateBackstagepassesQualityTo0()
        {
            this.shop.UpdateQuality();
            Assert.AreEqual(0, this.itemsRepository.GetInventory()[9].Quality);
        }

    }
}