using SEP.Model.Model;

namespace SEP.Repository.Config
{
    internal class RiskConfig : BaseConfig<Risk>
    {
        public RiskConfig()
            : base()
        {
            Property(m => m.Name).HasMaxLength(128).IsRequired();
            HasRequired(m => m.InsuranceType);
        }
    }
}