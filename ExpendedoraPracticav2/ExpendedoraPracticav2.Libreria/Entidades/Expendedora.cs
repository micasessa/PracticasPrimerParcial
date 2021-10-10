using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraPracticav2.Libreria.Entidades
{
    public class Expendedora
    {
        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;

        //Des constructores
        public Expendedora() { }
        public Expendedora(string proveedor, int capacidad, double dinero, bool encendida)
        {
            _proveedor = proveedor;
            _capacidad = capacidad;
            _dinero = dinero;
            _encendida = encendida;
            _latas = new List<Lata>();
        }

        //des propiedades
        public string Proveedor { get => _proveedor; }
        public int Capacidad { get => _capacidad; set { _capacidad = value; } }
        public double Dinero { get => _dinero; set { _dinero = value; } }
        public bool Encendida { get => _encendida; }
        public List<Lata> Latas { get => _latas; }

        //des metodos (vacios). chequear variables
        public void EncenderMaquina()
        {
            _encendida = true;
        }

        public void AgregarLata(Lata)
        {
        }

        public Lata ExtraerLata(string cod, double precio)
        { }

        public string GetBalance()
        { }

        public int GetCapacidadRestante()
        {
        }


        public bool EstaVacia()
        { }


    }
}
