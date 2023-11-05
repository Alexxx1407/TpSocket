
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.textBoxSendS = new System.Windows.Forms.TextBox();
            this.textBoxReceiveS = new System.Windows.Forms.TextBox();
            this.buttonCreateS = new System.Windows.Forms.Button();
            this.buttonSendS = new System.Windows.Forms.Button();
            this.buttonReceiveS = new System.Windows.Forms.Button();
            this.buttonCloseS = new System.Windows.Forms.Button();
            this.textBoxIPS = new System.Windows.Forms.TextBox();
            this.textBoxPortS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSendS
            // 
            this.textBoxSendS.Location = new System.Drawing.Point(45, 367);
            this.textBoxSendS.Name = "textBoxSendS";
            this.textBoxSendS.Size = new System.Drawing.Size(100, 20);
            this.textBoxSendS.TabIndex = 0;
            // 
            // textBoxReceiveS
            // 
            this.textBoxReceiveS.Location = new System.Drawing.Point(45, 46);
            this.textBoxReceiveS.Multiline = true;
            this.textBoxReceiveS.Name = "textBoxReceiveS";
            this.textBoxReceiveS.Size = new System.Drawing.Size(313, 278);
            this.textBoxReceiveS.TabIndex = 1;
            // 
            // buttonCreateS
            // 
            this.buttonCreateS.Location = new System.Drawing.Point(192, 388);
            this.buttonCreateS.Name = "buttonCreateS";
            this.buttonCreateS.Size = new System.Drawing.Size(108, 23);
            this.buttonCreateS.TabIndex = 2;
            this.buttonCreateS.Text = "Créer socket UDP";
            this.buttonCreateS.UseVisualStyleBackColor = true;
            this.buttonCreateS.Click += new System.EventHandler(this.buttonCreateS_Click);
            // 
            // buttonSendS
            // 
            this.buttonSendS.Location = new System.Drawing.Point(225, 345);
            this.buttonSendS.Name = "buttonSendS";
            this.buttonSendS.Size = new System.Drawing.Size(75, 23);
            this.buttonSendS.TabIndex = 3;
            this.buttonSendS.Text = "Envoyer";
            this.buttonSendS.UseVisualStyleBackColor = true;
            this.buttonSendS.Click += new System.EventHandler(this.buttonSendS_Click);
            // 
            // buttonReceiveS
            // 
            this.buttonReceiveS.Location = new System.Drawing.Point(315, 388);
            this.buttonReceiveS.Name = "buttonReceiveS";
            this.buttonReceiveS.Size = new System.Drawing.Size(75, 23);
            this.buttonReceiveS.TabIndex = 4;
            this.buttonReceiveS.Text = "Recevoir";
            this.buttonReceiveS.UseVisualStyleBackColor = true;
            this.buttonReceiveS.Click += new System.EventHandler(this.buttonReceiveS_Click);
            // 
            // buttonCloseS
            // 
            this.buttonCloseS.Location = new System.Drawing.Point(315, 345);
            this.buttonCloseS.Name = "buttonCloseS";
            this.buttonCloseS.Size = new System.Drawing.Size(88, 23);
            this.buttonCloseS.TabIndex = 5;
            this.buttonCloseS.Text = "Fermer socket";
            this.buttonCloseS.UseVisualStyleBackColor = true;
            this.buttonCloseS.Click += new System.EventHandler(this.buttonCloseS_Click);
            // 
            // textBoxIPS
            // 
            this.textBoxIPS.Location = new System.Drawing.Point(593, 172);
            this.textBoxIPS.Name = "textBoxIPS";
            this.textBoxIPS.Size = new System.Drawing.Size(100, 20);
            this.textBoxIPS.TabIndex = 6;
            // 
            // textBoxPortS
            // 
            this.textBoxPortS.Location = new System.Drawing.Point(593, 199);
            this.textBoxPortS.Name = "textBoxPortS";
            this.textBoxPortS.Size = new System.Drawing.Size(100, 20);
            this.textBoxPortS.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPortS);
            this.Controls.Add(this.textBoxIPS);
            this.Controls.Add(this.buttonCloseS);
            this.Controls.Add(this.buttonReceiveS);
            this.Controls.Add(this.buttonSendS);
            this.Controls.Add(this.buttonCreateS);
            this.Controls.Add(this.textBoxReceiveS);
            this.Controls.Add(this.textBoxSendS);
            this.Name = "Form1";
            this.Text = "Communication par socket UDP ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSendS;
        private System.Windows.Forms.TextBox textBoxReceiveS;
        private System.Windows.Forms.Button buttonCreateS;
        private System.Windows.Forms.Button buttonSendS;
        private System.Windows.Forms.Button buttonReceiveS;
        private System.Windows.Forms.Button buttonCloseS;
        private System.Windows.Forms.TextBox textBoxIPS;
        private System.Windows.Forms.TextBox textBoxPortS;
    }
}

