﻿namespace Discord_Nick_Randomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textToken = new System.Windows.Forms.TextBox();
            this.btnApplyToken = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridServers = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxSequence = new System.Windows.Forms.CheckBox();
            this.textListOfNicks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericSecondsChange = new System.Windows.Forms.NumericUpDown();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServers)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecondsChange)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textToken);
            this.groupBox1.Controls.Add(this.btnApplyToken);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API Token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Discord API Token:";
            // 
            // textToken
            // 
            this.textToken.Location = new System.Drawing.Point(22, 38);
            this.textToken.Name = "textToken";
            this.textToken.Size = new System.Drawing.Size(275, 20);
            this.textToken.TabIndex = 1;
            // 
            // btnApplyToken
            // 
            this.btnApplyToken.Location = new System.Drawing.Point(318, 35);
            this.btnApplyToken.Name = "btnApplyToken";
            this.btnApplyToken.Size = new System.Drawing.Size(117, 23);
            this.btnApplyToken.TabIndex = 0;
            this.btnApplyToken.Text = "Apply API token";
            this.btnApplyToken.UseVisualStyleBackColor = true;
            this.btnApplyToken.Click += new System.EventHandler(this.btnApplyToken_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridServers);
            this.groupBox2.Location = new System.Drawing.Point(25, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server list where you can change nick (select one)";
            // 
            // dataGridServers
            // 
            this.dataGridServers.AllowUserToAddRows = false;
            this.dataGridServers.AllowUserToDeleteRows = false;
            this.dataGridServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnName});
            this.dataGridServers.Location = new System.Drawing.Point(25, 30);
            this.dataGridServers.MultiSelect = false;
            this.dataGridServers.Name = "dataGridServers";
            this.dataGridServers.ReadOnly = true;
            this.dataGridServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServers.Size = new System.Drawing.Size(434, 213);
            this.dataGridServers.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxSequence);
            this.groupBox3.Controls.Add(this.textListOfNicks);
            this.groupBox3.Location = new System.Drawing.Point(25, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of nicks (separate them with new lines)";
            // 
            // checkBoxSequence
            // 
            this.checkBoxSequence.AutoSize = true;
            this.checkBoxSequence.Location = new System.Drawing.Point(22, 202);
            this.checkBoxSequence.Name = "checkBoxSequence";
            this.checkBoxSequence.Size = new System.Drawing.Size(176, 17);
            this.checkBoxSequence.TabIndex = 1;
            this.checkBoxSequence.Text = "Set nicks in specified sequence";
            this.checkBoxSequence.UseVisualStyleBackColor = true;
            // 
            // textListOfNicks
            // 
            this.textListOfNicks.Location = new System.Drawing.Point(22, 30);
            this.textListOfNicks.Multiline = true;
            this.textListOfNicks.Name = "textListOfNicks";
            this.textListOfNicks.Size = new System.Drawing.Size(413, 166);
            this.textListOfNicks.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of seconds how often to change nickname:";
            // 
            // numericSecondsChange
            // 
            this.numericSecondsChange.Location = new System.Drawing.Point(202, 613);
            this.numericSecondsChange.Name = "numericSecondsChange";
            this.numericSecondsChange.Size = new System.Drawing.Size(120, 20);
            this.numericSecondsChange.TabIndex = 4;
            this.numericSecondsChange.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btnStartStop
            // 
            this.btnStartStop.Enabled = false;
            this.btnStartStop.Location = new System.Drawing.Point(222, 639);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 5;
            this.btnStartStop.Text = "Start!";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.status.Location = new System.Drawing.Point(12, 680);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(138, 13);
            this.status.TabIndex = 6;
            this.status.Text = "Status: waiting for user";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // columnId
            // 
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 702);
            this.Controls.Add(this.status);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.numericSecondsChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Discord Nick Randomizer";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecondsChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textToken;
        private System.Windows.Forms.Button btnApplyToken;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridServers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textListOfNicks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericSecondsChange;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.CheckBox checkBoxSequence;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
    }
}

