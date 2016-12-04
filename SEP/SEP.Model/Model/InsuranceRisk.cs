namespace SEP.Model.Model
{
    public class InsuranceRisk : BaseModel
    {
        public Insurance Insurance { get; set; }
        public RiskItem RiskItem { get; set; }
    }
}