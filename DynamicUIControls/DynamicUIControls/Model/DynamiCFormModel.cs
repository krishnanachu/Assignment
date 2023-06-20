using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicUIControls.Model
{

    public class DynamiCFormModel
    {
        public Controldetail[] ControlDetail { get; set; }
    }

    public class Controldetail
    {
        public string Type { get; set; }
        public string Discription { get; set; }
    }

}
