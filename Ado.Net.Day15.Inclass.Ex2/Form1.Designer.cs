namespace Ado.Net.Day15.Inclass.Ex2
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
            this.LblDepartName = new System.Windows.Forms.Label();
            this.LblDepartCode = new System.Windows.Forms.Label();
            this.LblDepartHead = new System.Windows.Forms.Label();
            this.LblLocation = new System.Windows.Forms.Label();
            this.TxtDepartCode = new System.Windows.Forms.TextBox();
            this.TxtDepartName = new System.Windows.Forms.TextBox();
            this.TxtDepartHead = new System.Windows.Forms.TextBox();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.LblLoation = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.GridDepartment = new System.Windows.Forms.DataGridView();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDepartName
            // 
            this.LblDepartName.AutoSize = true;
            this.LblDepartName.Location = new System.Drawing.Point(206, 61);
            this.LblDepartName.Name = "LblDepartName";
            this.LblDepartName.Size = new System.Drawing.Size(93, 13);
            this.LblDepartName.TabIndex = 0;
            this.LblDepartName.Text = "Department Name";
            // 
            // LblDepartCode
            // 
            this.LblDepartCode.AutoSize = true;
            this.LblDepartCode.Location = new System.Drawing.Point(206, 31);
            this.LblDepartCode.Name = "LblDepartCode";
            this.LblDepartCode.Size = new System.Drawing.Size(90, 13);
            this.LblDepartCode.TabIndex = 1;
            this.LblDepartCode.Text = "Department Code";
            // 
            // LblDepartHead
            // 
            this.LblDepartHead.AutoSize = true;
            this.LblDepartHead.Location = new System.Drawing.Point(208, 94);
            this.LblDepartHead.Name = "LblDepartHead";
            this.LblDepartHead.Size = new System.Drawing.Size(91, 13);
            this.LblDepartHead.TabIndex = 2;
            this.LblDepartHead.Text = "Department Head";
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(249, 175);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(0, 13);
            this.LblLocation.TabIndex = 3;
            // 
            // TxtDepartCode
            // 
            this.TxtDepartCode.Location = new System.Drawing.Point(328, 24);
            this.TxtDepartCode.Name = "TxtDepartCode";
            this.TxtDepartCode.Size = new System.Drawing.Size(100, 20);
            this.TxtDepartCode.TabIndex = 4;
            // 
            // TxtDepartName
            // 
            this.TxtDepartName.Location = new System.Drawing.Point(328, 54);
            this.TxtDepartName.Name = "TxtDepartName";
            this.TxtDepartName.Size = new System.Drawing.Size(100, 20);
            this.TxtDepartName.TabIndex = 5;
            // 
            // TxtDepartHead
            // 
            this.TxtDepartHead.Location = new System.Drawing.Point(328, 87);
            this.TxtDepartHead.Name = "TxtDepartHead";
            this.TxtDepartHead.Size = new System.Drawing.Size(100, 20);
            this.TxtDepartHead.TabIndex = 6;
            // 
            // TxtLocation
            // 
            this.TxtLocation.Location = new System.Drawing.Point(328, 117);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(100, 20);
            this.TxtLocation.TabIndex = 7;
            // 
            // LblLoation
            // 
            this.LblLoation.AutoSize = true;
            this.LblLoation.Location = new System.Drawing.Point(248, 124);
            this.LblLoation.Name = "LblLoation";
            this.LblLoation.Size = new System.Drawing.Size(48, 13);
            this.LblLoation.TabIndex = 8;
            this.LblLoation.Text = "Location";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(255, 170);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add New";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(387, 170);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(512, 170);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // GridDepartment
            // 
            this.GridDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDepartment.Location = new System.Drawing.Point(56, 199);
            this.GridDepartment.Name = "GridDepartment";
            this.GridDepartment.Size = new System.Drawing.Size(618, 133);
            this.GridDepartment.TabIndex = 12;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(127, 170);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 13;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(482, 22);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 14;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.GridDepartment);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblLoation);
            this.Controls.Add(this.TxtLocation);
            this.Controls.Add(this.TxtDepartHead);
            this.Controls.Add(this.TxtDepartName);
            this.Controls.Add(this.TxtDepartCode);
            this.Controls.Add(this.LblLocation);
            this.Controls.Add(this.LblDepartHead);
            this.Controls.Add(this.LblDepartCode);
            this.Controls.Add(this.LblDepartName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDepartName;
        private System.Windows.Forms.Label LblDepartCode;
        private System.Windows.Forms.Label LblDepartHead;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.TextBox TxtDepartCode;
        private System.Windows.Forms.TextBox TxtDepartName;
        private System.Windows.Forms.TextBox TxtDepartHead;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.Label LblLoation;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView GridDepartment;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnSearch;
    }
}

