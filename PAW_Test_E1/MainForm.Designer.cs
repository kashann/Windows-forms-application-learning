namespace PAW_Test_E1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpManufacturingDate = new System.Windows.Forms.DateTimePicker();
            this.lbManufacturingDate = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lbModel = new System.Windows.Forms.Label();
            this.epManDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.lvCars = new System.Windows.Forms.ListView();
            this.chModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chManDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBinarySerialization = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBinaryDeserialization = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXmlSerialization = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXmlDeserialization = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epManDate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dtpManufacturingDate);
            this.groupBox1.Controls.Add(this.lbManufacturingDate);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.lbPrice);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.lbModel);
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new car";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(311, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpManufacturingDate
            // 
            this.dtpManufacturingDate.Location = new System.Drawing.Point(117, 57);
            this.dtpManufacturingDate.Name = "dtpManufacturingDate";
            this.dtpManufacturingDate.Size = new System.Drawing.Size(138, 20);
            this.dtpManufacturingDate.TabIndex = 5;
            this.dtpManufacturingDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpManufacturingDate_Validating);
            this.dtpManufacturingDate.Validated += new System.EventHandler(this.dtpManufacturingDate_Validated);
            // 
            // lbManufacturingDate
            // 
            this.lbManufacturingDate.AutoSize = true;
            this.lbManufacturingDate.Location = new System.Drawing.Point(7, 63);
            this.lbManufacturingDate.Name = "lbManufacturingDate";
            this.lbManufacturingDate.Size = new System.Drawing.Size(104, 13);
            this.lbManufacturingDate.TabIndex = 4;
            this.lbManufacturingDate.Text = "Manufacturing Date:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(311, 24);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 3;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(271, 27);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price:";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(51, 24);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(204, 20);
            this.tbModel.TabIndex = 1;
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(6, 27);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(39, 13);
            this.lbModel.TabIndex = 0;
            this.lbModel.Text = "Model:";
            // 
            // epManDate
            // 
            this.epManDate.ContainerControl = this;
            // 
            // lvCars
            // 
            this.lvCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chModel,
            this.chPrice,
            this.chManDate,
            this.chAge});
            this.lvCars.GridLines = true;
            this.lvCars.Location = new System.Drawing.Point(13, 136);
            this.lvCars.Name = "lvCars";
            this.lvCars.Size = new System.Drawing.Size(424, 141);
            this.lvCars.TabIndex = 1;
            this.lvCars.UseCompatibleStateImageBehavior = false;
            this.lvCars.View = System.Windows.Forms.View.Details;
            // 
            // chModel
            // 
            this.chModel.Text = "Model";
            this.chModel.Width = 120;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            // 
            // chManDate
            // 
            this.chManDate.Text = "Manufacturing Date";
            this.chManDate.Width = 120;
            // 
            // chAge
            // 
            this.chAge.Text = "Age (years)";
            this.chAge.Width = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBinarySerialization,
            this.btnBinaryDeserialization});
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.binaryToolStripMenuItem.Text = "Binary";
            // 
            // btnBinarySerialization
            // 
            this.btnBinarySerialization.Name = "btnBinarySerialization";
            this.btnBinarySerialization.Size = new System.Drawing.Size(152, 22);
            this.btnBinarySerialization.Text = "Serialize";
            this.btnBinarySerialization.Click += new System.EventHandler(this.btnBinarySerialization_Click);
            // 
            // btnBinaryDeserialization
            // 
            this.btnBinaryDeserialization.Name = "btnBinaryDeserialization";
            this.btnBinaryDeserialization.Size = new System.Drawing.Size(152, 22);
            this.btnBinaryDeserialization.Text = "Deserialize";
            this.btnBinaryDeserialization.Click += new System.EventHandler(this.btnBinaryDeserialization_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXmlSerialization,
            this.btnXmlDeserialization});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // btnXmlSerialization
            // 
            this.btnXmlSerialization.Name = "btnXmlSerialization";
            this.btnXmlSerialization.Size = new System.Drawing.Size(152, 22);
            this.btnXmlSerialization.Text = "Serialize";
            this.btnXmlSerialization.Click += new System.EventHandler(this.btnXmlSerialization_Click);
            // 
            // btnXmlDeserialization
            // 
            this.btnXmlDeserialization.Name = "btnXmlDeserialization";
            this.btnXmlDeserialization.Size = new System.Drawing.Size(152, 22);
            this.btnXmlDeserialization.Text = "Deserialize";
            this.btnXmlDeserialization.Click += new System.EventHandler(this.btnXmlDeserialization_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 289);
            this.Controls.Add(this.lvCars);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cars";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epManDate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbManufacturingDate;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpManufacturingDate;
        private System.Windows.Forms.ErrorProvider epManDate;
        private System.Windows.Forms.ListView lvCars;
        private System.Windows.Forms.ColumnHeader chModel;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ColumnHeader chManDate;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnBinarySerialization;
        private System.Windows.Forms.ToolStripMenuItem btnBinaryDeserialization;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnXmlSerialization;
        private System.Windows.Forms.ToolStripMenuItem btnXmlDeserialization;
    }
}

