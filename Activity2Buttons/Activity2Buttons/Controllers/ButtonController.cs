using Activity2Buttons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Buttons.Controllers
{
    public class ButtonController : Controller
    {
        // GET: Button
        static List<ButtonModel> buttons = new List<ButtonModel>();
        static ToggleModel toggle = new ToggleModel(0);
        Random random = new Random();

        public ButtonController()
        {
            if (buttons.Count == 0)
            {
                for (int i = 0; i < 20; i++)
                {
                    buttons.Add(new ButtonModel(random.Next(100) > 50, random.Next(100) > 50));
                }
            }
        }
        public ActionResult Index()
        {
            return View("Index", buttons);
        }

        public ActionResult HandleButtonClick(string mine)
        {
            int buttonNumber = Int32.Parse(mine);
            if (!buttons[buttonNumber].Flagged)
            {
                buttons[buttonNumber].State = !buttons[buttonNumber].State;
            }
            return View("Index", buttons);
        }

        public ActionResult HandleOnRightButtonClick(string mine)
        {
            int ButtonNumber = Int32.Parse(mine);
            buttons[ButtonNumber].Flagged = !buttons[ButtonNumber].Flagged;
            return View("Index", buttons);
        }


        public ActionResult showChallenge()
        {
            return View("Challenge",toggle);
        }

        public ActionResult HandleToggleClick(string status)
        {
            int statusnum = Int32.Parse(status);
            if ((statusnum + 1) > 2){
                statusnum = 0;
            }
            else
            {
                statusnum++;
            }
            toggle.Status = statusnum;
            return View("Challenge",toggle);
        }
    }
}