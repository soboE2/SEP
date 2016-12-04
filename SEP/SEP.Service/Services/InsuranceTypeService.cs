using SEP.Contract.DbSet;
using SEP.Contract.Repositories;
using SEP.Contract.Services;
using SEP.Model.Model;
using SEP.Repository;
using SEP.Repository.Repositories;
using System.Collections.Generic;
using System.Data.Entity;

namespace SEP.Service.Services
{
    public class InsuranceTypeService : BaseService<InsuranceType>, IInsuranceTypeService
    {
        private readonly IInsuranceTypeRepository _insuranceTypeRepository;
        private readonly DbContext _dbContext;

        public InsuranceTypeService(IInsuranceTypeRepository insuranceTypeRepository, DbContext dbContext)
            : base(insuranceTypeRepository)
        {
            _insuranceTypeRepository = insuranceTypeRepository;
            _dbContext = dbContext;
        }

    }
}