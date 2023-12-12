namespace EmployeeWFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnUpdate = new Button();
            dgvData = new DataGridView();
            label3 = new Label();
            btnLoad = new Button();
            textBoxNama = new TextBox();
            textBoxDept = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            label4 = new Label();
            textBoxIDKaryawan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 150);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 194);
            label2.Name = "label2";
            label2.Size = new Size(127, 19);
            label2.TabIndex = 1;
            label2.Text = "ID Dept Karyawan: ";
            label2.Click += label2_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(494, 119);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 81);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseMnemonic = false;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(280, 271);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(346, 150);
            dgvData.TabIndex = 7;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(238, 33);
            label3.Name = "label3";
            label3.Size = new Size(339, 37);
            label3.TabIndex = 8;
            label3.Text = "Aplikasi Pencatat Karyawan";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(647, 387);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 34);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(195, 149);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(129, 23);
            textBoxNama.TabIndex = 11;
            // 
            // textBoxDept
            // 
            textBoxDept.Location = new Point(195, 194);
            textBoxDept.Name = "textBoxDept";
            textBoxDept.Size = new Size(129, 23);
            textBoxDept.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(375, 119);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 81);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(614, 119);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 81);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 109);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 15;
            label4.Text = "ID Karyawan: ";
            label4.Click += label4_Click;
            // 
            // textBoxIDKaryawan
            // 
            textBoxIDKaryawan.Location = new Point(195, 108);
            textBoxIDKaryawan.Name = "textBoxIDKaryawan";
            textBoxIDKaryawan.Size = new Size(129, 23);
            textBoxIDKaryawan.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxIDKaryawan);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(textBoxDept);
            Controls.Add(textBoxNama);
            Controls.Add(btnLoad);
            Controls.Add(label3);
            Controls.Add(dgvData);
            Controls.Add(btnUpdate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxIDKaryawan;
        private ComboBox comboBox1;
        private Button btn_add;
        private Button btnUpdate;
        private Button button3;
        private DataGridView dgvData;
        private Label label3;
        private Button btnLoad;
        private TextBox textBoxNama;
        private TextBox textBoxDept;
        private Button btnAdd;
        private Button btnDelete;
        private Label label4;
    }
}
