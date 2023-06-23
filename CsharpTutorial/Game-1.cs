using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Game_1
    {
        public static void Main(string[] args)
        {
            /* Two player game
                Inputs : ‘s’ / ‘w’ / ‘g’
                Rules:
                Snake vs water: snake drinks water so snake wins
                Sake vs gun : gun kills snake so gun wins
                Water vs gun: gun drowns in water so water wins
             */

            Console.WriteLine("***** Snake, Water, Gun *****");
            char comp = '\0'; // it is a null character
            var rnd = new Random();  // var can take any things like num,char ....
            var str = "swg";
            var rndIndex = rnd.Next(str.Length);
            comp = str[rndIndex];

            Console.Write("Enter 's' / 'w' / 'g' : ");
            char user = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Computer: {comp} | User: {user}");
            // logic
            if (comp == user)
            {
                Console.WriteLine("Draw");
            }
            if(comp == 's' && user == 'w')
            {
                Console.WriteLine("Computer Wins!");
            }
            if (comp == 'w' && user == 's')
            {
                Console.WriteLine("User Wins!");
            }
            if (comp == 's' && user == 'g')
            {
                Console.WriteLine("User Wins!");
            }
            if (comp == 'w' && user == 's')
            {
                Console.WriteLine("User Wins!");
            }
            if (comp == 'w' && user == 'g')
            {
                Console.WriteLine("Computer Wins!");
            }
            if (comp == 'g' && user == 'w')
            {
                Console.WriteLine("User Wins!");
            }





        }
    }
}
