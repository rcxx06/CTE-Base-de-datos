namespace ProyectoCRUD.Models
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public int ClienteId { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string NumeroSerie { get; set; }
        public string Modelo { get; set; }
    }
}
