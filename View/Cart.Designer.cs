
namespace View
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.totalVal = new System.Windows.Forms.Label();
            this.editProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.qtySave = new System.Windows.Forms.Label();
            this.qtyVal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSlider = new System.Windows.Forms.TrackBar();
            this.ptotal = new System.Windows.Forms.Label();
            this.pprice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pcode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PlaceOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.dgvCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 315);
            this.panel1.TabIndex = 0;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCode,
            this.productName,
            this.quantity,
            this.category,
            this.price,
            this.totalPrice});
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.Location = new System.Drawing.Point(0, 0);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(1065, 315);
            this.dgvCart.TabIndex = 0;
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
            // totalPrice
            // 
            this.totalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPrice.DataPropertyName = "totalPrice";
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total amount";
            // 
            // totalVal
            // 
            this.totalVal.AutoSize = true;
            this.totalVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVal.Location = new System.Drawing.Point(140, 432);
            this.totalVal.Name = "totalVal";
            this.totalVal.Size = new System.Drawing.Size(0, 20);
            this.totalVal.TabIndex = 2;
            // 
            // editProduct
            // 
            this.editProduct.Location = new System.Drawing.Point(929, 421);
            this.editProduct.Name = "editProduct";
            this.editProduct.Size = new System.Drawing.Size(153, 44);
            this.editProduct.TabIndex = 3;
            this.editProduct.Text = "Edit Product";
            this.editProduct.UseVisualStyleBackColor = true;
            this.editProduct.Click += new System.EventHandler(this.editProduct_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.qtySave);
            this.panel2.Controls.Add(this.qtyVal);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.tbSlider);
            this.panel2.Controls.Add(this.ptotal);
            this.panel2.Controls.Add(this.pprice);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pcode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(353, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 345);
            this.panel2.TabIndex = 4;
            // 
            // qtySave
            // 
            this.qtySave.AutoSize = true;
            this.qtySave.Location = new System.Drawing.Point(604, 130);
            this.qtySave.Name = "qtySave";
            this.qtySave.Size = new System.Drawing.Size(0, 17);
            this.qtySave.TabIndex = 12;
            // 
            // qtyVal
            // 
            this.qtyVal.AutoSize = true;
            this.qtyVal.Location = new System.Drawing.Point(167, 130);
            this.qtyVal.Name = "qtyVal";
            this.qtyVal.Size = new System.Drawing.Size(0, 17);
            this.qtyVal.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(277, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSlider
            // 
            this.tbSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSlider.Location = new System.Drawing.Point(227, 126);
            this.tbSlider.Minimum = 1;
            this.tbSlider.Name = "tbSlider";
            this.tbSlider.Size = new System.Drawing.Size(357, 56);
            this.tbSlider.TabIndex = 10;
            this.tbSlider.Value = 1;
            this.tbSlider.Scroll += new System.EventHandler(this.tbSlider_Scroll);
            // 
            // ptotal
            // 
            this.ptotal.AutoSize = true;
            this.ptotal.Location = new System.Drawing.Point(167, 248);
            this.ptotal.Name = "ptotal";
            this.ptotal.Size = new System.Drawing.Size(0, 17);
            this.ptotal.TabIndex = 8;
            // 
            // pprice
            // 
            this.pprice.AutoSize = true;
            this.pprice.Location = new System.Drawing.Point(167, 202);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(0, 17);
            this.pprice.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantity";
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Location = new System.Drawing.Point(167, 82);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(0, 17);
            this.pname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Product Name";
            // 
            // pcode
            // 
            this.pcode.AutoSize = true;
            this.pcode.Location = new System.Drawing.Point(167, 32);
            this.pcode.Name = "pcode";
            this.pcode.Size = new System.Drawing.Size(0, 17);
            this.pcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Code";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(757, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 44);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Return Shop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlaceOrder
            // 
            this.PlaceOrder.BackColor = System.Drawing.Color.Green;
            this.PlaceOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlaceOrder.Location = new System.Drawing.Point(353, 421);
            this.PlaceOrder.Name = "PlaceOrder";
            this.PlaceOrder.Size = new System.Drawing.Size(173, 44);
            this.PlaceOrder.TabIndex = 7;
            this.PlaceOrder.Text = "Place Order";
            this.PlaceOrder.UseVisualStyleBackColor = false;
            this.PlaceOrder.Click += new System.EventHandler(this.PlaceOrder_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(20, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 345);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 815);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PlaceOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editProduct);
            this.Controls.Add(this.totalVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Cart";
            this.Text = "Cart";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSlider)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalVal;
        private System.Windows.Forms.Button editProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar tbSlider;
        private System.Windows.Forms.Label ptotal;
        private System.Windows.Forms.Label pprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label qtyVal;
        private System.Windows.Forms.Label qtySave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PlaceOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}