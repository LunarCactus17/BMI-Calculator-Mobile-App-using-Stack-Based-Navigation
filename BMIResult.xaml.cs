namespace BMICalculatorMobileApp;

public partial class BMIResult : ContentPage
{
    string healthStatus = "None";
    public BMIResult(double BMI,string Gender)
	{
		InitializeComponent();
        LblBMI.Text = "BMI:" + BMI.ToString();
        LblGender.Text = "Gender:" + Gender;
        if (Gender == "Male")
        {
            if (BMI < 18.5)
            {
                healthStatus = "Underweight";
            }
            else if (18.5 <= BMI && BMI < 25)
            {
                healthStatus = "Normal Weight";
            }
            else if (25 <= BMI && BMI < 30)
            {
                healthStatus = "Overweight";
            }
            else if (BMI >= 30)
            {
                healthStatus = "Obese";
            }
        }
        else if (Gender == "Female")
        {
            if (BMI < 18)
            {
                healthStatus = "Underweight";
            }
            else if (18 <= BMI && BMI < 24)
            {
                healthStatus = "Normal Weight";
            }
            else if (24 <= BMI && BMI < 29)
            {
                healthStatus = "Overweight";
            }
            else if (BMI >= 29)
            {
                healthStatus = "Obese";
            }
        }
        LblHealthStatus.Text = "HealthStatus:" + healthStatus;

    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HealthRecommendations(healthStatus));
    }
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}