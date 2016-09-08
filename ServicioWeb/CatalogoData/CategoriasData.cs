using CatalogoData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDto;

namespace CatalogoData
{
    class CategoriasData : IBaseData<CategoriaDto>
    {
        public CategoriaDto Crear(CategoriaDto entidadDto)
        {
            throw new NotImplementedException();
        }

        public bool Editar(CategoriaDto entidadDto)
        {
            throw new NotImplementedException();
        }

        public bool Eliminat(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoriaDto> Obtener()
        {
            throw new NotImplementedException();
        }

        public CategoriaDto Obtener(int id)
        {
            throw new NotImplementedException();
        }
    }
}
