using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Volumovscky.Model
{
    public class Peso
    {
        [Key]
        public int Id { get; set; }
        public double Volume { get; set; }
        public double Densidade { get; set; }
        public double Peso1 { get; set; }
    }
}
