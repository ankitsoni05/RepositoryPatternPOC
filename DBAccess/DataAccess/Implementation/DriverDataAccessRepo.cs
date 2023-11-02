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
    public class DriverDataAccessRepo : Repository<Driver>, IDriverDataAccessRepo
    {
        private readonly AppDbContext driverContext;

        public DriverDataAccessRepo(AppDbContext driverContext) : base(driverContext)
        {
            this.driverContext = driverContext;
        }
    }
}
