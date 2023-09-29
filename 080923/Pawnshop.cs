using System.Reflection.Metadata;

class Pawnshop
{
    private List<Item> listItems;
    private Adress adress;
    public List<Item> ListItems
    {
        get{return listItems;}
        set{listItems = value;}
    }
    public Adress Adress
    {
        get{return adress;}
        set{adress = value;}
    }

    public Pawnshop(List<Item> listItems, Adress adress)
    {
        this.listItems = listItems;
        this.adress = adress;
    }

    public void addItem(Item item)
    {
        listItems.Add(item);
    }
    public void eraseItem(string itemName)
    {
        foreach(Item items in listItems){
            
            var count = -1;
            count++;
            if(itemName == items.Name){ listItems.RemoveAt(count); }

        }
        //listItems.Remove(item);
    }
    public void searchItem(Item item)
    {
        foreach (Item items in listItems)
        {
            if (items == item)
            {
                Console.WriteLine("El item que estás buscando es: " + items.Name);
            }
        }
    }
    public void searchItem2(Item item)
    {
        var count = 0;
        while (listItems.Count == 0)
        {
            if(listItems[count] == item)
            {
                Console.WriteLine("El item que estás buscando es: " + item.Name);
            }
            count++;
        }
        
        Console.WriteLine("El item que estás buscando no existe 🥺🥺");
    }
}