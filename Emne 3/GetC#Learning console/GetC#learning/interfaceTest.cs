
//with a game character  in mind

namespace Emne3
{
    //all this is just a test file, i dont need all the warnings//
#pragma warning disable

    internal class interfaceExample
    {
        internal class somethingelse : IClassFeatures, IRaceFeatures, IGeneralFeatures
        {
            public string Strength { get; set; }

            public string SpecialAttack { get; set; }
            public string Name { get;}
            public string Gender { get; set; }
            public int Age { get; set; }
        }

        internal partial class Character : IGeneralFeatures
        {
            public string Name { get;}
            public string Gender { get; set; }
            public int Age { get; set; }
        }

        internal partial class Character : IRaceFeatures
        {
            public string Strength { get; set; }
            public string SpecialAttack { get; set; }
        }

        internal partial class Character : IClassFeatures
        {
            string Attacks { get; set; }
        }

        internal interface IGeneralFeatures : IRaceFeatures
        {
            string Name { get;}
            string Gender { get; set; }
            int Age { get; set; }
            string Strength { get; set; } //intelligence,strength,dexterity etc.
            string SpecialAttack { get; set; }
        }

        internal interface IRaceFeatures
        {
            string Strength { get; set; } //intelligence,strength,dexterity etc.
            string SpecialAttack { get; set; }
        }

        internal interface IClassFeatures
        {
            public string Strength { get; set; }
            public string SpecialAttack { get; set; }
        }
    }
#pragma warning restore
}