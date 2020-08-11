using Fluxor;
using Teams.Models;

namespace Teams.Store
{
    public class UserFeature : Feature<UserState>
    {
        public override string GetName() => "Items";
        protected override UserState GetInitialState()
        {
            return new UserState(new User());
        }
    }
}
