using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBAccess.DataAccessModels
{
    public class Depo
    {
        [Key]
        public int DepoId { get; set; }
        public string DepoName { get; set; }
        public int DivisionId { get; set; }
        public virtual Division division { get; set; }
        public virtual IEnumerable<Driver> drivers { get; set; }
    }
}
