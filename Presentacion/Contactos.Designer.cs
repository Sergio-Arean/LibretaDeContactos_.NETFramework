namespace Presentacion
{
    partial class Contactos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtnEditar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.ipbIconoGenerico = new FontAwesome.Sharp.IconPictureBox();
            this.ipbLupa = new FontAwesome.Sharp.IconPictureBox();
            this.lblInicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbIconoGenerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContactos
            // 
            this.dgvContactos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContactos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContactos.Location = new System.Drawing.Point(32, 65);
            this.dgvContactos.MultiSelect = false;
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.RowTemplate.Height = 24;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(514, 204);
            this.dgvContactos.TabIndex = 0;
            this.dgvContactos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellClick);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(582, 83);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(178, 155);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscar.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(132, 30);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(265, 29);
            this.tbBuscar.TabIndex = 2;
            this.tbBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar:";
            // 
            // ibtnEditar
            // 
            this.ibtnEditar.BackColor = System.Drawing.Color.Silver;
            this.ibtnEditar.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.ibtnEditar.IconColor = System.Drawing.Color.Black;
            this.ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEditar.IconSize = 25;
            this.ibtnEditar.Location = new System.Drawing.Point(149, 283);
            this.ibtnEditar.Name = "ibtnEditar";
            this.ibtnEditar.Size = new System.Drawing.Size(118, 34);
            this.ibtnEditar.TabIndex = 4;
            this.ibtnEditar.Text = "Editar";
            this.ibtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEditar.UseVisualStyleBackColor = false;
            this.ibtnEditar.Click += new System.EventHandler(this.ibtnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Silver;
            this.btnEliminar.Font = new System.Drawing.Font("Yu Gothic", 10.2F);
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.Location = new System.Drawing.Point(296, 283);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinResultados.Location = new System.Drawing.Point(241, 106);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(99, 17);
            this.lblSinResultados.TabIndex = 6;
            this.lblSinResultados.Text = "Sin Resultados";
            this.lblSinResultados.Visible = false;
            // 
            // ipbIconoGenerico
            // 
            this.ipbIconoGenerico.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ipbIconoGenerico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbIconoGenerico.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ipbIconoGenerico.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbIconoGenerico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbIconoGenerico.IconSize = 136;
            this.ipbIconoGenerico.Location = new System.Drawing.Point(605, 93);
            this.ipbIconoGenerico.Name = "ipbIconoGenerico";
            this.ipbIconoGenerico.Size = new System.Drawing.Size(137, 136);
            this.ipbIconoGenerico.TabIndex = 7;
            this.ipbIconoGenerico.TabStop = false;
            // 
            // ipbLupa
            // 
            this.ipbLupa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ipbLupa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipbLupa.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ipbLupa.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipbLupa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbLupa.Location = new System.Drawing.Point(34, 22);
            this.ipbLupa.Name = "ipbLupa";
            this.ipbLupa.Size = new System.Drawing.Size(32, 32);
            this.ipbLupa.TabIndex = 8;
            this.ipbLupa.TabStop = false;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(118, 147);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(337, 17);
            this.lblInicio.TabIndex = 9;
            this.lblInicio.Text = "Haga click en \'Agregar\' para añadir su primer contacto";
            this.lblInicio.Visible = false;
            // 
            // Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(782, 323);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.ipbLupa);
            this.Controls.Add(this.ipbIconoGenerico);
            this.Controls.Add(this.lblSinResultados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.ibtnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.dgvContactos);
            this.MaximumSize = new System.Drawing.Size(800, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 370);
            this.Name = "Contactos";
            this.Text = "Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbIconoGenerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Label lblSinResultados;
        private FontAwesome.Sharp.IconPictureBox ipbIconoGenerico;
        private FontAwesome.Sharp.IconPictureBox ipbLupa;
        private System.Windows.Forms.Label lblInicio;
    }
}