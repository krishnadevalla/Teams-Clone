using Teams.Models;

namespace Teams.Store.User
{
    public class SaveUserAction
    {
        public AppUser User;

        public SaveUserAction(AppUser user)
        {
            User = user;
        }
    }
}