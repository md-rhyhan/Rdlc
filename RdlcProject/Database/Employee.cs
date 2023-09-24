namespace RdlcProject.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTimeOffset JoiningDate { get; set; }

        public bool Ssc { get; set; }

        public bool Hsc { get; set; }

        public bool Bsc { get; set; }

        public bool Msc { get; set; }

        public int CountryId { get; set; }

        public int StateId { get; set; }

        public int CityId { get; set; }

        public int DeparmentId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public int CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public string Picture { get; set; }

        public virtual City City { get; set; }

        public virtual Country Country { get; set; }

        public virtual Department Department { get; set; }

        public virtual State State { get; set; }
    }
}
