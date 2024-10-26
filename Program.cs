using System;

abstract class Ekiperovka
{
    public abstract void Orujie();
    public abstract double Weight { get; }
    public abstract double Price { get; }

}

class Gladiator
{
    public void Orujie(Ekiperovka ekiperovka)
    {
        ekiperovka.Orujie();
    }
}

class Mech : Ekiperovka

{
    public override double Weight
    {
        get { return 1.5; } 
    }
    public override double Price
    {
        get { return 150; } 
    }
    public override void Orujie()
    {
        Console.WriteLine("Меч. Вес: " + Weight + " кг, Цена: " + Price + " сом.");
    }
}

class Trezubec : Ekiperovka
{
    public override double Weight
    {
        get { return 2.4; }
    }
    public override double Price
    {
        get { return 300; }
    }
    public override void Orujie()
    {
        Console.WriteLine("Трезубец. Вес: " + Weight + " кг, Цена: " + Price + " сом.");
    }
}

class Kopio : Ekiperovka
{
    public override double Weight
    {
        get { return 3; }
    }
    public override double Price
    {
        get { return 500; }
    }
    public override void Orujie()
    {
        Console.WriteLine("Меч. Вес: " + Weight + " кг, Цена: " + Price + " сом.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        

        Gladiator gladiator = new Gladiator();
        Mech mech = new Mech();
        Trezubec trezubec = new Trezubec();
        Kopio kopio = new Kopio();

        gladiator.Orujie(mech);
        gladiator.Orujie(trezubec);
        gladiator.Orujie(kopio);
        Console.ReadKey();
    }

}