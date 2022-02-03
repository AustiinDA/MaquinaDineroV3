using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotonesMVVM.Model
{
    public class Cliente : INotifyPropertyChanged
    {

        public string nombre { get; set; }
        public int codigoCliente { get; set; }
        double saldoCliente { get; set; }
        double interes { get; set; }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }

        }
        public int CodigoCliente
        {
            get { return codigoCliente; }
            set
            {
                codigoCliente = value;
                OnPropertyChanged("CodigoCliente");
            }
        }
        public double SaldoCliente
        {
            get { return saldoCliente; }
            set
            {
                saldoCliente = value;
                OnPropertyChanged("SaldoCliente");
            }
        }
        public double Interes
        {
            get { return interes; }
            set
            {
                interes = value;
                OnPropertyChanged("Interes");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }//OnProperyChanged

    }//Final



}
