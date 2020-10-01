using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Local
{
    public partial class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new View.Aluno.MainPage());
        }
        static XF.Local.Model.Aluno alunoModel;
        public static XF.Local.Model.Aluno AlunoModel
        {
            get
            {
                if (alunoModel == null)
                {
                    alunoModel = new XF.Local.Model.Aluno();
                }
                return alunoModel;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
