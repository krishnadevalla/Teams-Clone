using Fluxor;
using Teams.Models;

namespace Teams.Store.Menu
{
    public class MenuFeature : Feature<MenuState>
    {
        public override string GetName() => "Menu";

        protected override MenuState GetInitialState()
        {
            return new MenuState(new SelectedMenu());
        }
    }
}