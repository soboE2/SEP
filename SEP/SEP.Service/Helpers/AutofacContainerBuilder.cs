﻿using Autofac;
using SEP.Contract.Repositories;
using SEP.Contract.Services;
using SEP.Repository;
using SEP.Repository.Repositories;
using SEP.Service.Services;
using System.Data.Entity;

namespace SEP.Service.Helpers
{
    public class AutofacContainerBuilder
    {
        private readonly ContainerBuilder _builder;

        public AutofacContainerBuilder(ContainerBuilder builder)
        {
            _builder = builder;
        }

        public AutofacContainerBuilder WithRepositories()
        {
            _builder.Register(c => new Context("Name=InsuranceDb")).As<DbContext>().InstancePerLifetimeScope();
            _builder.RegisterType<InsuranceTypeRepository>().As<IInsuranceTypeRepository>().InstancePerLifetimeScope();
            _builder.RegisterType<RiksItemRepository>().As<IRiskItemRepository>().InstancePerLifetimeScope();
            _builder.RegisterType<RiskRepository>().As<IRiskRepository>().InstancePerLifetimeScope();

            return this;
        }

        public AutofacContainerBuilder WithServices()
        {
            //_builder.RegisterAssemblyTypes(Assembly.Load("SEP.Contract"))
            //        .Where(t => t.Name.EndsWith("Service"))
            //        .AsImplementedInterfaces()
            //        .InstancePerLifetimeScope();
            _builder.RegisterType<InsuranceTypeService>().As<IInsuranceTypeService>().InstancePerLifetimeScope();
            _builder.RegisterType<RiskItemServices>().As<IRiskItemServices>().InstancePerLifetimeScope();
            _builder.RegisterType<PriceService>().As<IPriceService>().InstancePerLifetimeScope();
            return this;
        }

        public IContainer Build()
        {
            return _builder.Build();
        }
    }
}