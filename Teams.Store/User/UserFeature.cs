using Fluxor;
using Teams.Models;

namespace Teams.Store.User
{
    public class MenuFeature : Feature<UserState>
    {
        public override string GetName() => "User";

        protected override UserState GetInitialState()
        {
            return new UserState(new AppUser());
        }
    }
}