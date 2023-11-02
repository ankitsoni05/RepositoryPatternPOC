﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBAccess.DataAccessModels
{
    public class Driver
    {
        [Key]
        public int driverId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime dateOfJoining { get; set; }
        public string contactNumber { get; set; }
        public string emailId { get; set; }
        public string aadharNumber { get; set; }
        public string panNumber { get; set; }
        public string drivingLicenceNumber { get; set; }
        public virtual Depo depo { get; set; }
        public decimal driverSalary { get; set; }
        public int DepoId { get; set; }
        public virtual IEnumerable<DriverPay> DriverPays { get; set; }
    }
}
