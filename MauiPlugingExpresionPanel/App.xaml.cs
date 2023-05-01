using MauiPlugingExpresionPanel.Views;

namespace MauiPlugingExpresionPanel;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ExpandableList();
	}
}
