using System;
using System.Collections.Generic;
using System.Linq;

namespace Video04
{
    public class EmployeeDto
    {

        public string name { get; set; }

        public string skills { get; set; }
        public override string ToString()
        {

            return $"{name} ({skills})";

        }
    }


}