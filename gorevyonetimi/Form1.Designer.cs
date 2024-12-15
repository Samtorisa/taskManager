namespace gorevyonetimi
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
            this.taskListButton = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.listControl1 = new gorevyonetimi.ListControl();
            this.graphTask1 = new gorevyonetimi.GraphTask();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskListButton
            // 
            this.taskListButton.Location = new System.Drawing.Point(12, 60);
            this.taskListButton.Name = "taskListButton";
            this.taskListButton.Size = new System.Drawing.Size(140, 32);
            this.taskListButton.TabIndex = 10;
            this.taskListButton.Text = "Gorev Listesi";
            this.taskListButton.UseVisualStyleBackColor = true;
            this.taskListButton.Click += new System.EventHandler(this.taskListButton_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Location = new System.Drawing.Point(12, 147);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(140, 32);
            this.buttonGraph.TabIndex = 11;
            this.buttonGraph.Text = "Grafikler";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.listControl1);
            this.panelContainer.Controls.Add(this.graphTask1);
            this.panelContainer.Location = new System.Drawing.Point(221, 35);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(567, 445);
            this.panelContainer.TabIndex = 12;
            // 
            // listControl1
            // 
            this.listControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listControl1.Location = new System.Drawing.Point(0, 0);
            this.listControl1.Name = "listControl1";
            this.listControl1.Size = new System.Drawing.Size(567, 445);
            this.listControl1.TabIndex = 1;
            // 
            // graphTask1
            // 
            this.graphTask1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphTask1.Location = new System.Drawing.Point(0, 0);
            this.graphTask1.Name = "graphTask1";
            this.graphTask1.Size = new System.Drawing.Size(567, 445);
            this.graphTask1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(380, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 492);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.taskListButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button taskListButton;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ListControl listControl1;
        private GraphTask graphTask1;
    }
}

