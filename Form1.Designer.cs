namespace RashidHelper
{
    partial class form_main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_main));
            this.prox_button = new System.Windows.Forms.Button();
            this.vendor_combobox = new System.Windows.Forms.ComboBox();
            this.items_combobox = new System.Windows.Forms.ComboBox();
            this.vendorLocation_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prox_button
            // 
            this.prox_button.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.prox_button.Location = new System.Drawing.Point(12, 79);
            this.prox_button.Name = "prox_button";
            this.prox_button.Size = new System.Drawing.Size(241, 33);
            this.prox_button.TabIndex = 0;
            this.prox_button.Text = "Próximo";
            this.prox_button.UseVisualStyleBackColor = false;
            this.prox_button.Click += new System.EventHandler(this.prox_button_Click);
            // 
            // vendor_combobox
            // 
            this.vendor_combobox.FormattingEnabled = true;
            this.vendor_combobox.Location = new System.Drawing.Point(12, 12);
            this.vendor_combobox.Name = "vendor_combobox";
            this.vendor_combobox.Size = new System.Drawing.Size(241, 21);
            this.vendor_combobox.TabIndex = 2;
            this.vendor_combobox.SelectedIndexChanged += new System.EventHandler(this.vendor_combobox_SelectedIndexChanged);
            // 
            // items_combobox
            // 
            this.items_combobox.FormattingEnabled = true;
            this.items_combobox.Location = new System.Drawing.Point(12, 52);
            this.items_combobox.Name = "items_combobox";
            this.items_combobox.Size = new System.Drawing.Size(241, 21);
            this.items_combobox.TabIndex = 5;
            // 
            // vendorLocation_label
            // 
            this.vendorLocation_label.AutoSize = true;
            this.vendorLocation_label.Location = new System.Drawing.Point(12, 36);
            this.vendorLocation_label.Name = "vendorLocation_label";
            this.vendorLocation_label.Size = new System.Drawing.Size(60, 13);
            this.vendorLocation_label.TabIndex = 6;
            this.vendorLocation_label.Text = "<Location>";
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 122);
            this.Controls.Add(this.vendorLocation_label);
            this.Controls.Add(this.items_combobox);
            this.Controls.Add(this.vendor_combobox);
            this.Controls.Add(this.prox_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_main";
            this.Text = "RashidHelper";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prox_button;
        private System.Windows.Forms.ComboBox vendor_combobox;
        private System.Windows.Forms.ComboBox items_combobox;
        private System.Windows.Forms.Label vendorLocation_label;
    }
}

