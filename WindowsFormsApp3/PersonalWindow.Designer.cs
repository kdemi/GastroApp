namespace WindowsFormsApp3
{
    partial class PersonalWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.enterData = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.enter_Button = new System.Windows.Forms.Button();
            this.day_earnings_TB = new System.Windows.Forms.TextBox();
            this.imprest_TB = new System.Windows.Forms.TextBox();
            this.work_h_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showSalary_TB = new System.Windows.Forms.TextBox();
            this.paid_B_salary = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_B_salary = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.settings = new System.Windows.Forms.TabPage();
            this.savechangesB = new System.Windows.Forms.Button();
            this.RemoveE = new System.Windows.Forms.Button();
            this.tb_percent = new System.Windows.Forms.TextBox();
            this.tb_rate = new System.Windows.Forms.TextBox();
            this.tb_target = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPWname = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.enterData.SuspendLayout();
            this.salary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbPWname, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.583333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.41666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(248, 273);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.enterData);
            this.tabControl1.Controls.Add(this.salary);
            this.tabControl1.Controls.Add(this.settings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 241);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 11;
            // 
            // enterData
            // 
            this.enterData.Controls.Add(this.label2);
            this.enterData.Controls.Add(this.enter_Button);
            this.enterData.Controls.Add(this.day_earnings_TB);
            this.enterData.Controls.Add(this.imprest_TB);
            this.enterData.Controls.Add(this.work_h_TB);
            this.enterData.Controls.Add(this.label3);
            this.enterData.Controls.Add(this.label4);
            this.enterData.Location = new System.Drawing.Point(4, 22);
            this.enterData.Name = "enterData";
            this.enterData.Padding = new System.Windows.Forms.Padding(3);
            this.enterData.Size = new System.Drawing.Size(234, 215);
            this.enterData.TabIndex = 0;
            this.enterData.Text = "Wprowadź";
            this.enterData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Utarg:";
            // 
            // enter_Button
            // 
            this.enter_Button.Location = new System.Drawing.Point(52, 157);
            this.enter_Button.Name = "enter_Button";
            this.enter_Button.Size = new System.Drawing.Size(137, 38);
            this.enter_Button.TabIndex = 9;
            this.enter_Button.Text = "Wprowadź";
            this.enter_Button.UseVisualStyleBackColor = true;
            this.enter_Button.Click += new System.EventHandler(this.enter_Button_Click);
            // 
            // day_earnings_TB
            // 
            this.day_earnings_TB.Location = new System.Drawing.Point(52, 40);
            this.day_earnings_TB.Name = "day_earnings_TB";
            this.day_earnings_TB.Size = new System.Drawing.Size(137, 20);
            this.day_earnings_TB.TabIndex = 6;
            this.day_earnings_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.day_earnings_TB_KeyDown);
            // 
            // imprest_TB
            // 
            this.imprest_TB.Location = new System.Drawing.Point(52, 118);
            this.imprest_TB.Name = "imprest_TB";
            this.imprest_TB.Size = new System.Drawing.Size(137, 20);
            this.imprest_TB.TabIndex = 8;
            this.imprest_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imprest_TB_KeyDown);
            // 
            // work_h_TB
            // 
            this.work_h_TB.Location = new System.Drawing.Point(52, 79);
            this.work_h_TB.Name = "work_h_TB";
            this.work_h_TB.Size = new System.Drawing.Size(137, 20);
            this.work_h_TB.TabIndex = 7;
            this.work_h_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.work_h_TB_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Godziny pracy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zaliczka:";
            // 
            // salary
            // 
            this.salary.Controls.Add(this.groupBox1);
            this.salary.Controls.Add(this.tableLayoutPanel2);
            this.salary.Location = new System.Drawing.Point(4, 22);
            this.salary.Name = "salary";
            this.salary.Padding = new System.Windows.Forms.Padding(3);
            this.salary.Size = new System.Drawing.Size(234, 215);
            this.salary.TabIndex = 1;
            this.salary.Text = "Wypłata";
            this.salary.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showSalary_TB);
            this.groupBox1.Controls.Add(this.paid_B_salary);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 184);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wypłata :";
            // 
            // showSalary_TB
            // 
            this.showSalary_TB.Location = new System.Drawing.Point(35, 36);
            this.showSalary_TB.Name = "showSalary_TB";
            this.showSalary_TB.Size = new System.Drawing.Size(155, 20);
            this.showSalary_TB.TabIndex = 2;
            // 
            // paid_B_salary
            // 
            this.paid_B_salary.Location = new System.Drawing.Point(35, 62);
            this.paid_B_salary.Name = "paid_B_salary";
            this.paid_B_salary.Size = new System.Drawing.Size(155, 39);
            this.paid_B_salary.TabIndex = 4;
            this.paid_B_salary.Text = "Wypłacono";
            this.paid_B_salary.UseVisualStyleBackColor = true;
            this.paid_B_salary.Click += new System.EventHandler(this.paid_B_salary_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Wyświetl szczegółowe dane";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Controls.Add(this.OK_B_salary, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 25);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // OK_B_salary
            // 
            this.OK_B_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OK_B_salary.Location = new System.Drawing.Point(201, 3);
            this.OK_B_salary.Name = "OK_B_salary";
            this.OK_B_salary.Size = new System.Drawing.Size(30, 19);
            this.OK_B_salary.TabIndex = 7;
            this.OK_B_salary.Text = "OK";
            this.OK_B_salary.UseVisualStyleBackColor = true;
            this.OK_B_salary.Click += new System.EventHandler(this.OK_B_salary_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(102, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // settings
            // 
            this.settings.Controls.Add(this.savechangesB);
            this.settings.Controls.Add(this.RemoveE);
            this.settings.Controls.Add(this.tb_percent);
            this.settings.Controls.Add(this.tb_rate);
            this.settings.Controls.Add(this.tb_target);
            this.settings.Controls.Add(this.label7);
            this.settings.Controls.Add(this.label6);
            this.settings.Controls.Add(this.label8);
            this.settings.Location = new System.Drawing.Point(4, 22);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(234, 215);
            this.settings.TabIndex = 2;
            this.settings.Text = "Ustawienia";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // savechangesB
            // 
            this.savechangesB.Location = new System.Drawing.Point(52, 129);
            this.savechangesB.Name = "savechangesB";
            this.savechangesB.Size = new System.Drawing.Size(134, 38);
            this.savechangesB.TabIndex = 7;
            this.savechangesB.Text = "Zapisz zmiany";
            this.savechangesB.UseVisualStyleBackColor = true;
            this.savechangesB.Click += new System.EventHandler(this.savechangesB_Click);
            // 
            // RemoveE
            // 
            this.RemoveE.Location = new System.Drawing.Point(52, 173);
            this.RemoveE.Name = "RemoveE";
            this.RemoveE.Size = new System.Drawing.Size(134, 39);
            this.RemoveE.TabIndex = 6;
            this.RemoveE.Text = "Usuń pracownika";
            this.RemoveE.UseVisualStyleBackColor = true;
            this.RemoveE.Click += new System.EventHandler(this.RemoveE_Click);
            // 
            // tb_percent
            // 
            this.tb_percent.Location = new System.Drawing.Point(52, 25);
            this.tb_percent.Name = "tb_percent";
            this.tb_percent.Size = new System.Drawing.Size(133, 20);
            this.tb_percent.TabIndex = 5;
            this.tb_percent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_percent_KeyDown);
            // 
            // tb_rate
            // 
            this.tb_rate.Location = new System.Drawing.Point(53, 64);
            this.tb_rate.Name = "tb_rate";
            this.tb_rate.Size = new System.Drawing.Size(133, 20);
            this.tb_rate.TabIndex = 4;
            this.tb_rate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_rate_KeyDown);
            // 
            // tb_target
            // 
            this.tb_target.Location = new System.Drawing.Point(52, 103);
            this.tb_target.Name = "tb_target";
            this.tb_target.Size = new System.Drawing.Size(133, 20);
            this.tb_target.TabIndex = 3;
            this.tb_target.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_target_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Stawka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Target:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Procent:";
            // 
            // lbPWname
            // 
            this.lbPWname.AutoSize = true;
            this.lbPWname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPWname.Location = new System.Drawing.Point(3, 0);
            this.lbPWname.Name = "lbPWname";
            this.lbPWname.Size = new System.Drawing.Size(242, 26);
            this.lbPWname.TabIndex = 12;
            this.lbPWname.Text = "label1";
            this.lbPWname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 273);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonalWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.enterData.ResumeLayout(false);
            this.enterData.PerformLayout();
            this.salary.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage enterData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enter_Button;
        private System.Windows.Forms.TextBox day_earnings_TB;
        private System.Windows.Forms.TextBox imprest_TB;
        private System.Windows.Forms.TextBox work_h_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage salary;
        private System.Windows.Forms.TextBox showSalary_TB;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.Button RemoveE;
        private System.Windows.Forms.TextBox tb_percent;
        private System.Windows.Forms.TextBox tb_rate;
        private System.Windows.Forms.TextBox tb_target;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbPWname;
        private System.Windows.Forms.Button savechangesB;
        private System.Windows.Forms.Button paid_B_salary;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button OK_B_salary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}