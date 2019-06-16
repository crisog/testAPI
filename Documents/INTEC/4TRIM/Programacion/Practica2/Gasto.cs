using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica2
{
    public class Gasto : Transaccion
    {
        public int? UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]

        private string ingresoAsociadoId;
        public string IngresoAsociadoId
        {
            get { return ingresoAsociadoId;}
            set { ingresoAsociadoId = value;}
        }
        
        
        
    }
}
