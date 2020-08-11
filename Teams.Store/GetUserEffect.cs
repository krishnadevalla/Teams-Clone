using Fluxor;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Teams.Models;

namespace Teams.Store
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
            var user = await _httpClient.GetFromJsonAsync<User>("sample-data/user.json");
            dispatcher.Dispatch(new SaveUserAction(user));
        }
    }
}
