using System.Data.Entity;
using System.Data;
using System.Data.OleDb;


namespace CrudMVC.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext() : base("Banco")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}