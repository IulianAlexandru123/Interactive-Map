namespace Harta_Interactiva
{
    partial class Bulgaria_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bulgaria_form));
            this.Meniu_bulgaria = new System.Windows.Forms.Button();
            this.Istorie_bulgaria = new System.Windows.Forms.Button();
            this.Geografie_bulgaria = new System.Windows.Forms.Button();
            this.Economie_bulgaria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Meniu_bulgaria
            // 
            this.Meniu_bulgaria.Location = new System.Drawing.Point(838, 204);
            this.Meniu_bulgaria.Name = "Meniu_bulgaria";
            this.Meniu_bulgaria.Size = new System.Drawing.Size(133, 77);
            this.Meniu_bulgaria.TabIndex = 0;
            this.Meniu_bulgaria.Text = "Meniu";
            this.Meniu_bulgaria.UseVisualStyleBackColor = true;
            this.Meniu_bulgaria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Meniu_bulgaria_MouseClick);
            // 
            // Istorie_bulgaria
            // 
            this.Istorie_bulgaria.Location = new System.Drawing.Point(723, 149);
            this.Istorie_bulgaria.Name = "Istorie_bulgaria";
            this.Istorie_bulgaria.Size = new System.Drawing.Size(109, 55);
            this.Istorie_bulgaria.TabIndex = 1;
            this.Istorie_bulgaria.Text = "Istorie";
            this.Istorie_bulgaria.UseVisualStyleBackColor = true;
            this.Istorie_bulgaria.Visible = false;
            this.Istorie_bulgaria.Click += new System.EventHandler(this.Istorie_bulgaria_Click);
            // 
            // Geografie_bulgaria
            // 
            this.Geografie_bulgaria.Location = new System.Drawing.Point(723, 204);
            this.Geografie_bulgaria.Name = "Geografie_bulgaria";
            this.Geografie_bulgaria.Size = new System.Drawing.Size(109, 55);
            this.Geografie_bulgaria.TabIndex = 2;
            this.Geografie_bulgaria.Text = "Geografie";
            this.Geografie_bulgaria.UseVisualStyleBackColor = true;
            this.Geografie_bulgaria.Visible = false;
            this.Geografie_bulgaria.Click += new System.EventHandler(this.Geografie_bulgaria_Click);
            // 
            // Economie_bulgaria
            // 
            this.Economie_bulgaria.Location = new System.Drawing.Point(723, 259);
            this.Economie_bulgaria.Name = "Economie_bulgaria";
            this.Economie_bulgaria.Size = new System.Drawing.Size(109, 55);
            this.Economie_bulgaria.TabIndex = 3;
            this.Economie_bulgaria.Text = "Economie";
            this.Economie_bulgaria.UseVisualStyleBackColor = true;
            this.Economie_bulgaria.Visible = false;
            this.Economie_bulgaria.Click += new System.EventHandler(this.Economie_bulgaria_Click);
            // 
            // Bulgaria_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Harta_Interactiva.Properties.Resources.bulgaria1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 586);
            this.Controls.Add(this.Economie_bulgaria);
            this.Controls.Add(this.Geografie_bulgaria);
            this.Controls.Add(this.Istorie_bulgaria);
            this.Controls.Add(this.Meniu_bulgaria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Bulgaria_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulgaria_form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bulgaria_form_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Meniu_bulgaria;
        private System.Windows.Forms.Button Istorie_bulgaria;
        private System.Windows.Forms.Button Geografie_bulgaria;
        private System.Windows.Forms.Button Economie_bulgaria;
    }
}