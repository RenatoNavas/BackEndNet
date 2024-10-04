namespace BackEndNet.Data
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaIngreso { get; set; }

        public int BodegaId { get; set; }

        public Bodega Bodega { get; set; }
    }
}
