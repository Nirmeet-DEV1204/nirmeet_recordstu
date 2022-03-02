using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesrecordstu.Models
{
    public class recordstu
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string Program { get; set; }
        public decimal Credit { get; set; }
    }
}