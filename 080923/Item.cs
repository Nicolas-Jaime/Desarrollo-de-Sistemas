using System.Dynamic;

class Item
{
    private string name;
    private double price;
    private bool onSale;
    private Category category;
    private State state;

    public string Name{
        get{return name;}
        set{name = value;}
    }
    public double Price{
        get{return price;}
        set{price = value;}
    }
    public bool OnSale{
        get{return onSale;}
        set{onSale = value;}
    }
    public Category Category{
        get{return category;}
        set{category = value;}
    }
    public State State{
        get{return state;}
        set{state = value;}
    }
    public Item(string name, double price, bool onSale, Category category, State state)
    {
        this.name = name;
        this.price = price;
        this.onSale = onSale;
        this.category = category;
        this.state = state;
    }
}