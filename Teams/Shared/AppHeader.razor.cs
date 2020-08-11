using Fluxor;
using Fluxor.Blazor.Web.Components;
using Microsoft.AspNetCore.Components;
using Teams.Models;
using Teams.Store;

namespace Teams.Shared
{
    public partial class AppHeader
    {
        [Inject]
        public IDispatcher Dispatcher { get; }
        [Inject]
        public IState<UserState> State { get; }

        private string searchText;
        private bool showOptions;

        public AppHeader()
        {
            User = State.Value.User;
        }

        public User User { get; }
        private void changeOptions()
        {
            showOptions = !showOptions;
        }
    }
}
