using System;
using System.Collections.Generic;

using Xamarin.Forms;
using EconduceDevLab.ViewModels;
using EconduceDevLab.Models;

namespace EconduceDevLab.Views
{
    public partial class MapFeaturesPage : ContentPage
    {
        readonly MapFeaturesViewModel viewModel;

        public MapFeaturesPage()
        {
            InitializeComponent();

            viewModel = new MapFeaturesViewModel();
            BindingContext = viewModel;

            MapFeaturesList.ItemSelected += MapFeaturesList_ItemSelected;
        }

        async void MapFeaturesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var feature = e.SelectedItem as MapFeature;

            await Navigation.PushAsync(new MapFeatureDetailsPage(feature));
            MapFeaturesList.SelectedItem = null;
        }
    }
}
