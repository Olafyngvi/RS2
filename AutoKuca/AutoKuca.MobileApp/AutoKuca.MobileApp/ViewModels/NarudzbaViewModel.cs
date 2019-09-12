using AutoKuca.Model;
using AutoKuca.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AutoKuca.MobileApp.ViewModels
{
    public class NarudzbaViewModel
    {
        private readonly ApiService _stavke = new ApiService("DetaljiNarudzba");
        private readonly int _id;
        public ObservableCollection<DetaljiNarudzbe> stavkeNarudzbe { get; set; } = new ObservableCollection<DetaljiNarudzbe>();
        public NarudzbaViewModel(int id)
        {
            _id = id;
            InitCommand = new Command(async () => await Init(_id));
        }

        double _ukupno = 0;
        public double Ukupno
        {
            get { return _ukupno; }
            set { _ukupno = value; }
        }
        public async Task Init(int id)
        {
            stavkeNarudzbe.Clear();
            DetaljiNarudzbaSearchRequest req = new DetaljiNarudzbaSearchRequest()
            {
                NarudzbaId = id
            };
            var result = await _stavke.Get<List<DetaljiNarudzbe>>(req);
            foreach(var x in result)
            {
                Ukupno += x.Cijena * x.Kolicina;
                stavkeNarudzbe.Add(x);
            }
        }

        public ICommand InitCommand { get; set; }
    }
}
