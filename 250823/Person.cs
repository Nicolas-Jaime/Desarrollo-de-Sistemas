class Person
{
    private string name;
    private string lastname;
    public void introduceHimself(){}
}

class FootballPlayer : Person
{
    private int shirtNumber;
    public void introduceHimself()
    {
        console.WriteLine("Hola, me llamo " + FootballPlayer.name + " " + FootballPlayer.lastname + ". mi dorsal es " + FootballPlayer.shirtNumber);
    }
}

class Employee : Person
{
    private string fuction;
    public void introduceHimself()
    {
        console.WriteLine("Hola, me llamo " + Employee.name + " " + Employee.lastname + ". Mi empleo es " + Employee.fuction)
    }
}

class Trainer : Person
{
    private Tactic tactic;
    public void introduceHimself()
    {
        console.WriteLine("Hola, me llamo " + Trainer.name + " " + Trainer.lastname + ". Soy entrenador en este club.")
    }
}