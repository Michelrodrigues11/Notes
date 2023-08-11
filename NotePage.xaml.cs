namespace notes;

public partial class NotePage : ContentPage
{
	public NotePage()
	{
		InitializeComponent();
	}
	public void SaveButton_Clicked(object sender, EventArgs e)
	{
		Console.WriteLine(sender.ToString(), e);

	}
    public void DeleteButton_Clicked(object sender, EventArgs e)
	{
        Console.WriteLine(sender.ToString(), e);
    }
}