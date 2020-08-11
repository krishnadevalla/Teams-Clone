using Teams.Models;

namespace Teams.Store
{
    public class SaveUserAction
    {
        public User User;

        public SaveUserAction(User user)
        {
            User = user;
        }
    }
}