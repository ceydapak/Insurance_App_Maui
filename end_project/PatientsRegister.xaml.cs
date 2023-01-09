using Microsoft.Maui.Controls;

namespace end_project;

public partial class PatientsRegister : ContentPage
{
	public PatientsRegister()
	{
		InitializeComponent();
     
        picker.ItemsSource = App.DBTrans.GetCompany();
        picker.ItemDisplayBinding = new Binding("CompanyName");


    }

    private void PSave_Btn_Clicked(object sender, EventArgs e)
    {
		var patient = new Patient();
        patient.PatientName = pname.Text;
        patient.PatientAddress = padd.Text;  
        patient.PatientBirth= pdate.Date; 
		patient.PatientPhone = pphone.Text;
        patient.InsuranceCompanyName = picker.SelectedItem.ToString();
		App.DBTrans.InsertPatient(patient);
        label.Text = Convert.ToString(patient.PatientId);
       
        



    }


}