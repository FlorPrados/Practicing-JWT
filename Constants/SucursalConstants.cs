using Jwt.Models;

namespace Jwt.Constants
{
    public class SucursalConstants
    {
        public static List<Sucursal> Sucursales = new List<Sucursal>()
        {
            new Sucursal() {Place= "Tigre"},
            new Sucursal() {Place= "Avellaneda"},
            new Sucursal() {Place= "Mar del Plata"},
            new Sucursal() {Place= "Adrogué"}
        };
    }
}
