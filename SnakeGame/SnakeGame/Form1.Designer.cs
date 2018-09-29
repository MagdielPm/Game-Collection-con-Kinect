namespace SnakeGame
{
    partial class Form1
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
            this.bucle = new System.Windows.Forms.Timer(this.components);
            this.game = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.puntaje = new System.Windows.Forms.Label();
            this.CordX = new System.Windows.Forms.Label();
            this.CordY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.game)).BeginInit();
            this.SuspendLayout();
            // 
            // bucle
            // 
            this.bucle.Enabled = true;
            this.bucle.Tick += new System.EventHandler(this.bucle_Tick);
            // 
            // game
            // 
            this.game.Location = new System.Drawing.Point(42, 35);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(1130, 420);
            this.game.TabIndex = 3;
            this.game.TabStop = false;
            this.game.Click += new System.EventHandler(this.game_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Puntaje:";
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.Font = new System.Drawing.Font("Yu Gothic UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntaje.Location = new System.Drawing.Point(487, 460);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(42, 50);
            this.puntaje.TabIndex = 5;
            this.puntaje.Text = "0";
            this.puntaje.Click += new System.EventHandler(this.puntaje_Click);
            // 
            // CordX
            // 
            this.CordX.AutoSize = true;
            this.CordX.Location = new System.Drawing.Point(707, 492);
            this.CordX.Name = "CordX";
            this.CordX.Size = new System.Drawing.Size(46, 17);
            this.CordX.TabIndex = 6;
            this.CordX.Text = "label2";
            // 
            // CordY
            // 
            this.CordY.AutoSize = true;
            this.CordY.Location = new System.Drawing.Point(810, 492);
            this.CordY.Name = "CordY";
            this.CordY.Size = new System.Drawing.Size(46, 17);
            this.CordY.TabIndex = 7;
            this.CordY.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 531);
            this.Controls.Add(this.CordY);
            this.Controls.Add(this.CordX);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.game);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.game)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer bucle;
        private System.Windows.Forms.PictureBox game;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label puntaje;
        private System.Windows.Forms.Label CordX;
        private System.Windows.Forms.Label CordY;
    }
}

