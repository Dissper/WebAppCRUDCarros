using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Dato
{
    public class VehiculoAdmin
    {

        //Consulta todos los vehiculos
        public IEnumerable<Vehiculo> Consultar()
        {
            using (WebApp1Entities contexto = new WebApp1Entities())
            {
                return contexto.Vehiculo.AsNoTracking().ToList();
            }
        }

        //Guarda un vehiculo en la base de datos
        public void Guardar(Vehiculo modelo)
        {
            using (WebApp1Entities contexto = new WebApp1Entities())
            {
                contexto.Vehiculo.Add(modelo);
                contexto.SaveChanges();
            }
        }

        //Consulta la informacion del vehiculo ingresado
        public Vehiculo Consultar(int id) {

            using (WebApp1Entities contexto = new WebApp1Entities())
            {
                return contexto.Vehiculo.FirstOrDefault(v=> v.Id == id);

            }

        }
        

        //modifica los datos de un vehiculo
        public void Modificar(Vehiculo modelo)
        {
            using (WebApp1Entities contexto = new WebApp1Entities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        //Elimina el vehiculo seleccionado
        public void Eliminar(Vehiculo modelo)
        {

            using (WebApp1Entities contexto = new WebApp1Entities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }

        }

    }
}