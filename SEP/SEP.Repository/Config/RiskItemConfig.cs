using SEP.Model.Model;

namespace SEP.Repository.Config
{
    internal class RiskItemConfig : BaseConfig<RiskItem>
    {
        public RiskItemConfig()
            : base()
        {
            HasRequired(m => m.Risk);
        }
    }
}