using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_FSI
{
    public class Control
    {
        public static List<Compra> ListaCompras { get; set; }
        public static List<Caja> Cajas { get; set; }
        public Control()
        {
            if(Cajas==null)
            {
                Cajas = new List<Caja>();
            }
            if(ListaCompras==null)
            {
                ListaCompras = new List<Compra>();
            }
        }
        public void CrearCaja(Caja obj)
        {
            Cajas.Add(obj);
        }
        public bool CajaExiste(string codigo)
        {
            return Cajas.Exists(delegate (Caja value)
            {
                return value.Codigo == codigo;
            });
        }
        public void InsertarCompraEnCaja(string cod_caja,Compra aux)
        {
            Caja caja_encontrada = Cajas.Find(delegate(Caja value)
            {
                return value.Codigo == cod_caja;
               
            });
            if(caja_encontrada!=null)
            {
                caja_encontrada.Compras.Add(aux);
                if(!ListaCompras.Exists(delegate (Compra value)
                {
                    return value.DNI == aux.DNI;
                }))
                {
                    ListaCompras.Add(aux);
                }
            }
        }
        public Caja Caja_Mayor()
        {
            Caja aux2 = new Caja();
            int items = 0;
            foreach(Caja aux in Cajas)
            {
                if(aux.Compras.Count()>items)
                {
                    items = aux.Compras.Count();
                    aux2 = aux;
                }
            }
            return aux2;
        }
        public List<Caja> ListarCajasDeCliente(Compra obj)
        {
            List<Caja> auxlista = new List<Caja>();
            foreach(Caja objcaja in Cajas)
            {
                foreach(Compra objcompra in objcaja.Compras)
                {
                    if(objcompra.DNI==obj.DNI)
                    {
                        auxlista.Add(objcaja);
                    }
                }
            }
            return auxlista;
        }



    }
}
