using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica2
{
    public class Ingreso : Transaccion
    {
        public int? UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        private string fechaEstimada;
        public string FechaEstimada
        {
            get { return fechaEstimada;}
            set { fechaEstimada = value;}
        }

    }
}
