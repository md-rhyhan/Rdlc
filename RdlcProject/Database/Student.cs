namespace RdlcProject.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        public int Id { get; set; }

        public string StudentName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public int CountryId { get; set; }

        public int StateId { get; set; }

        public int CityId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public int CreatedBy { get; set; }

        public int? UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public virtual City City { get; set; }

        public virtual Country Country { get; set; }

        public virtual State State { get; set; }
    }
}
