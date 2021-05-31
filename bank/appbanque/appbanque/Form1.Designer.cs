
namespace appbanque
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.epargneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virementCCourantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virementCEpargneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeClientToolStripMenuItem,
            this.gestionDeCompteToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // gestionDeClientToolStripMenuItem
            // 
            this.gestionDeClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.afficherToolStripMenuItem});
            this.gestionDeClientToolStripMenuItem.Name = "gestionDeClientToolStripMenuItem";
            this.gestionDeClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDeClientToolStripMenuItem.Text = "gestion de client";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.afficherToolStripMenuItem.Text = "afficher";
            // 
            // gestionDeCompteToolStripMenuItem
            // 
            this.gestionDeCompteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.afficherToolStripMenuItem1});
            this.gestionDeCompteToolStripMenuItem.Name = "gestionDeCompteToolStripMenuItem";
            this.gestionDeCompteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDeCompteToolStripMenuItem.Text = "gestion de compte";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.epargneToolStripMenuItem,
            this.courantToolStripMenuItem});
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem1.Text = "ajouter";
            // 
            // epargneToolStripMenuItem
            // 
            this.epargneToolStripMenuItem.Name = "epargneToolStripMenuItem";
            this.epargneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.epargneToolStripMenuItem.Text = "epargne";
            this.epargneToolStripMenuItem.Click += new System.EventHandler(this.epargneToolStripMenuItem_Click);
            // 
            // courantToolStripMenuItem
            // 
            this.courantToolStripMenuItem.Name = "courantToolStripMenuItem";
            this.courantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.courantToolStripMenuItem.Text = "courant";
            this.courantToolStripMenuItem.Click += new System.EventHandler(this.courantToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem1
            // 
            this.afficherToolStripMenuItem1.Name = "afficherToolStripMenuItem1";
            this.afficherToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.afficherToolStripMenuItem1.Text = "afficher";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertisseurToolStripMenuItem,
            this.virementToolStripMenuItem,
            this.afficherOperationsToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.servicesToolStripMenuItem.Text = "services";
            // 
            // convertisseurToolStripMenuItem
            // 
            this.convertisseurToolStripMenuItem.Name = "convertisseurToolStripMenuItem";
            this.convertisseurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertisseurToolStripMenuItem.Text = "convertisseur";
            this.convertisseurToolStripMenuItem.Click += new System.EventHandler(this.convertisseurToolStripMenuItem_Click);
            // 
            // virementToolStripMenuItem
            // 
            this.virementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.virementCCourantToolStripMenuItem,
            this.virementCEpargneToolStripMenuItem});
            this.virementToolStripMenuItem.Name = "virementToolStripMenuItem";
            this.virementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.virementToolStripMenuItem.Text = "virement";
            this.virementToolStripMenuItem.Click += new System.EventHandler(this.virementToolStripMenuItem_Click);
            // 
            // afficherOperationsToolStripMenuItem
            // 
            this.afficherOperationsToolStripMenuItem.Name = "afficherOperationsToolStripMenuItem";
            this.afficherOperationsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.afficherOperationsToolStripMenuItem.Text = "afficher operations";
            // 
            // virementCCourantToolStripMenuItem
            // 
            this.virementCCourantToolStripMenuItem.Name = "virementCCourantToolStripMenuItem";
            this.virementCCourantToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.virementCCourantToolStripMenuItem.Text = "virement c courant";
            this.virementCCourantToolStripMenuItem.Click += new System.EventHandler(this.virementCCourantToolStripMenuItem_Click);
            // 
            // virementCEpargneToolStripMenuItem
            // 
            this.virementCEpargneToolStripMenuItem.Name = "virementCEpargneToolStripMenuItem";
            this.virementCEpargneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.virementCEpargneToolStripMenuItem.Text = "virement c epargne";
            this.virementCEpargneToolStripMenuItem.Click += new System.EventHandler(this.virementCEpargneToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem epargneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virementCCourantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virementCEpargneToolStripMenuItem;
    }
}

