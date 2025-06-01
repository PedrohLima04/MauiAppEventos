namespace MauiAppEventos.Views;

public partial class EventoCadastrado : ContentPage
{
	public EventoCadastrado()
	{
		InitializeComponent();
	}

    private void Button_ClickedVoltar(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}