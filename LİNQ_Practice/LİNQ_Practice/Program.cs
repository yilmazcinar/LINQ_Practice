public class Program
{
    public static void Main(string[] args)
    {


        //Çift sayıları bulma

        List<int> numbers = new List<int> { -1, -2, 3, 4, 5, 6, 7, 8, 17, 35 };

        var result = numbers.Where(x => x % 2 == 0).ToList();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("-------------------------------");

        //Tek sayıları bulma

        var result2 = numbers.Where(x => x % 2 == 1).ToList();



        foreach (var item in result2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------------------");


        //Negatif sayıları bulma
        var negativeNumbers = numbers.Where(x => x < 0).ToList();


        foreach (var item in negativeNumbers)
        {
            Console.WriteLine(item);
        }
        
        
        
        Console.WriteLine("---------------------------");
        
        
        //Pozitif sayıları bulma

        var positiveNumbers = numbers.Where(x => x > 0).ToList();

        foreach (var item in positiveNumbers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------------------");
        
        
        // 15 ile 22 arasındaki sayıları bulma
        var result3 = numbers.Where(x => x > 15 && x < 22).ToList();

        foreach (var item in result3)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------------------");


        List<double> numbers2 = new List<double> { 1, 3, 4, 5, 6, 7, 8, 17, 35 };


         //Sayıların karesini alma
        var squareNumbers = numbers.Select(x => x * x).ToList();

        foreach (var square in squareNumbers)
        {
            Console.WriteLine(square);
        }
    }
}