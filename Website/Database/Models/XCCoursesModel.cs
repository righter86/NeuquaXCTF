using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Database.Models.XCCoursesModel;
using System.Data.Entity;

namespace Database.Models
{
    public class XCCoursesModel
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Distance { get; set; }
    }

    public class NVXCTFData : DbContext
    {
        public DbSet<XCCoursesModel> Courses { get; set; }
    }
}
