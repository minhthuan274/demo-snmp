﻿namespace SNMP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCommunityString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtOIDValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSNMPListValue = new System.Windows.Forms.DataGridView();
            this.cbbSNMPVersion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCommand = new System.Windows.Forms.ComboBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSNMPListValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbSNMPVersion);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCommunityString);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIPAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông số SNMP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(343, 23);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(164, 20);
            this.txtPort.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // txtCommunityString
            // 
            this.txtCommunityString.Location = new System.Drawing.Point(119, 55);
            this.txtCommunityString.Name = "txtCommunityString";
            this.txtCommunityString.Size = new System.Drawing.Size(164, 20);
            this.txtCommunityString.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Community string";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(119, 23);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(164, 20);
            this.txtIPAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbCommand);
            this.groupBox2.Controls.Add(this.btnExecute);
            this.groupBox2.Controls.Add(this.txtOIDValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SNMP";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(609, 26);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 7;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtOIDValue
            // 
            this.txtOIDValue.Location = new System.Drawing.Point(116, 29);
            this.txtOIDValue.Name = "txtOIDValue";
            this.txtOIDValue.Size = new System.Drawing.Size(298, 20);
            this.txtOIDValue.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "OID: ";
            // 
            // dgvSNMPListValue
            // 
            this.dgvSNMPListValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSNMPListValue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.OID,
            this.Values});
            this.dgvSNMPListValue.Location = new System.Drawing.Point(12, 274);
            this.dgvSNMPListValue.Name = "dgvSNMPListValue";
            this.dgvSNMPListValue.Size = new System.Drawing.Size(749, 191);
            this.dgvSNMPListValue.TabIndex = 2;
            // 
            // cbbSNMPVersion
            // 
            this.cbbSNMPVersion.FormattingEnabled = true;
            this.cbbSNMPVersion.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbSNMPVersion.Location = new System.Drawing.Point(119, 90);
            this.cbbSNMPVersion.Name = "cbbSNMPVersion";
            this.cbbSNMPVersion.Size = new System.Drawing.Size(121, 21);
            this.cbbSNMPVersion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Version";
            // 
            // cbbCommand
            // 
            this.cbbCommand.FormattingEnabled = true;
            this.cbbCommand.Items.AddRange(new object[] {
            "Get",
            "Get Next",
            "Get Bulk"});
            this.cbbCommand.Location = new System.Drawing.Point(482, 28);
            this.cbbCommand.Name = "cbbCommand";
            this.cbbCommand.Size = new System.Drawing.Size(121, 21);
            this.cbbCommand.TabIndex = 8;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // OID
            // 
            this.OID.HeaderText = "OID";
            this.OID.Name = "OID";
            // 
            // Values
            // 
            this.Values.HeaderText = "Values";
            this.Values.Name = "Values";
            this.Values.Width = 500;
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(12, 245);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(63, 23);
            this.btnClearData.TabIndex = 9;
            this.btnClearData.Text = "Clear";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 477);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.dgvSNMPListValue);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSNMPListValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCommunityString;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtOIDValue;
        private System.Windows.Forms.DataGridView dgvSNMPListValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbSNMPVersion;
        private System.Windows.Forms.ComboBox cbbCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn OID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Values;
        private System.Windows.Forms.Button btnClearData;
    }
}

