using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiValidationDemo
{
	public partial class MainPageViewModel : ObservableObject
	{
		[ObservableProperty]
		private LoginModel loginModel;

		private ContentPage _page;

		public MainPageViewModel(ContentPage page)
		{
			_page = page;
			LoginModel = new LoginModel();
		}

		[RelayCommand]
		private async Task Login()
		{
            if (!ValidationHelper.IsFormValid(LoginModel, _page)) { return; }

            await _page.DisplayAlert("Success", "Validation Success!", "OK");
        }
	}
}

