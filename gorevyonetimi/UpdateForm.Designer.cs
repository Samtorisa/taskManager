namespace gorevyonetimi
{
    partial class UpdateForm
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
            this.status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "YAPILIYOR",
            "YAPILDI",
            "YAPILACAK"});
            this.status.Location = new System.Drawing.Point(435, 166);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 21);
            this.status.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "status";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(452, 240);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(104, 56);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Guncelle";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.Cursor = System.Windows.Forms.Cursors.Default;
            this.descriptionText.Location = new System.Drawing.Point(122, 201);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descriptionText.Size = new System.Drawing.Size(258, 95);
            this.descriptionText.TabIndex = 19;
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(122, 166);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(142, 20);
            this.textTitle.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Aciklama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Baslik:";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}