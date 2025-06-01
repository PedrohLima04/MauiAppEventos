using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
        InitializeComponent(); 

        Dp_inicio.MinimumDate = DateTime.Now;
        Dp_termino.MinimumDate = Dp_inicio.Date.AddDays(1);
        Dp_termino.MaximumDate = Dp_inicio.Date.AddDays(7);
    }





    private async void Button_ClickedCalcular(object sender, EventArgs e)
    {
        try
        {
            Evento Ev = new Evento
            {
                Nome = NomeE.Text,
                Local = localE.Text,

                QntPessoas = (int)Convert.ToInt64(stp_pessoas.Value),

                Dp_inicio = Dp_inicio.Date,
                Dp_termino = Dp_termino.Date,
            };


            await Navigation.PushAsync(new EventoCadastrado()
            {
                BindingContext = Ev
            });
        }
        catch (Exception ex) 
        {
            await DisplayAlert("Ops", ex.Message, "ok");
        }
    }

    private void Button_ClickedSobre(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Sobre());
    }

    private void Dp_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker? elemento = sender as DatePicker;

        DateTime data_selecionada = elemento.Date;

        Dp_termino.MinimumDate = data_selecionada.AddDays(1);
        Dp_termino.MaximumDate = data_selecionada.AddDays(7);
    }
}//fim classe