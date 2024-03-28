//Level 1 - Mandatory
namespace inventory_management_assignment;
internal class Program
{
    private static void Main(string[] args)
    {
        var oatBar = new Item("oat Bar", 10, new DateTime(2023, 1, 1));
        var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
        var dumplings = new Item("dumplings", 5, new DateTime(2023, 3, 1));
        var ravioli = new Item("ravioli", 20, new DateTime(2023, 4, 1));
        var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
        var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
        var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
        var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
        var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
        var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));
        var coffee = new Item("Coffee", 20);
        var sandwich = new Item("Sandwich", 15);
        var pasta = new Item("pasta", 10);
        var umbrella = new Item("Umbrella", 5);
        var sunscreen = new Item("Sunscreen", 8);

        var store = new Store("health", 300);

        store.AddItem(oatBar);
        store.AddItem(chocolateBar);
        store.AddItem(dumplings);
        store.AddItem(ravioli);
        store.AddItem(tissuePack);
        store.AddItem(chipsBag);
        store.AddItem(sodaCan);
        store.AddItem(soap);
        store.AddItem(shampoo);
        store.AddItem(toothbrush);
        store.AddItem(coffee);
        store.AddItem(sandwich);
        store.AddItem(pasta);
        store.AddItem(umbrella);
        store.AddItem(sunscreen);

        List<Item> items = store.GetItems();
        Console.WriteLine("After " + items.Count);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("╔═════════════════════════════════╗");
        Console.WriteLine("║                                 ║");
        Console.WriteLine("║           WELCOME TO            ║");
        Console.WriteLine("║          Health Store           ║");
        Console.WriteLine("║                                 ║");
        Console.WriteLine("╚═════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.White;
        foreach (Item item in items)
        {
            Console.WriteLine("");
            string vv = @"                 
  _ _   _ _   _ _   _ _   _ _   _ _   _ _   _ _   
 ( ` ) ( ` ) ( ` ) ( ` ) ( ` ) ( ` ) ( ` ) ( ` )  
(_{;}_|_{;}_|_{;}_|_{;}_|_{;}_|_{;}_|_{;}_|_{;}_) 
 (_,_) (_,_) (_,_) (_,_) (_,_) (_,_) (_,_) (_,_)  
";
            Console.WriteLine(vv);

            Console.WriteLine($"find {store.FindByName("Wildflower Honey")}");

            Console.WriteLine($"Name= {item.GetName()} Created_At = {item.GetCreatedAt()} Quantity = {item.GetQuantity()}");
        }
        store.GetItems();
        List<Item> SortItems = store.SortItem();
        foreach (var item in SortItems)
        {
            Console.WriteLine($"Name = {item.GetName()},/nQuantity = {item.GetQuantity()}");
        }
        Console.WriteLine(store.GetCapacity());
        store.GetItems();
        List<Item> SortByDate = store.SortByDate(SortOrder.DESC);
        foreach (var item in SortByDate)
        {
            Console.WriteLine($"Name = {item.GetName()},/nCreated_At = {item.GetCreatedAt()}");
        }
        store.GroupByDate();
    }
}
