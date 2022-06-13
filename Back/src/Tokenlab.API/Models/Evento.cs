namespace Tokenlab.API.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Tema { get; set; }
        public string Descricao { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }
    }
}