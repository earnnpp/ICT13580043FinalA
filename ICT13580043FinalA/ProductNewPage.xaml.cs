using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580043FinalA
{
    public partial class ProductNewPage : ContentPage
    {

        public ProductNewPage()
        {
            InitializeComponent();
            genderPicker.Items.Add("ชาย");

            genderPicker.Items.Add("หญิง");

			departmentPicker.Items.Add("ไอที");
			departmentPicker.Items.Add("บัญชี");
			departmentPicker.Items.Add("การตลาด");
			departmentPicker.Items.Add("ผล");

			



			myStepper.ValueChanged += MyStepper_ValueChanged;

        }

        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valuelable.Text = value.ToString();

        }
    }
}
		
		