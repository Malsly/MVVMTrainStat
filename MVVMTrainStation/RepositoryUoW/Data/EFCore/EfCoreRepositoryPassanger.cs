using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryUoW.Data.EFCore
{
    public class EfCoreRepositoryPassanger : EfCoreRepository<Passanger, RepositoryUoWContext>
    {
        public EfCoreRepositoryPassanger(RepositoryUoWContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
