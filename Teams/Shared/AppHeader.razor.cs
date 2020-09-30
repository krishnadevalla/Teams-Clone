using Fluxor;
using Microsoft.AspNetCore.Components;
using Teams.Models;
using Teams.Store.User;

namespace Teams.Shared
{
    public partial class AppHeader
    {
        [Inject]
        public IState<UserState> State { get; set; }

        private string searchText;
        private bool showOptions;

        private AppUser User => State.Value.User;
    }
}