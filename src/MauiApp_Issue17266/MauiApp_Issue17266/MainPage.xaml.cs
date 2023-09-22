namespace MauiApp_Issue17266
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        async void CounterBtn_Clicked(object sender, EventArgs e)
        {
            var result = await Shell.Current.DisplayPromptAsync(
                "Input",
                "Input something and press `Enter`"
                );
        }
    }

}
