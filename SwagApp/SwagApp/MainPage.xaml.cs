using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwagApp
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
            Detail = new NavigationPage(new Pages.ListPage());
		    IsPresented = true;
		}

        private void ListViewBtn_OnClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.ListPage());
            IsPresented = false;
        }

        private void StatsBtn_OnClicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.StatsPage());
            IsPresented = false;
        }
    }
}
