namespace Wepsys_eCommerce.Dto.Productos
{
    public class ProductosDto
    {
        public string Nombre_Producto { get; set; } = "";

        public int Id_Marca { get; set; }

        public string Descripcion { get; set; } = "";

        public int Id_Categoria_Producto { get; set; }

        public int Stock { get; set; }

        public int Id_Proveedor { get; set; }

        public int Precio { get; set; }
    }
}
