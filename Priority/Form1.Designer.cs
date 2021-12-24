namespace Priority
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
            this.components = new System.ComponentModel.Container();
            this.result = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReadyQueue = new System.Windows.Forms.CheckedListBox();
            this.cpu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.p3Priority = new System.Windows.Forms.TextBox();
            this.p2Priority = new System.Windows.Forms.TextBox();
            this.p1Priority = new System.Windows.Forms.TextBox();
            this.p4Burst = new System.Windows.Forms.TextBox();
            this.p3Burst = new System.Windows.Forms.TextBox();
            this.p2Burst = new System.Windows.Forms.TextBox();
            this.p1Burst = new System.Windows.Forms.TextBox();
            this.p4Priority = new System.Windows.Forms.TextBox();
            this.Priority = new System.Windows.Forms.Button();
            this.executionTimer = new System.Windows.Forms.Timer(this.components);
            this.analysis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.HideSelection = false;
            this.result.Location = new System.Drawing.Point(543, 77);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(350, 170);
            this.result.TabIndex = 44;
            this.result.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Ready Queue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "CPU";
            // 
            // ReadyQueue
            // 
            this.ReadyQueue.AccessibleName = "";
            this.ReadyQueue.FormattingEnabled = true;
            this.ReadyQueue.Location = new System.Drawing.Point(40, 77);
            this.ReadyQueue.Name = "ReadyQueue";
            this.ReadyQueue.Size = new System.Drawing.Size(169, 169);
            this.ReadyQueue.TabIndex = 37;
            // 
            // cpu
            // 
            this.cpu.Location = new System.Drawing.Point(278, 77);
            this.cpu.Multiline = true;
            this.cpu.Name = "cpu";
            this.cpu.ReadOnly = true;
            this.cpu.Size = new System.Drawing.Size(199, 167);
            this.cpu.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "process #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "process #2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "process #3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "process #4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Burst Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Priority";
            // 
            // p3Priority
            // 
            this.p3Priority.Location = new System.Drawing.Point(506, 393);
            this.p3Priority.Name = "p3Priority";
            this.p3Priority.Size = new System.Drawing.Size(100, 20);
            this.p3Priority.TabIndex = 51;
            // 
            // p2Priority
            // 
            this.p2Priority.Location = new System.Drawing.Point(325, 393);
            this.p2Priority.Name = "p2Priority";
            this.p2Priority.Size = new System.Drawing.Size(100, 20);
            this.p2Priority.TabIndex = 52;
            // 
            // p1Priority
            // 
            this.p1Priority.Location = new System.Drawing.Point(143, 393);
            this.p1Priority.Name = "p1Priority";
            this.p1Priority.Size = new System.Drawing.Size(100, 20);
            this.p1Priority.TabIndex = 53;
            // 
            // p4Burst
            // 
            this.p4Burst.Location = new System.Drawing.Point(680, 334);
            this.p4Burst.Name = "p4Burst";
            this.p4Burst.Size = new System.Drawing.Size(100, 20);
            this.p4Burst.TabIndex = 54;
            // 
            // p3Burst
            // 
            this.p3Burst.Location = new System.Drawing.Point(506, 334);
            this.p3Burst.Name = "p3Burst";
            this.p3Burst.Size = new System.Drawing.Size(100, 20);
            this.p3Burst.TabIndex = 55;
            // 
            // p2Burst
            // 
            this.p2Burst.Location = new System.Drawing.Point(325, 334);
            this.p2Burst.Name = "p2Burst";
            this.p2Burst.Size = new System.Drawing.Size(100, 20);
            this.p2Burst.TabIndex = 56;
            // 
            // p1Burst
            // 
            this.p1Burst.Location = new System.Drawing.Point(143, 334);
            this.p1Burst.Name = "p1Burst";
            this.p1Burst.Size = new System.Drawing.Size(100, 20);
            this.p1Burst.TabIndex = 57;
            // 
            // p4Priority
            // 
            this.p4Priority.Location = new System.Drawing.Point(680, 393);
            this.p4Priority.Name = "p4Priority";
            this.p4Priority.Size = new System.Drawing.Size(100, 20);
            this.p4Priority.TabIndex = 58;
            // 
            // Priority
            // 
            this.Priority.Location = new System.Drawing.Point(421, 452);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(75, 23);
            this.Priority.TabIndex = 59;
            this.Priority.Text = "Priority";
            this.Priority.UseVisualStyleBackColor = true;
            this.Priority.Click += new System.EventHandler(this.Priority_Click);
            // 
            // executionTimer
            // 
            this.executionTimer.Tick += new System.EventHandler(this.executionTimer_Tick);
            // 
            // analysis
            // 
            this.analysis.AutoSize = true;
            this.analysis.Location = new System.Drawing.Point(716, 61);
            this.analysis.Name = "analysis";
            this.analysis.Size = new System.Drawing.Size(44, 13);
            this.analysis.TabIndex = 60;
            this.analysis.Text = "analysis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 502);
            this.Controls.Add(this.analysis);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.p4Priority);
            this.Controls.Add(this.p1Burst);
            this.Controls.Add(this.p2Burst);
            this.Controls.Add(this.p3Burst);
            this.Controls.Add(this.p4Burst);
            this.Controls.Add(this.p1Priority);
            this.Controls.Add(this.p2Priority);
            this.Controls.Add(this.p3Priority);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReadyQueue);
            this.Controls.Add(this.cpu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox ReadyQueue;
        private System.Windows.Forms.TextBox cpu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox p3Priority;
        private System.Windows.Forms.TextBox p2Priority;
        private System.Windows.Forms.TextBox p1Priority;
        private System.Windows.Forms.TextBox p4Burst;
        private System.Windows.Forms.TextBox p3Burst;
        private System.Windows.Forms.TextBox p2Burst;
        private System.Windows.Forms.TextBox p1Burst;
        private System.Windows.Forms.TextBox p4Priority;
        private System.Windows.Forms.Button Priority;
        private System.Windows.Forms.Timer executionTimer;
        private System.Windows.Forms.Label analysis;
    }
}

