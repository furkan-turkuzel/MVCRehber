using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.UI.Models
{
    public class KisiAdresModelView
    {
        public List<Kisiler> Kisiler { get; set; }
        public List<Adresler> Adresler { get; set; }
    }
}