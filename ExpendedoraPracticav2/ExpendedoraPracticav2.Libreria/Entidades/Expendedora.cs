using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpendedoraPracticav2.Libreria.Utilidades;

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
        public Expendedora(string proveedor, int capacidad, double dinero)
        {
            _proveedor = proveedor;
            _capacidad = capacidad;
            _dinero = dinero;
            _latas = new List<Lata>();
        }

        //des propiedades
        public string Proveedor { get => _proveedor; }
        public int Capacidad { get => _capacidad; set { _capacidad = 200; } }
        public double Dinero { get => _dinero; set { _dinero = value; } }
        public bool Encendida { get => _encendida; }
        public List<Lata> Latas { get => _latas; }

        //des metodos (vacios). chequear variables
        public void EncenderMaquina()
        {
            _encendida = true;
        }

        public void AgregarLata(Lata _lataAAgregar)
        {
            Lata aBuscar = _latas.Find(l => l.Codigo == _lataAAgregar.Codigo);
            //buscar que no exista el cod ingresado por usuario en mi maquina. si existe: mandar mensaje que no se puede agregar. else: add lata a la maquina
            if (aBuscar != null)
            {
                throw new CodigoInvalidoException(_lataAAgregar.Codigo);
            } else
            { //if controlando la CAPACIDAD de la maquina: si se llego al max: no se puede agregar(mje), else: add lata
                if (GetCapacidadRestante() < 1)
                {
                    throw new CapacidadInsuficienteException(_lataAAgregar.Cantidad);
                } else
                {
                    Latas.Add(_lataAAgregar);
                }
            }
        }

        public Lata ExtraerLata(string cod, double precio)
        {  // Se le listan los códigos de las latas(include CU 1)         
            Lata aBuscar = _latas.Find(l => l.Codigo == cod);
            //Flujo alternativo 1: El código es inválido. (me fijo si la lata ingresada existe)
            if (aBuscar == null)
            { //Flujo alternativo 2: El dinero no es suficiente
                if (aBuscar.Precio < precio)
                {//Flujo alternativo 3: No hay stock de esa lata
                    if (aBuscar.Cantidad < 1)
                    {   //La lata es seleccionada mediante un código que ingresa el usuario.
                        //El Usuario ingresa dinero que tiene.
                        //tengo que aumentar dinero a la expendedora +
                        _dinero = _dinero + precio;
                        // disminuir cantidad de stock=> averiguo cuanto es la cantidad=> a ese valor encontrado, le resto 1;
                        _latas.Find(l2 => l2.Codigo == cod).Cantidad = _latas.Find(l2 => l2.Codigo == cod).Cantidad - 1;
                    }
                    else { throw new SinStockException(cod); }
                }
                else { throw new DineroInsuficienteException(precio); }
            }
            else { throw new CodigoInvalidoException(cod); }
            
            return aBuscar;
        }

            public string GetBalance()
            { throw new NotImplementedException(); }

            public int GetCapacidadRestante()
            { //Inicializo la cantidad de latas en 0
                int cantLatas = 0;
                //busco cuantas latas hay.
                foreach (Lata l in _latas)
                {
                    cantLatas = cantLatas + l.Cantidad;
                }
                return _capacidad - cantLatas; //me devuelve la cantidad de latas disponibles para "llenar"
            }

            public bool EstaVacia()
            { //esta vacia: si no hay Latas => me tengo que fijar si hay o no hay latas
                bool flag = true;
                if (_latas.Count() == 0)
                {
                    flag = true; //rdo si esta vacia
                } else
                {
                    flag = false; //rdo si hay latas
                }
                return flag;
            }



        }
    
}
