using SQLite;

namespace end_project;

public partial class NewClaim : ContentPage
{
	public NewClaim()
	{
		InitializeComponent();
        p.ItemsSource = App.DBTrans.GetCompany();
        p.ItemDisplayBinding = new Binding("RepresentiveName");
        cdate.Date=Claim.ClaimDate;
        Cost.Text = Convert.ToString(Claim.VisitCost);
       
    }

    private void Send_Btn_Clicked(object sender, EventArgs e)
    {
        var claim = new Claim();
        claim.RepresentiveName = p.SelectedItem.ToString();
        App.DBTrans.InsertClaim(claim);
        label.Text = Convert.ToString(claim.ClaimId);



    }

}