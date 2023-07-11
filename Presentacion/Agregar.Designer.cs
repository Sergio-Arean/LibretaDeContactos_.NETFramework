namespace Presentacion
{
    partial class Agregar
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
            this.groupBoxContacto = new System.Windows.Forms.GroupBox();
            this.btnAdjuntar = new FontAwesome.Sharp.IconButton();
            this.tbFoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.ipbIconoGenerico = new FontAwesome.Sharp.IconPictureBox();
            this.groupBoxContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbIconoGenerico)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxContacto
            // 
            this.groupBoxContacto.Controls.Add(this.btnAdjuntar);
            this.groupBoxContacto.Controls.Add(this.tbFoto);
            this.groupBoxContacto.Controls.Add(this.label4);
            this.groupBoxContacto.Controls.Add(this.tbEmail);
            this.groupBoxContacto.Controls.Add(this.tbTelefono);
            this.groupBoxContacto.Controls.Add(this.tbNombre);
            this.groupBoxContacto.Controls.Add(this.label3);
            this.groupBoxContacto.Controls.Add(this.label2);
            this.groupBoxContacto.Controls.Add(this.label1);
            this.groupBoxContacto.Location = new System.Drawing.Point(57, 32);
            this.groupBoxContacto.Name = "groupBoxContacto";
            this.groupBoxContacto.Size = new System.Drawing.Size(466, 231);
            this.groupBoxContacto.TabIndex = 0;
            this.groupBoxContacto.TabStop = false;
            this.groupBoxContacto.Text = "Nuevo Contacto";
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdjuntar.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.btnAdjuntar.IconColor = System.Drawing.Color.Black;
            this.btnAdjuntar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdjuntar.IconSize = 18;
            this.btnAdjuntar.Location = new System.Drawing.Point(413, 185);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(34, 25);
            this.btnAdjuntar.TabIndex = 20;
            this.btnAdjuntar.UseVisualStyleBackColor = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // tbFoto
            // 
            this.tbFoto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbFoto.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.tbFoto.Location = new System.Drawing.Point(138, 178);
            this.tbFoto.Name = "tbFoto";
            this.tbFoto.Size = new System.Drawing.Size(269, 40);
            this.tbFoto.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Foto:";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbEmail.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.tbEmail.Location = new System.Drawing.Point(138, 127);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(269, 40);
            this.tbEmail.TabIndex = 17;
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbTelefono.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(138, 75);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(269, 40);
            this.tbTelefono.TabIndex = 16;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbNombre.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(138, 26);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(269, 40);
            this.tbNombre.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 13;
            this.label2.Tag = "";
            this.label2.Text = "Teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(302, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 42);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Silver;
            this.btnAceptar.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAceptar.IconColor = System.Drawing.Color.Black;
            this.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar.IconSize = 30;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAceptar.Location = new System.Drawing.Point(179, 283);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(117, 42);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(570, 78);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(178, 155);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 23;
            this.pbFoto.TabStop = false;
            // 
            // ipbIconoGenerico
            // 
            this.ipbIconoGenerico.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ipbIconoGenerico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbIconoGenerico.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ipbIconoGenerico.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbIconoGenerico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbIconoGenerico.IconSize = 136;
            this.ipbIconoGenerico.Location = new System.Drawing.Point(595, 87);
            this.ipbIconoGenerico.Name = "ipbIconoGenerico";
            this.ipbIconoGenerico.Size = new System.Drawing.Size(137, 136);
            this.ipbIconoGenerico.TabIndex = 24;
            this.ipbIconoGenerico.TabStop = false;
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(782, 323);
            this.Controls.Add(this.ipbIconoGenerico);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBoxContacto);
            this.MaximumSize = new System.Drawing.Size(800, 370);
            this.MinimumSize = new System.Drawing.Size(800, 370);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.groupBoxContacto.ResumeLayout(false);
            this.groupBoxContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbIconoGenerico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxContacto;
        private FontAwesome.Sharp.IconButton btnAdjuntar;
        private System.Windows.Forms.TextBox tbFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private System.Windows.Forms.PictureBox pbFoto;
        private FontAwesome.Sharp.IconPictureBox ipbIconoGenerico;
    }
}