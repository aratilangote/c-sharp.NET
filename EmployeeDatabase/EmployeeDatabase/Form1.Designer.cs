
namespace EmployeeDatabase
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_desi = new System.Windows.Forms.TextBox();
            this.txt_bs = new System.Windows.Forms.TextBox();
            this.txt_da = new System.Windows.Forms.TextBox();
            this.txt_hra = new System.Windows.Forms.TextBox();
            this.txt_totalSal = new System.Windows.Forms.TextBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.cb_age = new System.Windows.Forms.ComboBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basic_Sal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Sal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_calculate = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(418, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp_ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(75, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emp_Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(75, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(75, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(75, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Designation :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(75, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Basic Salary :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(75, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Daily Allowance :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(75, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Home Rent Allowance :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(75, 502);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total Salary :";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(275, 100);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(202, 26);
            this.txt_id.TabIndex = 1;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(275, 143);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(202, 26);
            this.txt_name.TabIndex = 2;
            // 
            // txt_desi
            // 
            this.txt_desi.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_desi.Location = new System.Drawing.Point(275, 299);
            this.txt_desi.Name = "txt_desi";
            this.txt_desi.Size = new System.Drawing.Size(202, 26);
            this.txt_desi.TabIndex = 6;
            // 
            // txt_bs
            // 
            this.txt_bs.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_bs.Location = new System.Drawing.Point(275, 351);
            this.txt_bs.Name = "txt_bs";
            this.txt_bs.Size = new System.Drawing.Size(202, 26);
            this.txt_bs.TabIndex = 7;
            this.txt_bs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bs_KeyPress);
            // 
            // txt_da
            // 
            this.txt_da.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_da.Location = new System.Drawing.Point(275, 406);
            this.txt_da.Name = "txt_da";
            this.txt_da.Size = new System.Drawing.Size(202, 26);
            this.txt_da.TabIndex = 8;
            this.txt_da.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_da_KeyPress);
            // 
            // txt_hra
            // 
            this.txt_hra.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_hra.Location = new System.Drawing.Point(275, 453);
            this.txt_hra.Name = "txt_hra";
            this.txt_hra.Size = new System.Drawing.Size(202, 26);
            this.txt_hra.TabIndex = 9;
            this.txt_hra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hra_KeyPress);
            // 
            // txt_totalSal
            // 
            this.txt_totalSal.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_totalSal.Location = new System.Drawing.Point(275, 499);
            this.txt_totalSal.Name = "txt_totalSal";
            this.txt_totalSal.Size = new System.Drawing.Size(202, 26);
            this.txt_totalSal.TabIndex = 10;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_male.Location = new System.Drawing.Point(275, 198);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(68, 22);
            this.rb_male.TabIndex = 3;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            this.rb_male.CheckedChanged += new System.EventHandler(this.rb_male_CheckedChanged);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_female.Location = new System.Drawing.Point(399, 198);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(87, 22);
            this.rb_female.TabIndex = 4;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // cb_age
            // 
            this.cb_age.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_age.FormattingEnabled = true;
            this.cb_age.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.cb_age.Location = new System.Drawing.Point(275, 246);
            this.cb_age.Name = "cb_age";
            this.cb_age.Size = new System.Drawing.Size(202, 26);
            this.cb_age.TabIndex = 5;
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Gender,
            this.Age,
            this.Designation,
            this.Basic_Sal,
            this.DA,
            this.HRA,
            this.Total_Sal});
            this.data.Location = new System.Drawing.Point(495, 100);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.Height = 29;
            this.data.Size = new System.Drawing.Size(693, 426);
            this.data.TabIndex = 20;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.MinimumWidth = 6;
            this.Designation.Name = "Designation";
            this.Designation.Width = 125;
            // 
            // Basic_Sal
            // 
            this.Basic_Sal.HeaderText = "BS";
            this.Basic_Sal.MinimumWidth = 6;
            this.Basic_Sal.Name = "Basic_Sal";
            this.Basic_Sal.Width = 125;
            // 
            // DA
            // 
            this.DA.HeaderText = "DA";
            this.DA.MinimumWidth = 6;
            this.DA.Name = "DA";
            this.DA.Width = 125;
            // 
            // HRA
            // 
            this.HRA.HeaderText = "HRA";
            this.HRA.MinimumWidth = 6;
            this.HRA.Name = "HRA";
            this.HRA.Width = 125;
            // 
            // Total_Sal
            // 
            this.Total_Sal.HeaderText = "Total_Salary";
            this.Total_Sal.MinimumWidth = 6;
            this.Total_Sal.Name = "Total_Sal";
            this.Total_Sal.Width = 125;
            // 
            // bt_calculate
            // 
            this.bt_calculate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_calculate.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_calculate.Location = new System.Drawing.Point(131, 543);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(220, 44);
            this.bt_calculate.TabIndex = 21;
            this.bt_calculate.Text = "Calculate";
            this.bt_calculate.UseVisualStyleBackColor = false;
            this.bt_calculate.Click += new System.EventHandler(this.bt_calculate_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_insert.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_insert.Location = new System.Drawing.Point(511, 543);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(126, 44);
            this.bt_insert.TabIndex = 22;
            this.bt_insert.Text = "Insert";
            this.bt_insert.UseVisualStyleBackColor = false;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_update.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_update.Location = new System.Drawing.Point(685, 543);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(126, 44);
            this.bt_update.TabIndex = 23;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_delete.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_delete.Location = new System.Drawing.Point(855, 543);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(126, 44);
            this.bt_delete.TabIndex = 24;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt_exit.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_exit.Location = new System.Drawing.Point(1033, 543);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(126, 44);
            this.bt_exit.TabIndex = 25;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 609);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_insert);
            this.Controls.Add(this.bt_calculate);
            this.Controls.Add(this.data);
            this.Controls.Add(this.cb_age);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.txt_totalSal);
            this.Controls.Add(this.txt_hra);
            this.Controls.Add(this.txt_da);
            this.Controls.Add(this.txt_bs);
            this.Controls.Add(this.txt_desi);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_desi;
        private System.Windows.Forms.TextBox txt_bs;
        private System.Windows.Forms.TextBox txt_da;
        private System.Windows.Forms.TextBox txt_hra;
        private System.Windows.Forms.TextBox txt_totalSal;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.ComboBox cb_age;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basic_Sal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Sal;
        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_exit;
    }
}

