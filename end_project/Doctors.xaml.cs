namespace end_project;

public partial class Doctors : ContentPage

{

    public Doctors()
    {
        InitializeComponent();
        Doctors_List.ItemsSource = App.DBTrans.GetDoctors();


    }

}

