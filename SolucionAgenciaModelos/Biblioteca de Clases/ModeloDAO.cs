using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class ModeloDAO
    {

        public bool ingresoModelo(modelo mod)
        {
            using (var context = new AgenciaModeloEntities())
            {
                try
                {
                    context.modelo.Add(mod);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al grabar el Modelo! debido a " + ex.Message);
                }
            }
        }

        public bool editarModelo(modelo mod)
        {
            using (var context = new AgenciaModeloEntities())
            {
                try
                {
                    modelo modTemp = buscarModelo(mod.codigo_unico);
                    modTemp.codigo_unico = mod.codigo_unico;
                    modTemp.nombre = mod.nombre;
                    modTemp.apellido_paterno = mod.apellido_paterno;
                    modTemp.apellido_materno = mod.apellido_materno;
                    modTemp.sexo = mod.sexo;
                    modTemp.color_ojos = mod.color_ojos;
                    modTemp.tez = mod.tez;
                    modTemp.medidas_anatomicas = mod.medidas_anatomicas;
                    modTemp.observaciones = mod.observaciones;
                    modTemp.foto = mod.foto;
                    modTemp.fecha_nacimiento = mod.fecha_nacimiento;
                    modTemp.estaActivo = mod.estaActivo;
                    context.Entry(modTemp).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al editar el Modelo! debido a " + ex.Message);
                }
            }
        }

        public modelo buscarModelo(int codigo)
        {
            using (var context = new AgenciaModeloEntities())
            {
                modelo mod = new modelo();
                try
                {
                    mod = context.modelo.First(m => m.codigo_unico.Equals(codigo));
                    return  mod;
                }
                catch (Exception ex)
                {
                    return null;
                    throw new ArgumentException("Error al buscar el Modelo! debido a " + ex.Message);
                }
            }
        }

        public bool darDeBajaModelo(int codigo)
        {
            using (var context = new AgenciaModeloEntities())
            {
                try
                {
                    modelo modTemp = buscarModelo(codigo);
                    modTemp.estaActivo = 0;
                    context.Entry(modTemp).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Error al dar de baja al Modelo! debido a " + ex.Message);
                }
            }
        }

        public List<modelo> listaModelos()
        {
            using (var context = new AgenciaModeloEntities())
            {
                List<modelo> lis = context.modelo.ToList();
                return lis;
            }
        }

    }
}
