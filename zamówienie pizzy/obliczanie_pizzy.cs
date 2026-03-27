using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace zamówienie_pizzy
{
    public class Obliczanie_pizzy : INotifyPropertyChanged
    {
        private int selected_Size;
        private int selected_Type;
        private string message;
        private int ilosc_osob;
        
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand Zamowienie { get; }
        public Obliczanie_pizzy()
        {
            selected_Size = default;
            selected_Type = default;
            ilosc_osob = 1;
            message = "";
            Zamowienie = new Command(Wyswietl);
        }
        public int Selected_Size
        {
            get => selected_Size;
            set
            {
                if(selected_Size != value)
                {
                    selected_Size = value;
                    OnPropertyChanged(nameof(Selected_Size));
                }
            }
        }
        public int Selected_Type
        {
            get => selected_Type;
            set
            {
                if (selected_Type != value)
                {
                    selected_Type = value;
                    OnPropertyChanged(nameof(Selected_Type));
                }
            }
        }
        public int Ilosc_Osob
        {
            get => ilosc_osob;
            set
            {
                if (ilosc_osob != value)
                {
                    ilosc_osob = value;
                    OnPropertyChanged(nameof(Ilosc_Osob));
                }
            }
        }
        public string Message
        {
            get => message;
            set
            {
                if (message != value)
                {
                    message = value;
                    OnPropertyChanged(nameof(Message));
                }
            }
        }
        private void Wyswietl()
        {
            Message = $"Kwota do zapłaty wynosi: {(Selected_Size + Selected_Type) * Ilosc_Osob}";

        }
        protected void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
