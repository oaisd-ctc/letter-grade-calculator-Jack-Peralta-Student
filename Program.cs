using System;

class program
{
    public static void Main(string[] args)
    {
        int score = int.Parse(Console.ReadLine());
        if ( score >= 100)
        {
            Console.WriteLine("A+");
            Console.WriteLine("Wow! 100…That's impressive!");
        }
        else if ( score >= 90)
        {
            Console.WriteLine("A");
            Console.WriteLine("Very nice!");
        }
        else if ( score >= 80)
        {
            Console.WriteLine("B");
            Console.WriteLine("Keep it up!");
        }
        else if ( score >= 70)
        {
            Console.WriteLine("C");
            Console.WriteLine("You got this, keep working!");
        }
        else if ( score >= 60)
        {
            Console.WriteLine("D");
            Console.WriteLine("Keep Trying!"); 
        }
        else
        {
            Console.WriteLine("E");
            Console.WriteLine("Don't give up!");

        }
    }
}
