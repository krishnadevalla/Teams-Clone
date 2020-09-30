using Teams.Models;

namespace Teams.Store.Menu
{
    public class SaveSelectedMenuAction
    {
        public SaveSelectedMenuAction(SelectedMenu selectedMenu)
        {
            SelectedMenu = selectedMenu;
        }

        public SelectedMenu SelectedMenu { get; set; }
    }
}
