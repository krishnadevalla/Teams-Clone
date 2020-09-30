using Fluxor;

namespace Teams.Store.Menu
{
    public class SaveSelectedMenuReducer : Reducer<MenuState, SaveSelectedMenuAction>
    {
        public override MenuState Reduce(MenuState state, SaveSelectedMenuAction action)
        {
            return new MenuState(action.SelectedMenu);
        }
    }
}