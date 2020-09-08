using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hublsoft.Web.Models
{
    public class LoginMonitorModel
    {
        [Key]
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.StringLength(320)]
        public string UserId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
