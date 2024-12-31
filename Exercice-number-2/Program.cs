// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
//definition des message
string welcomMessage = "Welcom on our App";
String Devinette = "Try to find the number ";
string MoreThan20 = "Smaller";
string Under10 = "Bigger";
string winMessage = "Congratulation you have succeed";
string loseMessage = "Please try again ";
//debut du code console (visible)
Console.WriteLine(welcomMessage + '\n' + Devinette);
//debut de la boucle 
while(true)
{
    Console.WriteLine("Enter your choice");
    string choice = Console.ReadLine();
//Test de la validiter de l'entrer
    if (int.TryParse(choice, out int numberSelected))
        {
            Random numberGenerating = new Random();
            int numberToFind = numberGenerating.Next(11,20);
       
//message de delimitation des choix
            if (numberSelected > 20)
                {
            Console.WriteLine(MoreThan20);
         
                }
            else if (numberSelected < 10)
                {
            Console.WriteLine(Under10);
           
        }
            else if (numberSelected == numberToFind)
                {
             Console.WriteLine(winMessage);
             break;
                }
        }
//message d'invalidation de l'entrer
    else
        {
        Console.WriteLine("you have enter a unvalide nummber");
        }

        

}
