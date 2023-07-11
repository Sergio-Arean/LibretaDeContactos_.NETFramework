namespace Presentacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.iconMenuItemSalir = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemAgregar = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemContactos = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.menuStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.AutoSize = false;
            this.menuStripPrincipal.BackColor = System.Drawing.Color.YellowGreen;
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItemSalir,
            this.iconMenuItemAgregar,
            this.iconMenuItemContactos});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 80);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            this.menuStripPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStripPrincipal_MouseMove);
            // 
            // iconMenuItemSalir
            // 
            this.iconMenuItemSalir.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItemSalir.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconMenuItemSalir.IconColor = System.Drawing.Color.Black;
            this.iconMenuItemSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemSalir.IconSize = 50;
            this.iconMenuItemSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItemSalir.Name = "iconMenuItemSalir";
            this.iconMenuItemSalir.Size = new System.Drawing.Size(64, 76);
            this.iconMenuItemSalir.Text = "Salir";
            this.iconMenuItemSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItemSalir.Click += new System.EventHandler(this.iconMenuItemSalir_Click);
            this.iconMenuItemSalir.MouseEnter += new System.EventHandler(this.iconMenuItemSalir_MouseEnter);
            this.iconMenuItemSalir.MouseLeave += new System.EventHandler(this.iconMenuItemSalir_MouseLeave);
            // 
            // iconMenuItemAgregar
            // 
            this.iconMenuItemAgregar.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItemAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconMenuItemAgregar.IconColor = System.Drawing.Color.Black;
            this.iconMenuItemAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemAgregar.IconSize = 50;
            this.iconMenuItemAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItemAgregar.Name = "iconMenuItemAgregar";
            this.iconMenuItemAgregar.Size = new System.Drawing.Size(75, 76);
            this.iconMenuItemAgregar.Text = "Agregar";
            this.iconMenuItemAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItemAgregar.Click += new System.EventHandler(this.iconMenuItemAgregar_Click);
            // 
            // iconMenuItemContactos
            // 
            this.iconMenuItemContactos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.iconMenuItemContactos.Checked = true;
            this.iconMenuItemContactos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iconMenuItemContactos.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItemContactos.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iconMenuItemContactos.IconColor = System.Drawing.Color.Black;
            this.iconMenuItemContactos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemContactos.IconSize = 50;
            this.iconMenuItemContactos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItemContactos.Name = "iconMenuItemContactos";
            this.iconMenuItemContactos.Size = new System.Drawing.Size(92, 76);
            this.iconMenuItemContactos.Text = "Contactos";
            this.iconMenuItemContactos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItemContactos.Click += new System.EventHandler(this.iconMenuItemContactos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libreta de Contactos";
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.LightSteelBlue;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 80);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(800, 370);
            this.content.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.YellowGreen;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 20);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(48, 40);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.content);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStripPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemSalir;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemContactos;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemAgregar;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

