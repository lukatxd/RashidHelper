using RashidHelper.Vendors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RashidHelper
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
            loadFormData();
        }

        private void loadFormData()
        {
            vendor_combobox.DataSource = loadVendors();
            selectFirstVendor();
        }

        private void selectFirstVendor()
        {
            vendor_combobox.SelectedIndex = 0;
            updateVendorData();
        }

        private void updateVendorData()
        {
            updateVendorLocation();
            selectFirstItemOfVendor();
        }
        void updateVendorLocation()
        {
            VendorJob vendor = (VendorJob)vendor_combobox.SelectedItem;
            vendorLocation_label.Text = vendor.getLocation();
        }

        private void selectFirstItemOfVendor()
        {
            VendorJob vendor = (VendorJob)vendor_combobox.SelectedItem;
            items_combobox.DataSource = vendor.getItemList();
            items_combobox.SelectedIndex = 0;
        }

        private List<VendorJob> loadVendors()
        {
            List<VendorJob> vendors = new List<VendorJob>();
            vendors.Add(new Rashid());
            vendors.Add(new NahBob());
            vendors.Add(new Haroun());
            vendors.Add(new Alesar());
            vendors.Add(new Yaman());
            vendors.Add(new GrizzlyAdams());
            vendors.Add(new Malunga());
            return vendors;
        }

        private void prox_button_Click(object sender, EventArgs e)
        {
            try
            {
                selectNextItem();
            }
            catch (ArgumentOutOfRangeException)
            {
                try
                {
                    selectNextVendor();
                }
                catch (ArgumentOutOfRangeException)
                {
                    selectFirstVendor();
                }
            }
        }

        private void selectNextVendor()
        {
            vendor_combobox.SelectedIndex = vendor_combobox.SelectedIndex + 1;
            updateVendorData();
        }

        private void selectNextItem()
        {
            items_combobox.SelectedIndex = items_combobox.SelectedIndex + 1;
        }

        private void vendor_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateVendorData();
        }
    }
}
