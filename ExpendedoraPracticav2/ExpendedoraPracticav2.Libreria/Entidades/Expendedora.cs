﻿using System;
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
            foreach (Lata l in _latas)
            { //buscar que no exista el cod ingresado por usuario en mi maquina. si existe: mandar mensaje que no se puede agregar. else: add lata a la maquina
                if (l.Codigo == _lataAAgregar.Codigo)
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
        }

        public Lata ExtraerLata(string cod, double precio)
        { //me fijo si la lata ingresada existe

            throw new NotImplementedException(); }

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
            if (_latas.Count() == 0 ) 
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
