    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    namespace BaltaTest.Models;

    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do student")]
        [StringLength(80, ErrorMessage = "O nome deeve conter até 80 caracteres")]
        [DisplayName("Nome completo")]
        public String name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe seu email")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [DisplayName("E-mail")]
        public String Email { get; set; } = string.Empty;

        public List<Premium> Premiums { get; set; } = new();
    }