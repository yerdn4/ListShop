using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Maui.Models;

namespace ShopList.Maui.ViewModels
{
    public partial class EditItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private ShopListItem _item;

        [RelayCommand]
        public async Task SaveAsync(ShopListItem item)
        {
            await Shell.Current.GoToAsync("..");

        }

    }


}
