using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Please provide Employee Name ")]
        [MaxLength(50)]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Please provide Employee Surname ")]
        [MaxLength(50)]
        public string EmployeeSurname { get; set; }
        
    }
}
