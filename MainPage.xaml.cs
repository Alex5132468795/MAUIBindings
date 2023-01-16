namespace MauiApp3;
 
using MauiApp3.Model;

public partial class MainPage : ContentPage
{
    List<User> data = new List<User>(); 
	public MainPage()
	{
		InitializeComponent();
	}

	private void starts_Clicked(object sender, EventArgs e)
    {
        int m;
        try {
            m = Int32.Parse(cont.Text);
        }
        catch
        {
            return;
        }
        container.Clear();
        for (int i = 1; i <= m; i++)
        {
            NewContent1 n = new NewContent1(new User(i.ToString(), (i + 10).ToString(), (i * 100).ToString(), "dotnet_bot.png"));
            container.Add(n);
        }
        //data.Clear();
    }
}

