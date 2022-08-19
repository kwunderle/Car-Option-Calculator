
namespace UIControlsAndMultiLine_KatharineWunderle
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
            this.chooseCarGrpBx = new System.Windows.Forms.GroupBox();
            this.car1Rad = new System.Windows.Forms.RadioButton();
            this.car2Rad = new System.Windows.Forms.RadioButton();
            this.chooseOptGrpBx = new System.Windows.Forms.GroupBox();
            this.opt1Chk = new System.Windows.Forms.CheckBox();
            this.opt2Chk = new System.Windows.Forms.CheckBox();
            this.opt3Chk = new System.Windows.Forms.CheckBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.ttlCstLbl = new System.Windows.Forms.Label();
            this.ttlCstOtpt = new System.Windows.Forms.Label();
            this.ordrLbl = new System.Windows.Forms.Label();
            this.ordrOtpt = new System.Windows.Forms.Label();
            this.descipLbl = new System.Windows.Forms.Label();
            this.chooseCarGrpBx.SuspendLayout();
            this.chooseOptGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseCarGrpBx
            // 
            this.chooseCarGrpBx.Controls.Add(this.car2Rad);
            this.chooseCarGrpBx.Controls.Add(this.car1Rad);
            this.chooseCarGrpBx.Location = new System.Drawing.Point(12, 46);
            this.chooseCarGrpBx.Name = "chooseCarGrpBx";
            this.chooseCarGrpBx.Size = new System.Drawing.Size(215, 67);
            this.chooseCarGrpBx.TabIndex = 0;
            this.chooseCarGrpBx.TabStop = false;
            this.chooseCarGrpBx.Text = "Choose One Car To Buy";
            // 
            // car1Rad
            // 
            this.car1Rad.AutoSize = true;
            this.car1Rad.Location = new System.Drawing.Point(36, 19);
            this.car1Rad.Name = "car1Rad";
            this.car1Rad.Size = new System.Drawing.Size(139, 17);
            this.car1Rad.TabIndex = 0;
            this.car1Rad.Text = "2015 Kia Soul ($10,000)";
            this.car1Rad.UseVisualStyleBackColor = true;
            // 
            // car2Rad
            // 
            this.car2Rad.AutoSize = true;
            this.car2Rad.Location = new System.Drawing.Point(36, 42);
            this.car2Rad.Name = "car2Rad";
            this.car2Rad.Size = new System.Drawing.Size(142, 17);
            this.car2Rad.TabIndex = 1;
            this.car2Rad.Text = "2020 Kia Forte ($18,000)";
            this.car2Rad.UseVisualStyleBackColor = true;
            // 
            // chooseOptGrpBx
            // 
            this.chooseOptGrpBx.Controls.Add(this.opt3Chk);
            this.chooseOptGrpBx.Controls.Add(this.opt2Chk);
            this.chooseOptGrpBx.Controls.Add(this.opt1Chk);
            this.chooseOptGrpBx.Location = new System.Drawing.Point(12, 119);
            this.chooseOptGrpBx.Name = "chooseOptGrpBx";
            this.chooseOptGrpBx.Size = new System.Drawing.Size(215, 88);
            this.chooseOptGrpBx.TabIndex = 1;
            this.chooseOptGrpBx.TabStop = false;
            this.chooseOptGrpBx.Text = "Choose One or More Optional Features";
            // 
            // opt1Chk
            // 
            this.opt1Chk.AutoSize = true;
            this.opt1Chk.Location = new System.Drawing.Point(36, 19);
            this.opt1Chk.Name = "opt1Chk";
            this.opt1Chk.Size = new System.Drawing.Size(147, 17);
            this.opt1Chk.TabIndex = 0;
            this.opt1Chk.Text = "Rear View Camera ($500)";
            this.opt1Chk.UseVisualStyleBackColor = true;
            // 
            // opt2Chk
            // 
            this.opt2Chk.AutoSize = true;
            this.opt2Chk.Location = new System.Drawing.Point(36, 42);
            this.opt2Chk.Name = "opt2Chk";
            this.opt2Chk.Size = new System.Drawing.Size(166, 17);
            this.opt2Chk.TabIndex = 1;
            this.opt2Chk.Text = "Stow and Go Seating ($1000)";
            this.opt2Chk.UseVisualStyleBackColor = true;
            // 
            // opt3Chk
            // 
            this.opt3Chk.AutoSize = true;
            this.opt3Chk.Location = new System.Drawing.Point(36, 65);
            this.opt3Chk.Name = "opt3Chk";
            this.opt3Chk.Size = new System.Drawing.Size(138, 17);
            this.opt3Chk.TabIndex = 2;
            this.opt3Chk.Text = "All Wheel Drive ($2000)";
            this.opt3Chk.UseVisualStyleBackColor = true;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(276, 46);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(416, 46);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 3;
            this.clrBtn.Text = "Clear All";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // ttlCstLbl
            // 
            this.ttlCstLbl.AutoSize = true;
            this.ttlCstLbl.Location = new System.Drawing.Point(235, 85);
            this.ttlCstLbl.Name = "ttlCstLbl";
            this.ttlCstLbl.Size = new System.Drawing.Size(155, 13);
            this.ttlCstLbl.TabIndex = 4;
            this.ttlCstLbl.Text = "Total Cost of Car and Options $";
            // 
            // ttlCstOtpt
            // 
            this.ttlCstOtpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttlCstOtpt.Location = new System.Drawing.Point(391, 80);
            this.ttlCstOtpt.Name = "ttlCstOtpt";
            this.ttlCstOtpt.Size = new System.Drawing.Size(100, 23);
            this.ttlCstOtpt.TabIndex = 5;
            this.ttlCstOtpt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ordrLbl
            // 
            this.ordrLbl.AutoSize = true;
            this.ordrLbl.Location = new System.Drawing.Point(235, 119);
            this.ordrLbl.Name = "ordrLbl";
            this.ordrLbl.Size = new System.Drawing.Size(94, 13);
            this.ordrLbl.TabIndex = 6;
            this.ordrLbl.Text = "What you Ordered";
            // 
            // ordrOtpt
            // 
            this.ordrOtpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ordrOtpt.Location = new System.Drawing.Point(238, 138);
            this.ordrOtpt.Name = "ordrOtpt";
            this.ordrOtpt.Size = new System.Drawing.Size(253, 69);
            this.ordrOtpt.TabIndex = 7;
            // 
            // descipLbl
            // 
            this.descipLbl.AutoSize = true;
            this.descipLbl.Location = new System.Drawing.Point(12, 19);
            this.descipLbl.Name = "descipLbl";
            this.descipLbl.Size = new System.Drawing.Size(541, 13);
            this.descipLbl.TabIndex = 8;
            this.descipLbl.Text = "The Form will show the Total Cost of selected Car and options. It will also displ" +
    "ay text descibing what was chosen.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 220);
            this.Controls.Add(this.descipLbl);
            this.Controls.Add(this.ordrOtpt);
            this.Controls.Add(this.ordrLbl);
            this.Controls.Add(this.ttlCstOtpt);
            this.Controls.Add(this.ttlCstLbl);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.chooseOptGrpBx);
            this.Controls.Add(this.chooseCarGrpBx);
            this.Name = "Form1";
            this.Text = "User Interface Controls";
            this.chooseCarGrpBx.ResumeLayout(false);
            this.chooseCarGrpBx.PerformLayout();
            this.chooseOptGrpBx.ResumeLayout(false);
            this.chooseOptGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox chooseCarGrpBx;
        private System.Windows.Forms.RadioButton car2Rad;
        private System.Windows.Forms.RadioButton car1Rad;
        private System.Windows.Forms.GroupBox chooseOptGrpBx;
        private System.Windows.Forms.CheckBox opt3Chk;
        private System.Windows.Forms.CheckBox opt2Chk;
        private System.Windows.Forms.CheckBox opt1Chk;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Label ttlCstLbl;
        private System.Windows.Forms.Label ttlCstOtpt;
        private System.Windows.Forms.Label ordrLbl;
        private System.Windows.Forms.Label ordrOtpt;
        private System.Windows.Forms.Label descipLbl;
    }
}

