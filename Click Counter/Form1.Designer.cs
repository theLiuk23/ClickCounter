
namespace Click_Counter
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCounter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showClicks = new System.Windows.Forms.TextBox();
            this.testoCommento = new System.Windows.Forms.RichTextBox();
            this.bottonePulisci = new System.Windows.Forms.Button();
            this.bottoneInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCounter
            // 
            this.btnCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCounter.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCounter.Location = new System.Drawing.Point(12, 247);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(296, 141);
            this.btnCounter.TabIndex = 0;
            this.btnCounter.Text = "Click here!";
            this.btnCounter.UseVisualStyleBackColor = true;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "hai cliccato ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "volte";
            // 
            // showClicks
            // 
            this.showClicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showClicks.Location = new System.Drawing.Point(222, 17);
            this.showClicks.Name = "showClicks";
            this.showClicks.Size = new System.Drawing.Size(102, 31);
            this.showClicks.TabIndex = 4;
            // 
            // testoCommento
            // 
            this.testoCommento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testoCommento.Location = new System.Drawing.Point(12, 54);
            this.testoCommento.Name = "testoCommento";
            this.testoCommento.Size = new System.Drawing.Size(432, 144);
            this.testoCommento.TabIndex = 5;
            this.testoCommento.Text = "";
            // 
            // bottonePulisci
            // 
            this.bottonePulisci.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottonePulisci.Location = new System.Drawing.Point(314, 323);
            this.bottonePulisci.Name = "bottonePulisci";
            this.bottonePulisci.Size = new System.Drawing.Size(130, 65);
            this.bottonePulisci.TabIndex = 6;
            this.bottonePulisci.Text = "Pulisci";
            this.bottonePulisci.UseVisualStyleBackColor = true;
            this.bottonePulisci.Click += new System.EventHandler(this.bottonePulisci_Click);
            // 
            // bottoneInfo
            // 
            this.bottoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottoneInfo.Location = new System.Drawing.Point(314, 247);
            this.bottoneInfo.Name = "bottoneInfo";
            this.bottoneInfo.Size = new System.Drawing.Size(129, 70);
            this.bottoneInfo.TabIndex = 7;
            this.bottoneInfo.Text = "Info sull\'autore";
            this.bottoneInfo.UseVisualStyleBackColor = true;
            this.bottoneInfo.Click += new System.EventHandler(this.bottoneInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "N.B = Il massimo numero di click è impostato a 10\'000.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Al raggiungimento del numero massimo verranno ripulite le caselle!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bottoneInfo);
            this.Controls.Add(this.bottonePulisci);
            this.Controls.Add(this.testoCommento);
            this.Controls.Add(this.showClicks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCounter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Click Counter®™ - made by Luca Dalla Villa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox showClicks;
        private System.Windows.Forms.RichTextBox testoCommento;
        private System.Windows.Forms.Button bottonePulisci;
        private System.Windows.Forms.Button bottoneInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

