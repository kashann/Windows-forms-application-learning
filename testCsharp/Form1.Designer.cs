namespace testCsharp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvCars = new System.Windows.Forms.ListView();
            this.column1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPriceSortASC = new System.Windows.Forms.Button();
            this.btnPriceSortDESC = new System.Windows.Forms.Button();
            this.btnDateSortASC = new System.Windows.Forms.Button();
            this.btnDateSortDesc = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufacturing Date";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(197, 27);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(191, 20);
            this.tbModel.TabIndex = 3;
            this.tbModel.Validating += new System.ComponentModel.CancelEventHandler(this.tbModel_Validating);
            this.tbModel.Validated += new System.EventHandler(this.tbModel_Validated);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(197, 60);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(191, 20);
            this.tbPrice.TabIndex = 4;
            this.tbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrice_Validating);
            this.tbPrice.Validated += new System.EventHandler(this.tbPrice_Validated);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 97);
            this.dateTimePicker1.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2018, 5, 20, 0, 0, 0, 0);
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            this.dateTimePicker1.Validated += new System.EventHandler(this.dateTimePicker1_Validated);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(313, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvCars
            // 
            this.lvCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column1,
            this.column2,
            this.columnHeader3,
            this.columnHeader1});
            this.lvCars.GridLines = true;
            this.lvCars.Location = new System.Drawing.Point(12, 167);
            this.lvCars.Name = "lvCars";
            this.lvCars.Size = new System.Drawing.Size(397, 244);
            this.lvCars.TabIndex = 7;
            this.lvCars.UseCompatibleStateImageBehavior = false;
            this.lvCars.View = System.Windows.Forms.View.Details;
            // 
            // column1
            // 
            this.column1.Text = "Model";
            // 
            // column2
            // 
            this.column2.Text = "Manufacturing Date";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // btnPriceSortASC
            // 
            this.btnPriceSortASC.Location = new System.Drawing.Point(12, 138);
            this.btnPriceSortASC.Name = "btnPriceSortASC";
            this.btnPriceSortASC.Size = new System.Drawing.Size(98, 23);
            this.btnPriceSortASC.TabIndex = 8;
            this.btnPriceSortASC.Text = "Price Sort ( ASC )";
            this.btnPriceSortASC.UseVisualStyleBackColor = true;
            this.btnPriceSortASC.Click += new System.EventHandler(this.btnPriceSortASC_Click);
            // 
            // btnPriceSortDESC
            // 
            this.btnPriceSortDESC.Location = new System.Drawing.Point(116, 138);
            this.btnPriceSortDESC.Name = "btnPriceSortDESC";
            this.btnPriceSortDESC.Size = new System.Drawing.Size(106, 23);
            this.btnPriceSortDESC.TabIndex = 9;
            this.btnPriceSortDESC.Text = "Price Sort ( DESC )";
            this.btnPriceSortDESC.UseVisualStyleBackColor = true;
            this.btnPriceSortDESC.Click += new System.EventHandler(this.btnPriceSortDESC_Click);
            // 
            // btnDateSortASC
            // 
            this.btnDateSortASC.Location = new System.Drawing.Point(12, 416);
            this.btnDateSortASC.Name = "btnDateSortASC";
            this.btnDateSortASC.Size = new System.Drawing.Size(121, 23);
            this.btnDateSortASC.TabIndex = 10;
            this.btnDateSortASC.Text = "Date Sort (ASC)";
            this.btnDateSortASC.UseVisualStyleBackColor = true;
            this.btnDateSortASC.Click += new System.EventHandler(this.btnDateSortASC_Click);
            // 
            // btnDateSortDesc
            // 
            this.btnDateSortDesc.Location = new System.Drawing.Point(139, 416);
            this.btnDateSortDesc.Name = "btnDateSortDesc";
            this.btnDateSortDesc.Size = new System.Drawing.Size(113, 23);
            this.btnDateSortDesc.TabIndex = 11;
            this.btnDateSortDesc.Text = "Date Sort ( DESC )";
            this.btnDateSortDesc.UseVisualStyleBackColor = true;
            this.btnDateSortDesc.Click += new System.EventHandler(this.btnDateSortDesc_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Age(Years)";
            this.columnHeader1.Width = 74;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 451);
            this.Controls.Add(this.btnDateSortDesc);
            this.Controls.Add(this.btnDateSortASC);
            this.Controls.Add(this.btnPriceSortDESC);
            this.Controls.Add(this.btnPriceSortASC);
            this.Controls.Add(this.lvCars);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvCars;
        private System.Windows.Forms.ColumnHeader column1;
        private System.Windows.Forms.ColumnHeader column2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnPriceSortASC;
        private System.Windows.Forms.Button btnPriceSortDESC;
        private System.Windows.Forms.Button btnDateSortASC;
        private System.Windows.Forms.Button btnDateSortDesc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
    }
}

