using Fluxor;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Teams.Store.User;

namespace Teams.Pages
{
    public partial class Index
    {
        [Inject]
        public IDispatcher Dispatcher { get; set; }

        protected override Task OnInitializedAsync()
        {
            Dispatcher.Dispatch(new GetUserAction());
            return base.OnInitializedAsync();
        }
    }
}