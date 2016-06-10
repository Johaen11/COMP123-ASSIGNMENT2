using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author's Name: Johaen Gnanakumar
 * Author's Student#:300880309
 * Date Last Modified:06/06/2016
 * Program Description:This program 
 * Revision History: Version 0.0.8
 */
namespace COMP123_Assignment2
{
  /*
   * This class is the "driver" class for my program
   * 
   * @class program
   */ 
    
   
    class Program
    {
        /*
         * The main method for our driver class program
         * 
         * @method Main
         * @param {string[]} args
         */  
         
        static void Main(string[] args)
        {
            Hero hero = new Hero("Johaen");
            hero.Show();
            hero.Fight();

            Console.WriteLine();

            SuperHero superHero = new SuperHero("Johaen");
            superHero.Show();
            superHero.ShowPower();
        }
    }
}
