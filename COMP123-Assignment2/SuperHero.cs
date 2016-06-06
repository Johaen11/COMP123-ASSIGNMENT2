using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment2
{
    class SuperHero : Hero
    {
        string[] _superPowers = new string[3];

        public SuperHero(string name):base(name)
        {
            _generateRandomPowers();
        }
        /*A	private _generateRandomPowers	Method	randomly	
         * generates	three	random	superpowers	from	
         * the	following	list	of	6	powers	
         * (hint:	create	a	loop	that	picks	from	
         * the	power	list	three	times.	Note:	Make	
         * sure	the	resulting	private	_superPowers	array	
         * does	not	contain	any	duplicate	powers).	
         * The	_generateRandomPowers	Method	assigns	the	randomly
         * 	generated	powers	to	the	private	_superPowers	
         * 	array	(7	Marks:	Functionality):
         * 		1. Super Speed	2. Super Strength	3. Body	Armour	4. Flight	5. Fire	Generation	6. Weather	Control   	e. A	public ShowPowers	Method	that	will	display	the	Hero’s	super	powers	to	the	console.	Please	ensure	that	the	output	is	pretty	(3	Marks:	Functionality).	2
         */
        private void _generateRandomPowers()
        {
            List<string> superPowers = new List<string>();
            superPowers.Add("Super Speed");
            superPowers.Add("Super Strength");
            superPowers.Add("Body Armour");
            superPowers.Add("Flight");
            superPowers.Add("Fire Generation");
            superPowers.Add("Weather Control");

            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                int randomNum = rnd.Next(0, superPowers.Count);

                _superPowers[i] = superPowers.ElementAt(randomNum);
                superPowers.RemoveAt(randomNum);
                Console.WriteLine(_superPowers[i]);
            }
            Console.WriteLine();
        }
    }
}
