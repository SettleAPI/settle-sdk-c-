namespace POSDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randomizePosTidButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.currencyTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.posTidTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateStatusButton = new System.Windows.Forms.Button();
            this.tidLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.captureButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.abortButton = new System.Windows.Forms.Button();
            this.getScanButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getScanButton);
            this.groupBox1.Controls.Add(this.randomizePosTidButton);
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.currencyTextBox);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Controls.Add(this.posTidTextBox);
            this.groupBox1.Controls.Add(this.customerTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Payment Request";
            // 
            // randomizePosTidButton
            // 
            this.randomizePosTidButton.Location = new System.Drawing.Point(225, 39);
            this.randomizePosTidButton.Name = "randomizePosTidButton";
            this.randomizePosTidButton.Size = new System.Drawing.Size(59, 23);
            this.randomizePosTidButton.TabIndex = 9;
            this.randomizePosTidButton.Text = "rand";
            this.randomizePosTidButton.UseVisualStyleBackColor = true;
            this.randomizePosTidButton.Click += new System.EventHandler(this.randomizePosTidButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(119, 116);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(100, 23);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.Location = new System.Drawing.Point(119, 90);
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.currencyTextBox.TabIndex = 7;
            this.currencyTextBox.Text = "NOK";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(119, 65);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 6;
            this.amountTextBox.Text = "100.00";
            // 
            // posTidTextBox
            // 
            this.posTidTextBox.Location = new System.Drawing.Point(119, 41);
            this.posTidTextBox.Name = "posTidTextBox";
            this.posTidTextBox.Size = new System.Drawing.Size(100, 20);
            this.posTidTextBox.TabIndex = 5;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(119, 17);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local transaction ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusLabel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.updateStatusButton);
            this.groupBox2.Controls.Add(this.tidLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Status";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(116, 43);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(27, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Status";
            // 
            // updateStatusButton
            // 
            this.updateStatusButton.Location = new System.Drawing.Point(119, 71);
            this.updateStatusButton.Name = "updateStatusButton";
            this.updateStatusButton.Size = new System.Drawing.Size(100, 23);
            this.updateStatusButton.TabIndex = 2;
            this.updateStatusButton.Text = "Refresh";
            this.updateStatusButton.UseVisualStyleBackColor = true;
            this.updateStatusButton.Click += new System.EventHandler(this.updateStatusButton_Click);
            // 
            // tidLabel
            // 
            this.tidLabel.AutoSize = true;
            this.tidLabel.Location = new System.Drawing.Point(116, 20);
            this.tidLabel.Name = "tidLabel";
            this.tidLabel.Size = new System.Drawing.Size(27, 13);
            this.tidLabel.TabIndex = 1;
            this.tidLabel.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Global transaction ID:";
            // 
            // captureButton
            // 
            this.captureButton.Enabled = false;
            this.captureButton.Location = new System.Drawing.Point(10, 33);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(100, 23);
            this.captureButton.TabIndex = 5;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.abortButton);
            this.groupBox3.Controls.Add(this.captureButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // abortButton
            // 
            this.abortButton.Enabled = false;
            this.abortButton.Location = new System.Drawing.Point(119, 33);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(100, 23);
            this.abortButton.TabIndex = 6;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // getScanButton
            // 
            this.getScanButton.Location = new System.Drawing.Point(225, 17);
            this.getScanButton.Name = "getScanButton";
            this.getScanButton.Size = new System.Drawing.Size(59, 20);
            this.getScanButton.TabIndex = 10;
            this.getScanButton.Text = "Get scan";
            this.getScanButton.UseVisualStyleBackColor = true;
            this.getScanButton.Click += new System.EventHandler(this.getScanButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 419);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox currencyTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox posTidTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updateStatusButton;
        private System.Windows.Forms.Label tidLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button randomizePosTidButton;
        private System.Windows.Forms.Button getScanButton;
    }
}

