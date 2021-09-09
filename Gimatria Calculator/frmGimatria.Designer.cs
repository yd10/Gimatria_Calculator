
namespace Gimatria
{
    partial class frmGimatria
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
            this.txtGimatriaInput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTextOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMisparGadol = new System.Windows.Forms.Label();
            this.lblMisparKatan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGimatriaInput
            // 
            this.txtGimatriaInput.Location = new System.Drawing.Point(123, 37);
            this.txtGimatriaInput.Name = "txtGimatriaInput";
            this.txtGimatriaInput.Size = new System.Drawing.Size(256, 96);
            this.txtGimatriaInput.TabIndex = 0;
            this.txtGimatriaInput.Text = "";
            this.txtGimatriaInput.TextChanged += new System.EventHandler(this.txtGimatriaInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type or paste \r\nyour text here:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "You entered....";
            // 
            // lblTextOutput
            // 
            this.lblTextOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTextOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTextOutput.Location = new System.Drawing.Point(124, 159);
            this.lblTextOutput.Name = "lblTextOutput";
            this.lblTextOutput.Size = new System.Drawing.Size(255, 93);
            this.lblTextOutput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mispar Gadol:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mispar Katan:";
            // 
            // lblMisparGadol
            // 
            this.lblMisparGadol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMisparGadol.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMisparGadol.Location = new System.Drawing.Point(124, 300);
            this.lblMisparGadol.Name = "lblMisparGadol";
            this.lblMisparGadol.Size = new System.Drawing.Size(185, 23);
            this.lblMisparGadol.TabIndex = 11;
            // 
            // lblMisparKatan
            // 
            this.lblMisparKatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMisparKatan.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMisparKatan.Location = new System.Drawing.Point(124, 352);
            this.lblMisparKatan.Name = "lblMisparKatan";
            this.lblMisparKatan.Size = new System.Drawing.Size(185, 23);
            this.lblMisparKatan.TabIndex = 12;
            // 
            // frmGimatria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 416);
            this.Controls.Add(this.lblMisparKatan);
            this.Controls.Add(this.lblMisparGadol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTextOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGimatriaInput);
            this.Name = "frmGimatria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimatria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtGimatriaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTextOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMisparGadol;
        private System.Windows.Forms.Label lblMisparKatan;
    }
}

