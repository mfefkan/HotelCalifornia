namespace Project.WinUI
{
    partial class Form3
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
            this.dtpEntry = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.lstRoomVisitors = new System.Windows.Forms.ListBox();
            this.btnAddVisitorInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstSelectedRooms = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpEntry
            // 
            this.dtpEntry.Location = new System.Drawing.Point(164, 216);
            this.dtpEntry.Name = "dtpEntry";
            this.dtpEntry.Size = new System.Drawing.Size(258, 22);
            this.dtpEntry.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(50, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Check In Date";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(362, 326);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 19;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // lstRoomVisitors
            // 
            this.lstRoomVisitors.FormattingEnabled = true;
            this.lstRoomVisitors.ItemHeight = 16;
            this.lstRoomVisitors.Location = new System.Drawing.Point(443, 143);
            this.lstRoomVisitors.Name = "lstRoomVisitors";
            this.lstRoomVisitors.Size = new System.Drawing.Size(308, 100);
            this.lstRoomVisitors.TabIndex = 18;
            // 
            // btnAddVisitorInfo
            // 
            this.btnAddVisitorInfo.Location = new System.Drawing.Point(280, 260);
            this.btnAddVisitorInfo.Name = "btnAddVisitorInfo";
            this.btnAddVisitorInfo.Size = new System.Drawing.Size(140, 23);
            this.btnAddVisitorInfo.TabIndex = 17;
            this.btnAddVisitorInfo.Text = "Add Visitor Info";
            this.btnAddVisitorInfo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(175, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(576, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Entry Visitor Info";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSelectedRooms
            // 
            this.lstSelectedRooms.FormattingEnabled = true;
            this.lstSelectedRooms.ItemHeight = 16;
            this.lstSelectedRooms.Location = new System.Drawing.Point(443, 249);
            this.lstSelectedRooms.Name = "lstSelectedRooms";
            this.lstSelectedRooms.Size = new System.Drawing.Size(308, 100);
            this.lstSelectedRooms.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(50, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(175, 178);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(245, 22);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(175, 150);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(245, 22);
            this.txtFirstName.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpEntry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lstRoomVisitors);
            this.Controls.Add(this.btnAddVisitorInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstSelectedRooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEntry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox lstRoomVisitors;
        private System.Windows.Forms.Button btnAddVisitorInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstSelectedRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}