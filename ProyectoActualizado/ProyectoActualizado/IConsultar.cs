using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoActualizado
{
    interface IConsultar
    {
        DataTable ActulizarConsulta();
        DataTable BuscarDato(Consulta_Movimiento consulta);
        
    }
}
