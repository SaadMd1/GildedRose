using GildedRose;

internal class Program
{
    private static void Main(string[] args)
    {        
        Shop shop = new Shop(new FileItemsRepository());
        shop.UpdateQuality();

         
    }
}