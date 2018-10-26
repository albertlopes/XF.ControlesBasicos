using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XF.ControlesBasicos
{

    public class ControleViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnAlterarPropriedade([CallerMemberName]String propriedade = null) {
            PropertyChanged(this, new PropertyChangedEventArgs(propriedade));
        }
        public string Email { get; set; }

        private bool ativo;
        public bool Ativo
        {

            get { return ativo; }

            set
            {
                ativo = value;
                OnAlterarPropriedade();
            }

        }

       

        public ICommand OnEnviar { get; set; }
        public ICommand OnConfiguracao { get; set; }

        public ControleViewModel()
        {

            OnEnviar = new Command(Enviar);
            OnConfiguracao = new Command(IrConfiguracao);
        }


        public void Enviar()
        {
            if ((App.ControlesVM.Ativo) &&
                (!string.IsNullOrWhiteSpace(App.ControlesVM.Email)))
                App.Current.MainPage.DisplayAlert("1", "1", "1");
            else {
                App.Current.MainPage.DisplayAlert("2", "2", "2");
            }
        }
        public void IrConfiguracao()
        {


            App.Current.MainPage.Navigation.PushAsync(new ConfigView() { BindingContext = App.ControlesVM });
        }






    }


}
