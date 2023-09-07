namespace HW_ScrollBars_n_Indicators
{
    partial class FormTools
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
            this.components = new System.ComponentModel.Container();
            this.textBoxTools = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.btn_counter_clockwise = new System.Windows.Forms.Button();
            this.btn_clockwise = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTools
            // 
            this.textBoxTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTools.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTools.Location = new System.Drawing.Point(13, 13);
            this.textBoxTools.Multiline = true;
            this.textBoxTools.Name = "textBoxTools";
            this.textBoxTools.Size = new System.Drawing.Size(178, 27);
            this.textBoxTools.TabIndex = 0;
            this.textBoxTools.Text = "Панель управления";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(13, 122);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(249, 45);
            this.trackBar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.trackBar, "Увеличить/уменьшить размер");
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // btn_counter_clockwise
            // 
            this.btn_counter_clockwise.Image = global::HW_ScrollBars_n_Indicators.Properties.Resources._4;
            this.btn_counter_clockwise.Location = new System.Drawing.Point(13, 59);
            this.btn_counter_clockwise.Name = "btn_counter_clockwise";
            this.btn_counter_clockwise.Size = new System.Drawing.Size(35, 35);
            this.btn_counter_clockwise.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_counter_clockwise, "Поворот против часовой стрелки на 90");
            this.btn_counter_clockwise.UseVisualStyleBackColor = true;
            this.btn_counter_clockwise.Click += new System.EventHandler(this.btn_counter_clockwise_Click);
            // 
            // btn_clockwise
            // 
            this.btn_clockwise.Image = global::HW_ScrollBars_n_Indicators.Properties.Resources._3;
            this.btn_clockwise.Location = new System.Drawing.Point(58, 59);
            this.btn_clockwise.Name = "btn_clockwise";
            this.btn_clockwise.Size = new System.Drawing.Size(35, 35);
            this.btn_clockwise.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_clockwise, "Поворот по часовой стрелке на 90 гр");
            this.btn_clockwise.UseVisualStyleBackColor = true;
            this.btn_clockwise.Click += new System.EventHandler(this.btn_clockwise_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(245, 202);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 145);
            this.vScrollBar1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.vScrollBar1, "Смещение по вертикали");
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(9, 330);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(216, 17);
            this.hScrollBar1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.hScrollBar1, "Смещение по горизонтали");
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btn_clockwise);
            this.Controls.Add(this.btn_counter_clockwise);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.textBoxTools);
            this.Name = "FormTools";
            this.Text = "Tools";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTools;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button btn_counter_clockwise;
        private System.Windows.Forms.Button btn_clockwise;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}