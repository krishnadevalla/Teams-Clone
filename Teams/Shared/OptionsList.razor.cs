using Fluxor;
using Microsoft.AspNetCore.Components;
using Teams.Models;
using Teams.Store.User;

namespace Teams.Shared
{
    public partial class OptionsList
    {
        [Inject]
        public IState<UserState> State { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        public AppUser User => State.Value.User;
        private bool canEditStatus = false;
        private bool changingStatus = false;
        private bool isChangingPicture = false;
        private string picUrl;

        private void UpdateStatus()
        {
            Dispatcher.Dispatch(new SaveUserAction(User));
            canEditStatus = false;
        }

        private void UpdatePicture()
        {
            if (!string.IsNullOrWhiteSpace(picUrl))
            {
                User.Avatar = picUrl;
                Dispatcher.Dispatch(new SaveUserAction(User));
            }
            isChangingPicture = false;
        }
    }
}