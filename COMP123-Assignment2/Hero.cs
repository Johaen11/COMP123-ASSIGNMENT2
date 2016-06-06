using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment2
{
    public class Hero 
    {
        //Private Instance Variables
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;


        //Public Property+++++++++++++++++++
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
               this._name = value;
            }

        }

        private void _generateAbilities()
        {
            Random rnd = new Random();
            this._strength = rnd.Next(1, 101);
            _speed = rnd.Next(1, 101);
            _health = rnd.Next(1, 101);
        }

        private bool _hitAttempt()
        {
            Random rnd = new Random();
            if (rnd.Next(1, 101) <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private int _hitDamage()
        {
            Random rnd = new Random();

            return rnd.Next(1, 7) * _strength;


        }

        public void Fight()
        {
            if (_hitAttempt() == true)
            {
                _hitDamage();
                Console.WriteLine("The Damage hit was {0}", _hitDamage());
            }
            else
                Console.WriteLine("Hit Attempt Failed");
        }

        public void Show()
        {
            Console.WriteLine("Strength: {0}", _strength);
            Console.WriteLine("Health: {0}", _health);
            Console.WriteLine("Speed: {0}", _speed);


        }
        //
        public Hero(string name)
        {
            _name = name;
            _generateAbilities();
        }
    }
}
