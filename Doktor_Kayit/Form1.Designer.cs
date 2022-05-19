
namespace Doktor_Kayit
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.tbxNameAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.tbxSurnameAdd = new System.Windows.Forms.TextBox();
            this.lblSurnameAdd = new System.Windows.Forms.Label();
            this.dgwDoctors = new System.Windows.Forms.DataGridView();
            this.lblPolyclinicAdd = new System.Windows.Forms.Label();
            this.tbxPolyclinicAdd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPolyclinicUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSurnameUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoctors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(540, 397);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 35);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.tbxPolyclinicAdd);
            this.gbxAdd.Controls.Add(this.lblPolyclinicAdd);
            this.gbxAdd.Controls.Add(this.tbxNameAdd);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblNameAdd);
            this.gbxAdd.Controls.Add(this.tbxSurnameAdd);
            this.gbxAdd.Controls.Add(this.lblSurnameAdd);
            this.gbxAdd.Location = new System.Drawing.Point(540, 12);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(349, 191);
            this.gbxAdd.TabIndex = 10;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a doctor";
            // 
            // tbxNameAdd
            // 
            this.tbxNameAdd.Location = new System.Drawing.Point(101, 30);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(152, 22);
            this.tbxNameAdd.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(254, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(21, 33);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(45, 17);
            this.lblNameAdd.TabIndex = 1;
            this.lblNameAdd.Text = "Name";
            // 
            // tbxSurnameAdd
            // 
            this.tbxSurnameAdd.Location = new System.Drawing.Point(101, 64);
            this.tbxSurnameAdd.Name = "tbxSurnameAdd";
            this.tbxSurnameAdd.Size = new System.Drawing.Size(152, 22);
            this.tbxSurnameAdd.TabIndex = 4;
            // 
            // lblSurnameAdd
            // 
            this.lblSurnameAdd.AutoSize = true;
            this.lblSurnameAdd.Location = new System.Drawing.Point(21, 67);
            this.lblSurnameAdd.Name = "lblSurnameAdd";
            this.lblSurnameAdd.Size = new System.Drawing.Size(65, 17);
            this.lblSurnameAdd.TabIndex = 2;
            this.lblSurnameAdd.Text = "Surname";
            // 
            // dgwDoctors
            // 
            this.dgwDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDoctors.Location = new System.Drawing.Point(12, 12);
            this.dgwDoctors.Name = "dgwDoctors";
            this.dgwDoctors.RowHeadersWidth = 51;
            this.dgwDoctors.RowTemplate.Height = 24;
            this.dgwDoctors.Size = new System.Drawing.Size(522, 379);
            this.dgwDoctors.TabIndex = 9;
            this.dgwDoctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDoctors_CellClick);
            // 
            // lblPolyclinicAdd
            // 
            this.lblPolyclinicAdd.AutoSize = true;
            this.lblPolyclinicAdd.Location = new System.Drawing.Point(21, 105);
            this.lblPolyclinicAdd.Name = "lblPolyclinicAdd";
            this.lblPolyclinicAdd.Size = new System.Drawing.Size(66, 17);
            this.lblPolyclinicAdd.TabIndex = 6;
            this.lblPolyclinicAdd.Text = "Polyclinic";
            // 
            // tbxPolyclinicAdd
            // 
            this.tbxPolyclinicAdd.Location = new System.Drawing.Point(101, 105);
            this.tbxPolyclinicAdd.Name = "tbxPolyclinicAdd";
            this.tbxPolyclinicAdd.Size = new System.Drawing.Size(152, 22);
            this.tbxPolyclinicAdd.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxPolyclinicUpdate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxNameUpdate);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxSurnameUpdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(540, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 182);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update a doctor";
            // 
            // tbxPolyclinicUpdate
            // 
            this.tbxPolyclinicUpdate.Location = new System.Drawing.Point(101, 105);
            this.tbxPolyclinicUpdate.Name = "tbxPolyclinicUpdate";
            this.tbxPolyclinicUpdate.Size = new System.Drawing.Size(152, 22);
            this.tbxPolyclinicUpdate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Polyclinic";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(101, 30);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(152, 22);
            this.tbxNameUpdate.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 34);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // tbxSurnameUpdate
            // 
            this.tbxSurnameUpdate.Location = new System.Drawing.Point(101, 64);
            this.tbxSurnameUpdate.Name = "tbxSurnameUpdate";
            this.tbxSurnameUpdate.Size = new System.Drawing.Size(152, 22);
            this.tbxSurnameUpdate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwDoctors);
            this.Name = "Form1";
            this.Text = "Doktor Kayıt Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDoctors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbxNameAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.TextBox tbxSurnameAdd;
        private System.Windows.Forms.Label lblSurnameAdd;
        private System.Windows.Forms.DataGridView dgwDoctors;
        private System.Windows.Forms.TextBox tbxPolyclinicAdd;
        private System.Windows.Forms.Label lblPolyclinicAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxPolyclinicUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSurnameUpdate;
        private System.Windows.Forms.Label label3;
    }
}

