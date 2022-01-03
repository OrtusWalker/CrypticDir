
namespace CrypticDir
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
            this.programTitlePanel = new System.Windows.Forms.Panel();
            this.programTitleLabel = new System.Windows.Forms.Label();
            this.programTitleIcon = new System.Windows.Forms.PictureBox();
            this.programTitleButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMinimaze = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.programBodyPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.programTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programTitleIcon)).BeginInit();
            this.programTitleButtonsPanel.SuspendLayout();
            this.programBodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // programTitlePanel
            // 
            this.programTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.programTitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.programTitlePanel.Controls.Add(this.programTitleLabel);
            this.programTitlePanel.Controls.Add(this.programTitleIcon);
            this.programTitlePanel.Controls.Add(this.programTitleButtonsPanel);
            this.programTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.programTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.programTitlePanel.Name = "programTitlePanel";
            this.programTitlePanel.Size = new System.Drawing.Size(750, 36);
            this.programTitlePanel.TabIndex = 0;
            // 
            // programTitleLabel
            // 
            this.programTitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.programTitleLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programTitleLabel.Location = new System.Drawing.Point(34, 0);
            this.programTitleLabel.Name = "programTitleLabel";
            this.programTitleLabel.Size = new System.Drawing.Size(212, 34);
            this.programTitleLabel.TabIndex = 2;
            this.programTitleLabel.Text = "Cryptic Directory";
            this.programTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // programTitleIcon
            // 
            this.programTitleIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.programTitleIcon.Image = global::CrypticDir.Properties.Resources._57b8bfaf3756c156a9acc47b;
            this.programTitleIcon.Location = new System.Drawing.Point(0, 0);
            this.programTitleIcon.Name = "programTitleIcon";
            this.programTitleIcon.Size = new System.Drawing.Size(34, 34);
            this.programTitleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.programTitleIcon.TabIndex = 1;
            this.programTitleIcon.TabStop = false;
            // 
            // programTitleButtonsPanel
            // 
            this.programTitleButtonsPanel.AutoSize = true;
            this.programTitleButtonsPanel.Controls.Add(this.buttonMinimaze);
            this.programTitleButtonsPanel.Controls.Add(this.buttonExit);
            this.programTitleButtonsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.programTitleButtonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.programTitleButtonsPanel.Location = new System.Drawing.Point(680, 0);
            this.programTitleButtonsPanel.Name = "programTitleButtonsPanel";
            this.programTitleButtonsPanel.Size = new System.Drawing.Size(68, 34);
            this.programTitleButtonsPanel.TabIndex = 0;
            // 
            // buttonMinimaze
            // 
            this.buttonMinimaze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.buttonMinimaze.FlatAppearance.BorderSize = 0;
            this.buttonMinimaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonMinimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.buttonMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimaze.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinimaze.ForeColor = System.Drawing.Color.White;
            this.buttonMinimaze.Location = new System.Drawing.Point(3, 3);
            this.buttonMinimaze.Name = "buttonMinimaze";
            this.buttonMinimaze.Size = new System.Drawing.Size(28, 28);
            this.buttonMinimaze.TabIndex = 0;
            this.buttonMinimaze.TabStop = false;
            this.buttonMinimaze.Text = "_";
            this.buttonMinimaze.UseVisualStyleBackColor = false;
            this.buttonMinimaze.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(37, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(28, 28);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // programBodyPanel
            // 
            this.programBodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.programBodyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.programBodyPanel.Controls.Add(this.groupBox1);
            this.programBodyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.programBodyPanel.Location = new System.Drawing.Point(0, 36);
            this.programBodyPanel.Name = "programBodyPanel";
            this.programBodyPanel.Size = new System.Drawing.Size(750, 355);
            this.programBodyPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 440);
            this.Controls.Add(this.programBodyPanel);
            this.Controls.Add(this.programTitlePanel);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptic Directory";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.programTitlePanel.ResumeLayout(false);
            this.programTitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programTitleIcon)).EndInit();
            this.programTitleButtonsPanel.ResumeLayout(false);
            this.programBodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel programTitlePanel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimaze;
        private System.Windows.Forms.Panel programBodyPanel;
        private System.Windows.Forms.FlowLayoutPanel programTitleButtonsPanel;
        private System.Windows.Forms.Label programTitleLabel;
        private System.Windows.Forms.PictureBox programTitleIcon;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

