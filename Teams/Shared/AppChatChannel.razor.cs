using Fluxor;
using Microsoft.AspNetCore.Components;
using Teams.Models;
using Teams.Store.Menu;

namespace Teams.Shared
{
    public partial class AppChatChannel
    {
        [Inject]
        public IState<MenuState> State { get; set; }

        private SelectedMenu SelectedMenu => State.Value.SelectedMenu;
    }
}
