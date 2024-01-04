
namespace Emne3.Friendface
{
    internal class User
    {
        private string? _name { get; }
        private string? _hobby { get; set; }
        private Friends _friends { get; set; }
        
        public User(string? name, string? hobby)
        {
            _name = name;
            _hobby = hobby;
            _friends=new Friends();
        }

        internal void Addfriend(User NewFriend)
        {
            _friends.Addf(NewFriend);
        }

        internal(string?, string?) GetProfile()
        {
            return (_name, _hobby);

        }

        internal string GetName()
        {
            return _name!;
        }

        internal void Removefriend(User Friend)
        {
            _friends.Remove(Friend);
        }

        internal void ShowFriends()
        {
            foreach (var friend in _friends.Getlist())
            {
                Console.WriteLine($"{friend._name}");
            }
        }

        internal List<User> Friendlist()
        {
            return _friends.Getlist();
        }
    }
}