namespace Verona
{
    partial class Available_Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Available_Stock));
            this.rdbtnavil = new System.Windows.Forms.RadioButton();
            this.rdbtnavil2 = new System.Windows.Forms.RadioButton();
            this.btnprint2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cmbavailname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnenter = new System.Windows.Forms.Button();
            this.txtavailcode = new System.Windows.Forms.TextBox();
            this.cmbavailcode = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.cmbtone = new System.Windows.Forms.ComboBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbsize2 = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbtnavil
            // 
            this.rdbtnavil.AutoSize = true;
            this.rdbtnavil.Checked = true;
            this.rdbtnavil.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnavil.ForeColor = System.Drawing.Color.White;
            this.rdbtnavil.Location = new System.Drawing.Point(12, 12);
            this.rdbtnavil.Name = "rdbtnavil";
            this.rdbtnavil.Size = new System.Drawing.Size(61, 23);
            this.rdbtnavil.TabIndex = 381;
            this.rdbtnavil.TabStop = true;
            this.rdbtnavil.Text = "TILES";
            this.rdbtnavil.UseVisualStyleBackColor = true;
            this.rdbtnavil.CheckedChanged += new System.EventHandler(this.rdbtnavil_CheckedChanged);
            // 
            // rdbtnavil2
            // 
            this.rdbtnavil2.AutoSize = true;
            this.rdbtnavil2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnavil2.ForeColor = System.Drawing.Color.White;
            this.rdbtnavil2.Location = new System.Drawing.Point(12, 309);
            this.rdbtnavil2.Name = "rdbtnavil2";
            this.rdbtnavil2.Size = new System.Drawing.Size(93, 23);
            this.rdbtnavil2.TabIndex = 380;
            this.rdbtnavil2.Text = "SANITARY";
            this.rdbtnavil2.UseVisualStyleBackColor = true;
            this.rdbtnavil2.CheckedChanged += new System.EventHandler(this.rdbtnavil2_CheckedChanged);
            // 
            // btnprint2
            // 
            this.btnprint2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprint2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(178)))));
            this.btnprint2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint2.ForeColor = System.Drawing.Color.White;
            this.btnprint2.Location = new System.Drawing.Point(1112, 362);
            this.btnprint2.Name = "btnprint2";
            this.btnprint2.Size = new System.Drawing.Size(60, 21);
            this.btnprint2.TabIndex = 376;
            this.btnprint2.Text = "Print";
            this.btnprint2.UseVisualStyleBackColor = false;
            this.btnprint2.Click += new System.EventHandler(this.btnprint2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.Location = new System.Drawing.Point(12, 62);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.Size = new System.Drawing.Size(1160, 241);
            this.dataGridView3.TabIndex = 370;
            this.dataGridView3.TabStop = false;
            // 
            // cmbavailname
            // 
            this.cmbavailname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbavailname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbavailname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbavailname.BackColor = System.Drawing.Color.White;
            this.cmbavailname.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbavailname.FormattingEnabled = true;
            this.cmbavailname.Location = new System.Drawing.Point(75, 362);
            this.cmbavailname.Name = "cmbavailname";
            this.cmbavailname.Size = new System.Drawing.Size(535, 21);
            this.cmbavailname.TabIndex = 374;
            this.cmbavailname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbavailname_KeyDown);
            this.cmbavailname.Leave += new System.EventHandler(this.cmbavailname_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 371;
            this.label5.Text = "Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 379;
            this.label4.Text = "Name:";
            // 
            // btnenter
            // 
            this.btnenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(178)))));
            this.btnenter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnenter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.ForeColor = System.Drawing.Color.White;
            this.btnenter.Location = new System.Drawing.Point(898, 38);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(60, 21);
            this.btnenter.TabIndex = 368;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = false;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // txtavailcode
            // 
            this.txtavailcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtavailcode.BackColor = System.Drawing.Color.White;
            this.txtavailcode.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtavailcode.Location = new System.Drawing.Point(75, 335);
            this.txtavailcode.Name = "txtavailcode";
            this.txtavailcode.Size = new System.Drawing.Size(535, 21);
            this.txtavailcode.TabIndex = 375;
            this.txtavailcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtavailcode_KeyDown);
            this.txtavailcode.Leave += new System.EventHandler(this.txtavailcode_Leave);
            // 
            // cmbavailcode
            // 
            this.cmbavailcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbavailcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbavailcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbavailcode.BackColor = System.Drawing.Color.White;
            this.cmbavailcode.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbavailcode.FormattingEnabled = true;
            this.cmbavailcode.Location = new System.Drawing.Point(69, 37);
            this.cmbavailcode.Name = "cmbavailcode";
            this.cmbavailcode.Size = new System.Drawing.Size(541, 21);
            this.cmbavailcode.TabIndex = 365;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(18, 335);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 21);
            this.label25.TabIndex = 378;
            this.label25.Text = "Code:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToResizeColumns = false;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView4.Location = new System.Drawing.Point(12, 389);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView4.Size = new System.Drawing.Size(1160, 239);
            this.dataGridView4.TabIndex = 377;
            this.dataGridView4.TabStop = false;
            // 
            // cmbtone
            // 
            this.cmbtone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbtone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbtone.BackColor = System.Drawing.Color.White;
            this.cmbtone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtone.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtone.FormattingEnabled = true;
            this.cmbtone.Location = new System.Drawing.Point(821, 38);
            this.cmbtone.Name = "cmbtone";
            this.cmbtone.Size = new System.Drawing.Size(71, 21);
            this.cmbtone.TabIndex = 367;
            this.cmbtone.Enter += new System.EventHandler(this.cmbtone_Enter);
            // 
            // btnprint
            // 
            this.btnprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(178)))));
            this.btnprint.Enabled = false;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprint.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(1112, 38);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(60, 21);
            this.btnprint.TabIndex = 369;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(742, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 21);
            this.label17.TabIndex = 373;
            this.label17.Text = "Tone No:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(616, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 21);
            this.label7.TabIndex = 372;
            this.label7.Text = "Size:";
            // 
            // cmbsize2
            // 
            this.cmbsize2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbsize2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbsize2.BackColor = System.Drawing.Color.White;
            this.cmbsize2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsize2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsize2.FormattingEnabled = true;
            this.cmbsize2.Location = new System.Drawing.Point(665, 38);
            this.cmbsize2.Name = "cmbsize2";
            this.cmbsize2.Size = new System.Drawing.Size(71, 21);
            this.cmbsize2.TabIndex = 366;
            this.cmbsize2.Enter += new System.EventHandler(this.cmbsize2_Enter);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1112, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 21);
            this.button1.TabIndex = 382;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Available_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbtnavil);
            this.Controls.Add(this.rdbtnavil2);
            this.Controls.Add(this.btnprint2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.cmbavailname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.txtavailcode);
            this.Controls.Add(this.cmbavailcode);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.cmbtone);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbsize2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Available_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Available Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Available_Stock_FormClosing);
            this.Load += new System.EventHandler(this.Available_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbsize2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.ComboBox cmbtone;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbavailcode;
        private System.Windows.Forms.TextBox txtavailcode;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbavailname;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnprint2;
        private System.Windows.Forms.RadioButton rdbtnavil2;
        private System.Windows.Forms.RadioButton rdbtnavil;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.Button button1;
    }
}