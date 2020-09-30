using Fluxor;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Teams.Models;

namespace Teams.Store.User
{
    public class GetUserEffect : Effect<GetUserAction>
    {
        private readonly HttpClient _httpClient;

        public GetUserEffect(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        protected override async Task HandleAsync(GetUserAction action, IDispatcher dispatcher)
        {
            var user = await _httpClient.GetFromJsonAsync<AppUser>("sample-data/user.json");
            dispatcher.Dispatch(new SaveUserAction(user));
        }
    }
}