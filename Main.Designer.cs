namespace CustomPINSample
{
    partial class Main
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
            this.txtActivateKeys = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.checkR4 = new System.Windows.Forms.CheckBox();
            this.checkR3 = new System.Windows.Forms.CheckBox();
            this.checkR2 = new System.Windows.Forms.CheckBox();
            this.checkR1 = new System.Windows.Forms.CheckBox();
            this.checkL4 = new System.Windows.Forms.CheckBox();
            this.checkL3 = new System.Windows.Forms.CheckBox();
            this.checkL2 = new System.Windows.Forms.CheckBox();
            this.checkL1 = new System.Windows.Forms.CheckBox();
            this.btnStartInput = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtActivateKeys
            // 
            this.txtActivateKeys.Location = new System.Drawing.Point(137, 42);
            this.txtActivateKeys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtActivateKeys.Name = "txtActivateKeys";
            this.txtActivateKeys.ReadOnly = true;
            this.txtActivateKeys.Size = new System.Drawing.Size(86, 28);
            this.txtActivateKeys.TabIndex = 39;
            this.txtActivateKeys.Text = "00000000";
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(137, 84);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(85, 42);
            this.btnActivate.TabIndex = 8;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(440, 72);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 42);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear History";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(264, 136);
            this.txtHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistory.Size = new System.Drawing.Size(335, 280);
            this.txtHistory.TabIndex = 36;
            // 
            // checkR4
            // 
            this.checkR4.Location = new System.Drawing.Point(65, 161);
            this.checkR4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkR4.Name = "checkR4";
            this.checkR4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkR4.Size = new System.Drawing.Size(52, 28);
            this.checkR4.TabIndex = 7;
            this.checkR4.Text = "R4";
            this.checkR4.UseVisualStyleBackColor = true;
            this.checkR4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkR3
            // 
            this.checkR3.Location = new System.Drawing.Point(65, 119);
            this.checkR3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkR3.Name = "checkR3";
            this.checkR3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkR3.Size = new System.Drawing.Size(52, 28);
            this.checkR3.TabIndex = 6;
            this.checkR3.Text = "R3";
            this.checkR3.UseVisualStyleBackColor = true;
            this.checkR3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkR2
            // 
            this.checkR2.Location = new System.Drawing.Point(65, 77);
            this.checkR2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkR2.Name = "checkR2";
            this.checkR2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkR2.Size = new System.Drawing.Size(52, 28);
            this.checkR2.TabIndex = 5;
            this.checkR2.Text = "R2";
            this.checkR2.UseVisualStyleBackColor = true;
            this.checkR2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkR1
            // 
            this.checkR1.Location = new System.Drawing.Point(65, 35);
            this.checkR1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkR1.Name = "checkR1";
            this.checkR1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkR1.Size = new System.Drawing.Size(52, 28);
            this.checkR1.TabIndex = 4;
            this.checkR1.Text = "R1";
            this.checkR1.UseVisualStyleBackColor = true;
            this.checkR1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkL4
            // 
            this.checkL4.Location = new System.Drawing.Point(13, 161);
            this.checkL4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkL4.Name = "checkL4";
            this.checkL4.Size = new System.Drawing.Size(52, 28);
            this.checkL4.TabIndex = 3;
            this.checkL4.Text = "L4";
            this.checkL4.UseVisualStyleBackColor = true;
            this.checkL4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkL3
            // 
            this.checkL3.Location = new System.Drawing.Point(13, 119);
            this.checkL3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkL3.Name = "checkL3";
            this.checkL3.Size = new System.Drawing.Size(52, 28);
            this.checkL3.TabIndex = 2;
            this.checkL3.Text = "L3";
            this.checkL3.UseVisualStyleBackColor = true;
            this.checkL3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkL2
            // 
            this.checkL2.Location = new System.Drawing.Point(13, 77);
            this.checkL2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkL2.Name = "checkL2";
            this.checkL2.Size = new System.Drawing.Size(52, 28);
            this.checkL2.TabIndex = 1;
            this.checkL2.Text = "L2";
            this.checkL2.UseVisualStyleBackColor = true;
            this.checkL2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkL1
            // 
            this.checkL1.Location = new System.Drawing.Point(13, 35);
            this.checkL1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkL1.Name = "checkL1";
            this.checkL1.Size = new System.Drawing.Size(52, 28);
            this.checkL1.TabIndex = 0;
            this.checkL1.Text = "L1";
            this.checkL1.UseVisualStyleBackColor = true;
            this.checkL1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // btnStartInput
            // 
            this.btnStartInput.Location = new System.Drawing.Point(264, 72);
            this.btnStartInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartInput.Name = "btnStartInput";
            this.btnStartInput.Size = new System.Drawing.Size(164, 42);
            this.btnStartInput.TabIndex = 3;
            this.btnStartInput.Text = "StartInput";
            this.btnStartInput.UseVisualStyleBackColor = true;
            this.btnStartInput.Click += new System.EventHandler(this.btnStartInput_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(136, 72);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(16, 136);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(232, 42);
            this.btnStatus.TabIndex = 2;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(16, 72);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(111, 42);
            this.btnInitialize.TabIndex = 0;
            this.btnInitialize.Text = "Initialize";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Custom PIN Sample";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(600, 8);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActivate);
            this.groupBox2.Controls.Add(this.checkL1);
            this.groupBox2.Controls.Add(this.txtActivateKeys);
            this.groupBox2.Controls.Add(this.checkL2);
            this.groupBox2.Controls.Add(this.checkL3);
            this.groupBox2.Controls.Add(this.checkL4);
            this.groupBox2.Controls.Add(this.checkR1);
            this.groupBox2.Controls.Add(this.checkR4);
            this.groupBox2.Controls.Add(this.checkR2);
            this.groupBox2.Controls.Add(this.checkR3);
            this.groupBox2.Location = new System.Drawing.Point(16, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(236, 208);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FDK";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.btnStartInput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInitialize);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActivateKeys;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.CheckBox checkR4;
        private System.Windows.Forms.CheckBox checkR3;
        private System.Windows.Forms.CheckBox checkR2;
        private System.Windows.Forms.CheckBox checkR1;
        private System.Windows.Forms.CheckBox checkL4;
        private System.Windows.Forms.CheckBox checkL3;
        private System.Windows.Forms.CheckBox checkL2;
        private System.Windows.Forms.CheckBox checkL1;
        private System.Windows.Forms.Button btnStartInput;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

