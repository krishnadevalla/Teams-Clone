using Teams.Models;

namespace Teams.Store.User
{
    public class UserState
    {
        public UserState(AppUser user)
        {
            User = user;
        }

        public AppUser User { get; }
    }
}