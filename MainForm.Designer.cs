namespace ColorPickerFor77ro
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.PickColorBtn = new System.Windows.Forms.Button();
            this.MousePosTitle = new System.Windows.Forms.Label();
            this.MousePosValue = new System.Windows.Forms.Label();
            this.DebugLabel = new System.Windows.Forms.Label();
            this.PickedColorPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HSV_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PickColorBtn
            // 
            this.PickColorBtn.Location = new System.Drawing.Point(12, 12);
            this.PickColorBtn.Name = "PickColorBtn";
            this.PickColorBtn.Size = new System.Drawing.Size(150, 150);
            this.PickColorBtn.TabIndex = 0;
            this.PickColorBtn.Text = "PickColor";
            this.PickColorBtn.UseVisualStyleBackColor = true;
            this.PickColorBtn.Click += new System.EventHandler(this.PickColorBtn_Click);
            // 
            // MousePosTitle
            // 
            this.MousePosTitle.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MousePosTitle.Location = new System.Drawing.Point(12, 178);
            this.MousePosTitle.Name = "MousePosTitle";
            this.MousePosTitle.Size = new System.Drawing.Size(150, 25);
            this.MousePosTitle.TabIndex = 1;
            this.MousePosTitle.Text = "마우스 위치";
            // 
            // MousePosValue
            // 
            this.MousePosValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MousePosValue.Location = new System.Drawing.Point(168, 178);
            this.MousePosValue.Name = "MousePosValue";
            this.MousePosValue.Size = new System.Drawing.Size(150, 25);
            this.MousePosValue.TabIndex = 2;
            this.MousePosValue.Text = "(0,0)";
            this.MousePosValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(9, 391);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(18, 18);
            this.DebugLabel.TabIndex = 3;
            this.DebugLabel.Text = "0";
            // 
            // PickedColorPanel
            // 
            this.PickedColorPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PickedColorPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PickedColorPanel.Location = new System.Drawing.Point(168, 12);
            this.PickedColorPanel.Name = "PickedColorPanel";
            this.PickedColorPanel.Size = new System.Drawing.Size(150, 150);
            this.PickedColorPanel.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 28);
            this.textBox1.TabIndex = 5;
            // 
            // HSV_Title
            // 
            this.HSV_Title.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HSV_Title.Location = new System.Drawing.Point(12, 219);
            this.HSV_Title.Name = "HSV_Title";
            this.HSV_Title.Size = new System.Drawing.Size(150, 25);
            this.HSV_Title.TabIndex = 6;
            this.HSV_Title.Text = "Hex 코드";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(651, 418);
            this.Controls.Add(this.HSV_Title);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PickedColorPanel);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.MousePosValue);
            this.Controls.Add(this.MousePosTitle);
            this.Controls.Add(this.PickColorBtn);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "깡지\'s Color Picker";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PickColorBtn;
        private System.Windows.Forms.Label MousePosTitle;
        private System.Windows.Forms.Label MousePosValue;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.Panel PickedColorPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label HSV_Title;
    }
}

