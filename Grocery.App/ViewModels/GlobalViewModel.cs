using Grocery.Core.Models;

namespace Grocery.App.ViewModels
{
    public partial class GlobalViewModel : BaseViewModel
    {
        public static GlobalViewModel Current { get; set; } = new GlobalViewModel();
        public Client Client { get; set; }
        public string UserDisplayName => Client?.Name ?? "Niet ingelogd";
    }
}
