using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity2Buttons.Models
{
    public class ButtonModel
    {
        public bool State { get; set; }
        public bool Flagged { get; set; }

        public ButtonModel(bool state, bool flagged)
        {
            State = state;
            Flagged = flagged;
        }
    }
}