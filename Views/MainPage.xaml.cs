using AppHotelAgenda13.Models;

namespace AppHotelAgenda13.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        var hoje = DateTime.Today;
        EntradaPicker.MinimumDate = hoje;
        EntradaPicker.Date = hoje;
        SaidaPicker.MinimumDate = hoje.AddDays(1);
        SaidaPicker.Date = hoje.AddDays(1);
        QuartoPicker.SelectedIndex = 0;
    }

    private void OnHospedesChanged(object sender, ValueChangedEventArgs e)
    {
        HospedesLabel.Text = $"{(int)e.NewValue} hóspede(s)";
    }

    private void OnEntradaChanged(object sender, DateChangedEventArgs e)
    {
        if (e.NewDate is not DateTime entrada)
            return;

        var saidaMinima = entrada.AddDays(1);
        SaidaPicker.MinimumDate = saidaMinima;
        if (SaidaPicker.Date is not DateTime saida || saida < saidaMinima)
            SaidaPicker.Date = saidaMinima;
    }

    private async void OnReservarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NomeEntry.Text))
        {
            await DisplayAlertAsync("Atenção", "Informe o nome do hóspede.", "OK");
            return;
        }

        if (QuartoPicker.SelectedItem is not string quarto ||
            EntradaPicker.Date is not DateTime entrada ||
            SaidaPicker.Date is not DateTime saida ||
            saida <= entrada)
        {
            await DisplayAlertAsync("Atenção", "Verifique a acomodação e as datas.", "OK");
            return;
        }

        var reserva = new Reserva
        {
            Nome = NomeEntry.Text.Trim(),
            Quarto = quarto,
            Hospedes = (int)HospedesStepper.Value,
            Entrada = entrada,
            Saida = saida
        };

        await Navigation.PushAsync(new ResumoPage(reserva));
    }
}
