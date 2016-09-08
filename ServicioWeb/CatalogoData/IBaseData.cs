using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDto;

namespace CatalogoData
{
    //<T> Recibe cualquier tipo clase generica
    public interface IBaseData<T>
    {
        /*Obtener todos
          Obtener uno por ID
          Crear 
          Editar
          Eliminar*/
        List<T> Obtener();
        T Obtener(int id);
        T Crear(T entidadDto);
        bool Editar(T entidadDto);
        bool Eliminat(int id);
    }
}
