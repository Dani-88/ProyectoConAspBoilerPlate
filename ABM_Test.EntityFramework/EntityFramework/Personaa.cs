using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Test.EntityFramework
{
    public class Personaa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
