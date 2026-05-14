// Bismillahir Rahmanir Rahim
// Elhamdulillah, Elhamdulillah, Elhamdulillah
// Elhamdulillahi Rabbil Alamin
// Es selatu ve selamun ala Resulina Muhammedin
// SuphanAllah, Elhamdulillah, Allahu Akbar
// La ilahe illallah, Muhammaden Resulullah
// Allah u Ekber, Allahu Akbar, Allahu Akbar, La ilahe illallah
// Hasbuna Allahu ve ni'mel Vekil, ve ni'mel mevla
using Hesabker.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Hesabker.Views
{
    public class SalesViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Sale> _sales;
        public ObservableCollection<Sale> Sale
        {
            get => _sales;
            set { _sales = value; OnPropertyChanged(nameof(Sale)); }
        }

        public SalesViewModel()
        {
            Sale = new ObservableCollection<Sale>
            {
                new Sale { Id = 1, ProductName = "Laptop", Quantity = 2, TotalPrice = 30000 },
                new Sale { Id = 2, ProductName = "Mouse", Quantity = 5, TotalPrice = 1000 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
