namespace FrmView
{
    partial class FrmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            this.lblTitleComida = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTitleTiempo = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblTmp = new System.Windows.Forms.Label();
            this.lblTitleTmp = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.rchElaborando = new System.Windows.Forms.RichTextBox();
            this.rchFinalizados = new System.Windows.Forms.RichTextBox();
            this.lblFinalizados = new System.Windows.Forms.Label();
            this.pcbComida = new System.Windows.Forms.PictureBox();
            this.lblProximaComida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbComida)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleComida
            // 
            this.lblTitleComida.AutoSize = true;
            this.lblTitleComida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleComida.Location = new System.Drawing.Point(12, 9);
            this.lblTitleComida.Name = "lblTitleComida";
            this.lblTitleComida.Size = new System.Drawing.Size(148, 32);
            this.lblTitleComida.TabIndex = 1;
            this.lblTitleComida.Text = "Preparando: ";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTiempo.Location = new System.Drawing.Point(711, 174);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(87, 32);
            this.lblTiempo.TabIndex = 5;
            this.lblTiempo.Text = "tiempo";
            // 
            // lblTitleTiempo
            // 
            this.lblTitleTiempo.AutoSize = true;
            this.lblTitleTiempo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleTiempo.Location = new System.Drawing.Point(610, 138);
            this.lblTitleTiempo.Name = "lblTitleTiempo";
            this.lblTitleTiempo.Size = new System.Drawing.Size(305, 32);
            this.lblTitleTiempo.TabIndex = 4;
            this.lblTitleTiempo.Text = "Tiempo Preparacion Actual:";
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Image = global::FrmView.Properties.Resources.open_icon;
            this.btnAbrir.Location = new System.Drawing.Point(711, 21);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(64, 62);
            this.btnAbrir.TabIndex = 6;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblTmp
            // 
            this.lblTmp.AutoSize = true;
            this.lblTmp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTmp.Location = new System.Drawing.Point(601, 304);
            this.lblTmp.Name = "lblTmp";
            this.lblTmp.Size = new System.Drawing.Size(286, 32);
            this.lblTmp.TabIndex = 9;
            this.lblTmp.Text = "tiempo medio de atencion";
            // 
            // lblTitleTmp
            // 
            this.lblTitleTmp.AutoSize = true;
            this.lblTitleTmp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleTmp.Location = new System.Drawing.Point(591, 258);
            this.lblTitleTmp.Name = "lblTitleTmp";
            this.lblTitleTmp.Size = new System.Drawing.Size(341, 32);
            this.lblTitleTmp.TabIndex = 8;
            this.lblTitleTmp.Text = "Tiempo medio de Preparacion:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.Image = global::FrmView.Properties.Resources.comida_icon;
            this.btnSiguiente.Location = new System.Drawing.Point(220, 156);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(96, 96);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // rchElaborando
            // 
            this.rchElaborando.Location = new System.Drawing.Point(12, 51);
            this.rchElaborando.Name = "rchElaborando";
            this.rchElaborando.Size = new System.Drawing.Size(548, 82);
            this.rchElaborando.TabIndex = 14;
            this.rchElaborando.Text = "";
            // 
            // rchFinalizados
            // 
            this.rchFinalizados.Location = new System.Drawing.Point(12, 258);
            this.rchFinalizados.Name = "rchFinalizados";
            this.rchFinalizados.Size = new System.Drawing.Size(548, 96);
            this.rchFinalizados.TabIndex = 15;
            this.rchFinalizados.Text = "";
            // 
            // lblFinalizados
            // 
            this.lblFinalizados.AutoSize = true;
            this.lblFinalizados.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFinalizados.Location = new System.Drawing.Point(12, 223);
            this.lblFinalizados.Name = "lblFinalizados";
            this.lblFinalizados.Size = new System.Drawing.Size(136, 32);
            this.lblFinalizados.TabIndex = 16;
            this.lblFinalizados.Text = "Finalizados:";
            // 
            // pcbComida
            // 
            this.pcbComida.Location = new System.Drawing.Point(12, 139);
            this.pcbComida.Name = "pcbComida";
            this.pcbComida.Size = new System.Drawing.Size(102, 81);
            this.pcbComida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbComida.TabIndex = 17;
            this.pcbComida.TabStop = false;
            // 
            // lblProximaComida
            // 
            this.lblProximaComida.AutoSize = true;
            this.lblProximaComida.Location = new System.Drawing.Point(220, 138);
            this.lblProximaComida.Name = "lblProximaComida";
            this.lblProximaComida.Size = new System.Drawing.Size(99, 15);
            this.lblProximaComida.TabIndex = 18;
            this.lblProximaComida.Text = "Proxima Comida:";
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FrmView.Properties.Resources.cocinero_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(943, 366);
            this.Controls.Add(this.lblProximaComida);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pcbComida);
            this.Controls.Add(this.lblFinalizados);
            this.Controls.Add(this.rchFinalizados);
            this.Controls.Add(this.rchElaborando);
            this.Controls.Add(this.lblTmp);
            this.Controls.Add(this.lblTitleTmp);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTitleTiempo);
            this.Controls.Add(this.lblTitleComida);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cocinero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcbComida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitleComida;
        private Label lblTiempo;
        private Label lblTitleTiempo;
        private Button btnAbrir;
        private Label lblTmp;
        private Label lblTitleTmp;
        private Button btnSiguiente;
        private RichTextBox rchElaborando;
        private RichTextBox rchFinalizados;
        private Label lblFinalizados;
        private PictureBox pcbComida;
        private Label lblProximaComida;
    }
}