/*int x = 0;
x++; //1
//x = x 
//x = x + 1;
System.Console.WriteLine(x); //1
x += 5; // 6
System.Console.WriteLine(x); //6
x--; //5
int y = --x; //y? 4 x? 4
System.Console.WriteLine($"y={y}");
System.Console.WriteLine($"x={x}");

System.Console.WriteLine(x);
x--;
System.Console.WriteLine(x);
*/
char choice;

do
{
    System.Console.Write("Give me a number between 1 - 10! ");
    //user input
    int x = int.Parse(Console.ReadLine());
    int wrongTimes = 0;
    while(x > 10 || x < 1)
    {
        wrongTimes++;
        if(wrongTimes > 5)
        {
            System.Console.WriteLine("ARE YOU STUPID!!!");
            Thread.Sleep(10000);
        }
        
        System.Console.WriteLine("Invalid Entry!");
        System.Console.Write("Give me a number between 1 - 10! ");
        //user input
        x = int.Parse(Console.ReadLine());
    }


    while(x > 0)
    {
        System.Console.WriteLine(x--);
        //x = x - 1;
        
        /*
        if(x == 3)
        {
            x = -1;
        }
        */
        Thread.Sleep(1000);
    }

    System.Console.WriteLine("Happy New Year!");

    System.Console.Write("Do you wish to continue? (Y or N) ");
    choice = Console.ReadLine()[0];

} while(choice == 'Y');


