using System.Collections.ObjectModel;
using System.Windows.Input;
using Domain;
using Data;
using S3_Lab5.Abstractions;

namespace S3_Lab6.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IPlywacyRepository _repository;
        private Plywak? _selectedPlywak;

        public ObservableCollection<Plywak> Plywacy { get; set; }

        public Plywak? SelectedPlywak
        {
            get => _selectedPlywak;
            set { _selectedPlywak = value; OnPropertyChanged(); }
        }

        public ICommand LoadCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }

        public MainViewModel()
        {
            _repository = new PlywakRepository(); //
            Plywacy = new ObservableCollection<Plywak>();

            LoadCommand = new RelayCommand(_ => LoadData());
            AddCommand = new RelayCommand(_ => AddNew());
            DeleteCommand = new RelayCommand(_ => Delete(), _ => SelectedPlywak != null);
        }

        private void LoadData()
        {
            Plywacy.Clear();
            foreach (var p in _repository.PobierzWszystkich())
                Plywacy.Add(p);
        }

        private void AddNew()
        {
            var nowy = new Plywak { ImieNazwisko = "Nowy Zawodnik", RokUrodzenia = 2000 };
            _repository.Dodaj(nowy);
            LoadData();
        }

        private void Delete()
        {
            if (SelectedPlywak != null)
            {
                _repository.Usun(SelectedPlywak.Id);
                LoadData();
            }
        }
    }
}