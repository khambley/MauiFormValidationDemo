namespace MauiValidationDemo;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new MainPageViewModel(this);
	}
	
}


