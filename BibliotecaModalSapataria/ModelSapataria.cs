namespace BibliotecaModalSapataria
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelSapataria : DbContext
    {
        // Your context has been configured to use a 'ModelSapataria' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ConsoleApp1.ModelSapataria' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelSapataria' 
        // connection string in the application configuration file.
        public ModelSapataria()
            : base("BancoDeDados_NOVIM_[1710456]")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Cor> Cores { get; set; }
        public DbSet<Sapato> Sapatos { get; set; }
        public DbSet<Tamanho> Tamanhos { get; set; }
        public DbSet<PessoaFisica> pessoaFisicas { get; set; }
        public DbSet<PessoaJuridica> pessoaJuridicas { get; set; }
        public DbSet<ItensSapato> itensSapatos { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}