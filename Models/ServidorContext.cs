using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json; 

namespace MCTransparencia.Models
{
    public class ServidorContext : DbContext
    {
        public ServidorContext(DbContextOptions<ServidorContext> options) : base(options) { }

        public DbSet<Servidor> Servidores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string json;
            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                wc.Headers["Cookie"] = "security=true";
                json = wc.DownloadString(@"http://www.licitacao.pmmc.com.br/Transparencia/vencimentos2");
            }

            ExternalData data = JsonConvert.DeserializeObject<ExternalData>(json);
            for (int i = 0; i < data.servidores.Count; i++)
            {
                data.servidores[i].Id = i + 1;
            }
            modelBuilder.Entity<Servidor>().HasData(data.servidores);
        }
    }
}