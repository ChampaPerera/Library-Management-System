namespace LibraryManagementSytem
{
    partial class BookCheckinForm
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
            this.buttonFineSettle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.textMemberID = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonReturnHome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonFineSettle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBookID);
            this.groupBox1.Controls.Add(this.textMemberID);
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonCheckIn);
            this.groupBox1.Controls.Add(this.buttonReturnHome);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 421);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // buttonFineSettle
            // 
            this.buttonFineSettle.Location = new System.Drawing.Point(25, 346);
            this.buttonFineSettle.Name = "buttonFineSettle";
            this.buttonFineSettle.Size = new System.Drawing.Size(217, 34);
            this.buttonFineSettle.TabIndex = 10;
            this.buttonFineSettle.Text = " Settle Over Due Fine here";
            this.buttonFineSettle.UseVisualStyleBackColor = true;
            this.buttonFineSettle.Click += new System.EventHandler(this.buttonFineSettle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Book Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Member Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book Check-In";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(235, 183);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(149, 22);
            this.txtBookID.TabIndex = 6;
            // 
            // textMemberID
            // 
            this.textMemberID.Location = new System.Drawing.Point(235, 126);
            this.textMemberID.Name = "textMemberID";
            this.textMemberID.Size = new System.Drawing.Size(149, 22);
            this.textMemberID.TabIndex = 5;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(25, 285);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(109, 35);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Location = new System.Drawing.Point(319, 285);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(109, 35);
            this.buttonCheckIn.TabIndex = 1;
            this.buttonCheckIn.Text = "Check_in";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonReturnHome
            // 
            this.buttonReturnHome.Location = new System.Drawing.Point(269, 346);
            this.buttonReturnHome.Name = "buttonReturnHome";
            this.buttonReturnHome.Size = new System.Drawing.Size(159, 34);
            this.buttonReturnHome.TabIndex = 0;
            this.buttonReturnHome.Text = "Return to Home";
            this.buttonReturnHome.UseVisualStyleBackColor = true;
            this.buttonReturnHome.Click += new System.EventHandler(this.buttonReturnHome_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookCheckinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 434);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookCheckinForm";
            this.Text = "BookCheckinForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox textMemberID;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonReturnHome;
        private System.Windows.Forms.Button buttonFineSettle;
        private System.Windows.Forms.Button button1;
    }
}