using RashidHelper.Libs;
using RashidHelper.Vendors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RashidHelper
{
    public partial class form_main : Form
    {
        //Source for this madness
        //https://www.fluxbytes.com/csharp/how-to-register-a-global-hotkey-for-your-application-in-c/
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public form_main()
        {
            InitializeComponent();
            loadFormData();
            vendor_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            items_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            copyItemNameToClipboard();
            RegisterHotKey(this.Handle, 0, (int)Hotkey.KeyModifier.Control, Keys.Space.GetHashCode());
        }

        public void clearItemNameFieldOnGame()
        {
            for(int i = 0; i < 30; i++) {
                SendKeys.Send("{LEFT}");
                SendKeys.Send("{DEL}");
            }
        }

        private void copyItemNameToClipboard()
        {
            Item item = (Item)items_combobox.SelectedItem;
            Clipboard.SetText(item.nome);
        }

        private void loadFormData()
        {
            vendor_combobox.DataSource = loadVendors();
            selectFirstVendor();
        }

        private void selectFirstVendor()
        {
            vendor_combobox.SelectedIndex = 0;
            changeVendorEvent();
        }

        private void changeVendorEvent()
        {
            updateVendorLocation();
            selectFirstItemOfVendor();
        }
        private void updateVendorLocation()
        {
            VendorJob vendor = (VendorJob)vendor_combobox.SelectedItem;
            vendorLocation_label.Text = vendor.getLocation();
        }

        private void selectFirstItemOfVendor()
        {
            VendorJob vendor = (VendorJob)vendor_combobox.SelectedItem;
            items_combobox.DataSource = vendor.getItemList();
            items_combobox.SelectedIndex = 0;
            copyItemNameToClipboard();
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

        public void prox_button_Click(object sender, EventArgs e)
        {
            findNextItemOrVendor();
        }

        private void findNextItemOrVendor()
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
            clearItemNameFieldAndTypeItemName();
        }

        private void selectNextVendor()
        {
            vendor_combobox.SelectedIndex = vendor_combobox.SelectedIndex + 1;
            changeVendorEvent();
        }

        private void selectNextItem()
        {
            items_combobox.SelectedIndex = items_combobox.SelectedIndex + 1;
            copyItemNameToClipboard();
        }

        public void vendor_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeVendorEvent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /*
                //Note that the three lines below are not needed if you only want to register one hotkey.
                // The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason.

                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                Hotkey.KeyModifier modifier = (Hotkey.KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.
                */

                //MessageBox.Show("Hotkey has been pressed!");
                this.findNextItemOrVendor();
            }
        }

        private void clearItemNameFieldAndTypeItemName()
        {
            clearItemNameFieldOnGame();
            inputItemNameOnGame();
        }

        private void inputItemNameOnGame()
        {
            Item item = (Item)items_combobox.SelectedItem;
            SendKeys.Send(item.nome);
        }

        private void form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Passou no form close");
            UnregisterHotKey(this.Handle, 0);
        }
    }
}
