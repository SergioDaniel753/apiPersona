namespace WebapiPersona.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public enum SexoType
    {
        Femenino=0,
        Masculino=1
    }
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        [StringLength(80,ErrorMessage ="Favor ingrese su nombre complete entre 5 y 80 caracteres",MinimumLength =5)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Birthday { get; set; }

        public SexoType Sex { get; set; } 
    }
}