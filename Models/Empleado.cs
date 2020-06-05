using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Laboratorio.Models
{
    [Table("t_empleado")]
    public class Empleado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Ingrese nombres")]
        [Column("nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese apellidos")]
        [Column("apellido")]
        public string Apellido { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("dni")]
        public string Dni { get; set; }
        [Column("tel")]
        public int Tel { get; set; }
        [Column("sexo")]
        public string Sexo { get; set; }
        [Column("agree")]
        public Boolean Agree { get; set; }
        [DataType(DataType.Date)]
        [Column("birth")]
        public DateTime Birth { get; set; }
        [NotMapped]
        public string mensaje{ get; set; }
    }
}