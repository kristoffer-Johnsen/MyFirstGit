
namespace Emne3.Bossfight
{
    class GameCharacter
    {
        private int _health { get; set; }
        
        private bool _strRandom { get; }
        private int _strength { get; set; }

        private int _MaxStamina { get; }
        private int _stamina { get; set; }

        public GameCharacter(int health, int stamina, int strength = -1)
        {
            _health = health;

            _strRandom = strength == -1;
            _strength = strength == -1 ? Rand() : strength;

            _MaxStamina = stamina;
            _stamina = stamina;
             
        }


        private int Rand() //int max = 31
        {
            Random rand = new Random();
            return rand.Next(0, 31);
            //return rand.Next(0, max);
        }

        internal int Health()
        {
            return _health;
        }

        internal int Damage()
        {
            return _strength;
        }

        ///<summary>
        ///<param name="rndStrength">Should the attack have a random strength?</param>
        ///<param name="rndStrength">What should the maximum value of the random strength be?</param>
        ///</summary>
        internal int Attack() //bool rndStrength = false, int maxHit = 31
        {
            if (_stamina <= 0)
            {
                Recharge();
                return -1;
            }

            if (_strRandom)
            {
                _strength = Rand();
            }

            //if (rndStrength)
            //{
            //    _strength = Rand(maxHit);
            //}

            if (_stamina > 0)
            {
                _stamina -= 10;
                return _strength;
            }
            return -1;
        }

        internal void TakeDamage(int strength)
        {
            _health -= strength;
        }

        private void Recharge()
        {
            _stamina = _MaxStamina;
        }

        internal (int, int, int, bool) show()
        {
            return (_health, _stamina, _strength, _strRandom);
        }
    }
}