﻿using System.ComponentModel.DataAnnotations.Schema;

namespace gestione_vacanze.Models
{
    public class RecUtente
    {
        public int RecUtenteId { get; set; }
        [Column("NomeU")]
        public string NomeUtente { get; set; } = null!;
        public string Codice { get; set; } = null!;
        [Column("Voto")]
        private int _voto;
        #region prop voto
        public int Voto
        {
            get => _voto;
            set
            {
                if (value >= 1 && value <= 5)
                {
                    _voto = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Il numero deve essere compreso tra 1 e 5.");
                }
            }
        }
        #endregion
        public string? Commento { get; set; }
        public DateOnly DataRec { get; set; }
        public int PacchettoRif { get; set; }
    }
}
