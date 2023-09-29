class Adress
{
    private string street;
    private int number;
    private int postalCode;

    public string Street{
        get{return street;}
        set{street = value;}
    }
    public int Number{
        get{return number;}
        set{number = value;}
    }
    public int PostalCode{
        get{return postalCode;}
        set{postalCode = value;}
    }

    public Adress(string street, int number, int postalCode)
    {
        this.street = street;
        this.number = number;
        this.postalCode = postalCode;
    }
}