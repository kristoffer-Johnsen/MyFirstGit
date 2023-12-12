
using Emne3.Friendface;
using static Emne3.Friendface.Methods;

namespace Emne3.FriendFace
{
    internal static class FriendFace
    {
        internal static List<User> Members = new();
        internal static User? CurrentUser = null;
        public static void Start()
        {

            Console.Clear();
            CurrentUser = CreateUser();
            GeneratedMembers();
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(0, 3);
            bool menu = true;
            while (menu)
            {
                Console.Clear();
                Console.WriteLine($" ------------------------------------------------------- \n" +
                                  $"|                      friendface                       |\n" +
                                  $"|                                                       |\n" +
                                  $"|                      hello user!                      |\n" +
                                  $"|              here are some options for you            |\n" +
                                  $"|          0.stop                                       |\n" +
                                  $"|          1.see a list of current members              |\n" +
                                  $"|          2.add another member to your friendlist      |\n" +
                                  $"|          3.remove friends from your friendlist        |\n" +
                                  $"|          4.see your friendlist                        |\n" +
                                  $"|          5.look at someones profile                    |\n" +
                                  $"|                                                       |\n" +
                                  $"|   type the number of the thing you would like to do   |\n" +
                                  $" ------------------------------------------------------- \n");

                //-------------made with help from teacher-------------//

                dynamic ans = "";
                while (ans?.GetType() == typeof(string) || ans == null)
                {
                    ans = Console.ReadLine()!;

                    if (ans?.Length != 1 && ans != null) //bare ett tegn og ikke null
                        continue; //gå til neste iterasjon av loopen

                    char ansChar = ans?[0]; //en string er basically bare et array av characters
                    if (char.IsDigit(ansChar))//sjekk om tegnet som ble skrevet er et siffer
                    {
                        ans = int.Parse(ans);
                        break; //stopp loopen
                    }
                }

                //-----------------------------------------------------//

                if (ans >= 0 || ans <= 5)
                {
                    //not how switch expression work(not ith methods)

                    //string Result = ans switch
                    //{
                    //    1 => "CurrentMembers",
                    //    2 => "something"  //FriendList.AddFriend(),
                    //    3 => "FriendList.RemoveFriend(),"
                    //    4 => "FriendList.ShowFriends(),"
                    //    5 => "User.GetProfile()",
                    //    _ => "Console.WriteLine("mate... how?") //should not be possible      Im not even mad, thats Amazing!
                    //};
                    switch (ans)
                    {
                        case 0:
                            menu = false;
                            break;
                        case 1:
                            AllMembers();
                            break;
                        case 2:
                            AddFriend();
                            break;
                        case 3:
                            Console.WriteLine("type the name you want to remove");
                            User Friend = RemoveFriend();
                            CurrentUser.Removefriend(Friend);
                            break;
                        case 4:
                            Console.WriteLine("Friends:");
                            CurrentUser.ShowFriends();
                            break;
                        case 5:
                            Console.Clear();
                            Userprofile();
                            break;
                    }
                    Console.WriteLine("\nPress any key to continue");
                }
            }
        }

        
    }
}
//          Oppgave Social Media
// Lag applikasjon FriendFace. Det er tiltenkt at dette skal bli det nyeste kule sosiale mediet som tar verden med storm. Her trenger en bruker en profilside med diverse info om seg (ta gjerne inspirasjon fra andre sosiale medier),
// 
// Du må lage en metode som heter “AddFriend” og en metode “RemoveFriend”.
// 
// Når programmet starter opp skal du lage en hovedbruker som er “innlogget”. Du må også opprette flere forskjellige brukere som lever på det sosiale mediet.
// 
// Lag et kommandbasert meny i konsollen der du kan:
// 
// Legge til forskjellige brukere som venn (på den som er innlogget)
// Fjerne brukere som venn
// Printe ut en liste av alle man har lagt til som venn
// Velge en av vennene og printe ut profilinformasjonen deres.



//out var axsel, out var ingrid, out var pål, out var harald, out var hanna



