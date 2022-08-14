namespace WinFormsAppTextEditor
{
    partial class txtWinForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txtWinForm));
            this.txtContainer = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaYHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarPáginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alejarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reestaurarZoomPreterminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusteDeLíneaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContainer
            // 
            this.txtContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContainer.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContainer.ForeColor = System.Drawing.SystemColors.Window;
            this.txtContainer.Location = new System.Drawing.Point(0, 46);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Size = new System.Drawing.Size(517, 634);
            this.txtContainer.TabIndex = 0;
            this.txtContainer.Text = "";
            this.txtContainer.TextChanged += new System.EventHandler(this.txtContainer_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(517, 46);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.nuevaVentanaToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(86, 42);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.new_copy_100px;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // nuevaVentanaToolStripMenuItem
            // 
            this.nuevaVentanaToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.new_window_100px1;
            this.nuevaVentanaToolStripMenuItem.Name = "nuevaVentanaToolStripMenuItem";
            this.nuevaVentanaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.nuevaVentanaToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.nuevaVentanaToolStripMenuItem.Text = "Nueva ventana";
            this.nuevaVentanaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentanaToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.open_document_100px;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.save_60px;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.Save_as_128px;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(344, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.close_tab_100px1;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(347, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deacerToolStripMenuItem,
            this.toolStripSeparator3,
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripSeparator4,
            this.seleccionarTodoToolStripMenuItem,
            this.fechaYHoraToolStripMenuItem,
            this.toolStripSeparator6,
            this.fuenteToolStripMenuItem});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(71, 42);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // deacerToolStripMenuItem
            // 
            this.deacerToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.undo_60px;
            this.deacerToolStripMenuItem.Name = "deacerToolStripMenuItem";
            this.deacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deacerToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.deacerToolStripMenuItem.Text = "Deshacer";
            this.deacerToolStripMenuItem.Click += new System.EventHandler(this.deacerToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(287, 6);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.cut_60px;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.copy_100px;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.Paste_128px;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.delete_48px;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.eliminarToolStripMenuItem.Text = "Eliminar todo";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(287, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.select_all_100px;
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // fechaYHoraToolStripMenuItem
            // 
            this.fechaYHoraToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.calendar_100px;
            this.fechaYHoraToolStripMenuItem.Name = "fechaYHoraToolStripMenuItem";
            this.fechaYHoraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.fechaYHoraToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.fechaYHoraToolStripMenuItem.Text = "Fecha y hora";
            this.fechaYHoraToolStripMenuItem.Click += new System.EventHandler(this.fechaYHoraToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(287, 6);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.font_style_formatting_60px;
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarPáginaToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.barraDeEstadoToolStripMenuItem,
            this.ajusteDeLíneaToolStripMenuItem});
            this.verToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(51, 42);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // configurarPáginaToolStripMenuItem
            // 
            this.configurarPáginaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorDeTextoToolStripMenuItem,
            this.colorDeFondoToolStripMenuItem});
            this.configurarPáginaToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.show_property_60px;
            this.configurarPáginaToolStripMenuItem.Name = "configurarPáginaToolStripMenuItem";
            this.configurarPáginaToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.configurarPáginaToolStripMenuItem.Text = "Configurar página";
            // 
            // colorDeTextoToolStripMenuItem
            // 
            this.colorDeTextoToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.paint_palette_60px;
            this.colorDeTextoToolStripMenuItem.Name = "colorDeTextoToolStripMenuItem";
            this.colorDeTextoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.colorDeTextoToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.colorDeTextoToolStripMenuItem.Text = "Texto";
            this.colorDeTextoToolStripMenuItem.Click += new System.EventHandler(this.colorDeTextoToolStripMenuItem_Click_1);
            // 
            // colorDeFondoToolStripMenuItem
            // 
            this.colorDeFondoToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.Fill_Color_128px;
            this.colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            this.colorDeFondoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.colorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.colorDeFondoToolStripMenuItem.Text = "Fondo";
            this.colorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.colorDeFondoToolStripMenuItem_Click_1);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercarToolStripMenuItem,
            this.alejarToolStripMenuItem,
            this.reestaurarZoomPreterminadoToolStripMenuItem});
            this.zoomToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.view_60px;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // acercarToolStripMenuItem
            // 
            this.acercarToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.zoom_in_64px;
            this.acercarToolStripMenuItem.Name = "acercarToolStripMenuItem";
            this.acercarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.NumPad2)));
            this.acercarToolStripMenuItem.Size = new System.Drawing.Size(405, 30);
            this.acercarToolStripMenuItem.Text = "Acercar";
            this.acercarToolStripMenuItem.Click += new System.EventHandler(this.acercarToolStripMenuItem_Click);
            // 
            // alejarToolStripMenuItem
            // 
            this.alejarToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.zoom_out_64px;
            this.alejarToolStripMenuItem.Name = "alejarToolStripMenuItem";
            this.alejarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.alejarToolStripMenuItem.Size = new System.Drawing.Size(405, 30);
            this.alejarToolStripMenuItem.Text = "Alejar";
            this.alejarToolStripMenuItem.Click += new System.EventHandler(this.alejarToolStripMenuItem_Click);
            // 
            // reestaurarZoomPreterminadoToolStripMenuItem
            // 
            this.reestaurarZoomPreterminadoToolStripMenuItem.Image = global::WinFormsAppTextEditor.Properties.Resources.Zoom_to_Extents_128px;
            this.reestaurarZoomPreterminadoToolStripMenuItem.Name = "reestaurarZoomPreterminadoToolStripMenuItem";
            this.reestaurarZoomPreterminadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.reestaurarZoomPreterminadoToolStripMenuItem.Size = new System.Drawing.Size(405, 30);
            this.reestaurarZoomPreterminadoToolStripMenuItem.Text = "Restaurar zoom preterminado";
            this.reestaurarZoomPreterminadoToolStripMenuItem.Click += new System.EventHandler(this.reestaurarZoomPreterminadoToolStripMenuItem_Click);
            // 
            // barraDeEstadoToolStripMenuItem
            // 
            this.barraDeEstadoToolStripMenuItem.Checked = true;
            this.barraDeEstadoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barraDeEstadoToolStripMenuItem.Name = "barraDeEstadoToolStripMenuItem";
            this.barraDeEstadoToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.barraDeEstadoToolStripMenuItem.Text = "Barra de estado";
            this.barraDeEstadoToolStripMenuItem.Click += new System.EventHandler(this.barraDeEstadoToolStripMenuItem_Click);
            // 
            // ajusteDeLíneaToolStripMenuItem
            // 
            this.ajusteDeLíneaToolStripMenuItem.Name = "ajusteDeLíneaToolStripMenuItem";
            this.ajusteDeLíneaToolStripMenuItem.Size = new System.Drawing.Size(241, 30);
            this.ajusteDeLíneaToolStripMenuItem.Text = "Ajuste de línea";
            this.ajusteDeLíneaToolStripMenuItem.Click += new System.EventHandler(this.ajusteDeLíneaToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Abrir archivo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(517, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 20);
            this.toolStripStatusLabel1.Text = "0 Letras         ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(81, 20);
            this.toolStripStatusLabel2.Text = "100%         ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(148, 20);
            this.toolStripStatusLabel3.Text = "Windows (CRLF)        ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(48, 20);
            this.toolStripStatusLabel4.Text = "UTF-8";
            // 
            // txtWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(517, 680);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "txtWinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaYHoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alejarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reestaurarZoomPreterminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraDeEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusteDeLíneaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem configurarPáginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeFondoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}

