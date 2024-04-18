﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP_2
{
    public class Articulo
    {
        public int ID { get; set; }
        public string Nombree { get; set; }
        public string Descripcionn { get; set; }
        public string Codigo { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public Imagen Imagen { get; set; }
        public decimal Precio { get; set; }
    }
}