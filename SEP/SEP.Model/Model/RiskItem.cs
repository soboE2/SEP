using System;
namespace SEP.Model.Model
{
    public class RiskItem :BaseModel
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }

        public decimal Coefficient { get; set; }
    }
}