using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DynamicUIControls.View.Controls
{
    public class CustomViewCellTemplate<T> : CustomViewCell where T : Xamarin.Forms.View, new()
    {
        public CustomViewCellTemplate()
        {
            View = new T();
        }
    }
    public class CustomViewCell : ViewCell
    {
    }
}
