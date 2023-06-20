using DynamicUIControls.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicUIControls.ViewModel
{
 public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {

        }

        private DynamiCFormModel myFormData = null;
        public DynamiCFormModel MyFormData
        {
            get { return this.myFormData; }
            set
            {
                this.myFormData = value;
                if (value != null)
                {
                    myFormData = value;
                    NotifyPropertyChanged("MyFormData");
                }

            }
        }

        public void LoadData()
        {
            string jsonData = @"{'ControlDetail': [
                                {'Type': 'TextBox','Discription': 'Name'},
                                {'Type': 'TextBox','Discription': 'Address'}, 
                                {'Type': 'DropDown','Discription': 'Select value'}
                                ]}";
            MyFormData= JsonConvert.DeserializeObject<DynamiCFormModel>(jsonData);
        }

    }
}
