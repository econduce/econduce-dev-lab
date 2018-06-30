using System;
using System.Collections.Generic;

using Xamarin.Forms;
using EconduceDevLab.Models;

namespace EconduceDevLab.Views
{
    public partial class MapFeatureDetailsPage : ContentPage
    {
        readonly MapFeature feature;

        public MapFeatureDetailsPage(MapFeature feature)
        {
            InitializeComponent();

            this.feature = feature;
            BindingContext = this.feature;
        }
    }
}
