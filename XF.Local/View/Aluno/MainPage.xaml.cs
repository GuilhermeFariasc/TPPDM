using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Local.Aluno;

namespace XF.Local.View.Aluno
{
    public partial class MainPage : ContentPage
    {
        XF.Local.AlunoViewModel.AlunoViewModel vmAluno;
        public MainPage()
        {
            vmAluno = new XF.Local.AlunoViewModel.AlunoViewModel();
            BindingContext = vmAluno;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            vmAluno = new XF.Local.AlunoViewModel.AlunoViewModel();
            BindingContext = vmAluno;
            base.OnAppearing();
        }
        private void OnNovo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovoAlunoView());
        }
        private void OnAlunoTapped(object sender,ItemTappedEventArgs args)
        {
            var selecionado = args.Item as XF.Local.Model.Aluno;
            DisplayAlert("Aluno selecionado", "Aluno: " + selecionado.Id, "OK");
        }
    }
}