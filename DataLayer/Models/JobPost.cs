using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class JobPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TypeOfWork Type;
    }
}
