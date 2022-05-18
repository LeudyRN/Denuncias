namespace TareaFinal
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Agregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.l = new System.Windows.Forms.Label();
            this.gridPkm = new System.Windows.Forms.DataGridView();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.e = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.ú = new System.Windows.Forms.Label();
            this.txtNombre_denunciado = new System.Windows.Forms.TextBox();
            this.w = new System.Windows.Forms.Label();
            this.txtCedula_denunciado = new System.Windows.Forms.TextBox();
            this.z = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.Label();
            this.txtTribunal = new System.Windows.Forms.ListBox();
            this.q = new System.Windows.Forms.Label();
            this.txtFecha_hecho = new System.Windows.Forms.TextBox();
            this.modificarDenuncias = new System.Windows.Forms.Button();
            this.Exportar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPkm)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.acercaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaToolStripMenuItem
            // 
            this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            this.acercaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.acercaToolStripMenuItem.Text = "Acerca";
            this.acercaToolStripMenuItem.Click += new System.EventHandler(this.acercaToolStripMenuItem_Click_1);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(173, 27);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(68, 80);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(51, 15);
            this.l.TabIndex = 3;
            this.l.Text = "Nombre";
            // 
            // gridPkm
            // 
            this.gridPkm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPkm.Location = new System.Drawing.Point(12, 350);
            this.gridPkm.Name = "gridPkm";
            this.gridPkm.RowTemplate.Height = 25;
            this.gridPkm.Size = new System.Drawing.Size(1017, 280);
            this.gridPkm.TabIndex = 4;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(125, 130);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(206, 23);
            this.txtCedula.TabIndex = 5;
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(75, 138);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(44, 15);
            this.e.TabIndex = 6;
            this.e.Text = "Cedula";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Location = new System.Drawing.Point(82, 192);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(37, 15);
            this.o.TabIndex = 7;
            this.o.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(125, 189);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(206, 23);
            this.txtTitulo.TabIndex = 8;
            // 
            // ú
            // 
            this.ú.AutoSize = true;
            this.ú.Location = new System.Drawing.Point(0, 242);
            this.ú.Name = "ú";
            this.ú.Size = new System.Drawing.Size(119, 15);
            this.ú.TabIndex = 9;
            this.ú.Text = "Nombre del Acusado";
            // 
            // txtNombre_denunciado
            // 
            this.txtNombre_denunciado.Location = new System.Drawing.Point(125, 239);
            this.txtNombre_denunciado.Name = "txtNombre_denunciado";
            this.txtNombre_denunciado.Size = new System.Drawing.Size(206, 23);
            this.txtNombre_denunciado.TabIndex = 10;
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Location = new System.Drawing.Point(395, 80);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(112, 15);
            this.w.TabIndex = 11;
            this.w.Text = "Cedula del Acusado";
            // 
            // txtCedula_denunciado
            // 
            this.txtCedula_denunciado.Location = new System.Drawing.Point(513, 72);
            this.txtCedula_denunciado.Name = "txtCedula_denunciado";
            this.txtCedula_denunciado.Size = new System.Drawing.Size(206, 23);
            this.txtCedula_denunciado.TabIndex = 12;
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.Location = new System.Drawing.Point(395, 143);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(69, 15);
            this.z.TabIndex = 13;
            this.z.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(513, 138);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(206, 23);
            this.txtDescripcion.TabIndex = 14;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(395, 208);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(49, 15);
            this.s.TabIndex = 15;
            this.s.Text = "Tribunal";
            // 
            // txtTribunal
            // 
            this.txtTribunal.FormattingEnabled = true;
            this.txtTribunal.ItemHeight = 15;
            this.txtTribunal.Items.AddRange(new object[] {
            "Juzgados de Primera Instancia Ordinarios divididos en cámara o salas",
            "Juzgados de Primera Instancia con plenitud de jurisdicción",
            "Tribunales de Primera Instancia Especializados",
            "Tribunales de Niños, Niñas y Adolescentes",
            "Los Juzgados de Trabajo",
            "Tribunal de Tierras de Jurisdicción Original",
            "Jueces de Ejecución de la Pena",
            "Tribunal de Control de las Sanciones de la Persona Adolescente",
            "Juzgados de la Instrucción",
            "Tribunal de Control de las Sanciones de la Persona Adolescente",
            "Otros"});
            this.txtTribunal.Location = new System.Drawing.Point(513, 192);
            this.txtTribunal.Name = "txtTribunal";
            this.txtTribunal.Size = new System.Drawing.Size(385, 94);
            this.txtTribunal.TabIndex = 16;
            // 
            // q
            // 
            this.q.AutoSize = true;
            this.q.Location = new System.Drawing.Point(24, 294);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(95, 15);
            this.q.TabIndex = 17;
            this.q.Text = "Fecha del Hecho";
            // 
            // txtFecha_hecho
            // 
            this.txtFecha_hecho.Location = new System.Drawing.Point(125, 291);
            this.txtFecha_hecho.Name = "txtFecha_hecho";
            this.txtFecha_hecho.Size = new System.Drawing.Size(206, 23);
            this.txtFecha_hecho.TabIndex = 18;
            // 
            // modificarDenuncias
            // 
            this.modificarDenuncias.Location = new System.Drawing.Point(297, 27);
            this.modificarDenuncias.Name = "modificarDenuncias";
            this.modificarDenuncias.Size = new System.Drawing.Size(75, 23);
            this.modificarDenuncias.TabIndex = 19;
            this.modificarDenuncias.Text = "Eliminar";
            this.modificarDenuncias.UseVisualStyleBackColor = true;
            this.modificarDenuncias.Click += new System.EventHandler(this.modificarDenuncias_Click);
            // 
            // Exportar
            // 
            this.Exportar.Location = new System.Drawing.Point(418, 27);
            this.Exportar.Name = "Exportar";
            this.Exportar.Size = new System.Drawing.Size(75, 23);
            this.Exportar.TabIndex = 20;
            this.Exportar.Text = "Exportar";
            this.Exportar.UseVisualStyleBackColor = true;
            this.Exportar.Click += new System.EventHandler(this.Exportar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 642);
            this.Controls.Add(this.Exportar);
            this.Controls.Add(this.modificarDenuncias);
            this.Controls.Add(this.txtFecha_hecho);
            this.Controls.Add(this.q);
            this.Controls.Add(this.txtTribunal);
            this.Controls.Add(this.s);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.z);
            this.Controls.Add(this.txtCedula_denunciado);
            this.Controls.Add(this.w);
            this.Controls.Add(this.txtNombre_denunciado);
            this.Controls.Add(this.ú);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.o);
            this.Controls.Add(this.e);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.gridPkm);
            this.Controls.Add(this.l);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "DenunciasRLN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPkm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem acercaToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Button Agregar;
        private TextBox txtNombre;
        private Label l;
        private DataGridView gridPkm;
        private TextBox txtCedula;
        private Label e;
        private Label o;
        private TextBox txtTitulo;
        private Label ú;
        private TextBox txtNombre_denunciado;
        private Label w;
        private TextBox txtCedula_denunciado;
        private Label z;
        private TextBox txtDescripcion;
        private Label s;
        private ListBox txtTribunal;
        private Label q;
        private TextBox txtFecha_hecho;
        private Button modificarDenuncias;
        private Button Exportar;
    }
}