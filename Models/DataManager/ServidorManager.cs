using MCTransparencia.Models.Repository;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq; 

namespace MCTransparencia.Models.DataManager
{
    public class ServidorManager : IDataRepository<Servidor>
    {
        readonly ServidorContext _servidorContext;
        public ServidorManager(ServidorContext servidorContext)
        {
            _servidorContext = servidorContext;
        }
        public void Add(Servidor e)
        {
            _servidorContext.Servidores.Add(e);
            _servidorContext.SaveChanges();
        }

        public void Delete(Servidor s)
        {
            _servidorContext.Servidores.Remove(s);
            _servidorContext.SaveChanges();
        }

        public Servidor Get(int id)
        {
            return _servidorContext.Servidores.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Servidor> GetAll()
        {
            return _servidorContext.Servidores.ToList();
        }

        public void Update(Servidor db, Servidor s)
        {
            db.Nome = s.Nome;
            db.Rgf = s.Rgf;
            db.Rendimentos = s.Rendimentos;
            db.Cargo = db.Cargo;
            _servidorContext.SaveChanges();
        }
    }
}