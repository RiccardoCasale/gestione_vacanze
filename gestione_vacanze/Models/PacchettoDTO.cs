﻿
namespace gestione_vacanze.Models
{
    public class PacchettoDTO
    {
        public string NomeP { get; set; }
        public decimal prezzo { get; set; }
        public int Durata { get; set; }
        public DateOnly DataIni { get; set; }
        public DateOnly DataFin { get; set; }
        public string ElencoDes { get; set; }
    }
}
