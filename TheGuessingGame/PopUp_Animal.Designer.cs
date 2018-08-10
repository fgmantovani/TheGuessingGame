namespace TheGuessingGame
{
    partial class PopUp_Animal
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
            this.lblText = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txbTextInsert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(19, 14);
            this.lblText.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(269, 16);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "What was the animal that you thought about?";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(465, 76);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txbTextInsert
            // 
            this.txbTextInsert.Location = new System.Drawing.Point(22, 43);
            this.txbTextInsert.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.txbTextInsert.Name = "txbTextInsert";
            this.txbTextInsert.Size = new System.Drawing.Size(518, 20);
            this.txbTextInsert.TabIndex = 3;
            this.txbTextInsert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTextInsert_KeyDown);
            // 
            // PopUp_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 111);
            this.Controls.Add(this.txbTextInsert);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblText);
            this.Name = "PopUp_Animal";
            this.Text = "PopUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopUp_Animal_FormClosing);
            this.Load += new System.EventHandler(this.PopUp_Animal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txbTextInsert;
    }
}