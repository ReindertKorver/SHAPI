using System;
using System.Collections.Generic;
using System.Text;

namespace SHAPI_ClassLibrary.Models
{
    class Role
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public List<Right> rights { get; set; }
    }
}
