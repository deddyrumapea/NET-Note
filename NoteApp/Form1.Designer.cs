
namespace NoteApp
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
            this.buttonDecreaseFontSize = new System.Windows.Forms.Button();
            this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.buttonIncreaseFontSize = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStrikeout = new System.Windows.Forms.Button();
            this.buttonUnderline = new System.Windows.Forms.Button();
            this.buttonItalic = new System.Windows.Forms.Button();
            this.buttonBold = new System.Windows.Forms.Button();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.comboBoxTextAlignment = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDecreaseFontSize
            // 
            this.buttonDecreaseFontSize.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecreaseFontSize.Location = new System.Drawing.Point(13, 33);
            this.buttonDecreaseFontSize.Name = "buttonDecreaseFontSize";
            this.buttonDecreaseFontSize.Size = new System.Drawing.Size(35, 35);
            this.buttonDecreaseFontSize.TabIndex = 0;
            this.buttonDecreaseFontSize.Text = "-";
            this.buttonDecreaseFontSize.UseVisualStyleBackColor = true;
            this.buttonDecreaseFontSize.Click += new System.EventHandler(this.buttonDecreaseFontSize_Click);
            // 
            // comboBoxFontSize
            // 
            this.comboBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontSize.FormattingEnabled = true;
            this.comboBoxFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "18",
            "24",
            "30",
            "36",
            "48",
            "60",
            "72",
            "96"});
            this.comboBoxFontSize.Location = new System.Drawing.Point(51, 34);
            this.comboBoxFontSize.Name = "comboBoxFontSize";
            this.comboBoxFontSize.Size = new System.Drawing.Size(69, 28);
            this.comboBoxFontSize.TabIndex = 1;
            this.comboBoxFontSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontSize_SelectedIndexChanged);
            // 
            // buttonIncreaseFontSize
            // 
            this.buttonIncreaseFontSize.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncreaseFontSize.Location = new System.Drawing.Point(124, 33);
            this.buttonIncreaseFontSize.Name = "buttonIncreaseFontSize";
            this.buttonIncreaseFontSize.Size = new System.Drawing.Size(35, 35);
            this.buttonIncreaseFontSize.TabIndex = 2;
            this.buttonIncreaseFontSize.Text = "+";
            this.buttonIncreaseFontSize.UseVisualStyleBackColor = true;
            this.buttonIncreaseFontSize.Click += new System.EventHandler(this.buttonIncreaseFontSize_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTextAlignment);
            this.groupBox1.Controls.Add(this.buttonStrikeout);
            this.groupBox1.Controls.Add(this.buttonUnderline);
            this.groupBox1.Controls.Add(this.buttonItalic);
            this.groupBox1.Controls.Add(this.buttonBold);
            this.groupBox1.Controls.Add(this.buttonDecreaseFontSize);
            this.groupBox1.Controls.Add(this.buttonIncreaseFontSize);
            this.groupBox1.Controls.Add(this.comboBoxFontSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Appearance";
            // 
            // buttonStrikeout
            // 
            this.buttonStrikeout.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStrikeout.Location = new System.Drawing.Point(330, 33);
            this.buttonStrikeout.Name = "buttonStrikeout";
            this.buttonStrikeout.Size = new System.Drawing.Size(35, 35);
            this.buttonStrikeout.TabIndex = 8;
            this.buttonStrikeout.Text = "S";
            this.buttonStrikeout.UseVisualStyleBackColor = true;
            this.buttonStrikeout.Click += new System.EventHandler(this.buttonStrikeout_Click);
            // 
            // buttonUnderline
            // 
            this.buttonUnderline.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnderline.Location = new System.Drawing.Point(290, 33);
            this.buttonUnderline.Name = "buttonUnderline";
            this.buttonUnderline.Size = new System.Drawing.Size(35, 35);
            this.buttonUnderline.TabIndex = 7;
            this.buttonUnderline.Text = "U";
            this.buttonUnderline.UseVisualStyleBackColor = true;
            this.buttonUnderline.Click += new System.EventHandler(this.buttonUnderline_Click);
            // 
            // buttonItalic
            // 
            this.buttonItalic.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItalic.Location = new System.Drawing.Point(250, 33);
            this.buttonItalic.Name = "buttonItalic";
            this.buttonItalic.Size = new System.Drawing.Size(35, 35);
            this.buttonItalic.TabIndex = 6;
            this.buttonItalic.Text = "I";
            this.buttonItalic.UseVisualStyleBackColor = true;
            this.buttonItalic.Click += new System.EventHandler(this.buttonItalic_Click);
            // 
            // buttonBold
            // 
            this.buttonBold.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBold.Location = new System.Drawing.Point(210, 33);
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Size = new System.Drawing.Size(35, 35);
            this.buttonBold.TabIndex = 5;
            this.buttonBold.Text = "B";
            this.buttonBold.UseVisualStyleBackColor = true;
            this.buttonBold.Click += new System.EventHandler(this.buttonBold_Click);
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNote.Location = new System.Drawing.Point(12, 118);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(1114, 549);
            this.richTextBoxNote.TabIndex = 4;
            this.richTextBoxNote.Text = "";
            // 
            // comboBoxTextAlignment
            // 
            this.comboBoxTextAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTextAlignment.Items.AddRange(new object[] {
            "Align Left",
            "Align Center",
            "Align Right"});
            this.comboBoxTextAlignment.Location = new System.Drawing.Point(469, 34);
            this.comboBoxTextAlignment.Name = "comboBoxTextAlignment";
            this.comboBoxTextAlignment.Size = new System.Drawing.Size(121, 28);
            this.comboBoxTextAlignment.TabIndex = 0;
            this.comboBoxTextAlignment.SelectedIndexChanged += new System.EventHandler(this.comboBoxTextAlignment_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 679);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Note App";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDecreaseFontSize;
        private System.Windows.Forms.ComboBox comboBoxFontSize;
        private System.Windows.Forms.Button buttonIncreaseFontSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUnderline;
        private System.Windows.Forms.Button buttonItalic;
        private System.Windows.Forms.Button buttonBold;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.Button buttonStrikeout;
        private System.Windows.Forms.ComboBox comboBoxTextAlignment;
    }
}

