namespace Harta_Interactiva
{
    partial class Regatul_Unit_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regatul_Unit_form));
            this.Meniu = new System.Windows.Forms.Button();
            this.Istorie = new System.Windows.Forms.Button();
            this.Economie = new System.Windows.Forms.Button();
            this.Geografie = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Meniu
            // 
            this.Meniu.Location = new System.Drawing.Point(17, 220);
            this.Meniu.Name = "Meniu";
            this.Meniu.Size = new System.Drawing.Size(102, 72);
            this.Meniu.TabIndex = 0;
            this.Meniu.Text = "Meniu";
            this.Meniu.UseVisualStyleBackColor = true;
            this.Meniu.Click += new System.EventHandler(this.Meniu_Click);
            // 
            // Istorie
            // 
            this.Istorie.Location = new System.Drawing.Point(125, 136);
            this.Istorie.Name = "Istorie";
            this.Istorie.Size = new System.Drawing.Size(105, 83);
            this.Istorie.TabIndex = 1;
            this.Istorie.Text = "Istorie";
            this.Istorie.UseVisualStyleBackColor = true;
            this.Istorie.Visible = false;
            this.Istorie.Click += new System.EventHandler(this.Istorie_Click);
            // 
            // Economie
            // 
            this.Economie.Location = new System.Drawing.Point(125, 296);
            this.Economie.Name = "Economie";
            this.Economie.Size = new System.Drawing.Size(105, 83);
            this.Economie.TabIndex = 2;
            this.Economie.Text = "Economie";
            this.Economie.UseVisualStyleBackColor = true;
            this.Economie.Visible = false;
            this.Economie.Click += new System.EventHandler(this.Economie_Click);
            // 
            // Geografie
            // 
            this.Geografie.Location = new System.Drawing.Point(125, 215);
            this.Geografie.Name = "Geografie";
            this.Geografie.Size = new System.Drawing.Size(105, 83);
            this.Geografie.TabIndex = 3;
            this.Geografie.Text = "Geografie";
            this.Geografie.UseVisualStyleBackColor = true;
            this.Geografie.Visible = false;
            this.Geografie.Click += new System.EventHandler(this.Geografie_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Harta_Interactiva.Properties.Resources.physical_map_of_UK;
            this.pictureBox1.Location = new System.Drawing.Point(277, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 541);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Regatul_Unit_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Harta_Interactiva.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Geografie);
            this.Controls.Add(this.Economie);
            this.Controls.Add(this.Istorie);
            this.Controls.Add(this.Meniu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Regatul_Unit_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regatul_Unit_form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Regatul_Unit_form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Meniu;
        private System.Windows.Forms.Button Istorie;
        private System.Windows.Forms.Button Economie;
        private System.Windows.Forms.Button Geografie;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}