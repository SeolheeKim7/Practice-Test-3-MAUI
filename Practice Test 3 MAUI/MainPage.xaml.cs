using NumberFun;
using Practice_Test_3_MAUI.Data;
using Practice_Test_3_MAUI.Models;

namespace Practice_Test_3_MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;
    private BatmanSayingRepository r;

    public MainPage()
	{
		InitializeComponent();
        r = new BatmanSayingRepository();
    }

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        if (!int.TryParse(txtNumber.Text, out int compareNumber))
        {
            await DisplayAlert("Invalid Input", "You must enter a valid number to compare.", "OK");
        }
		else
		{
            count++;
            BatmanSaying Batman = await r.GetSaying();
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
            {
                string summary = $"Clicked {count} times and the biggest is: " + Numfun.Biggest(compareNumber, count);
                CounterBtn.Text = summary;
                await DisplayAlert(Batman.Saying, summary, "OK");
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
            
	}
}

