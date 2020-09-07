using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hublsoft.Web.Models
{
    public class LoginMonitorModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
