using Fluxor;
using Microsoft.AspNetCore.Components;
using Teams.Models;
using Teams.Store.Menu;

namespace Teams.Shared.AppMenu
{
    public partial class AppMenuItem
    {
        [Inject]
        public IDispatcher Dispatcher { get; set; }

        [Parameter]
        public string ItemName { get; set; }

        [Parameter]
        public string ItemClass { get; set; }

        [Parameter]
        public string SpecialClass { get; set; } = "";

        private void SelectMenu()
        {
            Dispatcher.Dispatch(new SaveSelectedMenuAction(
                new SelectedMenu
                {
                    Name = ItemName
                }));
        }
    }
}