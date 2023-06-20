using DynamicUIControls.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DynamicUIControls.View.Controls
{
 public  class FormControlTemplateSelector : DataTemplateSelector
    {

        private static readonly DataTemplate DropDownButtonViewTemplate;
        private static readonly DataTemplate TextBoxViewTemplate;
        static FormControlTemplateSelector()
        {
            DropDownButtonViewTemplate = new DataTemplate(typeof(CustomViewCellTemplate<DropdownView>));          
            TextBoxViewTemplate = new DataTemplate(typeof(CustomViewCellTemplate<TextBoxView>));
           
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var data = (ControlDetail)item;
            switch (data.Type)
            {

                case "DropDown":
                    return DropDownButtonViewTemplate;
                case "TextBox":
                    return TextBoxViewTemplate;
                default:
                    throw new Exception("Invalid Question ViewModel");
            }
        }
    }
}
