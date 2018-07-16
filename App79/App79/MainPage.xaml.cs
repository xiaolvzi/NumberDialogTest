using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App79
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            MessagingCenter.Subscribe<Object, string>(this, "Hi", (sender, arg) => {
                System.Diagnostics.Debug.Write(arg + "==================================================================================");
            });
            bt.Clicked += Bt_Clicked;

		}

        private void Bt_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IDispalyDialog>().displayDialog();
            
        }
    }
}
