namespace TotalSalesApplication
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
            salesLabel = new Label();
            salesListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // salesLabel
            // 
            salesLabel.AutoSize = true;
            salesLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesLabel.Location = new Point(116, 9);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new Size(56, 25);
            salesLabel.TabIndex = 0;
            salesLabel.Text = "Sales";
            // 
            // salesListBox
            // 
            salesListBox.FormattingEnabled = true;
            salesListBox.ItemHeight = 15;
            salesListBox.Location = new Point(37, 59);
            salesListBox.Name = "salesListBox";
            salesListBox.Size = new Size(216, 94);
            salesListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 156);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 2;
            label1.Text = "Total";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(37, 197);
            label2.Name = "label2";
            label2.Size = new Size(216, 23);
            label2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 271);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(salesListBox);
            Controls.Add(salesLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label salesLabel;
        private ListBox salesListBox;
        private Label label1;
        private Label label2;
    }
}
