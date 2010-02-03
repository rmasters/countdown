namespace Remote_Countdown
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.dataUrlTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.targetDateLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remTimeLbl = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataUrlTxt
            // 
            this.dataUrlTxt.Location = new System.Drawing.Point(100, 9);
            this.dataUrlTxt.Name = "dataUrlTxt";
            this.dataUrlTxt.Size = new System.Drawing.Size(182, 20);
            this.dataUrlTxt.TabIndex = 0;
            this.dataUrlTxt.Text = "http://github.com/rmasters/countdown/raw/master/data/date";
            this.dataUrlTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lookupUrl);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Load data from:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target Date:";
            // 
            // targetDateLbl
            // 
            this.targetDateLbl.AutoSize = true;
            this.targetDateLbl.Location = new System.Drawing.Point(100, 78);
            this.targetDateLbl.Name = "targetDateLbl";
            this.targetDateLbl.Size = new System.Drawing.Size(64, 13);
            this.targetDateLbl.TabIndex = 3;
            this.targetDateLbl.Text = "Target Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remaining Time:";
            // 
            // remTimeLbl
            // 
            this.remTimeLbl.AutoSize = true;
            this.remTimeLbl.Location = new System.Drawing.Point(100, 100);
            this.remTimeLbl.Name = "remTimeLbl";
            this.remTimeLbl.Size = new System.Drawing.Size(83, 13);
            this.remTimeLbl.TabIndex = 5;
            this.remTimeLbl.Text = "Remaining Time";
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(288, 7);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 6;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.lookupUrl);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(375, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 262);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.remTimeLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.targetDateLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataUrlTxt);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataUrlTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label targetDateLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label remTimeLbl;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

