namespace task1;
class Program
{
    static void Main(string[] args)
    {
        Apple apple = new Apple();

        apple.Sort = "Gizilahmadi";
        apple.Color = "red";

        Pear pear = new Pear();

        pear.Sort = "Asian";
        pear.Color = "yellow";

        Pomegranate pomegranate = new Pomegranate();
        pomegranate.Sort = "Guloysha";
        pomegranate.Color = "red";

        apple.Taste();
        pear.Taste();
        pomegranate.Taste();
    }
}

