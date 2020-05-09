using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities;
using RepositoryUoW.Data;
using RepositoryUoW.Data.EFCore;

namespace RepositoryUoW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassangersController : MyMDBController<Passanger, EfCoreRepositoryPassanger>
    {
        public PassangersController(EfCoreRepositoryPassanger repository) : base(repository)
        {

        }
    }
}
