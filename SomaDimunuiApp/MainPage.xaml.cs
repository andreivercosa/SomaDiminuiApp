using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SomaDimunuiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int valor = 0;

        void aumenta(object sender, EventArgs e)
        {
            valor++;
            texto.Text =  valor.ToString();
        }

        void diminui(object sender, EventArgs e)
        {
            valor--;
            texto.Text = valor.ToString();
        }
    }
}
