using AutoKuca.MobileApp.ViewModels;
using AutoKuca.Model;
using AutoKuca.Model.Requests;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AutoKuca.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetaljiVozilaPage : ContentPage
    {
       private DetaljiVozilaVM model;
        private ApiService _slike = new ApiService("Slike");
        private readonly ApiService _vozilo = new ApiService("Vozila");
        public  DetaljiVozilaPage(DetaljiVozilaVM model)
        {
            InitializeComponent();
           BindingContext= this.model = model;
           
        }

        private async void FlowListView_FlowItemTapped(object sender, ItemTappedEventArgs e)
        {
         
            await Navigation.PushModalAsync(new ModalSlikaPage(new ModalSlikaVM(model.OdabranaSlika)));
           
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.PopuniVozila();
        }
        private async void Button_Clicked(object sender, System.EventArgs e)
        {

            await Navigation.PushModalAsync(new ModalUpitVoziloPage(new ModalUpitVoziloVM(model.Vozilo.SifraAutomobila,model.Vozilo.VoziloId)));
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as VozilaM;
            if (item == null)
                return;
            var item2 = await _vozilo.GetById<VozilaM>(item.VoziloId);
            SlikeSearchRequest request = new SlikeSearchRequest
            {
                VoziloID = item.VoziloId
            };
            ObservableCollection<Slike> slike = await _slike.Get<ObservableCollection<Slike>>(request);
            await Navigation.PushAsync(new DetaljiVozilaPage(new DetaljiVozilaVM(slike, item2)));
        }
    }
}