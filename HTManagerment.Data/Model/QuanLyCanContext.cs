using System.Data.Entity;

namespace HTManagerment.Data.Model
{
    public class QuanLyCanContext : DbContext
    {
        public QuanLyCanContext() : base("Data Source=.; Initial Catalog=QuanLyCan; User ID=sa;Password=123")
        {
        }

        public virtual DbSet<UserModel> Users { get; set; }

        public virtual DbSet<ProductModel> Products { get; set; }

        public virtual DbSet<SettingModel> Settings { get; set; }

        public virtual DbSet<UnitModel> Units { get; set; }
    }
}
