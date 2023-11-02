using DBAccess.DataAccess.Contract;
using DBAccess.DataAccessModels;
using DBAccess.DBContext;
using DBAccess.Repository.GenericRepository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.DataAccess.Implementation
{
    internal class DivisionAccessRepo : Repository<Division>, IDivisionAccessRepo
    {
        private readonly AppDbContext driverContext;

        public DivisionAccessRepo(AppDbContext driverContext) : base(driverContext)
        {
            this.driverContext = driverContext;
        }
    }
}
