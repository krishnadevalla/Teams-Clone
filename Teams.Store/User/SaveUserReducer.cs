using Fluxor;

namespace Teams.Store.User
{
    public class SaveUserReducer : Reducer<UserState, SaveUserAction>
    {
        public override UserState Reduce(UserState state, SaveUserAction action)
        {
            return new UserState(action.User);
        }
    }
}