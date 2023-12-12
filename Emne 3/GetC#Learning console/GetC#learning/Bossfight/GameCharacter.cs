using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emne3.Bossfight
{
    class GameCharacter
    {
        private int _health { get; set; }

        private readonly bool _strRandom;
        private int _strength { get; }

        private int _MaxStamina { get; }
        private int _stamina { get; set; }

        public GameCharacter(int health, int stamina, int strength = -1)
        {
            _health = health;
            _strRandom = (strength == -1);
            _strength = (strength == -1) ? Rand() : strength;
            _stamina = stamina;
        }


        private int Rand()
        {
            Random rand = new Random();
            return rand.Next(0, 31);
        }



        internal int Health()
        {
            return _health;
        }

        internal int Damage()
        {
            return _strength;
        }

        internal int Attack()
        {
            if (_strRandom)
            {
                Rand();
            }

            if (_stamina > 0)
            {
                _stamina = -10;
                return _strength;
            }

            recharge();
            return -1;
        }

        internal void TakeDamage(int strength)
        {
            _health = -strength;
        }

        private void recharge()
        {
            _stamina = _MaxStamina;
        }

        internal (int, int, int, bool) show()
        {
            return (_health, _stamina, _strength, _strRandom);
        }
    }
}
