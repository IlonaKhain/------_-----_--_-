namespace методы_нелин_ур_й
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_run = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_dikhotomia = new System.Windows.Forms.Button();
            this.txb_b = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_a = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_polynom = new System.Windows.Forms.TextBox();
            this.txb_eps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btn_MN = new System.Windows.Forms.Button();
            this.btn_Hord = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(18, 124);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 0;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(24, 161);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 236);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.btn_run);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(449, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Метод Итераций";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_MN);
            this.tabPage2.Controls.Add(this.listBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(449, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Метод Ньютона";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox4);
            this.tabPage3.Controls.Add(this.btn_Hord);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(449, 210);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Метод Хорд";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBox2);
            this.tabPage4.Controls.Add(this.btn_dikhotomia);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(449, 210);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Половинное деление";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(42, 34);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(362, 121);
            this.listBox2.TabIndex = 1;
            // 
            // btn_dikhotomia
            // 
            this.btn_dikhotomia.Location = new System.Drawing.Point(29, 169);
            this.btn_dikhotomia.Name = "btn_dikhotomia";
            this.btn_dikhotomia.Size = new System.Drawing.Size(75, 23);
            this.btn_dikhotomia.TabIndex = 0;
            this.btn_dikhotomia.Text = "Run";
            this.btn_dikhotomia.UseVisualStyleBackColor = true;
            this.btn_dikhotomia.Click += new System.EventHandler(this.btn_dikhotomia_Click);
            // 
            // txb_b
            // 
            this.txb_b.Location = new System.Drawing.Point(352, 110);
            this.txb_b.Name = "txb_b";
            this.txb_b.Size = new System.Drawing.Size(18, 20);
            this.txb_b.TabIndex = 12;
            this.txb_b.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = ";";
            // 
            // txb_a
            // 
            this.txb_a.Location = new System.Drawing.Point(310, 110);
            this.txb_a.Name = "txb_a";
            this.txb_a.Size = new System.Drawing.Size(20, 20);
            this.txb_a.TabIndex = 9;
            this.txb_a.Text = "-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "[";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите левую и правую границу промежутка, на котором существует 1 корень";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите коэффициенты многочлена, подрят начиная с члена с наивысшего порядка, и р" +
    "азделяя их точкой с запятой (;)";
            // 
            // txb_polynom
            // 
            this.txb_polynom.Location = new System.Drawing.Point(160, 40);
            this.txb_polynom.Name = "txb_polynom";
            this.txb_polynom.Size = new System.Drawing.Size(100, 20);
            this.txb_polynom.TabIndex = 3;
            this.txb_polynom.Text = "1;-3;-24;-8";
            // 
            // txb_eps
            // 
            this.txb_eps.Location = new System.Drawing.Point(160, 70);
            this.txb_eps.Name = "txb_eps";
            this.txb_eps.Size = new System.Drawing.Size(100, 20);
            this.txb_eps.TabIndex = 2;
            this.txb_eps.Text = "0,001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите точность ";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(41, 19);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 0;
            // 
            // btn_MN
            // 
            this.btn_MN.Location = new System.Drawing.Point(41, 166);
            this.btn_MN.Name = "btn_MN";
            this.btn_MN.Size = new System.Drawing.Size(75, 23);
            this.btn_MN.TabIndex = 1;
            this.btn_MN.Text = "Run";
            this.btn_MN.UseVisualStyleBackColor = true;
            this.btn_MN.Click += new System.EventHandler(this.btn_MN_Click);
            // 
            // btn_Hord
            // 
            this.btn_Hord.Location = new System.Drawing.Point(37, 174);
            this.btn_Hord.Name = "btn_Hord";
            this.btn_Hord.Size = new System.Drawing.Size(75, 23);
            this.btn_Hord.TabIndex = 0;
            this.btn_Hord.Text = "Run";
            this.btn_Hord.UseVisualStyleBackColor = true;
            this.btn_Hord.Click += new System.EventHandler(this.btn_Hord_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(47, 19);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 95);
            this.listBox4.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 409);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_b);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_eps);
            this.Controls.Add(this.txb_a);
            this.Controls.Add(this.txb_polynom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_polynom;
        private System.Windows.Forms.TextBox txb_eps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_b;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_dikhotomia;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_MN;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button btn_Hord;
    }
}

