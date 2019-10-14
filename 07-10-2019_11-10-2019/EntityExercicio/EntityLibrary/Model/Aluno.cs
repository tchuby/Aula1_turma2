﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLibrary.Model
{
    public class Aluno
    {
        [Key] //Primary key indentity (1,1)
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
       
    };
}
