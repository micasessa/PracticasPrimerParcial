﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestoPractica.Libreria.Entidades
{
    public class VentaRepuestos
    {
        private List<Repuesto> _listaProductos;
        private string _nombreComercio;
        private string _direccion;

        //Desarrollo GETTER
        public string NombreComercio { get => _nombreComercio; }
        public string Direccion { get => _direccion; }
        public List<Repuesto> Lista { get => _listaProductos; }

        //Desarrollo Constructor. 1 vacio y otro con vars
        public VentaRepuestos() { }

        public VentaRepuestos(string comercio, string direccion)
        {
            _nombreComercio = comercio;
            _direccion = direccion;
            _listaProductos = new List<Repuesto>();
        }


        //Metodos del UML. Falta Desarrollo.
        public bool AgregarRepuesto(Repuesto repuesto)
        {
            bool flag = true;
            //Me dijo si el repuesto ingresado por usuario no esta vacio
            if (repuesto is null)
            {
                flag = false;
            } else //Recorro si hay info en el repuesto ingresado por usuario:
            {
                foreach (var item in _listaProductos)
                {   //si el item ya existente en listaprd coincide con repuesto ingresado por usuario
                    if (item.Equals(repuesto)) 
                    {
                        flag = false; //Devuelvo false. porque no puedo sobreescribir
                        break;
                    } 
                    else if (flag) //si no coincide: no lo encontró. por ende lo agrego a mi lista
                    {
                        _listaProductos.Add(repuesto);
                    }
                }
            } return flag;            
        }

        public bool QuitarRepuesto (int Codigo)
        {
            bool flag = true; //siempre va a ser true, caso contrario: se cambia flag a false
            if (_listaProductos.Count == 0) //Si no hay productos, no se puede borrar nada
            {
                flag = false; //Devuelvo falso!
            } else //si hay +1 prd:
            {   //recorro la lista
                foreach(var repues in _listaProductos)
                {
                    if (repues.Codigo == Codigo) //si el codigo ingresado coincide con uno existente
                    {   //checkeo el stock
                        if(repues.Stock >0)
                        {
                            flag = false; //No borro el repuesto
                        } else
                        {
                            _listaProductos.Remove(repues); //borro el repuesto
                            break;
                        }
                    }
                }
            }
            return flag;
        }

        public void ModificarPrecio(int Codigo, double Precio)
        { }

        public void AgregarStock (int Codigo, int Stock)
        { }

        public void QuitarStock (int Codigo, int Stock)
        { }

        public List<Repuesto> TraerPorCategoria (int Codigo)
        {
            List<Repuesto> repuestos = new List<Repuesto>();
            foreach (Repuesto item in _listaProductos)
            {
                if (item.Categoria.Codigo == Codigo)
                {
                    repuestos.Add(item);
                }
            }
            return repuestos;

        }

        //Desarrollarlo para obtener el cod max y que el usuario pueda agregar un nuevo repuesto.
        public int ObtenerCodigoMaximo()
        {            
            int resultado = 0;
            //Cuento cuantas listasde Prd hay (con el .count)
            if (_listaProductos.Count() == 0)
            {
                resultado = 1; //valor que devuelve si no hay ningun prod
            }
            else
            {
                resultado = _listaProductos.Count() + 1; //valor que devuelve si hay+1 (total +1)
            }
            return resultado;
        }

        public Repuesto BuscarPorCodigo (int cod)
        {
            //hago un foreach para buscar el codigo del repuesto ingresado por usuario
            Repuesto rr = new Repuesto();
            foreach (Repuesto r in _listaProductos)
            {
                if (r.Codigo == cod)
                {
                    rr = r;
                }
            }
            return rr;

        }
    }
}
