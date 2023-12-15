using System;
using Microsoft.Maui.Controls;


namespace LongitudApp
{
    public partial class KmToMPage : ContentPage
    {
        public KmToMPage()
        {
            InitializeComponent();
        }

        private void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kmEntry.Text))
            {
                if (double.TryParse(kmEntry.Text, out var kilometers))
                {
                    var meters = kilometers * 1000;
                    resultLabel.Text = $"{meters} metros";
                }
                else
                {
                    resultLabel.Text = "Por favor, ingrese un valor numérico";
                }
            }
            else
            {
                resultLabel.Text = "Por favor, ingrese un valor en kilómetros";
            }
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            kmEntry.Text = string.Empty;
            resultLabel.Text = string.Empty;
        }
    }
}