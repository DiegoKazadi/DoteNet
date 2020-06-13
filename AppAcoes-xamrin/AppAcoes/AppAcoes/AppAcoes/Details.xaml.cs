using AppAcoes.Entity;

using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAcoes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Details : ContentPage
    {
        public Details(Acao acao)
        {
            InitializeComponent();
            Title = acao.NomeAcao;
            Data.Text = acao.Data.ToString();
            QtdAcao.Text = acao.QtdAcao;
            PrecoAcao.Text = acao.PrecoAcao;
        }
        private async void btnPrevious_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}