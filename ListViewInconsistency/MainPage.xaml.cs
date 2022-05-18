using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ListViewCrash;

public partial class MainPage : ContentPage {
	public MainPage() {
		InitializeComponent();
		BindingContext = this;
	}

	public ObservableCollection<string> Items { get; set; } = new() {
		"Hello",
		"World",
	};
}

