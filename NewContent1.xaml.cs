namespace MauiApp3;
using MauiApp3.Model;
public partial class NewContent1 : ContentView
{
    public User U { get; set; }
    public NewContent1(User U) 
	{
        this.U = U;
        BindingContext = this;
        InitializeComponent();
        

            
	}
}