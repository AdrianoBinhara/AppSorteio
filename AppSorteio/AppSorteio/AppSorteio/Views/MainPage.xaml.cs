using AppSorteio.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSorteio
{
    public partial class MainPage : ContentPage
    {
        public string TotalParticipants { get; set; }
        private PrizeDraw Person { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Person = new PrizeDraw();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            TotalParticipants = Person.PrizeCountTotal();
            lbTotalParticipants.Text = TotalParticipants;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            var user = Person.PrizeDrawPerson();
            lbNome.Text = user.UserName;

        }
    }
}
