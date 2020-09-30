using Teams.Models;

namespace Teams.Store.Menu
{
    public class MenuState
    {
        public MenuState(SelectedMenu selectedMenu)
        {
            SelectedMenu = selectedMenu;
        }

        public SelectedMenu SelectedMenu { get; }
    }
}