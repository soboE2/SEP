using SEP.Model.Model;

namespace SEP.Repository.Config
{
    internal class InsuranceTypeConfig : BaseConfig<InsuranceType>
    {
        public InsuranceTypeConfig()
            : base()
        {
            Property(m => m.Name).HasMaxLength(128).IsRequired();
            Property(m => m.Code).IsRequired();
        }
    }
}