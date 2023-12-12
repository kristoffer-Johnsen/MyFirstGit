namespace PP_Kristoffer____Simon
{
    public class Hobbier
    {
        public string Name;
        public string Description;

        public Hobbier(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void printInfo()
        {
            Console.WriteLine($"Vi har til felles {Name}");
            Console.WriteLine($"Det innebærer {Description}");
        }
    }
}
