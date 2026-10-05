using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Persona
{
    public class personaResultadoQueryDTO
    {
        public required IEnumerable<PersonaDTO> alumnos { get; set; }
        public int pagina { get; set; }
        public int cant_alumnos_pagina { get; set; }
        public double total_paginas { get; set; }
        public int total_alumnos { get; set; }
    }
}
