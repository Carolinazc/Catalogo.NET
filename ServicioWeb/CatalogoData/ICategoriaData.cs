using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoData
{
    public interface ICategoriaData:CategoriasData
    {
        bool PublicarCategoria(int idCategoria);
    }
}
