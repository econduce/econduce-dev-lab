using System;
using System.Collections.Generic;

using Xamarin.Forms;
using EconduceDevLab.ViewModels;

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
        }
    }
}
