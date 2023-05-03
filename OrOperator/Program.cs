
//Math >= 90 or Chemistry >=90;

//math && chemistry || math && Biology || chemisty && biology

int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enrer you Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enrer you Biology result:");
biology = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (chemistry >= 99 && biology >= 90) || (math >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You got accepted!");
}
else
{
    Console.WriteLine("Your application cannot be approved!");
}
