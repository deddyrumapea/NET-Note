
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(141, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Appearance";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(290, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "U";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(250, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "I";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(210, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "B";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 457);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(330, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 8;
            this.button6.Text = "S";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(440, 33);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 35);
            this.button7.TabIndex = 9;
            this.button7.Text = "Center";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Note App";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

