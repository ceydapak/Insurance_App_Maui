namespace end_project;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void btn_register_Clicked(object sender, EventArgs e)
    {
       Navigation.PushAsync(new PatientsRegister());

    }
}

