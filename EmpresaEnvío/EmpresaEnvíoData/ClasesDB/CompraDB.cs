﻿namespace EmpresaEnvíoData
{
    public class CompraDB
    {
        public int CodigoCompra { get; set; }
        public int CodigoProducto { get; set; }
        public int DNICliente { get; set; }
        public DateTime FechaCompra { get; set; }
        public int CantComprada { get; set; }
        public DateTime FechaEntregaSolicitada { get; set; }
        public EstadosCompraDB EstadoCompra { get; set; }
        public double LatitudGeografica { get; set; }
        public double LongitudGeografica { get; set; }
        public double MontoTotal { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}