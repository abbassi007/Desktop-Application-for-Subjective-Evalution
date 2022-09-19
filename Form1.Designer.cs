namespace PC_Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftImage = new System.Windows.Forms.PictureBox();
            this.OpenELTM = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.RaLeft = new System.Windows.Forms.RadioButton();
            this.RaRight = new System.Windows.Forms.RadioButton();
            this.EvaluationPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.OpenOtherTMO = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RightImage = new System.Windows.Forms.PictureBox();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftImage)).BeginInit();
            this.EvaluationPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftPanel.AutoScroll = true;
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LeftPanel.Controls.Add(this.LeftImage);
            this.LeftPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LeftPanel.Location = new System.Drawing.Point(2, 57);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(620, 534);
            this.LeftPanel.TabIndex = 0;
            // 
            // LeftImage
            // 
            this.LeftImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LeftImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LeftImage.InitialImage = null;
            this.LeftImage.Location = new System.Drawing.Point(-3, 0);
            this.LeftImage.Margin = new System.Windows.Forms.Padding(2);
            this.LeftImage.Name = "LeftImage";
            this.LeftImage.Size = new System.Drawing.Size(623, 534);
            this.LeftImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LeftImage.TabIndex = 0;
            this.LeftImage.TabStop = false;
            this.LeftImage.Click += new System.EventHandler(this.LeftImage_Click);
            this.LeftImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.LeftImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // OpenELTM
            // 
            this.OpenELTM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenELTM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenELTM.BackgroundImage = global::PC_Test.Properties.Resources.next;
            this.OpenELTM.Font = new System.Drawing.Font("Hobo Std", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenELTM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenELTM.Location = new System.Drawing.Point(2, 2);
            this.OpenELTM.Margin = new System.Windows.Forms.Padding(2);
            this.OpenELTM.Name = "OpenELTM";
            this.OpenELTM.Size = new System.Drawing.Size(110, 42);
            this.OpenELTM.TabIndex = 2;
            this.OpenELTM.Text = "Open TMO";
            this.OpenELTM.UseVisualStyleBackColor = false;
            this.OpenELTM.Click += new System.EventHandler(this.OpenELTM_Click);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Start.BackgroundImage = global::PC_Test.Properties.Resources.next;
            this.Start.Font = new System.Drawing.Font("Hobo Std", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(116, 2);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(104, 42);
            this.Start.TabIndex = 5;
            this.Start.Text = "Evaluate";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // RaLeft
            // 
            this.RaLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RaLeft.AutoSize = true;
            this.RaLeft.Location = new System.Drawing.Point(14, 27);
            this.RaLeft.Margin = new System.Windows.Forms.Padding(2);
            this.RaLeft.Name = "RaLeft";
            this.RaLeft.Size = new System.Drawing.Size(75, 17);
            this.RaLeft.TabIndex = 0;
            this.RaLeft.TabStop = true;
            this.RaLeft.Text = "Left Image";
            this.RaLeft.UseVisualStyleBackColor = true;
            this.RaLeft.CheckedChanged += new System.EventHandler(this.RaLeft_CheckedChanged);
            // 
            // RaRight
            // 
            this.RaRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RaRight.AutoSize = true;
            this.RaRight.Location = new System.Drawing.Point(171, 27);
            this.RaRight.Margin = new System.Windows.Forms.Padding(2);
            this.RaRight.Name = "RaRight";
            this.RaRight.Size = new System.Drawing.Size(82, 17);
            this.RaRight.TabIndex = 1;
            this.RaRight.TabStop = true;
            this.RaRight.Text = "Right Image";
            this.RaRight.UseVisualStyleBackColor = true;
            this.RaRight.CheckedChanged += new System.EventHandler(this.RaRight_CheckedChanged);
            // 
            // EvaluationPanel
            // 
            this.EvaluationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.EvaluationPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EvaluationPanel.Controls.Add(this.RaRight);
            this.EvaluationPanel.Controls.Add(this.RaLeft);
            this.EvaluationPanel.Location = new System.Drawing.Point(503, 0);
            this.EvaluationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EvaluationPanel.Name = "EvaluationPanel";
            this.EvaluationPanel.Size = new System.Drawing.Size(255, 55);
            this.EvaluationPanel.TabIndex = 1;
            this.EvaluationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EvaluationPanel_Paint);
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.AutoScroll = true;
            this.RightPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.RightPanel.Controls.Add(this.RightImage);
            this.RightPanel.Location = new System.Drawing.Point(638, 57);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(622, 534);
            this.RightPanel.TabIndex = 1;
            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.RightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // OpenOtherTMO
            // 
            this.OpenOtherTMO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenOtherTMO.BackgroundImage = global::PC_Test.Properties.Resources.next;
            this.OpenOtherTMO.Font = new System.Drawing.Font("Hobo Std", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenOtherTMO.Location = new System.Drawing.Point(513, 2);
            this.OpenOtherTMO.Margin = new System.Windows.Forms.Padding(2);
            this.OpenOtherTMO.Name = "OpenOtherTMO";
            this.OpenOtherTMO.Size = new System.Drawing.Size(116, 42);
            this.OpenOtherTMO.TabIndex = 6;
            this.OpenOtherTMO.Text = "Open other TMO";
            this.OpenOtherTMO.UseVisualStyleBackColor = true;
            this.OpenOtherTMO.Click += new System.EventHandler(this.OpenOtherTMO_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1286, 704);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 643);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1262, 47);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel2.Controls.Add(this.OpenELTM);
            this.flowLayoutPanel2.Controls.Add(this.Start);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(631, 47);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel3.Controls.Add(this.OpenOtherTMO);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(631, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(631, 47);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.4898F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.020408F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.4898F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.LeftPanel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.RightPanel, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 14);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.866279F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.46512F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1262, 629);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 3);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.EvaluationPanel, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1262, 55);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Hobo Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, 595);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 22);
            this.textBox1.TabIndex = 3;
            // 
            // RightImage
            // 
            this.RightImage.BackColor = System.Drawing.SystemColors.ControlText;
            this.RightImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RightImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RightImage.Location = new System.Drawing.Point(0, 0);
            this.RightImage.Margin = new System.Windows.Forms.Padding(2);
            this.RightImage.Name = "RightImage";
            this.RightImage.Size = new System.Drawing.Size(622, 534);
            this.RightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RightImage.TabIndex = 0;
            this.RightImage.TabStop = false;
            this.RightImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.RightImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1286, 704);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "PC Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftImage)).EndInit();
            this.EvaluationPanel.ResumeLayout(false);
            this.EvaluationPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button OpenELTM;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.RadioButton RaLeft;
        private System.Windows.Forms.RadioButton RaRight;
        private System.Windows.Forms.Panel EvaluationPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Button OpenOtherTMO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox LeftImage;
        private System.Windows.Forms.PictureBox RightImage;
    }
}

