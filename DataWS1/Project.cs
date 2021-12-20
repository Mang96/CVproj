using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWS1
{
    public class Project
    {
        [Key]
        public int PID { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }

    }
}
