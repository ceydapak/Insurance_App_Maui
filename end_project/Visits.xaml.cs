namespace end_project;

public partial class Visits : ContentPage
{
    public Visits()
	{
		InitializeComponent();
        Visit_List.ItemsSource = App.DBTrans.GetVisits();

    }
    private void Visit_List_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var selected = e.Item as Visit;
        Claim.VisitCost = selected.VisitCost;
        Claim.ClaimDate = selected.VisitDate;

    }
    private void claim_nav_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewClaim());

    }
}




  