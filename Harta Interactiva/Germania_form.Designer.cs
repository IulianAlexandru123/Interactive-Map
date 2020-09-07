namespace Harta_Interactiva
{
    partial class Germania_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Germania_form));
            this.meniu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // meniu
            // 
            this.meniu.Location = new System.Drawing.Point(389, 161);
            this.meniu.Name = "meniu";
            this.meniu.Size = new System.Drawing.Size(141, 54);
            this.meniu.TabIndex = 0;
            this.meniu.Text = "Meniu";
            this.meniu.UseVisualStyleBackColor = true;
            this.meniu.Click += new System.EventHandler(this.meniu_Click);
            // 
            // Germania_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.meniu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Germania_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Germania_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button meniu;
    }
}