using Fluxor;
using Microsoft.AspNetCore.Components;
using Teams.Models;
using Teams.Store.User;

namespace Teams.Shared
{
    public partial class StatusItem
    {
        [Inject]
        public IState<UserState> State { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        public AppUser User => State.Value.User;

        [Parameter]
        public Status Status { get; set; }

        public void SaveStatus()
        {
            User.Status = Status;
            Dispatcher.Dispatch(new SaveUserAction(User));
        }
    }
}