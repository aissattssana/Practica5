//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practica5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PracticaEntities1 : DbContext
    {
        public PracticaEntities1()
            : base("name=PracticaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        private static PracticaEntities1 _context = new PracticaEntities1();
        public static PracticaEntities1 GetContext()
        {
            if (_context == null)
                _context = new PracticaEntities1();
            return _context;
        }

        public virtual DbSet<Plant> Plant { get; set; }
        public virtual DbSet<PriceList> PriceList { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<ResponsiblePerson> ResponsiblePerson { get; set; }
    }
}
