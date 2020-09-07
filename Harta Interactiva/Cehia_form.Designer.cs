namespace Harta_Interactiva
{
    partial class Cehia_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cehia_form));
            this.Meniu_cehia = new System.Windows.Forms.Button();
            this.Istorie_cehia = new System.Windows.Forms.Button();
            this.Economie_cehia = new System.Windows.Forms.Button();
            this.Geografie_cehia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Meniu_cehia
            // 
            this.Meniu_cehia.Location = new System.Drawing.Point(675, 58);
            this.Meniu_cehia.Name = "Meniu_cehia";
            this.Meniu_cehia.Size = new System.Drawing.Size(131, 87);
            this.Meniu_cehia.TabIndex = 0;
            this.Meniu_cehia.Text = "Meniu";
            this.Meniu_cehia.UseVisualStyleBackColor = true;
            this.Meniu_cehia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Meniu_cehia_MouseClick);
            // 
            // Istorie_cehia
            // 
            this.Istorie_cehia.Location = new System.Drawing.Point(812, 1);
            this.Istorie_cehia.Name = "Istorie_cehia";
            this.Istorie_cehia.Size = new System.Drawing.Size(137, 69);
            this.Istorie_cehia.TabIndex = 1;
            this.Istorie_cehia.Text = "Istorie";
            this.Istorie_cehia.UseVisualStyleBackColor = true;
            this.Istorie_cehia.Visible = false;
            this.Istorie_cehia.Click += new System.EventHandler(this.Istorie_cehia_Click);
            // 
            // Economie_cehia
            // 
            this.Economie_cehia.Location = new System.Drawing.Point(812, 133);
            this.Economie_cehia.Name = "Economie_cehia";
            this.Economie_cehia.Size = new System.Drawing.Size(137, 69);
            this.Economie_cehia.TabIndex = 2;
            this.Economie_cehia.Text = "Economie";
            this.Economie_cehia.UseVisualStyleBackColor = true;
            this.Economie_cehia.Visible = false;
            this.Economie_cehia.Click += new System.EventHandler(this.Economie_cehia_Click);
            // 
            // Geografie_cehia
            // 
            this.Geografie_cehia.Location = new System.Drawing.Point(812, 67);
            this.Geografie_cehia.Name = "Geografie_cehia";
            this.Geografie_cehia.Size = new System.Drawing.Size(137, 69);
            this.Geografie_cehia.TabIndex = 3;
            this.Geografie_cehia.Text = "Geografie";
            this.Geografie_cehia.UseVisualStyleBackColor = true;
            this.Geografie_cehia.Visible = false;
            this.Geografie_cehia.Click += new System.EventHandler(this.Geografie_cehia_Click);
            // 
            // Cehia_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Harta_Interactiva.Properties.Resources.Czech_physical_map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 581);
            this.Controls.Add(this.Geografie_cehia);
            this.Controls.Add(this.Economie_cehia);
            this.Controls.Add(this.Istorie_cehia);
            this.Controls.Add(this.Meniu_cehia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Cehia_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cehia_form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cehia_form_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Meniu_cehia;
        private System.Windows.Forms.Button Istorie_cehia;
        private System.Windows.Forms.Button Economie_cehia;
        private System.Windows.Forms.Button Geografie_cehia;
    }
}