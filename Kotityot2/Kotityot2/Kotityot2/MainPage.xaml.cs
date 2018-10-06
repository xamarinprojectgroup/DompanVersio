using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kotityot2
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Person> persons = new ObservableCollection<Person>();

        public MainPage()
        {
            InitializeComponent();
            btnKirjaudu.Clicked += KirjauduPage;
            btnRekisteroidy.Clicked += RekisteroidyPage;
            btnUusiSalasana.Clicked += UusiSalasanaPage;

        }
       
        public void KirjauduPage(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Kirjaudu());
        }
        public void RekisteroidyPage(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Rekisteroidy());
        }
        public void UusiSalasanaPage(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new UusiSalasana());
        }
    }
}
