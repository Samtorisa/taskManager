namespace gorevyonetimi
{
    partial class AddingForm
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
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionText
            // 
            this.descriptionText.Cursor = System.Windows.Forms.Cursors.Default;
            this.descriptionText.Location = new System.Drawing.Point(76, 47);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionText.Size = new System.Drawing.Size(258, 95);
            this.descriptionText.TabIndex = 12;
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(76, 12);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(142, 20);
            this.textTitle.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aciklama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Baslik:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(406, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonAdd);
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "AddingForm";
            this.Text = "addingForm";
            this.Load += new System.EventHandler(this.AddingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}