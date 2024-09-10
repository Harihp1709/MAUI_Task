namespace MAUI_Task;

public class MauiTask_1 : ContentPage
{
    Label lblText;
    Entry txtInput;

    public MauiTask_1()
    {

        this.BackgroundImageSource = "https://w0.peakpx.com/wallpaper/986/353/HD-wallpaper-google-logo.jpg";
        var scrollView = new ScrollView();
        var stackLayout = new StackLayout();
        scrollView.Content = stackLayout;

        lblText = new Label
        {
            Text = "Hello, This is my MAUI task",
            FontSize = 22,
            TextColor = Colors.WhiteSmoke,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
        };
        stackLayout.Children.Add(lblText);

        txtInput = new Entry
        {
            Placeholder = "Enter your name",
            FontSize = 18,
            TextColor = Colors.White,
            HorizontalOptions = LayoutOptions.Center,
            WidthRequest = 250
        };
        stackLayout.Children.Add(txtInput);

        var btnSubmit = new Button
        {
            Text = "OK",
            HorizontalOptions = LayoutOptions.Center,
        };
        stackLayout.Children.Add(btnSubmit);

        btnSubmit.Clicked += OnSubmitClicked;

        var btnAbout = new Button
        {
            Text = "Go to main page",
            HorizontalOptions = LayoutOptions.Center,
            BackgroundColor = Colors.Blue,
            TextColor = Colors.White,
        };
        stackLayout.Children.Add(btnAbout);

        btnAbout.Clicked += OnAboutClicked;

        this.Content = scrollView;
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtInput.Text))
        {
            lblText.Text = $"Hello {txtInput.Text}, See the color is changed";
            lblText.TextColor = Colors.Green;
        }
        else
        {
            lblText.Text = "Please enter something!";
            lblText.TextColor = Colors.Red;
        }
    }

    private async void OnAboutClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }


}