
using static Emne3.FriendFace.FriendFace;

namespace Emne3.Friendface
{
    internal static class Methods
    {
        public static void AllMembers()
        {
            Console.WriteLine("Current members are:");
            foreach (var user in Members)
            {
                Console.WriteLine(user.GetName());
            }
            Console.ReadLine();
        }
        internal static void GeneratedMembers()
        {
            User axsel = new("Axel", "something");
            User ingrid = new("Ingrid", "");
            User pål = new("Pål", "");
            User harald = new("Harald", "");
            User hanna = new("Hanna", "");
            Members.Add(axsel);
            Members.Add(ingrid);
            Members.Add(pål);
            Members.Add(harald);
            Members.Add(hanna);
        }

        internal static User CreateUser()
        {
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("Hello, thank you for making FriendFace your social media of choice\n" +
                              "what is your name?\n");
            string? name = null;
            while (string.IsNullOrEmpty(name)) name = Console.ReadLine();

            Console.WriteLine($"\nthank you {name}, what are some of your hobbies?");

            string? hobby = "";
            hobby = Console.ReadLine();

            User user = new(name, hobby);

            Console.WriteLine("your basic profile is now ready! press any key to continue");
            return user;
        }

        internal static void Userprofile()
        {
            var findprofile = true;
            Console.WriteLine("which profile would you like to see?");
            while (findprofile)
            {
                var Profile = Console.ReadLine();
                foreach (User person in Members)
                {
                    if (person.GetName().ToLower() == Profile)
                    {
                        (string? Name, string? Hobby) = person.GetProfile();
                        Console.WriteLine($"Name: {Name}\n" +
                                          $"Hobby:{Hobby}");
                        findprofile = false;
                    }
                    else
                    {
                        Console.WriteLine("could not find the profile, try again");
                    }
                }
            }
        }

        internal static void AddFriend()
        {
            Console.Clear();
            Console.WriteLine("please enter friends name");
            User NewFriend = Askname();

            CurrentUser!.Addfriend(NewFriend);

            User Askname()
            {
                string? name = null;
                while (name == null)
                {
                    name = Console.ReadLine()?.ToLower();
                }

                bool found = false;

                foreach (User person in Members)
                {
                    if (person.GetName().ToLower() == name)
                    {
                        Console.WriteLine($"{person.GetName()} has been added to your friend list");
                        found = true;
                        return person;
                    }
                }
                if (!found)
                {
                    Console.Clear();
                    Console.WriteLine("No person with that name is in our database.\n" +
                                      "Please try again");
                    Askname();
                }
                return null!;
            }
        }
        internal static User RemoveFriend()
        {
            CurrentUser!.ShowFriends();
            Console.WriteLine("who do you want to remove? if you change your mind do not write anything");
            User Friend = Friendfind();

            return Friend;

            User Friendfind()
            {
                var profile = Console.ReadLine()?.ToLower();
                if (profile == null)
                {
                    return null!;
                }

                foreach (var person in CurrentUser!.Friendlist())
                {
                    if (person.GetName() == profile)
                    {
                        return person;
                    }

                    Console.Clear();
                    Console.WriteLine("this member is not on  your friendlist, try again");
                    Friendfind();
                }
                return null!;
            }
        }

    }
}