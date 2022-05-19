
namespace Bolum_Kayit
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
            this.dgwPolyclinics = new System.Windows.Forms.DataGridView();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.lblEmployeeCountAdd = new System.Windows.Forms.Label();
            this.tbxNameAdd = new System.Windows.Forms.TextBox();
            this.tbxEmploeeCountAdd = new System.Windows.Forms.TextBox();
            this.gbxPolyclinicAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxEmployeeCountUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblEmploeeCountUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPolyclinics)).BeginInit();
            this.gbxPolyclinicAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPolyclinics
            // 
            this.dgwPolyclinics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPolyclinics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPolyclinics.Location = new System.Drawing.Point(13, 13);
            this.dgwPolyclinics.Name = "dgwPolyclinics";
            this.dgwPolyclinics.RowHeadersWidth = 51;
            this.dgwPolyclinics.RowTemplate.Height = 24;
            this.dgwPolyclinics.Size = new System.Drawing.Size(314, 425);
            this.dgwPolyclinics.TabIndex = 0;
            this.dgwPolyclinics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPolyclinics_CellClick);
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(21, 30);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(83, 17);
            this.lblNameAdd.TabIndex = 1;
            this.lblNameAdd.Text = "Polklinik Adı";
            // 
            // lblEmployeeCountAdd
            // 
            this.lblEmployeeCountAdd.AutoSize = true;
            this.lblEmployeeCountAdd.Location = new System.Drawing.Point(24, 65);
            this.lblEmployeeCountAdd.Name = "lblEmployeeCountAdd";
            this.lblEmployeeCountAdd.Size = new System.Drawing.Size(95, 17);
            this.lblEmployeeCountAdd.TabIndex = 2;
            this.lblEmployeeCountAdd.Text = "Çalışan Sayısı";
            // 
            // tbxNameAdd
            // 
            this.tbxNameAdd.Location = new System.Drawing.Point(139, 25);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(132, 22);
            this.tbxNameAdd.TabIndex = 3;
            // 
            // tbxEmploeeCountAdd
            // 
            this.tbxEmploeeCountAdd.Location = new System.Drawing.Point(139, 62);
            this.tbxEmploeeCountAdd.Name = "tbxEmploeeCountAdd";
            this.tbxEmploeeCountAdd.Size = new System.Drawing.Size(71, 22);
            this.tbxEmploeeCountAdd.TabIndex = 4;
            // 
            // gbxPolyclinicAdd
            // 
            this.gbxPolyclinicAdd.Controls.Add(this.btnAdd);
            this.gbxPolyclinicAdd.Controls.Add(this.tbxEmploeeCountAdd);
            this.gbxPolyclinicAdd.Controls.Add(this.lblNameAdd);
            this.gbxPolyclinicAdd.Controls.Add(this.tbxNameAdd);
            this.gbxPolyclinicAdd.Controls.Add(this.lblEmployeeCountAdd);
            this.gbxPolyclinicAdd.Location = new System.Drawing.Point(333, 13);
            this.gbxPolyclinicAdd.Name = "gbxPolyclinicAdd";
            this.gbxPolyclinicAdd.Size = new System.Drawing.Size(280, 153);
            this.gbxPolyclinicAdd.TabIndex = 5;
            this.gbxPolyclinicAdd.TabStop = false;
            this.gbxPolyclinicAdd.Text = "Add a polyclinic";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(196, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tbxEmployeeCountUpdate);
            this.groupBox1.Controls.Add(this.lblNameUpdate);
            this.groupBox1.Controls.Add(this.tbxNameUpdate);
            this.groupBox1.Controls.Add(this.lblEmploeeCountUpdate);
            this.groupBox1.Location = new System.Drawing.Point(333, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update a polyclinic";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(196, 115);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxEmployeeCountUpdate
            // 
            this.tbxEmployeeCountUpdate.Location = new System.Drawing.Point(139, 62);
            this.tbxEmployeeCountUpdate.Name = "tbxEmployeeCountUpdate";
            this.tbxEmployeeCountUpdate.Size = new System.Drawing.Size(71, 22);
            this.tbxEmployeeCountUpdate.TabIndex = 4;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(21, 30);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(83, 17);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Polklinik Adı";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(139, 25);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(132, 22);
            this.tbxNameUpdate.TabIndex = 3;
            // 
            // lblEmploeeCountUpdate
            // 
            this.lblEmploeeCountUpdate.AutoSize = true;
            this.lblEmploeeCountUpdate.Location = new System.Drawing.Point(24, 65);
            this.lblEmploeeCountUpdate.Name = "lblEmploeeCountUpdate";
            this.lblEmploeeCountUpdate.Size = new System.Drawing.Size(95, 17);
            this.lblEmploeeCountUpdate.TabIndex = 2;
            this.lblEmploeeCountUpdate.Text = "Çalışan Sayısı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(334, 348);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxPolyclinicAdd);
            this.Controls.Add(this.dgwPolyclinics);
            this.Name = "Form1";
            this.Text = "Bölüm Kayıt Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPolyclinics)).EndInit();
            this.gbxPolyclinicAdd.ResumeLayout(false);
            this.gbxPolyclinicAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPolyclinics;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.Label lblEmployeeCountAdd;
        private System.Windows.Forms.TextBox tbxNameAdd;
        private System.Windows.Forms.TextBox tbxEmploeeCountAdd;
        private System.Windows.Forms.GroupBox gbxPolyclinicAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxEmployeeCountUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblEmploeeCountUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

