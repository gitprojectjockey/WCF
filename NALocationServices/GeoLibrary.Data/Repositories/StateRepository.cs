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
    public class StateRepository : DataRepositoryBase<State, GeoLibraryDbContext>, IStateRepository
    {
        protected override DbSet<State> DbSet(GeoLibraryDbContext entityContext)
        {
            return entityContext.StateSet;
        }

        protected override Expression<Func<State, bool>> IdentifierPredicate(GeoLibraryDbContext  entityContext, int id)
        {
            return (e => e.StateId == id);
        }

        public State Get(string abbrev)
        {
            using (GeoLibraryDbContext  entityContext = new GeoLibraryDbContext ())
            {
                return entityContext.StateSet.FirstOrDefault(e => e.Abbreviation.ToUpper() == abbrev.ToUpper());
            }
        }

        public IEnumerable<State> Get(bool primaryOnly)
        {
            using (GeoLibraryDbContext  entityContext = new GeoLibraryDbContext ())
            {
                return entityContext.StateSet.Where(e => e.IsPrimaryState == primaryOnly).ToFullyLoaded();
            }
        }

        public void UpdateStateCodeBatch(Dictionary<int,string> stateCodeBatch)
        {
            using (GeoLibraryDbContext entityContext = new GeoLibraryDbContext())
            {
                int[] stateIdList = stateCodeBatch.Select(sc => sc.Key).ToArray();

                List<State> states = entityContext.StateSet
                    .Where(s => stateIdList.Contains(s.StateId)).ToList();

                states.ForEach(s => s.SSCode = stateCodeBatch[s.StateId]);

                entityContext.SaveChanges();
            }
        }
    }
}
