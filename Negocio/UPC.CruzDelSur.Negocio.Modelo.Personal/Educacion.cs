using System.ComponentModel.DataAnnotations;

namespace UPC.CruzDelSur.Negocio.Modelo.Personal
{
    public class Educacion : DetalleHojaVida
    {
        [Required(ErrorMessage = "Debe especificar el tipo de educacion")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Debe especificar el grado obtenido")]
        public string GradoObtenido { get; set; }
    }
}