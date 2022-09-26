namespace TwoPlayers;

public partial class CombinedPlayer : ContentPage
{
    private int count;


    public CombinedPlayer(int count)
    {
		InitializeComponent();
        this.count = count;

        WelcomeLabel.Text = $"Welcome to Combined Player! You opened this window {count} times.";
    }
}