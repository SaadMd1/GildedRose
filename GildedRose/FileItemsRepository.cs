using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace GildedRose
{
    public class FileItemsRepository : ItemsRepository
    {
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        public static SqlConnection OCON1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD_GildedRose;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public static SqlCommand OCMD1 = new SqlCommand();
        public static SqlDataReader ODR1;
        List<Item> listOfItems = new List<Item>();
        List<Item> ItemsRepository.GetInventory()
        {
            //read using file
            /* string line;

             var path = @"C:\\Users\\pc\\OneDrive - Ifag Paris\\Bureau\\EPSI COUR 4eme\\cv architecture  applicatives\\seance 1 le 02-11-2022\\gilded-rose-main\\csharpcore\\GildedRose\\File.txt";
             StreamReader file = new StreamReader(path);


             while ((line = file.ReadLine()) != null)
             {
                 string[] properties = line.Split(',');

                 switch (properties[0])
                 {
                     case "Generic": listOfItems.Add(new GenericItem(properties[0], int.Parse(properties[1]), int.Parse(properties[2])));
                         break;

                     case "Aged":
                         listOfItems.Add(new AgedItem(properties[0], int.Parse(properties[1]), int.Parse(properties[2])));
                         break;

                     case "Backstage passes":
                         listOfItems.Add(new BackstagePasses(properties[0], int.Parse(properties[1]), int.Parse(properties[2])));
                         break;
                 }

             }*/
            /////////////////////////////////////////////
            //read using BDD
            OCON1.Close();
            OCON1.Open();
            OCMD1.Connection = OCON1;
            OCMD1.CommandText = "select*From Items";
            ODR1 = OCMD1.ExecuteReader();
          
            while (ODR1.Read())
            {
                switch (ODR1[1].ToString())
                {
                    case "Generic":
                        listOfItems.Add(new GenericItem(ODR1[1].ToString(), (int)ODR1[2], (int)ODR1[3]));
                        break;

                    case "Aged":
                        listOfItems.Add(new AgedItem(ODR1[1].ToString(), (int)ODR1[2], (int)ODR1[3]));
                        break;

                    case "Backstage passes":
                        listOfItems.Add(new BackstagePasses(ODR1[1].ToString(), (int)ODR1[2], (int)ODR1[3]));
                        break;
                }
            }
            ODR1.Close();
            OCON1.Close();

            return listOfItems;
        }

        public void SaveInventory(List<Item> items)
        {
            
        }
    }
}
