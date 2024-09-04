using Microsoft.AspNetCore.Components;

namespace BlazorApp6.Components.Layout
{
    public partial class NavMenu
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

    public void NavigateToHome()
        {
            NavigationManager.NavigateTo("/");
        }

        private void NavigateToDetails()
        {
            NavigationManager.NavigateTo($"/detalhes/123");
        }
    }
}
