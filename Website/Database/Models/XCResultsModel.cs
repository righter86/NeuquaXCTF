using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Database.Models.XCResultsModel;

namespace Database.Models
{
    public class XCResultsModel
    {
        [Key]
        public int ResultId { get; set; }
        public int CourseId { get; set; }
        public string Level { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        public int Place { get; set; }
        public TimeOnly Time { get; set; }
    }
}
