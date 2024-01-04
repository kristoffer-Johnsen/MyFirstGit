
namespace Emne3.Friendface
{
    internal class Friends
    {
        private List<User> _list { get; } = new();

        internal void Addf(User NewFriend)
        {
            _list.Add(NewFriend);
        }

        internal void Remove(User Friend)
        {
            _list.Remove(Friend);
        }

        internal List<User> Getlist()
        {
            return _list;
        }
    }
}