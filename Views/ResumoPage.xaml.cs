using AppHotelAgenda13.Models;
namespace AppHotelAgenda13.Views;
public partial class ResumoPage : ContentPage { public ResumoPage(Reserva reserva) { InitializeComponent(); BindingContext = reserva; } async void OnVoltarClicked(object sender, EventArgs e) => await Navigation.PopAsync(); }
