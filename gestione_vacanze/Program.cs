
using gestione_vacanze.Models;
using gestione_vacanze.Repos;
using gestione_vacanze.Services;
using Microsoft.EntityFrameworkCore;

namespace gestione_vacanze
{
    /*
     * Destinazioni: Informazioni sulle località di viaggio.
        Nome
        Descrizione
        Paese
        Immagine (URL)
        Pacchetti Vacanza: Offerte di pacchetti per diverse destinazioni.
        Nome del pacchetto
        Prezzo
        Durata
        Data di inizio
        Data di fine
        Elenco destinazioni (per capirci)
        Recensioni Utente: Recensioni degli utenti sui pacchetti vacanza.
        Nome utente
        Voto
        Commento
        Data della recensione
        Funzionalità del Frontend (Angular)
        Visualizzazione Destinazioni: Mostra tutte le destinazioni di viaggio disponibili.
        Pacchetti Vacanza per Destinazione: Mostra i pacchetti vacanza disponibili per una destinazione selezionata.
        Dettaglio del Pacchetto Vacanza: Mostra tutte le destinazioni toccate dalla vacanza
        Recensioni Utenti: Visualizza le recensioni per un pacchetto vacanza.
        Inserimento Recensioni: Un utente può aggiungere una recensione per un pacchetto vacanza.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            #region Importanti per la configurazione del context

#if DEBUG
            builder.Services.AddDbContext<VacanzeContex>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseTest"))
                );

            builder.Services.AddScoped<DestinazioneService>();
            builder.Services.AddScoped<DestinazioneRepository>();
            builder.Services.AddScoped<PacchettoService>();
            builder.Services.AddScoped<PacchettoRepository>();
            builder.Services.AddScoped<RecUtenteService>();
            builder.Services.AddScoped<RecUtenteRepository>();

#else
            builder.Services.AddDbContext<BlockbusterContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseProd"))
                );
#endif

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
