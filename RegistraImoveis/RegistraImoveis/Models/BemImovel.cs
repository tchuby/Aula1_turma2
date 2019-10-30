﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistraImoveis.Models
{
    public class BemImovel
    {
        [Key]
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int TitularId { get; set; }

        //Cep,Logradouro,Bairro,Municipio,Numero,Complemento,Proprietario
    }
}