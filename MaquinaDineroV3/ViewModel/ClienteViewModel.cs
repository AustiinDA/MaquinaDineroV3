using MaquinaDineroV3.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDineroV3.ViewModel
{
    public class ClienteViewModel : INotifyPropertyChanged
    {
        //        private Cliente _model;
        public List<Cliente> Clientes { get; set; }

        public ClienteViewModel()
        {
            //_model = new Cliente { nombre = "Cat", codigoCliente = 192, interes = 2, saldoCliente = 300 };
            Clientes = new List<Cliente>
            {

                new Cliente
                {
                    Nombre = "Josejuan",
                    CodigoCliente = 12,
                    Interes = 3,
                    SaldoCliente = 3000

                },
                new Cliente
                {
                    Nombre = "Pedro",
                    CodigoCliente = 13,
                    Interes = 4,
                    SaldoCliente = 5400
                },
                new Cliente
                {
                    Nombre = "Juan",
                    CodigoCliente = 21,
                    Interes = 2,
                    SaldoCliente = 55000
                }
            };

        }

        public string Nombre
        {
            get { return Clientes[0].Nombre; }
            set
            {
                Clientes[0].Nombre = value;
                OnPropertyChanged("Nombre");
            }

        }

/*
public int CodigoCliente
{
    get { return _model.codigoCliente; }
    set
    {
        _model.codigoCliente = value;
        OnPropertyChanged("CodigoCliente");
    }
}
public double SaldoCliente
{
    get { return _model.saldoCliente; }
    set
    {
        _model.saldoCliente = value;
        OnPropertyChanged("SaldoCliente");
    }
}
public double Interes
{
    get { return _model.interes; }
    set
    {
        _model.interes = value;
        OnPropertyChanged("Interes");
    }
}*/



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        } //OnProperyChanged

    } //Final

}

