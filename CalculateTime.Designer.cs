using System.Reflection;


namespace CalculateTime
{
    partial class CalculateTime
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
            this.lOutput = new System.Windows.Forms.Label();
            this.lInput = new System.Windows.Forms.Label();
            this.inputSeconds = new System.Windows.Forms.TextBox();
            this.outputTime = new System.Windows.Forms.TextBox();
            this.copyright = new System.Windows.Forms.Label();
            this.useFullTime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Location = new System.Drawing.Point(70, 65);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(44, 13);
            this.lOutput.TabIndex = 4;
            this.lOutput.Text = "Kết quả";
            // 
            // lInput
            // 
            this.lInput.AutoSize = true;
            this.lInput.Location = new System.Drawing.Point(70, 23);
            this.lInput.Name = "lInput";
            this.lInput.Size = new System.Drawing.Size(69, 13);
            this.lInput.TabIndex = 5;
            this.lInput.Text = "Nhập số giây";
            // 
            // inputSeconds
            // 
            this.inputSeconds.Location = new System.Drawing.Point(147, 16);
            this.inputSeconds.Name = "inputSeconds";
            this.inputSeconds.Size = new System.Drawing.Size(246, 20);
            this.inputSeconds.TabIndex = 0;
            this.inputSeconds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputSeconds_KeyDown);
            // 
            // outputTime
            // 
            this.outputTime.Location = new System.Drawing.Point(147, 58);
            this.outputTime.Name = "outputTime";
            this.outputTime.ReadOnly = true;
            this.outputTime.Size = new System.Drawing.Size(246, 20);
            this.outputTime.TabIndex = 4;
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Location = new System.Drawing.Point(173, 143);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(104, 13);
            this.copyright.TabIndex = 6;
            this.copyright.Text = "© 2023 MeewMeew";
            // 
            // useFullTime
            // 
            this.useFullTime.AutoSize = true;
            this.useFullTime.Location = new System.Drawing.Point(73, 98);
            this.useFullTime.Name = "useFullTime";
            this.useFullTime.Size = new System.Drawing.Size(127, 17);
            this.useFullTime.TabIndex = 2;
            this.useFullTime.Text = "Kết quả dạng đầy đủ";
            this.useFullTime.UseVisualStyleBackColor = true;
            this.useFullTime.CheckedChanged += new System.EventHandler(this.UseFullTime_CheckedChanged);
            // 
            // CalculateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 165);
            this.Controls.Add(this.useFullTime);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.outputTime);
            this.Controls.Add(this.inputSeconds);
            this.Controls.Add(this.lInput);
            this.Controls.Add(this.lOutput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculateTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy chuyển đổi thời gian";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Icon = new System.Drawing.Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream("CalculateTime.favicon.ico"));
        }
        #endregion
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.Label lInput;
        private System.Windows.Forms.TextBox inputSeconds;
        private System.Windows.Forms.TextBox outputTime;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.CheckBox useFullTime;
    }
}

