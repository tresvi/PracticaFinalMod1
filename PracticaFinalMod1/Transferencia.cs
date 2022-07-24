using FixedWidthTextUtils.Attributes;
using System;

namespace PracticaFinalMod1
{
    [StringeableClass(117, ' ')]
    public class Transferencia
    {
        [StringField(0, 30)]
        public string Nombre { get; set; }

        [FloatingField(31, 40, 2, true)]
        public decimal Monto { get; set; }

        [DateTimeField(41, 54, "yyyyMMddHHmmss")]
        public DateTime HoraFecha { get; set; }

        [BooleanField(55, 55, "T", "F")]
        public bool Inmediata { get; set; }

        [StringField(56, 77)]
        public string CBUOrigen { get; set; }

        [StringField(78, 99)]
        public string CBUDestino { get; set; }

        [StringField(100, 105, leftPadding: true)]
        public string CodigoActividadAFIP { get; set; }

        [StringField(106, 116)]
        public string ClaveTributaria { get; set; }
    }
}