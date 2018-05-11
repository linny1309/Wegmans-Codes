using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WegmansProduce
{
	public partial class MainPage : ContentPage
	{
        List<string> names = new List<string>
        {
            "Apple, Honeycrisp: 3283" ,"Banana: 4011", "Banana, Organic: 94011","Cucumber: 4062","Pear, Bosc: 4411", "Squash, Green: 4067",""
        };

        public MainPage()
		{
			InitializeComponent();

            NamesListView.ItemsSource = names;
		}

        /* private void SearchBar_Pressed(object sender, EventArgs e)
        {
            var keyword = MainSearchBar.Text;

            NamesListView.ItemsSource = names.Where(name => name.ToLower().Contains(keyword.ToLower()));
        } */

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            var keyword = MainSearchBar.Text;

            NamesListView.ItemsSource = names.Where(name => name.ToLower().Contains(keyword.ToLower()));
        }
    }
}
