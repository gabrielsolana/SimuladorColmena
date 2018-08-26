namespace SimuladorColmena
{
    partial class Form
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assignJobToABeeButton = new System.Windows.Forms.Button();
            this.shiftsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.workSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.nextShiftButton = new System.Windows.Forms.Button();
            this.reportTextBox = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.assignJobToABeeButton);
            this.groupBox.Controls.Add(this.shiftsNumericUpDown);
            this.groupBox.Controls.Add(this.workSelectorComboBox);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(25, 48);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(388, 141);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Worker Bee Assignments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shifts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job";
            // 
            // assignJobToABeeButton
            // 
            this.assignJobToABeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignJobToABeeButton.Location = new System.Drawing.Point(6, 85);
            this.assignJobToABeeButton.Name = "assignJobToABeeButton";
            this.assignJobToABeeButton.Size = new System.Drawing.Size(364, 32);
            this.assignJobToABeeButton.TabIndex = 2;
            this.assignJobToABeeButton.Text = "Assign this job to a bee";
            this.assignJobToABeeButton.UseVisualStyleBackColor = true;
            this.assignJobToABeeButton.Click += new System.EventHandler(this.assignJobToABeeButton_Click);
            // 
            // shiftsNumericUpDown
            // 
            this.shiftsNumericUpDown.Location = new System.Drawing.Point(250, 43);
            this.shiftsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.shiftsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shiftsNumericUpDown.Name = "shiftsNumericUpDown";
            this.shiftsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.shiftsNumericUpDown.TabIndex = 1;
            this.shiftsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // workSelectorComboBox
            // 
            this.workSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workSelectorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workSelectorComboBox.FormattingEnabled = true;
            this.workSelectorComboBox.Items.AddRange(new object[] {
            "Baby bee tutoring",
            "Egg care",
            "Hive maintenance",
            "Honey manufacturing",
            "Nectar collector",
            "Stin patrol"});
            this.workSelectorComboBox.Location = new System.Drawing.Point(6, 42);
            this.workSelectorComboBox.Name = "workSelectorComboBox";
            this.workSelectorComboBox.Size = new System.Drawing.Size(204, 24);
            this.workSelectorComboBox.TabIndex = 0;
            // 
            // nextShiftButton
            // 
            this.nextShiftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextShiftButton.Location = new System.Drawing.Point(437, 48);
            this.nextShiftButton.Name = "nextShiftButton";
            this.nextShiftButton.Size = new System.Drawing.Size(195, 141);
            this.nextShiftButton.TabIndex = 0;
            this.nextShiftButton.Text = "Work the next Shift";
            this.nextShiftButton.UseVisualStyleBackColor = true;
            this.nextShiftButton.Click += new System.EventHandler(this.nextShiftButton_Click);
            // 
            // reportTextBox
            // 
            this.reportTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportTextBox.Location = new System.Drawing.Point(25, 236);
            this.reportTextBox.Multiline = true;
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportTextBox.Size = new System.Drawing.Size(607, 173);
            this.reportTextBox.TabIndex = 1;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimuladorColmena.Properties.Resources.panal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.nextShiftButton);
            this.Controls.Add(this.groupBox);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Beehive Management System";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button assignJobToABeeButton;
        private System.Windows.Forms.NumericUpDown shiftsNumericUpDown;
        private System.Windows.Forms.ComboBox workSelectorComboBox;
        private System.Windows.Forms.Button nextShiftButton;
        private System.Windows.Forms.TextBox reportTextBox;
    }
}

