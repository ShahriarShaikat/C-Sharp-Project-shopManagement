
namespace View
{
    partial class AddOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.dgvProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 448);
            this.panel1.TabIndex = 0;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial,
            this.productCode,
            this.productName,
            this.quantity,
            this.category,
            this.price});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1217, 448);
            this.dgvProduct.TabIndex = 0;
            // 
            // serial
            // 
            this.serial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serial.DataPropertyName = "serial";
            this.serial.HeaderText = "Serial No.";
            this.serial.MinimumWidth = 6;
            this.serial.Name = "serial";
            this.serial.ReadOnly = true;
            // 
            // productCode
            // 
            this.productCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCode.DataPropertyName = "productCode";
            this.productCode.HeaderText = "Product Code";
            this.productCode.MinimumWidth = 6;
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Category";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // addCart
            // 
            this.addCart.BackColor = System.Drawing.Color.LimeGreen;
            this.addCart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addCart.Location = new System.Drawing.Point(1102, 77);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(133, 49);
            this.addCart.TabIndex = 1;
            this.addCart.Text = "Add Cart";
            this.addCart.UseVisualStyleBackColor = false;
            this.addCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(21, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.btnSearch.CustomButton.Image = null;
            this.btnSearch.CustomButton.Location = new System.Drawing.Point(343, 1);
            this.btnSearch.CustomButton.Name = "";
            this.btnSearch.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.btnSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSearch.CustomButton.TabIndex = 1;
            this.btnSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSearch.CustomButton.UseSelectable = true;
            this.btnSearch.CustomButton.Visible = false;
            this.btnSearch.Lines = new string[0];
            this.btnSearch.Location = new System.Drawing.Point(312, 77);
            this.btnSearch.MaxLength = 32767;
            this.btnSearch.Multiline = true;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PasswordChar = '\0';
            this.btnSearch.PromptText = "Search....";
            this.btnSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.btnSearch.SelectedText = "";
            this.btnSearch.SelectionLength = 0;
            this.btnSearch.SelectionStart = 0;
            this.btnSearch.ShortcutsEnabled = true;
            this.btnSearch.Size = new System.Drawing.Size(377, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.WaterMark = "Search....";
            this.btnSearch.WaterMarkColor = System.Drawing.Color.Teal;
            this.btnSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.btnSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyUp);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Yellow;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton1.Location = new System.Drawing.Point(951, 77);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(108, 49);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "View Cart";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 611);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addCart);
            this.Controls.Add(this.panel1);
            this.Name = "AddOrder";
            this.Text = "Add Order";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroTextBox btnSearch;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}