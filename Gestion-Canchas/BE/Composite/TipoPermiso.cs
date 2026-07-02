using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public enum TipoPermiso
    {
        //Permisos del sistema
        PuedeHacerTodo,
        PuedeReservar,
        PuedeVisualizarDashboards,
        PuedeConfirmarPagos,
        PuedeBloquearCancha,
        PuedeConfigurarMantenimiento,
        PuedeAplicarPromociones,
        JefeDeVentas,
        PuedeGestionarPedidosDeCompra,
        PuedeHacerA,
        PuedeHacerB,
        PuedeHacerC,
        PuedeHacerD
    }
}
