namespace zamówienie_pizzy
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            BindingContext = new Obliczanie_pizzy();
            InitializeComponent();
        }

        private void Label_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
    }
}
