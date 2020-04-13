namespace BMICalculator
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
            this.txtbxHeight = new System.Windows.Forms.TextBox();
            this.txtbxWeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxHeight
            // 
            this.txtbxHeight.Location = new System.Drawing.Point(207, 150);
            this.txtbxHeight.Name = "txtbxHeight";
            this.txtbxHeight.Size = new System.Drawing.Size(128, 22);
            this.txtbxHeight.TabIndex = 0;
            // 
            // txtbxWeight
            // 
            this.txtbxWeight.Location = new System.Drawing.Point(430, 150);
            this.txtbxWeight.Name = "txtbxWeight";
            this.txtbxWeight.Size = new System.Drawing.Size(128, 22);
            this.txtbxWeight.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(224, 130);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(102, 17);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height(metres)";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(460, 130);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(77, 17);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight(kg)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(259, 227);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(239, 48);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(324, 309);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(121, 29);
            this.lblBMI.TabIndex = 5;
            this.lblBMI.Text = "BMI score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtbxWeight);
            this.Controls.Add(this.txtbxHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxHeight;
        private System.Windows.Forms.TextBox txtbxWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.Label lblBMI;
    }
}
