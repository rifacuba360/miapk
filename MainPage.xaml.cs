namespace rifa3602
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("¡Hola!", "Botón funcionando 😎", "OK");
        }
    }
}
