using Teams.Models;

namespace Teams.Store
{
    public class UserState
    {
        public UserState(User user)
        {
            User = user;
        }

        public User User { get; }
    }
}
