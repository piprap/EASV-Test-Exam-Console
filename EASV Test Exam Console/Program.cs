// See https://aka.ms/new-console-template for more information
using EASV_Test_Exam_Console;

Console.WriteLine("Hello, World!");

Cleaning d = new(500,true,true,true);
Console.WriteLine(d.ToString());

static void CalculatePrice(int distance)
{

    int kmprice = 500; //starting fee

    if (distance <= 100)
    {
        kmprice += distance * 20;
    }
    else if (distance <= 200)
    {
        kmprice += (distance - 100) * 15;
        kmprice += 2000;
    }
    else if (distance <= 500)
    {
        kmprice = (distance - 200) * 10;
        kmprice += 3500;
    }

    Console.WriteLine(distance + " - " + kmprice);

    //price1 = 100
    //price2 = 
    //price3 = 

    //modes: 
    //No multiplier = 000
    //Imprægnering  = 100
    //DoubleVask    = 010
    //Both          = 001
}

CalculatePrice(99);
CalculatePrice(100);
CalculatePrice(101);
CalculatePrice(200);
CalculatePrice(500);
Console.ReadLine();