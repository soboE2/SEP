using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Contract.ServiceModels
{
    public class TravelRiskItem
    {
        public int RegionID { get; set; }
        public int NumberOfChildren { get; set; }
        public int NumberOfAdultsUnder60 { get; set; }
        public int NumberOfAdultsOver60 { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int? SportId { get; set; }
        public decimal InsuranceAmmount { get; set; }
    }
}
