using Fluxor;
using Microsoft.AspNetCore.Components;
using Teams.Store;

namespace Teams.Pages
{
    public partial class Index
    {
        [Inject]
        public IDispatcher Dispatcher { get; }
        public Index(IDispatcher dispatcher)
        {
            Dispatcher.Dispatch(new GetUserAction());
        }
    }
}
