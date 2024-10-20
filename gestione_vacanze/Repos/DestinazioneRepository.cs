using gestione_vacanze.Models;

namespace gestione_vacanze.Repos
{
    public class DestinazioneRepository : IRepo<Destinazione>
    {
        private readonly VacanzeContex _context;

        public DestinazioneRepository(VacanzeContex context)
        {
            _context = context;
        }

        public bool Create(Destinazione entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int varId)
        {
            try
            {
                Destinazione daEliminare = _context.Destinazioni.FirstOrDefault(d => d.DestinazioneId  == varId);
                if (daEliminare == null)
                {
                    return false;
                }
                _context.Destinazioni.Remove(daEliminare);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public Destinazione? Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Destinazione> GetAll()
        {
            List<Destinazione> result = new List<Destinazione>();

            try
            {
                result = _context.Destinazioni.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public bool Update(Destinazione entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Destinazione> IRepo<Destinazione>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
