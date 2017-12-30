using System.Collections.Generic;
using GeoLibrary.Contracts;
using GeoLibrary.Data.RepositoryAbstractions;
using GeoLibrary.Data.Repositories;
using GeoLibrary.Data.Entities;
using System.Linq;
using System.ServiceModel;
using System;

namespace GeoLibrary.Services
{
    //This is the default wcf service behavior
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class GeoAdminManager : IGeoAdminService
    {
        IZipCodeRepository _zipcodeRepsitory;
        IStateRepository _stateRepository;

        public GeoAdminManager() { }

        public GeoAdminManager(IZipCodeRepository zipcodeRepository)
        {
            _zipcodeRepsitory = zipcodeRepository;
        }

        public GeoAdminManager(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public GeoAdminManager(IZipCodeRepository zipcodeRepository, IStateRepository stateRepository)
        {
            _zipcodeRepsitory = zipcodeRepository;
            _stateRepository = stateRepository;
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void UpdateZipCity(string zip, string city)
        {
            ZipCode zipCode = GetZipCodeRepository().GetByZip(zip);
            if (zipCode != null)
            {
                zipCode.City = city;
            }
            GetZipCodeRepository().Update(zipCode);
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void UpdateZipCity(IEnumerable<ZipCityData> zipCityData)
        {
            GetZipCodeRepository()
                .UpdateCityBatch(zipCityData.ToDictionary(key => key.ZipCode, value => value.City));
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void UpdateStateCodeBatch(IEnumerable<StateCodeData> stateCodeBatch)
        {
            try
            {
                using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required))
                {
                    if (stateCodeBatch.Any(sc => sc.SSCode.Length > 4))
                    {
                        GeoDatabaseUpdateFault customFault = new GeoDatabaseUpdateFault("The SSCode field cannot be longer then four characters.")
                        {
                            IssueDetail = "GeoAdminManager.UpdateStateCodeBatch has at least one invalid SSCode in collection."
                        };
                        throw new FaultException<GeoDatabaseUpdateFault>(customFault, "Invalid Argument");
                    }
                    GetStateRepository().UpdateStateCodeBatch(stateCodeBatch.ToDictionary(key => key.StateId, value => value.SSCode));
                    ts.Complete();
                }
            }
            catch (ApplicationException ex)
            {
                throw new FaultException<ApplicationException>(ex, "");
            }
        }

        //------------------------------------------------------------------------------------------------------------

        private IZipCodeRepository GetZipCodeRepository()
        {
            return _zipcodeRepsitory ?? new ZipCodeRepository();
        }

        private IStateRepository GetStateRepository()
        {
            return _stateRepository ?? new StateRepository();
        }
    }
}
