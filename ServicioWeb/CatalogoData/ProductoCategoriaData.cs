using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDto;
using ;

namespace CatalogoData
{
    class ProductoCategoriaData
    {
        public void ActualizarProducto()
        {
            using (CatalogoEntity)
                var entity = await _context.Person.Where(c => c.IdPerson == personDto.IdPerson).FirstOrDefaultAsync();
            if (entity != null)
            {
                entity.FirstName = personDto.FirstName;
                entity.LastName = personDto.LastName;
                entity.Email = personDto.Email;
                entity.Movil = personDto.Movil;
                entity.Telephone = personDto.Telephone;
                entity.IdCity = personDto.IdCity;
                if (personDto.ImageProfile != null)
                {
                    entity.ImageProfile = personDto.ImageProfile;
                }
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
