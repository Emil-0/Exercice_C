
namespace Projet_Boutons
{
    partial class Couleurs
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
            this.CmdBleu = new System.Windows.Forms.Button();
            this.CmdVert = new System.Windows.Forms.Button();
            this.CmdRouge = new System.Windows.Forms.Button();
            this.ClicksBleu = new System.Windows.Forms.Label();
            this.ClicksVert = new System.Windows.Forms.Label();
            this.ClicksRouge = new System.Windows.Forms.Label();
            this.CmdRéinitialiser = new System.Windows.Forms.Button();
            this.CmdFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdBleu
            // 
            this.CmdBleu.Location = new System.Drawing.Point(353, 110);
            this.CmdBleu.Name = "CmdBleu";
            this.CmdBleu.Size = new System.Drawing.Size(109, 43);
            this.CmdBleu.TabIndex = 0;
            this.CmdBleu.Text = "Bleu";
            this.CmdBleu.UseVisualStyleBackColor = true;
            this.CmdBleu.Click += new System.EventHandler(this.CmdBleu_Click);
            // 
            // CmdVert
            // 
            this.CmdVert.Location = new System.Drawing.Point(353, 192);
            this.CmdVert.Name = "CmdVert";
            this.CmdVert.Size = new System.Drawing.Size(109, 43);
            this.CmdVert.TabIndex = 1;
            this.CmdVert.Text = "Vert";
            this.CmdVert.UseVisualStyleBackColor = true;
            this.CmdVert.Click += new System.EventHandler(this.CmdVert_Click);
            // 
            // CmdRouge
            // 
            this.CmdRouge.Location = new System.Drawing.Point(353, 275);
            this.CmdRouge.Name = "CmdRouge";
            this.CmdRouge.Size = new System.Drawing.Size(109, 43);
            this.CmdRouge.TabIndex = 2;
            this.CmdRouge.Text = "Rouge";
            this.CmdRouge.UseVisualStyleBackColor = true;
            this.CmdRouge.Click += new System.EventHandler(this.CmdRouge_Click);
            // 
            // ClicksBleu
            // 
            this.ClicksBleu.AutoSize = true;
            this.ClicksBleu.Location = new System.Drawing.Point(387, 157);
            this.ClicksBleu.Name = "ClicksBleu";
            this.ClicksBleu.Size = new System.Drawing.Size(28, 17);
            this.ClicksBleu.TabIndex = 3;
            this.ClicksBleu.Text = "****";
            // 
            // ClicksVert
            // 
            this.ClicksVert.AutoSize = true;
            this.ClicksVert.Location = new System.Drawing.Point(387, 239);
            this.ClicksVert.Name = "ClicksVert";
            this.ClicksVert.Size = new System.Drawing.Size(28, 17);
            this.ClicksVert.TabIndex = 4;
            this.ClicksVert.Text = "****";
            // 
            // ClicksRouge
            // 
            this.ClicksRouge.AutoSize = true;
            this.ClicksRouge.Location = new System.Drawing.Point(387, 322);
            this.ClicksRouge.Name = "ClicksRouge";
            this.ClicksRouge.Size = new System.Drawing.Size(28, 17);
            this.ClicksRouge.TabIndex = 5;
            this.ClicksRouge.Text = "****";
            // 
            // CmdRéinitialiser
            // 
            this.CmdRéinitialiser.Location = new System.Drawing.Point(353, 395);
            this.CmdRéinitialiser.Name = "CmdRéinitialiser";
            this.CmdRéinitialiser.Size = new System.Drawing.Size(109, 43);
            this.CmdRéinitialiser.TabIndex = 6;
            this.CmdRéinitialiser.Text = "Réinitialisation";
            this.CmdRéinitialiser.UseVisualStyleBackColor = true;
            this.CmdRéinitialiser.Click += new System.EventHandler(this.CmdRéinitialiser_Click);
            // 
            // CmdFin
            // 
            this.CmdFin.Location = new System.Drawing.Point(708, 413);
            this.CmdFin.Name = "CmdFin";
            this.CmdFin.Size = new System.Drawing.Size(45, 24);
            this.CmdFin.TabIndex = 7;
            this.CmdFin.Text = "Fin";
            this.CmdFin.UseVisualStyleBackColor = true;
            this.CmdFin.Click += new System.EventHandler(this.CmdFin_Click);
            // 
            // Couleurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdFin);
            this.Controls.Add(this.CmdRéinitialiser);
            this.Controls.Add(this.ClicksRouge);
            this.Controls.Add(this.ClicksVert);
            this.Controls.Add(this.ClicksBleu);
            this.Controls.Add(this.CmdRouge);
            this.Controls.Add(this.CmdVert);
            this.Controls.Add(this.CmdBleu);
            this.Name = "Couleurs";
            this.Text = "Couleurs";
            this.Click += new System.EventHandler(this.Couleurs_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdBleu;
        private System.Windows.Forms.Button CmdVert;
        private System.Windows.Forms.Button CmdRouge;
        private System.Windows.Forms.Label ClicksBleu;
        private System.Windows.Forms.Label ClicksVert;
        private System.Windows.Forms.Label ClicksRouge;
        private System.Windows.Forms.Button CmdRéinitialiser;
        private System.Windows.Forms.Button CmdFin;
    }
}

