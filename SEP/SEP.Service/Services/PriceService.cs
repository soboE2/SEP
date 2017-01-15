using org.drools.dotnet;
using org.drools.dotnet.compiler;
using org.drools.dotnet.rule;
using SEP.Contract.Repositories;
using SEP.Contract.ServiceModels;
using SEP.Contract.Services;
using SEP.Service.Helpers;
using System;
using System.IO;
using System.Reflection;

namespace SEP.Service.Services
{
    public class PriceService : IPriceService
    {
        private readonly IRiskItemRepository _riskItemRepository;

        public PriceService(IRiskItemRepository riskItemRepository)
        {
            _riskItemRepository = riskItemRepository;
        }

        public decimal GetTravelInsurancePrice(TravelRiskItem riskItem)
        {
            string assemblyPath = AppDomain.CurrentDomain.RelativeSearchPath;
            System.IO.Stream stream = new FileStream(Path.Combine(assemblyPath, @"Rules\", "TravelInsurancePrice.drl"), FileMode.Open);
            try
            {
                var region = _riskItemRepository.GetById(riskItem.RegionID);
                var sport = riskItem.SportId.HasValue ? _riskItemRepository.GetById(riskItem.SportId.Value) : null;

                PackageBuilder builder = new PackageBuilder();
                builder.AddPackageFromDrl(stream);
                Package pkg = builder.GetPackage();
                RuleBase ruleBase = RuleBaseFactory.NewRuleBase();
                ruleBase.AddPackage(pkg);
                WorkingMemory workingMemory = ruleBase.NewWorkingMemory();

                workingMemory.assertObject(region);
                workingMemory.assertObject(sport);
                workingMemory.assertObject(riskItem);

                return riskItem.RuleAmmount;
            }
            finally
            {
                stream.Close();
            }


        }
    }
}