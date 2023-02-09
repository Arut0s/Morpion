
namespace Morpion
{
    partial class Morpion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Morpion));
            this.label1 = new System.Windows.Forms.Label();
            this.lblJoueur = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joueur : ";
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueur.Location = new System.Drawing.Point(56, 19);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(41, 13);
            this.lblJoueur.TabIndex = 1;
            this.lblJoueur.Text = "label2";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackgroundImage = global::Morpion.Properties.Resources._1142347;
            this.btnPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayAgain.Location = new System.Drawing.Point(125, 205);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(50, 34);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Location = new System.Drawing.Point(12, 213);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(35, 13);
            this.lblWin.TabIndex = 3;
            this.lblWin.Text = "label2";
            // 
            // Morpion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 248);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Morpion";
            this.Text = "Morpion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblWin;
    }
}

