namespace MauiAppEventos.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void Button_ClickedVoltar(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}