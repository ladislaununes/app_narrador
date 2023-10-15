namespace Narrador
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
            this.txTexto = new System.Windows.Forms.RichTextBox();
            this.btnFalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txTexto
            // 
            this.txTexto.Location = new System.Drawing.Point(12, 12);
            this.txTexto.Name = "txTexto";
            this.txTexto.Size = new System.Drawing.Size(784, 361);
            this.txTexto.TabIndex = 0;
            this.txTexto.Text = "";
            // 
            // btnFalar
            // 
            this.btnFalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalar.Location = new System.Drawing.Point(296, 412);
            this.btnFalar.Name = "btnFalar";
            this.btnFalar.Size = new System.Drawing.Size(215, 54);
            this.btnFalar.TabIndex = 1;
            this.btnFalar.Text = "Falar";
            this.btnFalar.UseVisualStyleBackColor = true;
            this.btnFalar.Click += new System.EventHandler(this.btnFalar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 478);
            this.Controls.Add(this.btnFalar);
            this.Controls.Add(this.txTexto);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "N A R R A D O R";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txTexto;
        private System.Windows.Forms.Button btnFalar;
    }
}

