using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PortfolioProject.Models
{
    
        public class Project
        {
            public int Id { get; set; }
            public string Title { get; set; }

            [Display(Name = "Start Date")]
            [DataType(DataType.Date)]
            public DateTime StartDate { get; set; }

            [Display(Name = "End Date")]
            [DataType(DataType.Date)]
            public DateTime EndDate { get; set; }
            public string Tools { get; set; }
            public string Languages { get; set; }
        }
    }
