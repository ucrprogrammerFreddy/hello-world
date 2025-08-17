using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.DAL.Repositorio
{
    public interface IGenericRepository<TEntityModel> where TEntityModel:class
    {
        //trabajara en modo asincrono
        //se inserta un modelo hacia la bd
        /*
           puede recibir un modelo como contacto , pero puede ser cualquier modelo contacto usuario etc va a ser genérico para todos
        no va a diferenciar modelos no va a estar amarrado a uno solo sino que va a trabajar para todos los modelos.
         */
        Task<bool>Insertar(TEntityModel modelo);
        Task<bool> Actualizar(TEntityModel modelo);
        Task<bool> Eliminar(int id);
        Task<TEntityModel> Obtener(int id); //Obtener por Id
        Task<IQueryable<TEntityModel>> ObtenerTodos(); //Listar



    }
}
