using System.Diagnostics;
using System;

namespace BMICalculatorMobileApp;

public partial class BMICalculator : ContentPage
{
    public BMICalculator()
    {
        InitializeComponent();
    }
    string choice = "None";

    private void TapMale_Tapped(object sender, TappedEventArgs e)
    {
        choice = "Male";
        FrameMale.BorderColor = Color.FromArgb("#0a0e29");
        FrameFemale.BorderColor = Color.FromArgb("#fdfdfd");
    }

    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {
        choice = "Female";
        FrameFemale.BorderColor = Color.FromArgb("#0a0e29");
        FrameMale.BorderColor = Color.FromArgb("#fdfdfd");
    }
    private void BtnCalculateBMI_Clicked(object sender, EventArgs e)
    {
        if (choice != "None")
        {
            double height = double.Parse(LblHeight.Text);
            double weight = double.Parse(LblWeight.Text);
            double BMI = (weight * 703) / (height * height);   
            Navigation.PushAsync(new BMIResult(BMI,choice));
        }
        else
        {
            DisplayAlert("Error:", "Gender Not Selected", "Ok");
        }
    }
}