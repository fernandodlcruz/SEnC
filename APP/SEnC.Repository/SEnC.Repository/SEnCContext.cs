using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SEnC.Datatypes;
using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using SEnC.Repository.Mapping;

namespace SEnC.Repository
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class SEnCContext : DbContext
    {
        public SEnCContext()
            : base("SEnCContext")
        {
            Database.SetInitializer<SEnCContext>(new SEnCContextInitializer());
            //Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        static SEnCContext()
        {
                DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
        }

        public DbSet<Afiliado> Afiliado { get; set; }
        public DbSet<Alerta> Alerta { get; set; }
        public DbSet<ConfiguracaoConta> ConfiguracaoConta { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Lancamento> Lancamento { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Periodicidade> Periodicidade { get; set; }
        public DbSet<Plano> Plano { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Configurations.Add(new StatusMap());

            base.OnModelCreating(modelBuilder);
        }        
    }

    public class SEnCContextInitializer : DropCreateDatabaseIfModelChanges<SEnCContext> // DropCreateDatabaseAlways<SEnCContext> // 
    {
        protected override void Seed(SEnCContext context)
        {
            context.Afiliado.Add(new Afiliado { Id = 1, Nome = "Isabella", Codigo = "FEDWD1232131" });
            context.SaveChanges();

            context.Periodicidade.Add(new Periodicidade { Id = 1, Descricao = "Mensal", PercentualDesconto = 0.5m });
            context.SaveChanges();

            context.Plano.Add(new Plano { Id = 1, Descricao = "Ouro",  Valor = 0m, PeriodicidadeId = 1 });
            context.SaveChanges();

            context.Usuario.Add(new Usuario { Id = 1, NomeUsuario = "Fernando", EmailUsuario = "fer@fer.com", DataCadastro = new DateTime(2017, 09, 14), DataVigencia = new DateTime(2017, 09, 14), AfiliadoId = 1, PlanoId = 1 });
            context.Usuario.Add(new Usuario { Id = 2, NomeUsuario = "Juliane", EmailUsuario = "ju@ju.com", DataCadastro = new DateTime(2017, 09, 14), DataVigencia = new DateTime(2017, 09, 14), AfiliadoId = 1, PlanoId = 1 });
            context.SaveChanges();

            context.Grupo.Add(new Grupo { Id = 1, Nome = "Moradia", UsuarioId = 1 });
            context.Grupo.Add(new Grupo { Id = 2, Nome = "Aluguel", UsuarioId = 1, IdPai = 1 });
            context.Grupo.Add(new Grupo { Id = 3, Nome = "Energia Elétrica", UsuarioId = 1, IdPai = 1 });
            context.Grupo.Add(new Grupo { Id = 4, Nome = "Gás", UsuarioId = 1, IdPai = 1 });
            context.Grupo.Add(new Grupo { Id = 5, Nome = "Água", UsuarioId = 1, IdPai = 1 });
            context.Grupo.Add(new Grupo { Id = 6, Nome = "Transporte", UsuarioId = 1 });
            context.Grupo.Add(new Grupo { Id = 7, Nome = "Prestação do Carro", UsuarioId = 1, IdPai = 6 });
            context.Grupo.Add(new Grupo { Id = 8, Nome = "Estacionamento", UsuarioId = 1, IdPai = 6 });
            context.Grupo.Add(new Grupo { Id = 9, Nome = "Combustível", UsuarioId = 1, IdPai = 6 });
            context.Grupo.Add(new Grupo { Id = 10, Nome = "Internet", UsuarioId = 1, IdPai = 1 });
            context.SaveChanges();

            context.Lancamento.Add(new Lancamento { Id = 1, Descricao = "Pagamento 01", DataLancamento = new DateTime(2017, 10, 19), DataContabil = new DateTime(2017, 10, 19), TipoLancamento = "A", GrupoId = 2, ValorLancamento = 123.45M});
            context.Lancamento.Add(new Lancamento { Id = 2, Descricao = "Pagamento 02", DataLancamento = new DateTime(2017, 10, 19), DataContabil = new DateTime(2017, 10, 19), TipoLancamento = "A", GrupoId = 2, ValorLancamento = 678.90M });
            context.Lancamento.Add(new Lancamento { Id = 3, Descricao = "Pagamento 03", DataLancamento = new DateTime(2017, 10, 19), DataContabil = new DateTime(2017, 10, 19), TipoLancamento = "A", GrupoId = 2, ValorLancamento = 111.22M });

            context.Lancamento.Add(new Lancamento { Id = 4, Descricao = "Pagamento 04", DataLancamento = new DateTime(2017, 10, 19), DataContabil = new DateTime(2017, 10, 19), TipoLancamento = "A", GrupoId = 6, ValorLancamento = 123.45M });
            context.Lancamento.Add(new Lancamento { Id = 5, Descricao = "Pagamento 05", DataLancamento = new DateTime(2017, 10, 19), DataContabil = new DateTime(2017, 10, 19), TipoLancamento = "A", GrupoId = 6, ValorLancamento = 678.90M });
            context.Lancamento.Add(new Lancamento { Id = 6, Descricao = "Pagamento 06", DataLancamento = new DateTime(2017, 10, 19), DataContabil = new DateTime(2017, 10, 19), TipoLancamento = "A", GrupoId = 6, ValorLancamento = 111.22M });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
