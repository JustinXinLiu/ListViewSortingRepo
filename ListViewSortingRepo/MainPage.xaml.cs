using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ListViewSortingRepo
{
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Item> Items { get; } = new ObservableCollection<Item>();

        public MainPage()
        {
            InitializeComponent();

            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Items.Add(new Item(1));
            Items.Add(new Item(3));
            Items.Add(new Item(2));
            Items.Add(new Item(4));
            Items.Add(new Item(5));
            Items.Add(new Item(8));
            Items.Add(new Item(7));
            Items.Add(new Item(6));
            Items.Add(new Item(13));
            Items.Add(new Item(12));
            Items.Add(new Item(11));
            Items.Add(new Item(10));
            Items.Add(new Item(9));
            Items.Add(new Item(14));
            Items.Add(new Item(15));
            Items.Add(new Item(17));
            Items.Add(new Item(16));
            Items.Add(new Item(18));
            Items.Add(new Item(19));
            Items.Add(new Item(20));
        }

        private void OnSortClick(object sender, RoutedEventArgs e) =>
            Items.Sort(i => i.Id);
    }
}