// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int numero = 1;
Item item1 = new Item("vaso", 12, true, Category.ANTIQUES, State.BAD);
Item item2 = new Item("vaso", 12, true, Category.ANTIQUES, State.BAD);
List<Item> itemsList = new List<Item>{
    item1
};
Adress adress = new Adress("liolifasd", 312, 6431);
Pawnshop pawnshop = new Pawnshop(itemsList, adress);
pawnshop.addItem(item2);