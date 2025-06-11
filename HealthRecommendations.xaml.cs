namespace BMICalculatorMobileApp;

public partial class HealthRecommendations : ContentPage
{
	public HealthRecommendations(string HealthStatus)
	{
        InitializeComponent();
        if(HealthStatus == "Underweight") {
            lblHeathRecommendations.Text = "- Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, whole grains).\n- Incorporate strength training to build muscle mass.\n- Consult a nutritionist if needed.";
        }
        else if(HealthStatus == "Normal Weight") {
            lblHeathRecommendations.Text = "- Maintain a balanced diet with proteins, healthy fats, and fiber.\n- Stay physically active with at least 150 minutes of exercise per week.\n- Keep regular check-ups to monitor overall health.";
        }
        else if(HealthStatus == "Overweight") {
            lblHeathRecommendations.Text = "- Reduce processed foods and focus on portion control. \n- Engage in regular aerobic exercises(e.g., jogging, swimming) and strength training. \n- Drink plenty of water and track your progress.";
        }
        else if(HealthStatus == "Obese") {
            lblHeathRecommendations.Text = "- Consult a doctor for personalized guidance. \n- Start with low-impact exercises (e.g., walking, cycling). \n- Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes.\n- Avoid sugary drinks and maintain a consistent sleep schedule.";
        }
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}