using System;
using Microsoft.Maui.Controls;


namespace LongitudApp
{
    public partial class MToCmPage : ContentPage
    {
        public MToCmPage()
        {
            InitializeComponent();
        }

        private void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mEntry.Text))
            {
                if (double.TryParse(mEntry.Text, out var meters))
                {
                    var centimeters = meters * 100;
                    resultLabel.Text = $"{centimeters} centímetros";
                }
                else
                {
                    resultLabel.Text = "Por favor, ingrese un valor numérico";
                }
            }
            else
            {
                resultLabel.Text = "Por favor, ingrese un valor en metros";
            }
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            mEntry.Text = string.Empty;
            resultLabel.Text = string.Empty;
        }
    }
}