using VersalityApp.ViewModels;

namespace VersalityApp.Views;

public partial class ActiveMethods : ContentPage
{
	public ActiveMethods()
	{
		InitializeComponent();
		BindingContext = new ActiveMethodsViewModel();
	}
}