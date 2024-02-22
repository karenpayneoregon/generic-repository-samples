namespace EntityFrameworkCoreBulkInsertsApp;

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
        BogusCreateFileButton = new Button();
        ReadDelimitedFileButton = new Button();
        groupBox1 = new GroupBox();
        SaveToDatabaseButton1 = new Button();
        dataGridView1 = new DataGridView();
        SampleButton = new Button();
        ResetCustomerTableButton = new Button();
        SaveToDatabaseButton2 = new Button();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // BogusCreateFileButton
        // 
        BogusCreateFileButton.Location = new Point(37, 36);
        BogusCreateFileButton.Name = "BogusCreateFileButton";
        BogusCreateFileButton.Size = new Size(254, 29);
        BogusCreateFileButton.TabIndex = 0;
        BogusCreateFileButton.Text = "Bogus Create File";
        BogusCreateFileButton.UseVisualStyleBackColor = true;
        BogusCreateFileButton.Click += BogusCreateFileButton_Click;
        // 
        // ReadDelimitedFileButton
        // 
        ReadDelimitedFileButton.Location = new Point(37, 82);
        ReadDelimitedFileButton.Name = "ReadDelimitedFileButton";
        ReadDelimitedFileButton.Size = new Size(254, 29);
        ReadDelimitedFileButton.TabIndex = 1;
        ReadDelimitedFileButton.Text = "Read CSV files";
        ReadDelimitedFileButton.UseVisualStyleBackColor = true;
        ReadDelimitedFileButton.Click += ReadDelimitedFileButton_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(ReadDelimitedFileButton);
        groupBox1.Controls.Add(BogusCreateFileButton);
        groupBox1.Location = new Point(39, 7);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(329, 127);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Create/read file";
        // 
        // SaveToDatabaseButton1
        // 
        SaveToDatabaseButton1.Location = new Point(391, 43);
        SaveToDatabaseButton1.Name = "SaveToDatabaseButton1";
        SaveToDatabaseButton1.Size = new Size(254, 29);
        SaveToDatabaseButton1.TabIndex = 3;
        SaveToDatabaseButton1.Text = "To SQL-Server table with EF Core";
        SaveToDatabaseButton1.UseVisualStyleBackColor = true;
        SaveToDatabaseButton1.Click += SaveToDatabaseButton_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(39, 214);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(939, 263);
        dataGridView1.TabIndex = 4;
        // 
        // SampleButton
        // 
        SampleButton.Location = new Point(391, 134);
        SampleButton.Name = "SampleButton";
        SampleButton.Size = new Size(254, 29);
        SampleButton.TabIndex = 5;
        SampleButton.Text = "Sample";
        SampleButton.UseVisualStyleBackColor = true;
        SampleButton.Click += SampleButton_Click;
        // 
        // ResetCustomerTableButton
        // 
        ResetCustomerTableButton.Location = new Point(724, 43);
        ResetCustomerTableButton.Name = "ResetCustomerTableButton";
        ResetCustomerTableButton.Size = new Size(254, 29);
        ResetCustomerTableButton.TabIndex = 2;
        ResetCustomerTableButton.Text = "Reset table";
        ResetCustomerTableButton.UseVisualStyleBackColor = true;
        ResetCustomerTableButton.Click += ResetCustomerTableButton_Click;
        // 
        // SaveToDatabaseButton2
        // 
        SaveToDatabaseButton2.Location = new Point(391, 89);
        SaveToDatabaseButton2.Name = "SaveToDatabaseButton2";
        SaveToDatabaseButton2.Size = new Size(254, 29);
        SaveToDatabaseButton2.TabIndex = 6;
        SaveToDatabaseButton2.Text = "Bulk with NuGet paclage";
        SaveToDatabaseButton2.UseVisualStyleBackColor = true;
        SaveToDatabaseButton2.Click += SaveToDatabaseButton2_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(990, 489);
        Controls.Add(SaveToDatabaseButton2);
        Controls.Add(ResetCustomerTableButton);
        Controls.Add(SampleButton);
        Controls.Add(dataGridView1);
        Controls.Add(SaveToDatabaseButton1);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Save to database";
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button BogusCreateFileButton;
    private Button ReadDelimitedFileButton;
    private GroupBox groupBox1;
    private Button SaveToDatabaseButton1;
    private DataGridView dataGridView1;
    private Button SampleButton;
    private Button ResetCustomerTableButton;
    private Button SaveToDatabaseButton2;
}
