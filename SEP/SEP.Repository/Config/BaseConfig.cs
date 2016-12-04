using SEP.Model.Model;
using System.Data.Entity.ModelConfiguration;

namespace SEP.Repository.Config
{
    internal class BaseConfig<T> : EntityTypeConfiguration<T> where T : BaseModel
    {
        public BaseConfig()
            : base()
        {
            HasKey(e => e.ID);
        }
    }
}