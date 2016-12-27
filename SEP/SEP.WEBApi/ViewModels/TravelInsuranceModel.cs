using System;

namespace SEP.WEBApi.ViewModels
{
    public class TravelInsuranceModel
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