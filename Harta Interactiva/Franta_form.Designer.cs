namespace Harta_Interactiva
{
    partial class Franta_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Franta_form));
            this.Menu = new System.Windows.Forms.Button();
            this.Istorie = new System.Windows.Forms.Button();
            this.Economie = new System.Windows.Forms.Button();
            this.Geografie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Location = new System.Drawing.Point(12, 201);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(109, 76);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Istorie
            // 
            this.Istorie.Location = new System.Drawing.Point(127, 124);
            this.Istorie.Name = "Istorie";
            this.Istorie.Size = new System.Drawing.Size(92, 78);
            this.Istorie.TabIndex = 1;
            this.Istorie.Text = "Istorie";
            this.Istorie.UseVisualStyleBackColor = true;
            this.Istorie.Visible = false;
            this.Istorie.Click += new System.EventHandler(this.Istorie_Click);
            // 
            // Economie
            // 
            this.Economie.Location = new System.Drawing.Point(127, 273);
            this.Economie.Name = "Economie";
            this.Economie.Size = new System.Drawing.Size(92, 78);
            this.Economie.TabIndex = 2;
            this.Economie.Text = "Economie";
            this.Economie.UseVisualStyleBackColor = true;
            this.Economie.Visible = false;
            this.Economie.Click += new System.EventHandler(this.Economie_Click);
            // 
            // Geografie
            // 
            this.Geografie.Location = new System.Drawing.Point(127, 199);
            this.Geografie.Name = "Geografie";
            this.Geografie.Size = new System.Drawing.Size(92, 78);
            this.Geografie.TabIndex = 3;
            this.Geografie.Text = "Geografie";
            this.Geografie.UseVisualStyleBackColor = true;
            this.Geografie.Visible = false;
            this.Geografie.Click += new System.EventHandler(this.Geografie_Click);
            // 
            // Franta_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Harta_Interactiva.Properties.Resources.franta1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Geografie);
            this.Controls.Add(this.Economie);
            this.Controls.Add(this.Istorie);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Franta_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Franta_form";
            this.Load += new System.EventHandler(this.Franta_form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Franta_form_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private new System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button Istorie;
        private System.Windows.Forms.Button Economie;
        private System.Windows.Forms.Button Geografie;
    }
}