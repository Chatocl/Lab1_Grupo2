using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_Grupo2.Models.Datos
{
    public sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public List<Clientes> ClientesList;
        private readonly static Singleton _instanceORD = new Singleton();
        public Clientes AuxClientes;
        private Singleton()
        {
            ClientesList = new List<Clientes>();
            AuxClientes = new Clientes();   
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
        public static Singleton InstanceORD
        {
            get
            {
                return _instanceORD;
            }
        }
    }
}


