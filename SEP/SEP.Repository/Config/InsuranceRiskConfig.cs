using SEP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Repository.Config
{
    class InsuranceRiskConfig: BaseConfig<InsuranceRisk>
    {
        public InsuranceRiskConfig()
            : base()
        {
            HasRequired(m => m.Insurance);
            HasRequired(m => m.RiskItem);
        }
    }
}
