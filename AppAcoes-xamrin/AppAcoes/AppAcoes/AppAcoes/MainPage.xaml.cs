
using AppAcoes.Database;
using AppAcoes.Entity;
using System;
using System.ComponentModel;

using Xamarin.Forms;

namespace AppAcoes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listAcoes.ItemsSource = Database.acoes;
            Title = "App Ações";
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nomeAcao.Text) || 
                !string.IsNullOrEmpty(quantidadeAcoes.Text) ||
                !string.IsNullOrEmpty(precoAcao.Text) || !string.IsNullOrEmpty(codigoAcao.Text) )
            {
                Acao acao = new Acao(nomeAcao.Text, quantidadeAcoes.Text, precoAcao.Text, codigoAcao.Text);
                acao.Data = DateTime.Now;
                Database.acoes.add(acao);
                DisplayAlert("Cadastro Realizado", "Fundo cadastrado com sucesso!", "Ok");
            }
            else
            {
                DisplayAlert("Campos obrigatorios", "Preencha.", "por favor");
            }
        }

        private async void listaDeAcoes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Acao fundoSelected = (Acao)e.SelectedItem;
            Details detalhesPage = new Details(fundoSelected);
            await Navigation.PushAsync(detalhesPage);
        }
    }
}
