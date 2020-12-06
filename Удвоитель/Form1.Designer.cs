namespace Удвоитель
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
            this.Udvoitel = new System.Windows.Forms.Button();
            this.Ugadayka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Udvoitel
            // 
            this.Udvoitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Udvoitel.Location = new System.Drawing.Point(79, 167);
            this.Udvoitel.Name = "Udvoitel";
            this.Udvoitel.Size = new System.Drawing.Size(230, 98);
            this.Udvoitel.TabIndex = 0;
            this.Udvoitel.Text = "Удвоитель";
            this.Udvoitel.UseVisualStyleBackColor = true;
            this.Udvoitel.Click += new System.EventHandler(this.Udvoitel_Click);
            // 
            // Ugadayka
            // 
            this.Ugadayka.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ugadayka.Location = new System.Drawing.Point(437, 167);
            this.Ugadayka.Name = "Ugadayka";
            this.Ugadayka.Size = new System.Drawing.Size(230, 98);
            this.Ugadayka.TabIndex = 0;
            this.Ugadayka.Text = "Угадайка";
            this.Ugadayka.UseVisualStyleBackColor = true;
            this.Ugadayka.Click += new System.EventHandler(this.Ugadayka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ugadayka);
            this.Controls.Add(this.Udvoitel);
            this.Name = "Form1";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Udvoitel;
        private System.Windows.Forms.Button Ugadayka;
    }
}