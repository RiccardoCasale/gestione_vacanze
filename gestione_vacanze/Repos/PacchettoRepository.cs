using gestione_vacanze.Models;

namespace gestione_vacanze.Repos
{
    public class PacchettoRepository : IRepo<Pacchetto>
    {
        private readonly VacanzeContex _context;

        public PacchettoRepository(VacanzeContex context)
        {
            _context = context;
        }

        //RACCOGLI I PACCHETTI DI UNA DESTINAZIONE

        public List<Pacchetto> GetPacchettiByDestinazione()
        {
            List<Pacchetto> pacchetti = new List<Pacchetto>();
            try
            {
                pacchetti = _context.Pacchetti.ToList();
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            return pacchetti;
        }

        //RACCOGLI LE DESTINAZIONI DI UN PACCHETTO

        public Pacchetto DettaglioVacanza(int varId)
        {
            Pacchetto pacchetto = new Pacchetto();
            try
            {
                pacchetto = _context.Pacchetti.FirstOrDefault(p => p.pacchettoID == varId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return pacchetto;
        }

        public bool Create(Pacchetto entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pacchetto? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pacchetto> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Pacchetto entity)
        {
            throw new NotImplementedException();
        }
    }
}
