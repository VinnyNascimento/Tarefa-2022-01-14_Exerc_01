
namespace Exerc_01
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
            this.lblRua1 = new System.Windows.Forms.Label();
            this.lblRua2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.btnVermelho = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.picRua1 = new System.Windows.Forms.PictureBox();
            this.picRua2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRua1
            // 
            this.lblRua1.AutoSize = true;
            this.lblRua1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRua1.Location = new System.Drawing.Point(130, 63);
            this.lblRua1.Name = "lblRua1";
            this.lblRua1.Size = new System.Drawing.Size(19, 21);
            this.lblRua1.TabIndex = 0;
            this.lblRua1.Text = "0";
            // 
            // lblRua2
            // 
            this.lblRua2.AutoSize = true;
            this.lblRua2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRua2.Location = new System.Drawing.Point(558, 63);
            this.lblRua2.Name = "lblRua2";
            this.lblRua2.Size = new System.Drawing.Size(19, 21);
            this.lblRua2.TabIndex = 1;
            this.lblRua2.Text = "0";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(340, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(19, 21);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "0";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRua.Location = new System.Drawing.Point(300, 55);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(100, 29);
            this.txtRua.TabIndex = 3;
            //this.txtRua.TextChanged += new System.EventHandler(this.txtRua_TextChanged);
            // 
            // btnVermelho
            // 
            this.btnVermelho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVermelho.Location = new System.Drawing.Point(300, 125);
            this.btnVermelho.Name = "btnVermelho";
            this.btnVermelho.Size = new System.Drawing.Size(100, 33);
            this.btnVermelho.TabIndex = 4;
            this.btnVermelho.Text = "Vermelho";
            this.btnVermelho.UseVisualStyleBackColor = true;
            this.btnVermelho.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAmarelo.Location = new System.Drawing.Point(300, 173);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(100, 33);
            this.btnAmarelo.TabIndex = 5;
            this.btnAmarelo.Text = "Amarelo";
            this.btnAmarelo.UseVisualStyleBackColor = true;
            this.btnAmarelo.Click += new System.EventHandler(this.btnAmarelo_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerde.Location = new System.Drawing.Point(300, 221);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(100, 33);
            this.btnVerde.TabIndex = 6;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = true;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // picRua1
            // 
            this.picRua1.Image = global::Exerc_01.Properties.Resources.semaforo_vermelho;
            this.picRua1.Location = new System.Drawing.Point(104, 125);
            this.picRua1.Name = "picRua1";
            this.picRua1.Size = new System.Drawing.Size(67, 165);
            this.picRua1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRua1.TabIndex = 8;
            this.picRua1.TabStop = false;
            this.picRua1.Click += new System.EventHandler(this.picVermelho_Click);
            // 
            // picRua2
            // 
            this.picRua2.Image = global::Exerc_01.Properties.Resources.semaforo_amarelo;
            this.picRua2.Location = new System.Drawing.Point(532, 125);
            this.picRua2.Name = "picRua2";
            this.picRua2.Size = new System.Drawing.Size(67, 165);
            this.picRua2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRua2.TabIndex = 9;
            this.picRua2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 318);
            this.Controls.Add(this.picRua2);
            this.Controls.Add(this.picRua1);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.btnVermelho);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRua2);
            this.Controls.Add(this.lblRua1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRua1;
        private System.Windows.Forms.Label lblRua2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Button btnVermelho;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.PictureBox picRua1;
        private System.Windows.Forms.PictureBox picRua2;
    }
}

