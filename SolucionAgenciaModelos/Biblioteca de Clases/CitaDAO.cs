using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class CitaDAO
    {
        public bool ingresarCita(cita ci)
        {
            using (var context = new AgenciaModeloEntities())
            {
                try
                {
                    if (agendaEstaOcupada(ci) == false)
                    {
                        context.cita.Add(ci);
                        context.SaveChanges();
                        return true;
                    }
                    throw new ArgumentException("El dia de la cita ya está ocupado");
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al ingresar la cita!! debido a " + ex.Message);
                }
            }
        }

        public bool agendaEstaOcupada(cita ci)
        {
            using (var context = new AgenciaModeloEntities())
            {
                try
                {
                    List<cita> list = context.cita.Where(x => x.modelo.Equals(ci.modelo)).ToList();
                    foreach (cita item in list)
                    {
                        if (item.fecha == ci.fecha)
                        {
                            return true;
                        }
                    }
                    return false;
                    //return citTemp.fecha == ci.fecha ? true : false;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Erro al ingresar la cita!! debido a " + ex.Message);
                }
            }
        }

        public List<cita> listaCitas()
        {
            using (var context = new AgenciaModeloEntities())
            {
                List<cita> li = context.cita.ToList();
                return li;
            }
        }

        public bool cancelarEvento(int numero)
        {
            using (var context = new AgenciaModeloEntities())
            {
                DateTime fechaHoy = DateTime.Now;
                //comparando el numero_cita (id) y el dia, mes y año para saber si la cita es hoy
                cita li = context.cita.First(x => x.numero_cita.Equals(numero));
                if (li.fecha.Day.Equals(fechaHoy.Day) && li.fecha.Month.Equals(fechaHoy.Month) && li.fecha.Year.Equals(fechaHoy.Year))
                {
                    return false;
                }
                context.cita.Remove(li);
                context.SaveChanges();
                return true;
            }
        }

        public bool modificarCita(cita ci)
        {
            using (var context = new AgenciaModeloEntities())
            {
                cita citaTemp = context.cita.First(x => x.numero_cita.Equals(ci.numero_cita));
                citaTemp.cliente = ci.cliente;
                citaTemp.modelo = ci.modelo;
                citaTemp.fecha = ci.fecha;
                citaTemp.nombre_evento = ci.nombre_evento;
                citaTemp.valor_dia_modelo = ci.valor_dia_modelo;
                context.SaveChanges();
                return true;
            }
        }

        public cita buscarCita(int numero)
        {
            using (var context = new AgenciaModeloEntities())
            {
                try
                {
                    cita citaTemp = context.cita.First(x => x.numero_cita.Equals(numero));
                    return citaTemp;
                }
                catch (Exception)
                {
                    return null;
                    throw;
                }
            }
        }

    }
}
