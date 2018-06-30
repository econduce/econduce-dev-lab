using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EconduceDevLab.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EconduceDevLab.ViewModels
{
    public class MapFeaturesViewModel : INotifyPropertyChanged
    {
        bool _isBusy;
        public bool IsBusy {
            get => _isBusy;
            set {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public Command GetMapFeaturesCommand { get; }

        public MapFeaturesViewModel()
        {
            GetMapFeaturesCommand = new Command(async () => await GetMapFeatures(), () => !IsBusy);
        }

        public ObservableCollection<MapFeature> MapFeatures { get; set; } = new ObservableCollection<MapFeature>();

        public async Task GetMapFeatures()
        {
            if (IsBusy)
                return;

            try {
                IsBusy = true;

                using (var client = new HttpClient()) {
                    var json = await client.GetStringAsync("https://demo2047210.mockable.io/mapFeatures");

                    var features = JsonConvert.DeserializeObject<List<MapFeature>>(json);

                    MapFeatures.Clear();

                    foreach (var ft in features) {
                        MapFeatures.Add(ft);
                    }
                }
            }
            catch(Exception ex) {
                await Application.Current.MainPage.DisplayAlert("¡Ups!", ex.Message, "OK");
            }
            finally {
                IsBusy = false;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
