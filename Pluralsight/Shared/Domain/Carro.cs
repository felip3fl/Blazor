﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Domain
{
    public class Carro
    {
        public string Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public double Quilometragem { get; set; }
    }
}
