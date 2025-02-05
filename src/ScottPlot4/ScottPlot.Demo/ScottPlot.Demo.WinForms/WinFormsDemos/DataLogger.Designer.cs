﻿namespace ScottPlot.Demo.WinForms.WinFormsDemos;

partial class DataLogger
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
        formsPlot1 = new FormsPlot();
        label1 = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        cbEnableViewManagement = new System.Windows.Forms.CheckBox();
        SuspendLayout();
        // 
        // formsPlot1
        // 
        formsPlot1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        formsPlot1.Location = new System.Drawing.Point(13, 41);
        formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        formsPlot1.Name = "formsPlot1";
        formsPlot1.Size = new System.Drawing.Size(715, 383);
        formsPlot1.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(12, 15);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(69, 15);
        label1.TabIndex = 1;
        label1.Text = "View Mode:";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(87, 12);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(121, 23);
        comboBox1.TabIndex = 2;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // checkBox1
        // 
        cbEnableViewManagement.AutoSize = true;
        cbEnableViewManagement.Checked = true;
        cbEnableViewManagement.CheckState = System.Windows.Forms.CheckState.Checked;
        cbEnableViewManagement.Location = new System.Drawing.Point(214, 14);
        cbEnableViewManagement.Name = "checkBox1";
        cbEnableViewManagement.Size = new System.Drawing.Size(110, 19);
        cbEnableViewManagement.TabIndex = 3;
        cbEnableViewManagement.Text = "Automatic View";
        cbEnableViewManagement.UseVisualStyleBackColor = true;
        cbEnableViewManagement.CheckedChanged += cbView_CheckedChanged;
        // 
        // DataLogger
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(741, 436);
        Controls.Add(cbEnableViewManagement);
        Controls.Add(comboBox1);
        Controls.Add(label1);
        Controls.Add(formsPlot1);
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Name = "DataLogger";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "ScottPlot Data Logger Demo";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private FormsPlot formsPlot1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.CheckBox cbEnableViewManagement;
}