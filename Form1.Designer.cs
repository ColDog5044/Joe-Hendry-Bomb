namespace JoeHendryRoll
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
            components = new System.ComponentModel.Container();
            LabelSayHisName = new Label();
            TimerClose = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LabelSayHisName
            // 
            LabelSayHisName.Anchor = AnchorStyles.None;
            LabelSayHisName.AutoSize = true;
            LabelSayHisName.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelSayHisName.Location = new Point(22, 45);
            LabelSayHisName.Name = "LabelSayHisName";
            LabelSayHisName.Size = new Size(457, 35);
            LabelSayHisName.TabIndex = 0;
            LabelSayHisName.Text = "Say his name and he appears...";
            LabelSayHisName.Click += label1_Click;
            // 
            // TimerClose
            // 
            TimerClose.Enabled = true;
            TimerClose.Interval = 5000;
            TimerClose.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 133);
            ControlBox = false;
            Controls.Add(LabelSayHisName);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Joe Hendry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelSayHisName;
        private System.Windows.Forms.Timer TimerClose;
    }
}
