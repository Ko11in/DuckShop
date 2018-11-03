namespace DuckShop
{
    partial class FormMain
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
            this.btRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDucks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.nudWhite = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudYellow = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBlack = new System.Windows.Forms.NumericUpDown();
            this.btSetValues = new System.Windows.Forms.Button();
            this.lbRefresh = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWhite)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(12, 42);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 0;
            this.btRefresh.Text = "Обновить";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDucks);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наличие";
            // 
            // lvDucks
            // 
            this.lvDucks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvDucks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDucks.FullRowSelect = true;
            this.lvDucks.Location = new System.Drawing.Point(3, 16);
            this.lvDucks.Name = "lvDucks";
            this.lvDucks.Size = new System.Drawing.Size(212, 154);
            this.lvDucks.TabIndex = 2;
            this.lvDucks.UseCompatibleStateImageBehavior = false;
            this.lvDucks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Цвет";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Количество";
            this.columnHeader2.Width = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Адрес сервиса";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(101, 6);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(395, 20);
            this.tbAddress.TabIndex = 3;
            // 
            // nudWhite
            // 
            this.nudWhite.Location = new System.Drawing.Point(59, 26);
            this.nudWhite.Name = "nudWhite";
            this.nudWhite.Size = new System.Drawing.Size(120, 20);
            this.nudWhite.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Белые";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbResult);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btSend);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudYellow);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudBlue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudBlack);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudWhite);
            this.groupBox2.Location = new System.Drawing.Point(236, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 207);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Заказ";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(6, 179);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(248, 20);
            this.tbResult.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Результат";
            // 
            // btSend
            // 
            this.btSend.Enabled = false;
            this.btSend.Location = new System.Drawing.Point(38, 130);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(194, 24);
            this.btSend.TabIndex = 7;
            this.btSend.Text = "Отправить заказ";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Желтые";
            // 
            // nudYellow
            // 
            this.nudYellow.Location = new System.Drawing.Point(59, 104);
            this.nudYellow.Name = "nudYellow";
            this.nudYellow.Size = new System.Drawing.Size(120, 20);
            this.nudYellow.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Синие";
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(59, 78);
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(120, 20);
            this.nudBlue.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Черные";
            // 
            // nudBlack
            // 
            this.nudBlack.Location = new System.Drawing.Point(59, 52);
            this.nudBlack.Name = "nudBlack";
            this.nudBlack.Size = new System.Drawing.Size(120, 20);
            this.nudBlack.TabIndex = 6;
            // 
            // btSetValues
            // 
            this.btSetValues.Enabled = false;
            this.btSetValues.Location = new System.Drawing.Point(15, 250);
            this.btSetValues.Name = "btSetValues";
            this.btSetValues.Size = new System.Drawing.Size(212, 28);
            this.btSetValues.TabIndex = 12;
            this.btSetValues.Text = "Установить значения";
            this.btSetValues.UseVisualStyleBackColor = true;
            this.btSetValues.Click += new System.EventHandler(this.btSetValues_Click);
            // 
            // lbRefresh
            // 
            this.lbRefresh.AutoSize = true;
            this.lbRefresh.Location = new System.Drawing.Point(98, 47);
            this.lbRefresh.Name = "lbRefresh";
            this.lbRefresh.Size = new System.Drawing.Size(155, 13);
            this.lbRefresh.TabIndex = 13;
            this.lbRefresh.Text = "Обновите наличие продуктов";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 293);
            this.Controls.Add(this.lbRefresh);
            this.Controls.Add(this.btSetValues);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Заказ уточек";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWhite)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDucks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.NumericUpDown nudWhite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudYellow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudBlack;
        private System.Windows.Forms.Button btSetValues;
        private System.Windows.Forms.Label lbRefresh;
    }
}

