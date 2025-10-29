using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal interface IMappers <T>
    {

        int Agregar(T parametro);
        int Editar(T parametro);
        int Eliminar(T parametro);

    }
}
