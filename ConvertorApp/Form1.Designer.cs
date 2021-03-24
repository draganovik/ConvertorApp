
namespace ConvertorApp
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.tbxValueInput = new System.Windows.Forms.TextBox();
            this.tbxValueOutput = new System.Windows.Forms.TextBox();
            this.lbConvertFrom = new System.Windows.Forms.Label();
            this.lbConvertTo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTypeCustomMoney = new System.Windows.Forms.RadioButton();
            this.rbtnTypeTime = new System.Windows.Forms.RadioButton();
            this.rbtnTypeMoney = new System.Windows.Forms.RadioButton();
            this.rbtnTypeLength = new System.Windows.Forms.RadioButton();
            this.rbtnTypeMass = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grbxTime = new System.Windows.Forms.GroupBox();
            this.rbtnTimeSeconds = new System.Windows.Forms.RadioButton();
            this.rbtnTimeMinutes = new System.Windows.Forms.RadioButton();
            this.rbtnTimeHours = new System.Windows.Forms.RadioButton();
            this.grbxSegment = new System.Windows.Forms.GroupBox();
            this.rbtnSegmentMultiple = new System.Windows.Forms.RadioButton();
            this.rbtnSegmentSingle = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grbxTime.SuspendLayout();
            this.grbxSegment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(552, 492);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(150, 46);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // tbxValueInput
            // 
            this.tbxValueInput.Location = new System.Drawing.Point(434, 364);
            this.tbxValueInput.Name = "tbxValueInput";
            this.tbxValueInput.Size = new System.Drawing.Size(267, 39);
            this.tbxValueInput.TabIndex = 1;
            // 
            // tbxValueOutput
            // 
            this.tbxValueOutput.Location = new System.Drawing.Point(434, 424);
            this.tbxValueOutput.Name = "tbxValueOutput";
            this.tbxValueOutput.ReadOnly = true;
            this.tbxValueOutput.Size = new System.Drawing.Size(267, 39);
            this.tbxValueOutput.TabIndex = 2;
            // 
            // lbConvertFrom
            // 
            this.lbConvertFrom.AutoSize = true;
            this.lbConvertFrom.Location = new System.Drawing.Point(27, 367);
            this.lbConvertFrom.Name = "lbConvertFrom";
            this.lbConvertFrom.Size = new System.Drawing.Size(92, 32);
            this.lbConvertFrom.TabIndex = 3;
            this.lbConvertFrom.Text = "Value 1";
            // 
            // lbConvertTo
            // 
            this.lbConvertTo.AutoSize = true;
            this.lbConvertTo.Location = new System.Drawing.Point(27, 428);
            this.lbConvertTo.Name = "lbConvertTo";
            this.lbConvertTo.Size = new System.Drawing.Size(92, 32);
            this.lbConvertTo.TabIndex = 4;
            this.lbConvertTo.Text = "Value 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTypeCustomMoney);
            this.groupBox1.Controls.Add(this.rbtnTypeTime);
            this.groupBox1.Controls.Add(this.rbtnTypeMoney);
            this.groupBox1.Controls.Add(this.rbtnTypeLength);
            this.groupBox1.Controls.Add(this.rbtnTypeMass);
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 239);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter type";
            // 
            // rbtnTypeCustomMoney
            // 
            this.rbtnTypeCustomMoney.AutoSize = true;
            this.rbtnTypeCustomMoney.Location = new System.Drawing.Point(205, 113);
            this.rbtnTypeCustomMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTypeCustomMoney.Name = "rbtnTypeCustomMoney";
            this.rbtnTypeCustomMoney.Size = new System.Drawing.Size(209, 36);
            this.rbtnTypeCustomMoney.TabIndex = 4;
            this.rbtnTypeCustomMoney.TabStop = true;
            this.rbtnTypeCustomMoney.Text = "Custom Money";
            this.rbtnTypeCustomMoney.UseVisualStyleBackColor = true;
            this.rbtnTypeCustomMoney.CheckedChanged += new System.EventHandler(this.TypeCheckedChanged);
            // 
            // rbtnTypeTime
            // 
            this.rbtnTypeTime.AutoSize = true;
            this.rbtnTypeTime.Location = new System.Drawing.Point(32, 174);
            this.rbtnTypeTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTypeTime.Name = "rbtnTypeTime";
            this.rbtnTypeTime.Size = new System.Drawing.Size(98, 36);
            this.rbtnTypeTime.TabIndex = 3;
            this.rbtnTypeTime.TabStop = true;
            this.rbtnTypeTime.Text = "Time";
            this.rbtnTypeTime.UseVisualStyleBackColor = true;
            this.rbtnTypeTime.CheckedChanged += new System.EventHandler(this.TypeCheckedChanged);
            // 
            // rbtnTypeMoney
            // 
            this.rbtnTypeMoney.AutoSize = true;
            this.rbtnTypeMoney.Location = new System.Drawing.Point(205, 54);
            this.rbtnTypeMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTypeMoney.Name = "rbtnTypeMoney";
            this.rbtnTypeMoney.Size = new System.Drawing.Size(120, 36);
            this.rbtnTypeMoney.TabIndex = 2;
            this.rbtnTypeMoney.TabStop = true;
            this.rbtnTypeMoney.Text = "Money";
            this.rbtnTypeMoney.UseVisualStyleBackColor = true;
            this.rbtnTypeMoney.CheckedChanged += new System.EventHandler(this.TypeCheckedChanged);
            // 
            // rbtnTypeLength
            // 
            this.rbtnTypeLength.AutoSize = true;
            this.rbtnTypeLength.Location = new System.Drawing.Point(32, 113);
            this.rbtnTypeLength.Name = "rbtnTypeLength";
            this.rbtnTypeLength.Size = new System.Drawing.Size(119, 36);
            this.rbtnTypeLength.TabIndex = 1;
            this.rbtnTypeLength.TabStop = true;
            this.rbtnTypeLength.Text = "Length";
            this.rbtnTypeLength.UseVisualStyleBackColor = true;
            this.rbtnTypeLength.CheckedChanged += new System.EventHandler(this.TypeCheckedChanged);
            // 
            // rbtnTypeMass
            // 
            this.rbtnTypeMass.AutoSize = true;
            this.rbtnTypeMass.Checked = true;
            this.rbtnTypeMass.Location = new System.Drawing.Point(32, 54);
            this.rbtnTypeMass.Name = "rbtnTypeMass";
            this.rbtnTypeMass.Size = new System.Drawing.Size(99, 36);
            this.rbtnTypeMass.TabIndex = 0;
            this.rbtnTypeMass.TabStop = true;
            this.rbtnTypeMass.Text = "Mass";
            this.rbtnTypeMass.UseVisualStyleBackColor = true;
            this.rbtnTypeMass.CheckedChanged += new System.EventHandler(this.TypeCheckedChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(30, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1040, 3);
            this.label1.TabIndex = 6;
            // 
            // grbxTime
            // 
            this.grbxTime.Controls.Add(this.rbtnTimeSeconds);
            this.grbxTime.Controls.Add(this.rbtnTimeMinutes);
            this.grbxTime.Controls.Add(this.rbtnTimeHours);
            this.grbxTime.Location = new System.Drawing.Point(489, 26);
            this.grbxTime.Name = "grbxTime";
            this.grbxTime.Size = new System.Drawing.Size(213, 239);
            this.grbxTime.TabIndex = 6;
            this.grbxTime.TabStop = false;
            this.grbxTime.Text = "Time output";
            this.grbxTime.Visible = false;
            // 
            // rbtnTimeSeconds
            // 
            this.rbtnTimeSeconds.AutoSize = true;
            this.rbtnTimeSeconds.Location = new System.Drawing.Point(31, 173);
            this.rbtnTimeSeconds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTimeSeconds.Name = "rbtnTimeSeconds";
            this.rbtnTimeSeconds.Size = new System.Drawing.Size(134, 36);
            this.rbtnTimeSeconds.TabIndex = 3;
            this.rbtnTimeSeconds.TabStop = true;
            this.rbtnTimeSeconds.Text = "Seconds";
            this.rbtnTimeSeconds.UseVisualStyleBackColor = true;
            this.rbtnTimeSeconds.CheckedChanged += new System.EventHandler(this.TimeCheckedChanged);
            // 
            // rbtnTimeMinutes
            // 
            this.rbtnTimeMinutes.AutoSize = true;
            this.rbtnTimeMinutes.Location = new System.Drawing.Point(31, 111);
            this.rbtnTimeMinutes.Name = "rbtnTimeMinutes";
            this.rbtnTimeMinutes.Size = new System.Drawing.Size(132, 36);
            this.rbtnTimeMinutes.TabIndex = 1;
            this.rbtnTimeMinutes.TabStop = true;
            this.rbtnTimeMinutes.Text = "Minutes";
            this.rbtnTimeMinutes.UseVisualStyleBackColor = true;
            this.rbtnTimeMinutes.CheckedChanged += new System.EventHandler(this.TimeCheckedChanged);
            // 
            // rbtnTimeHours
            // 
            this.rbtnTimeHours.AutoSize = true;
            this.rbtnTimeHours.Checked = true;
            this.rbtnTimeHours.Location = new System.Drawing.Point(31, 52);
            this.rbtnTimeHours.Name = "rbtnTimeHours";
            this.rbtnTimeHours.Size = new System.Drawing.Size(108, 36);
            this.rbtnTimeHours.TabIndex = 0;
            this.rbtnTimeHours.TabStop = true;
            this.rbtnTimeHours.Text = "Hours";
            this.rbtnTimeHours.UseVisualStyleBackColor = true;
            this.rbtnTimeHours.CheckedChanged += new System.EventHandler(this.TimeCheckedChanged);
            // 
            // grbxSegment
            // 
            this.grbxSegment.Controls.Add(this.rbtnSegmentMultiple);
            this.grbxSegment.Controls.Add(this.rbtnSegmentSingle);
            this.grbxSegment.Location = new System.Drawing.Point(729, 26);
            this.grbxSegment.Name = "grbxSegment";
            this.grbxSegment.Size = new System.Drawing.Size(341, 239);
            this.grbxSegment.TabIndex = 7;
            this.grbxSegment.TabStop = false;
            this.grbxSegment.Text = "Segment type";
            this.grbxSegment.Visible = false;
            // 
            // rbtnSegmentMultiple
            // 
            this.rbtnSegmentMultiple.AutoSize = true;
            this.rbtnSegmentMultiple.Location = new System.Drawing.Point(30, 110);
            this.rbtnSegmentMultiple.Name = "rbtnSegmentMultiple";
            this.rbtnSegmentMultiple.Size = new System.Drawing.Size(208, 36);
            this.rbtnSegmentMultiple.TabIndex = 1;
            this.rbtnSegmentMultiple.TabStop = true;
            this.rbtnSegmentMultiple.Text = "Multiple values";
            this.rbtnSegmentMultiple.UseVisualStyleBackColor = true;
            // 
            // rbtnSegmentSingle
            // 
            this.rbtnSegmentSingle.AutoSize = true;
            this.rbtnSegmentSingle.Checked = true;
            this.rbtnSegmentSingle.Location = new System.Drawing.Point(30, 51);
            this.rbtnSegmentSingle.Name = "rbtnSegmentSingle";
            this.rbtnSegmentSingle.Size = new System.Drawing.Size(175, 36);
            this.rbtnSegmentSingle.TabIndex = 0;
            this.rbtnSegmentSingle.TabStop = true;
            this.rbtnSegmentSingle.Text = "Single value";
            this.rbtnSegmentSingle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 689);
            this.Controls.Add(this.grbxSegment);
            this.Controls.Add(this.grbxTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbConvertTo);
            this.Controls.Add(this.lbConvertFrom);
            this.Controls.Add(this.tbxValueOutput);
            this.Controls.Add(this.tbxValueInput);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "Convertor App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbxTime.ResumeLayout(false);
            this.grbxTime.PerformLayout();
            this.grbxSegment.ResumeLayout(false);
            this.grbxSegment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox tbxValueInput;
        private System.Windows.Forms.TextBox tbxValueOutput;
        private System.Windows.Forms.Label lbConvertFrom;
        private System.Windows.Forms.Label lbConvertTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnTypeLength;
        private System.Windows.Forms.RadioButton rbtnTypeMass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnTypeCustomMoney;
        private System.Windows.Forms.RadioButton rbtnTypeTime;
        private System.Windows.Forms.RadioButton rbtnTypeMoney;
        private System.Windows.Forms.GroupBox grbxTime;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rbtnTimeHours;
        private System.Windows.Forms.RadioButton rbtnTimeMonutes;
        private System.Windows.Forms.RadioButton rbtnTimeMinutes;
        private System.Windows.Forms.RadioButton rbtnTimeSeconds;
        private System.Windows.Forms.GroupBox grbxSegment;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtnSegmentSingle;
        private System.Windows.Forms.RadioButton rbtnSegmentMultiple;
    }
}

