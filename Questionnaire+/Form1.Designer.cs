namespace Questionnaire_
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
            this.UserPoints = new System.Windows.Forms.TextBox();
            this.EnterBut = new System.Windows.Forms.Button();
            this.StartTestBut = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Topic = new System.Windows.Forms.Label();
            this.SubtopicBut = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ccs413list = new System.Windows.Forms.ListBox();
            this.csc413 = new System.Windows.Forms.Button();
            this.csc426list = new System.Windows.Forms.ListBox();
            this.csc410list = new System.Windows.Forms.ListBox();
            this.csc416 = new System.Windows.Forms.Button();
            this.csc410 = new System.Windows.Forms.Button();
            this.genQuestsTxtBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserPoints
            // 
            this.UserPoints.Location = new System.Drawing.Point(281, 472);
            this.UserPoints.Multiline = true;
            this.UserPoints.Name = "UserPoints";
            this.UserPoints.Size = new System.Drawing.Size(560, 174);
            this.UserPoints.TabIndex = 1;
            // 
            // EnterBut
            // 
            this.EnterBut.Location = new System.Drawing.Point(884, 472);
            this.EnterBut.Name = "EnterBut";
            this.EnterBut.Size = new System.Drawing.Size(129, 46);
            this.EnterBut.TabIndex = 2;
            this.EnterBut.Text = "Enter";
            this.EnterBut.UseVisualStyleBackColor = true;
            this.EnterBut.Click += new System.EventHandler(this.EnterBut_Click);
            // 
            // StartTestBut
            // 
            this.StartTestBut.Location = new System.Drawing.Point(884, 600);
            this.StartTestBut.Name = "StartTestBut";
            this.StartTestBut.Size = new System.Drawing.Size(129, 46);
            this.StartTestBut.TabIndex = 3;
            this.StartTestBut.Text = "Start Test";
            this.StartTestBut.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(312, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 28);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(729, 27);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 28);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.Location = new System.Drawing.Point(246, 27);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(47, 17);
            this.Topic.TabIndex = 6;
            this.Topic.Text = "Topic:";
            // 
            // SubtopicBut
            // 
            this.SubtopicBut.AutoSize = true;
            this.SubtopicBut.Location = new System.Drawing.Point(629, 27);
            this.SubtopicBut.Name = "SubtopicBut";
            this.SubtopicBut.Size = new System.Drawing.Size(67, 17);
            this.SubtopicBut.TabIndex = 7;
            this.SubtopicBut.Text = "Subtopic:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ccs413list);
            this.groupBox1.Controls.Add(this.csc413);
            this.groupBox1.Controls.Add(this.csc426list);
            this.groupBox1.Controls.Add(this.csc410list);
            this.groupBox1.Controls.Add(this.csc416);
            this.groupBox1.Controls.Add(this.csc410);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 644);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Courses";
            // 
            // ccs413list
            // 
            this.ccs413list.FormattingEnabled = true;
            this.ccs413list.ItemHeight = 22;
            this.ccs413list.Location = new System.Drawing.Point(39, 460);
            this.ccs413list.Name = "ccs413list";
            this.ccs413list.Size = new System.Drawing.Size(113, 92);
            this.ccs413list.TabIndex = 5;
            // 
            // csc413
            // 
            this.csc413.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csc413.Location = new System.Drawing.Point(22, 396);
            this.csc413.Name = "csc413";
            this.csc413.Size = new System.Drawing.Size(130, 33);
            this.csc413.TabIndex = 4;
            this.csc413.Text = "button3";
            this.csc413.UseVisualStyleBackColor = true;
            // 
            // csc426list
            // 
            this.csc426list.FormattingEnabled = true;
            this.csc426list.ItemHeight = 22;
            this.csc426list.Location = new System.Drawing.Point(39, 270);
            this.csc426list.Name = "csc426list";
            this.csc426list.Size = new System.Drawing.Size(113, 92);
            this.csc426list.TabIndex = 3;
            // 
            // csc410list
            // 
            this.csc410list.FormattingEnabled = true;
            this.csc410list.ItemHeight = 22;
            this.csc410list.Location = new System.Drawing.Point(39, 86);
            this.csc410list.Name = "csc410list";
            this.csc410list.Size = new System.Drawing.Size(113, 92);
            this.csc410list.TabIndex = 2;
            // 
            // csc416
            // 
            this.csc416.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csc416.Location = new System.Drawing.Point(22, 219);
            this.csc416.Name = "csc416";
            this.csc416.Size = new System.Drawing.Size(130, 33);
            this.csc416.TabIndex = 1;
            this.csc416.Text = "button2";
            this.csc416.UseVisualStyleBackColor = true;
            // 
            // csc410
            // 
            this.csc410.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csc410.Location = new System.Drawing.Point(22, 47);
            this.csc410.Name = "csc410";
            this.csc410.Size = new System.Drawing.Size(130, 33);
            this.csc410.TabIndex = 0;
            this.csc410.Text = "CSC 410";
            this.csc410.UseVisualStyleBackColor = true;
            // 
            // genQuestsTxtBox
            // 
            this.genQuestsTxtBox.Location = new System.Drawing.Point(263, 92);
            this.genQuestsTxtBox.Multiline = true;
            this.genQuestsTxtBox.Name = "genQuestsTxtBox";
            this.genQuestsTxtBox.Size = new System.Drawing.Size(750, 297);
            this.genQuestsTxtBox.TabIndex = 9;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(532, 439);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 673);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.genQuestsTxtBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SubtopicBut);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.StartTestBut);
            this.Controls.Add(this.EnterBut);
            this.Controls.Add(this.UserPoints);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserPoints;
        private System.Windows.Forms.Button EnterBut;
        private System.Windows.Forms.Button StartTestBut;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Topic;
        private System.Windows.Forms.Label SubtopicBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button csc416;
        private System.Windows.Forms.Button csc410;
        private System.Windows.Forms.ListBox ccs413list;
        private System.Windows.Forms.Button csc413;
        private System.Windows.Forms.ListBox csc426list;
        private System.Windows.Forms.ListBox csc410list;
        private System.Windows.Forms.TextBox genQuestsTxtBox;
        private System.Windows.Forms.Label errorLabel;
    }
}

