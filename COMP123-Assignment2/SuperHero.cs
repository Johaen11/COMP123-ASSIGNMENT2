using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment2
{
    /**
     * This Class defines a SuperHero Class
     * 
     * @Class SuperHero
     * @field {string}_superPowers
     * 
     */ 
    class SuperHero : Hero
    {
        //PRIVATE INSTANCE VARIABLES++++++++++++++++++++++++++++++++++++++++++++++++++++
        string[] _superPowers = new string[3];
        List<string> SuperPower = new List<string>();
        


        //PUBLIC PROPERTIES++++++++++++++++++++++++++++++++++++++++++
        /**
         * 
         * <summary>
         * this is a public property for our private_superPowers field
         * </summary>
         * 
         */ 
        public string SuperPowers
        {
            get
            {
                return this._superPowers[3];
            }

            set
            {
                this._superPowers[3]= value;
            }
        }
        
        // CONSTRUCTORS++++++++++++++++++++++
        /**
         * <summary>
         * This is the constructor for the SuperHero class
         * </summary>
         * 
         * 
         */ 

        public SuperHero(string name):base(name)
        {
            _generateRandomPowers();
        }
        
        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++

            /**
             * <summary>
             * This method generates random powers using a list,for loop and a foreach loop
             * 
             *
             * </summary>
             * 
             * @methods _generateRandomPowers
             * @returns void
             * 
             * 
             */ 
        private void _generateRandomPowers()
        {
            List<string> randomPowers = new List<string>();
            randomPowers.Add("Super Speed");
            randomPowers.Add("Super Strength");
            randomPowers.Add("Body Armour");
            randomPowers.Add("Flight");
            randomPowers.Add("Fire Generation");
            randomPowers.Add("Weather Control");

            Random rnd = new Random();

            for (int counter = 0; counter < 3; counter++)
            {
                int randomNum = rnd.Next(0, randomPowers.Count);

                _superPowers[counter] = randomPowers.ElementAt(randomNum);
                randomPowers.RemoveAt(randomNum);
                
            }
            Console.WriteLine();

            foreach (string power in _superPowers)
            {
                SuperPower.Add(power);
            }
        }

        /**
         * <summary>
         * 
         * This method outputs the power using a foreach statement
         * </summary>
         * 
         * @method ShowPower
         * @returns void
         */ 
        public void ShowPower()
        {
            foreach (string power in SuperPower)
            {
                Console.WriteLine(power);
            }
            
        }
    }
}
