﻿using SEP.Contract.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Contract.Services
{
    public interface IPriceService
    {
        decimal GetTravelInsurancePrice(TravelRiskItem riskItem);
    }
}
