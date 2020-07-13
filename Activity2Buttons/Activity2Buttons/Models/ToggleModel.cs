using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity2Buttons.Models
{
    public class ToggleModel
    {
        public int Status { get; set; }

        public ToggleModel(int status)
        {
            Status = status;
        }
    }
}