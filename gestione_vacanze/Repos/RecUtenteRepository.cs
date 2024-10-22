using gestione_vacanze.Models;

namespace gestione_vacanze.Repos
{
    public class RecUtenteRepository : IRepo<RecUtente>
    {
        private readonly VacanzeContex _context;

        public RecUtenteRepository(VacanzeContex context) 
        { 
            _context = context;
        }

        public bool Create(RecUtente entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public RecUtente? Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<RecUtente> GetAll()
        {
            List<RecUtente> recensioniUtente = new List<RecUtente>();
            try
            {
                recensioniUtente = _context.RecsUtente.ToList();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            return recensioniUtente;
        }

        public bool Update(RecUtente entity)
        {
            throw new NotImplementedException();
        }

        public bool InsertRecensione(RecUtente newRec)
        {
            bool result = false;
            try
            {
                _context.RecsUtente.Add(newRec);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return result;
            }
            result = true;
            return result;
        }
    }
}
