﻿using App1.Models;
using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateQRCodeView : ContentPage
    { 
        public CreateQRCodeView(string kq)
        {
            InitializeComponent();
            Barcode.BarcodeValue = kq;
            this.BindingContext = new CreateQRCodeViewModel(kq);
        }
    }
}