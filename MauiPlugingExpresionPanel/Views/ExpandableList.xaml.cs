using MauiPlugingExpresionPanel.ViewModels;

namespace MauiPlugingExpresionPanel.Views;

public partial class ExpandableList : ContentPage
{
	public ExpandableList()
	{
		InitializeComponent();
        this.BindingContext = new ProfileViewModel();
    }
}