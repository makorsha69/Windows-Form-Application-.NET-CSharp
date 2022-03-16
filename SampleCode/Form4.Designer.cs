namespace SampleCode
{
    partial class Form4
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.lbSal = new System.Windows.Forms.Label();
            this.lbDesig = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(496, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(558, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(391, 283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(285, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(169, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(319, 54);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(225, 20);
            this.txtId.TabIndex = 48;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(319, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 20);
            this.txtName.TabIndex = 47;
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(319, 172);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(225, 20);
            this.txtDesig.TabIndex = 46;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(319, 237);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(225, 20);
            this.txtSal.TabIndex = 45;
            // 
            // lbSal
            // 
            this.lbSal.AutoSize = true;
            this.lbSal.Location = new System.Drawing.Point(171, 240);
            this.lbSal.Name = "lbSal";
            this.lbSal.Size = new System.Drawing.Size(36, 13);
            this.lbSal.TabIndex = 44;
            this.lbSal.Text = "Salary";
            // 
            // lbDesig
            // 
            this.lbDesig.AutoSize = true;
            this.lbDesig.Location = new System.Drawing.Point(171, 179);
            this.lbDesig.Name = "lbDesig";
            this.lbDesig.Size = new System.Drawing.Size(63, 13);
            this.lbDesig.TabIndex = 43;
            this.lbDesig.Text = "Designation";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(171, 120);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(84, 13);
            this.lbName.TabIndex = 42;
            this.lbName.Text = "Employee Name";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(171, 61);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(67, 13);
            this.lbId.TabIndex = 41;
            this.lbId.Text = "Employee ID";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDesig);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.lbSal);
            this.Controls.Add(this.lbDesig);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Name = "Form4";
            this.Text = "EF DEMO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesig;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label lbSal;
        private System.Windows.Forms.Label lbDesig;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
    }
}