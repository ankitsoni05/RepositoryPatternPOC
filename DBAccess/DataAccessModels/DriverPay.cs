using System;
using System.ComponentModel.DataAnnotations;

namespace DBAccess.DataAccessModels
{
    public class DriverPay
    {
        [Key]
        public int payId { get; set; }
        public DateTime payDate { get; set; }
        public decimal overTimeAmount { get; set; }
        public virtual Driver Driver { get; set; }
        public int driverId { get; set; }
    }
}
