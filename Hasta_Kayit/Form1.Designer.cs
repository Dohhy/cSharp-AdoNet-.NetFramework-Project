
namespace Hasta_Kayit
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
            this.dgwPatients = new System.Windows.Forms.DataGridView();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.lblAgeAdd = new System.Windows.Forms.Label();
            this.tbxNameAdd = new System.Windows.Forms.TextBox();
            this.tbxAgeAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.gbxDelete = new System.Windows.Forms.GroupBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.tbxAgeUpdate = new System.Windows.Forms.TextBox();
            this.LabelAgeUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatients)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPatients
            // 
            this.dgwPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPatients.Location = new System.Drawing.Point(13, 13);
            this.dgwPatients.Name = "dgwPatients";
            this.dgwPatients.RowHeadersWidth = 51;
            this.dgwPatients.RowTemplate.Height = 24;
            this.dgwPatients.Size = new System.Drawing.Size(281, 379);
            this.dgwPatients.TabIndex = 0;
            this.dgwPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPatients_CellClick);
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
            // lblAgeAdd
            // 
            this.lblAgeAdd.AutoSize = true;
            this.lblAgeAdd.Location = new System.Drawing.Point(21, 67);
            this.lblAgeAdd.Name = "lblAgeAdd";
            this.lblAgeAdd.Size = new System.Drawing.Size(33, 17);
            this.lblAgeAdd.TabIndex = 2;
            this.lblAgeAdd.Text = "Age";
            // 
            // tbxNameAdd
            // 
            this.tbxNameAdd.Location = new System.Drawing.Point(72, 30);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(152, 22);
            this.tbxNameAdd.TabIndex = 3;
            // 
            // tbxAgeAdd
            // 
            this.tbxAgeAdd.Location = new System.Drawing.Point(72, 64);
            this.tbxAgeAdd.Name = "tbxAgeAdd";
            this.tbxAgeAdd.Size = new System.Drawing.Size(77, 22);
            this.tbxAgeAdd.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(163, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.tbxNameAdd);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblNameAdd);
            this.gbxAdd.Controls.Add(this.tbxAgeAdd);
            this.gbxAdd.Controls.Add(this.lblAgeAdd);
            this.gbxAdd.Location = new System.Drawing.Point(312, 13);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(253, 144);
            this.gbxAdd.TabIndex = 6;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a patient";
            // 
            // gbxDelete
            // 
            this.gbxDelete.Controls.Add(this.tbxNameUpdate);
            this.gbxDelete.Controls.Add(this.btnUpdate);
            this.gbxDelete.Controls.Add(this.lblNameUpdate);
            this.gbxDelete.Controls.Add(this.tbxAgeUpdate);
            this.gbxDelete.Controls.Add(this.LabelAgeUpdate);
            this.gbxDelete.Location = new System.Drawing.Point(312, 176);
            this.gbxDelete.Name = "gbxDelete";
            this.gbxDelete.Size = new System.Drawing.Size(253, 144);
            this.gbxDelete.TabIndex = 7;
            this.gbxDelete.TabStop = false;
            this.gbxDelete.Text = "Update a patient";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(72, 30);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(152, 22);
            this.tbxNameUpdate.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(163, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 34);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(21, 33);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(45, 17);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name";
            // 
            // tbxAgeUpdate
            // 
            this.tbxAgeUpdate.Location = new System.Drawing.Point(72, 64);
            this.tbxAgeUpdate.Name = "tbxAgeUpdate";
            this.tbxAgeUpdate.Size = new System.Drawing.Size(77, 22);
            this.tbxAgeUpdate.TabIndex = 4;
            // 
            // LabelAgeUpdate
            // 
            this.LabelAgeUpdate.AutoSize = true;
            this.LabelAgeUpdate.Location = new System.Drawing.Point(21, 67);
            this.LabelAgeUpdate.Name = "LabelAgeUpdate";
            this.LabelAgeUpdate.Size = new System.Drawing.Size(33, 17);
            this.LabelAgeUpdate.TabIndex = 2;
            this.LabelAgeUpdate.Text = "Age";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(312, 357);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 35);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 405);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxDelete);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwPatients);
            this.Name = "Form1";
            this.Text = "Hasta Kayıt Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatients)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxDelete.ResumeLayout(false);
            this.gbxDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPatients;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.Label lblAgeAdd;
        private System.Windows.Forms.TextBox tbxNameAdd;
        private System.Windows.Forms.TextBox tbxAgeAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.GroupBox gbxDelete;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox tbxAgeUpdate;
        private System.Windows.Forms.Label LabelAgeUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

