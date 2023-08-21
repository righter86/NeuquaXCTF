using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Database.Models.XCMeetsModel;

namespace Database.Models
{
    public class XCMeetsModel
    {
        [Key]
        public int MeetId { get; set; }
        public DateOnly Date { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
    }
}
