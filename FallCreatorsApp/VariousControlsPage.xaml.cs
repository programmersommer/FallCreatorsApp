﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FallCreatorsApp
{

    public sealed partial class VariousControlsPage : Page
    {
        public VariousControlsPage()
        {
            this.InitializeComponent();
        }

        private void MyRatings_Changed(RatingControl sender, object args)
        {
            MyRatings.Caption = "Рейтинг " + sender.Value.ToString();
        }

    }
}
