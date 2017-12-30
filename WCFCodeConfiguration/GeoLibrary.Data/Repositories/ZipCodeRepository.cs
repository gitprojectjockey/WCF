using GeoLibrary.Core;
using GeoLibrary.Data.Entities;
using GeoLibrary.Data.RepositoryAbstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace GeoLibrary.Data.Repositories
{
    public class ZipCodeRepository : DataRepositoryBase<ZipCode, GeoLibraryDbContext >, IZipCodeRepository
    {
        protected override DbSet<ZipCode> DbSet(GeoLibraryDbContext  entityContext)
        {
            return entityContext.ZipCodeSet;
        }

        protected override Expression<Func<ZipCode, bool>> IdentifierPredicate(GeoLibraryDbContext  entityContext, int id)
        {
            return (e => e.ZipCodeId == id);
        }

        public override IEnumerable<ZipCode> Get()
        {
            using (GeoLibraryDbContext  entityContext = new GeoLibraryDbContext ())
            {
                return entityContext.ZipCodeSet
                    .Include(e => e.State).ToFullyLoaded();
            }
        }

        public ZipCode GetByZip(string zip)
        {
            using (GeoLibraryDbContext  entityContext = new GeoLibraryDbContext ())
            {
                return entityContext.ZipCodeSet
                    .Include(e => e.State)
                    .Where(e => e.Zip == zip)
                    .FirstOrDefault();
            }
        }

        public IEnumerable<ZipCode> GetByState(string state)
        {
            using (GeoLibraryDbContext  entityContext = new GeoLibraryDbContext ())
            {
                return entityContext.ZipCodeSet
                    .Include(e => e.State)
                    .Where(e => e.State.Abbreviation == state).ToFullyLoaded();
            }
        }

        public IEnumerable<ZipCode> GetZipsForRange(ZipCode zip, int range)
        {
            using (GeoLibraryDbContext  entityContext = new GeoLibraryDbContext ())
            {
                double degrees = range / 69.047;

                return entityContext.ZipCodeSet
                    .Include(e => e.State)
                    .Where(e => (e.Latitude <= zip.Latitude + degrees && e.Latitude >= zip.Latitude - degrees) &&
                                (e.Longitude <= zip.Longitude + degrees && e.Longitude >= zip.Longitude - degrees))
                    .ToFullyLoaded();
            }
        }

        public void UpdateCityBatch(Dictionary<string, string> cityBatch)
        {
            using (GeoLibraryDbContext entityContext = new GeoLibraryDbContext())
            {
                List<string> cityBatchList = (from kvp in cityBatch select kvp.Key).ToList(); // Linq-to-Entities
                List<ZipCode> zips = entityContext.ZipCodeSet.Where(e => cityBatchList.Contains(e.Zip)).ToList();
                zips.ForEach(e => e.City = cityBatch[e.Zip]);

                entityContext.SaveChanges();
            }
        }

        public void UpdateCity(string zip, string city)
        {
            using (GeoLibraryDbContext entityContext = new GeoLibraryDbContext())
            {
                ZipCode zipCode = entityContext.ZipCodeSet.FirstOrDefault(z => z.Zip == zip);
                if (zipCode != null)
                {
                    zipCode.City = city;
                }
                entityContext.SaveChanges();
            }
        }
    }
}
