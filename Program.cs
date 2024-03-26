//Level 1 - Mandatory
namespace inventory_management_assignment;
internal class Program
{
    private static void Main(string[] args)
    {
        Store store = new("Healthy");
        Item Honey = new("Wildflower Honey", 200);
        Item protein = new("protein chocolate bar", 30);

        List<Item> items = store.GetItems();
        Console.WriteLine("Before " + items.Count);

        store.AddItems(Honey);
        store.AddItems(protein);
        Console.WriteLine("After " + items.Count);

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
    }

}
