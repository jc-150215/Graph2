using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Graph2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        Double w = Double.Parse(Weight.Text);
        Double b = Double.Parse(BFat.Text);

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
