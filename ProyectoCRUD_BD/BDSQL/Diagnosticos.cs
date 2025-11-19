using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoCRUD_BD.BDSQL
{
   public class Diagnosticos
    {
        public string diagnostico_id {  get; set; }
        public string tecnico_id { get; set; }
        public string equipo_id { get; set; }
        public string falla_reportada { get; set; }
        public DateTime fecha_hora {  get; set; }
        public string Diagnostico_real {  get; set; }

    }
}
