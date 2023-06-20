using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicUIControls.Model
{

    public class DynamiCFormModel
    {
        public List<ControlDetail> Controls { get; set; }
    }

    public class ControlDetail
    {
        public string Type { get; set; }
        public string Discription { get; set; }
    }

}
