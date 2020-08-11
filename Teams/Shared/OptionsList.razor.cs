using Microsoft.AspNetCore.Components;
using Teams.Models;

namespace Teams.Shared
{
    public partial class OptionsList
    {
        [Parameter]
        public bool Display { get; set; }
        [Parameter]
        public User User { get; set; }
    }
}
