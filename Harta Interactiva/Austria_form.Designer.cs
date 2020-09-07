namespace Harta_Interactiva
{
    partial class Austria_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Austria_form));
            this.Meniu_austria = new System.Windows.Forms.Button();
            this.Istorie_austria = new System.Windows.Forms.Button();
            this.Economie_austria = new System.Windows.Forms.Button();
            this.Geografie_austria = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // Meniu_austria
            // 
            this.Meniu_austria.Location = new System.Drawing.Point(204, 134);
            this.Meniu_austria.Name = "Meniu_austria";
            this.Meniu_austria.Size = new System.Drawing.Size(139, 72);
            this.Meniu_austria.TabIndex = 0;
            this.Meniu_austria.Text = "Meniu";
            this.Meniu_austria.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Meniu_austria.UseVisualStyleBackColor = true;
            this.Meniu_austria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Meniu_austria_MouseClick);
            // 
            // Istorie_austria
            // 
            this.Istorie_austria.Location = new System.Drawing.Point(360, 80);
            this.Istorie_austria.Name = "Istorie_austria";
            this.Istorie_austria.Size = new System.Drawing.Size(130, 60);
            this.Istorie_austria.TabIndex = 1;
            this.Istorie_austria.Text = "Istorie";
            this.Istorie_austria.UseVisualStyleBackColor = true;
            this.Istorie_austria.Visible = false;
            this.Istorie_austria.Click += new System.EventHandler(this.Istorie_austria_Click);
            // 
            // Economie_austria
            // 
            this.Economie_austria.Location = new System.Drawing.Point(360, 200);
            this.Economie_austria.Name = "Economie_austria";
            this.Economie_austria.Size = new System.Drawing.Size(130, 60);
            this.Economie_austria.TabIndex = 2;
            this.Economie_austria.Text = "Economie";
            this.Economie_austria.UseVisualStyleBackColor = true;
            this.Economie_austria.Visible = false;
            this.Economie_austria.Click += new System.EventHandler(this.Economie_austria_Click);
            // 
            // Geografie_austria
            // 
            this.Geografie_austria.Location = new System.Drawing.Point(360, 140);
            this.Geografie_austria.Name = "Geografie_austria";
            this.Geografie_austria.Size = new System.Drawing.Size(130, 60);
            this.Geografie_austria.TabIndex = 3;
            this.Geografie_austria.Text = "Geografie";
            this.Geografie_austria.UseVisualStyleBackColor = true;
            this.Geografie_austria.Visible = false;
            this.Geografie_austria.Click += new System.EventHandler(this.Geografie_austria_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Austria_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Harta_Interactiva.Properties.Resources.austria211;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Geografie_austria);
            this.Controls.Add(this.Economie_austria);
            this.Controls.Add(this.Istorie_austria);
            this.Controls.Add(this.Meniu_austria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Austria_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Austria_form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Austria_form_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Meniu_austria;
        private System.Windows.Forms.Button Istorie_austria;
        private System.Windows.Forms.Button Economie_austria;
        private System.Windows.Forms.Button Geografie_austria;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}