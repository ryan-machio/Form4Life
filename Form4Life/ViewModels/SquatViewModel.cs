using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Form4Life.Models;

namespace Form4Life.ViewModels
{
    public class SquatViewModel
    {
        public Squat Squat { get; set; }
        public List<Subscribers> Subscribers { get; set; }
    }
}