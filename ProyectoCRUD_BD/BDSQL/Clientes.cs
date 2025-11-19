using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCRUD_BD.BDSQL
{
 
        public class Cliente
        {
            public int ClienteId { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
            public string Correo { get; set; }
            public string ContactoSecundario { get; set; }
        }
    }


