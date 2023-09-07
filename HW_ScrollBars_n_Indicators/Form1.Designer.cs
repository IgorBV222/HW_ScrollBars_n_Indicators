namespace HW_ScrollBars_n_Indicators
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.btn_counter_clockwise = new System.Windows.Forms.Button();
            this.btn_clockwise = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 139);
            this.textBox1.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(316, 13);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 231);
            this.vScrollBar1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.vScrollBar1, "Смещение по вертикали");
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(13, 251);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(303, 17);
            this.hScrollBar1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.hScrollBar1, "Смещение по горизонтали");
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(372, 223);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(333, 45);
            this.trackBar1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.trackBar1, "Увеличить/уменьшить размер");
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(437, 289);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 323);
            this.vScrollBar2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.vScrollBar2, "Смещение по вертикали");
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(13, 594);
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(396, 17);
            this.hScrollBar2.TabIndex = 9;
            this.toolTip1.SetToolTip(this.hScrollBar2, "Смещение по горизонтали");
            this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
            // 
            // btn_counter_clockwise
            // 
            this.btn_counter_clockwise.Image = global::HW_ScrollBars_n_Indicators.Properties.Resources._4;
            this.btn_counter_clockwise.Location = new System.Drawing.Point(779, 31);
            this.btn_counter_clockwise.Name = "btn_counter_clockwise";
            this.btn_counter_clockwise.Size = new System.Drawing.Size(35, 35);
            this.btn_counter_clockwise.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_counter_clockwise, "Поворот против часовой стрелки на 90 гр");
            this.btn_counter_clockwise.UseVisualStyleBackColor = true;
            this.btn_counter_clockwise.Click += new System.EventHandler(this.btn_counter_clockwise_Click);
            // 
            // btn_clockwise
            // 
            this.btn_clockwise.Image = ((System.Drawing.Image)(resources.GetObject("btn_clockwise.Image")));
            this.btn_clockwise.Location = new System.Drawing.Point(820, 31);
            this.btn_clockwise.Name = "btn_clockwise";
            this.btn_clockwise.Size = new System.Drawing.Size(35, 35);
            this.btn_clockwise.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_clockwise, "Поворот по часовой стрелке на 90 гр");
            this.btn_clockwise.UseVisualStyleBackColor = true;
            this.btn_clockwise.Click += new System.EventHandler(this.btn_clockwise_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HW_ScrollBars_n_Indicators.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(372, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Для управления двойной щелчок");
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HW_ScrollBars_n_Indicators.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 189);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 638);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.btn_counter_clockwise);
            this.Controls.Add(this.btn_clockwise);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_clockwise;
        private System.Windows.Forms.Button btn_counter_clockwise;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.HScrollBar hScrollBar2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

