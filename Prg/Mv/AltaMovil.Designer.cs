﻿namespace Rivn.Mv
{
    partial class AltaMovil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaMovil));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbLimpiarTodo = new TNGS.NetControls.GlassButton();
            this.gbCancel = new TNGS.NetControls.GlassButton();
            this.gbGrabar = new TNGS.NetControls.GlassButton();
            this.igEquipamiento = new TNGS.NetControls.ImgGroup();
            this.btnDestildarTodoEqi = new TNGS.NetControls.GlassButton();
            this.btnTildaTodos = new TNGS.NetControls.GlassButton();
            this.clEquipamientos = new TNGS.NetControls.CDCheckedList();
            this.igDatosBasicosMovil = new TNGS.NetControls.ImgGroup();
            this.neKilometros = new TNGS.NetControls.NumberEdit();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.cdcModelo = new TNGS.NetControls.CDCombo();
            this.tePatente = new TNGS.NetControls.TextEdit();
            this.lblAnotaciones = new TNGS.NetControls.FullLabel();
            this.lblAnioFabricacion = new TNGS.NetControls.FullLabel();
            this.teAnotaciones = new TNGS.NetControls.TextEdit();
            this.lblMovilPropio = new TNGS.NetControls.FullLabel();
            this.neAnioFabric = new TNGS.NetControls.NumberEdit();
            this.teNroMotor = new TNGS.NetControls.TextEdit();
            this.cdcMovilPropio = new TNGS.NetControls.CDCombo();
            this.lblPatente = new TNGS.NetControls.FullLabel();
            this.lblDescripcionMovil = new TNGS.NetControls.FullLabel();
            this.teDescripcionMovil = new TNGS.NetControls.TextEdit();
            this.lblModelo = new TNGS.NetControls.FullLabel();
            this.teNroChasis = new TNGS.NetControls.TextEdit();
            this.lblNroMotor = new TNGS.NetControls.FullLabel();
            this.lblNroChasis = new TNGS.NetControls.FullLabel();
            this.xPanel1.SuspendLayout();
            this.igEquipamiento.SuspendLayout();
            this.igDatosBasicosMovil.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.gbLimpiarTodo);
            this.xPanel1.Controls.Add(this.gbCancel);
            this.xPanel1.Controls.Add(this.gbGrabar);
            this.xPanel1.Controls.Add(this.igEquipamiento);
            this.xPanel1.Controls.Add(this.igDatosBasicosMovil);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(1008, 651);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // gbLimpiarTodo
            // 
            this.gbLimpiarTodo.FixedImage = TNGS.NetControls.FixedGlassButtons.tDelete;
            this.gbLimpiarTodo.ImageOnTop = true;
            this.gbLimpiarTodo.Location = new System.Drawing.Point(661, 571);
            this.gbLimpiarTodo.Name = "gbLimpiarTodo";
            this.gbLimpiarTodo.Size = new System.Drawing.Size(91, 68);
            this.gbLimpiarTodo.TabIndex = 0;
            this.gbLimpiarTodo.Text = "Limpiar Campos";
            this.gbLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // gbCancel
            // 
            this.gbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.gbCancel.FixedImage = TNGS.NetControls.FixedGlassButtons.tCancel;
            this.gbCancel.ImageOnTop = true;
            this.gbCancel.Location = new System.Drawing.Point(791, 571);
            this.gbCancel.Name = "gbCancel";
            this.gbCancel.Size = new System.Drawing.Size(91, 68);
            this.gbCancel.TabIndex = 1;
            this.gbCancel.Text = "Cancelar";
            this.gbCancel.Click += new System.EventHandler(this.gbCancel_Click);
            // 
            // gbGrabar
            // 
            this.gbGrabar.FixedImage = TNGS.NetControls.FixedGlassButtons.tSave;
            this.gbGrabar.ImageOnTop = true;
            this.gbGrabar.Location = new System.Drawing.Point(888, 571);
            this.gbGrabar.Name = "gbGrabar";
            this.gbGrabar.Size = new System.Drawing.Size(91, 68);
            this.gbGrabar.TabIndex = 2;
            this.gbGrabar.Text = "Grabar";
            this.gbGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // igEquipamiento
            // 
            this.igEquipamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igEquipamiento.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igEquipamiento.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igEquipamiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igEquipamiento.BorderThickness = 1F;
            this.igEquipamiento.Controls.Add(this.btnDestildarTodoEqi);
            this.igEquipamiento.Controls.Add(this.btnTildaTodos);
            this.igEquipamiento.Controls.Add(this.clEquipamientos);
            this.igEquipamiento.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igEquipamiento.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igEquipamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igEquipamiento.GroupImage = ((System.Drawing.Image)(resources.GetObject("igEquipamiento.GroupImage")));
            this.igEquipamiento.GroupTitle = "Equipamiento";
            this.igEquipamiento.Location = new System.Drawing.Point(684, 17);
            this.igEquipamiento.Name = "igEquipamiento";
            this.igEquipamiento.Padding = new System.Windows.Forms.Padding(20);
            this.igEquipamiento.PaintGroupBox = true;
            this.igEquipamiento.RoundCorners = 10;
            this.igEquipamiento.ShadowColor = System.Drawing.Color.DarkGray;
            this.igEquipamiento.ShadowControl = true;
            this.igEquipamiento.ShadowThickness = 3;
            this.igEquipamiento.Size = new System.Drawing.Size(312, 536);
            this.igEquipamiento.SkinFixed = true;
            this.igEquipamiento.SkinFullFixed = true;
            this.igEquipamiento.TabIndex = 24;
            // 
            // btnDestildarTodoEqi
            // 
            this.btnDestildarTodoEqi.FixedImage = TNGS.NetControls.FixedGlassButtons.UnCheckAll;
            this.btnDestildarTodoEqi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestildarTodoEqi.Location = new System.Drawing.Point(158, 489);
            this.btnDestildarTodoEqi.Name = "btnDestildarTodoEqi";
            this.btnDestildarTodoEqi.Size = new System.Drawing.Size(122, 24);
            this.btnDestildarTodoEqi.TabIndex = 2;
            this.btnDestildarTodoEqi.Text = "Destildar Todo";
            this.btnDestildarTodoEqi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestildarTodoEqi.Click += new System.EventHandler(this.btnDestildarTodoEqi_Click);
            // 
            // btnTildaTodos
            // 
            this.btnTildaTodos.FixedImage = TNGS.NetControls.FixedGlassButtons.CheckAll;
            this.btnTildaTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTildaTodos.Location = new System.Drawing.Point(26, 489);
            this.btnTildaTodos.Name = "btnTildaTodos";
            this.btnTildaTodos.Size = new System.Drawing.Size(122, 24);
            this.btnTildaTodos.TabIndex = 1;
            this.btnTildaTodos.Text = "Tildar Todo";
            this.btnTildaTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTildaTodos.Click += new System.EventHandler(this.tildarTodo_Click);
            // 
            // clEquipamientos
            // 
            this.clEquipamientos.BackColor = System.Drawing.SystemColors.Window;
            this.clEquipamientos.FormattingEnabled = true;
            this.clEquipamientos.Location = new System.Drawing.Point(12, 37);
            this.clEquipamientos.Name = "clEquipamientos";
            this.clEquipamientos.Size = new System.Drawing.Size(286, 439);
            this.clEquipamientos.Sorted = true;
            this.clEquipamientos.TabIndex = 0;
            // 
            // igDatosBasicosMovil
            // 
            this.igDatosBasicosMovil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igDatosBasicosMovil.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igDatosBasicosMovil.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igDatosBasicosMovil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igDatosBasicosMovil.BorderThickness = 1F;
            this.igDatosBasicosMovil.Controls.Add(this.neKilometros);
            this.igDatosBasicosMovil.Controls.Add(this.fullLabel1);
            this.igDatosBasicosMovil.Controls.Add(this.cdcModelo);
            this.igDatosBasicosMovil.Controls.Add(this.tePatente);
            this.igDatosBasicosMovil.Controls.Add(this.lblAnotaciones);
            this.igDatosBasicosMovil.Controls.Add(this.lblAnioFabricacion);
            this.igDatosBasicosMovil.Controls.Add(this.teAnotaciones);
            this.igDatosBasicosMovil.Controls.Add(this.lblMovilPropio);
            this.igDatosBasicosMovil.Controls.Add(this.neAnioFabric);
            this.igDatosBasicosMovil.Controls.Add(this.teNroMotor);
            this.igDatosBasicosMovil.Controls.Add(this.cdcMovilPropio);
            this.igDatosBasicosMovil.Controls.Add(this.lblPatente);
            this.igDatosBasicosMovil.Controls.Add(this.lblDescripcionMovil);
            this.igDatosBasicosMovil.Controls.Add(this.teDescripcionMovil);
            this.igDatosBasicosMovil.Controls.Add(this.lblModelo);
            this.igDatosBasicosMovil.Controls.Add(this.teNroChasis);
            this.igDatosBasicosMovil.Controls.Add(this.lblNroMotor);
            this.igDatosBasicosMovil.Controls.Add(this.lblNroChasis);
            this.igDatosBasicosMovil.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.igDatosBasicosMovil.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igDatosBasicosMovil.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igDatosBasicosMovil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            //this.igDatosBasicosMovil.GroupImage = global::Rivn.Mv.Properties.Resources.ambulance_car;
            this.igDatosBasicosMovil.GroupTitle = "Datos Basicos";
            this.igDatosBasicosMovil.Location = new System.Drawing.Point(12, 17);
            this.igDatosBasicosMovil.Name = "igDatosBasicosMovil";
            this.igDatosBasicosMovil.Padding = new System.Windows.Forms.Padding(20);
            this.igDatosBasicosMovil.PaintGroupBox = true;
            this.igDatosBasicosMovil.RoundCorners = 10;
            this.igDatosBasicosMovil.ShadowColor = System.Drawing.Color.DarkGray;
            this.igDatosBasicosMovil.ShadowControl = true;
            this.igDatosBasicosMovil.ShadowThickness = 3;
            this.igDatosBasicosMovil.Size = new System.Drawing.Size(660, 536);
            this.igDatosBasicosMovil.SkinFixed = true;
            this.igDatosBasicosMovil.SkinFullFixed = true;
            this.igDatosBasicosMovil.TabIndex = 23;
            // 
            // neKilometros
            // 
            this.neKilometros.BackColor = System.Drawing.SystemColors.Window;
            this.neKilometros.Location = new System.Drawing.Point(451, 288);
            this.neKilometros.Name = "neKilometros";
            this.neKilometros.Size = new System.Drawing.Size(123, 20);
            this.neKilometros.TabIndex = 7;
            this.neKilometros.Text = "50000";
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.ForeColor = System.Drawing.Color.Black;
            this.fullLabel1.Location = new System.Drawing.Point(352, 288);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(90, 18);
            this.fullLabel1.TabIndex = 20;
            this.fullLabel1.Text = "Kilometros: ";
            // 
            // cdcModelo
            // 
            this.cdcModelo.BackColor = System.Drawing.SystemColors.Window;
            this.cdcModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcModelo.FormattingEnabled = true;
            this.cdcModelo.Location = new System.Drawing.Point(162, 288);
            this.cdcModelo.Name = "cdcModelo";
            this.cdcModelo.Size = new System.Drawing.Size(123, 21);
            this.cdcModelo.Sorted = true;
            this.cdcModelo.TabIndex = 6;
            // 
            // tePatente
            // 
            this.tePatente.BackColor = System.Drawing.SystemColors.Window;
            this.tePatente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tePatente.Location = new System.Drawing.Point(303, 68);
            this.tePatente.Name = "tePatente";
            this.tePatente.Size = new System.Drawing.Size(136, 20);
            this.tePatente.TabIndex = 0;
            this.tePatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAnotaciones
            // 
            this.lblAnotaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblAnotaciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotaciones.ForeColor = System.Drawing.Color.Black;
            this.lblAnotaciones.Location = new System.Drawing.Point(46, 363);
            this.lblAnotaciones.Name = "lblAnotaciones";
            this.lblAnotaciones.Size = new System.Drawing.Size(117, 18);
            this.lblAnotaciones.TabIndex = 13;
            this.lblAnotaciones.Text = "Anotaciones:";
            // 
            // lblAnioFabricacion
            // 
            this.lblAnioFabricacion.BackColor = System.Drawing.Color.Transparent;
            this.lblAnioFabricacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioFabricacion.ForeColor = System.Drawing.Color.Black;
            this.lblAnioFabricacion.Location = new System.Drawing.Point(315, 232);
            this.lblAnioFabricacion.Name = "lblAnioFabricacion";
            this.lblAnioFabricacion.Size = new System.Drawing.Size(124, 18);
            this.lblAnioFabricacion.TabIndex = 17;
            this.lblAnioFabricacion.Text = "Año Fabricacion:";
            // 
            // teAnotaciones
            // 
            this.teAnotaciones.BackColor = System.Drawing.SystemColors.Window;
            this.teAnotaciones.Location = new System.Drawing.Point(39, 384);
            this.teAnotaciones.Multiline = true;
            this.teAnotaciones.Name = "teAnotaciones";
            this.teAnotaciones.Size = new System.Drawing.Size(580, 129);
            this.teAnotaciones.TabIndex = 8;
            // 
            // lblMovilPropio
            // 
            this.lblMovilPropio.BackColor = System.Drawing.Color.Transparent;
            this.lblMovilPropio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovilPropio.ForeColor = System.Drawing.Color.Black;
            this.lblMovilPropio.Location = new System.Drawing.Point(339, 179);
            this.lblMovilPropio.Name = "lblMovilPropio";
            this.lblMovilPropio.Size = new System.Drawing.Size(105, 18);
            this.lblMovilPropio.TabIndex = 18;
            this.lblMovilPropio.Text = "Movil Propio:";
            // 
            // neAnioFabric
            // 
            this.neAnioFabric.BackColor = System.Drawing.SystemColors.Window;
            this.neAnioFabric.Location = new System.Drawing.Point(451, 233);
            this.neAnioFabric.Name = "neAnioFabric";
            this.neAnioFabric.Size = new System.Drawing.Size(123, 20);
            this.neAnioFabric.TabIndex = 5;
            this.neAnioFabric.Text = "1993";
            // 
            // teNroMotor
            // 
            this.teNroMotor.BackColor = System.Drawing.SystemColors.Window;
            this.teNroMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teNroMotor.Location = new System.Drawing.Point(161, 235);
            this.teNroMotor.Name = "teNroMotor";
            this.teNroMotor.Size = new System.Drawing.Size(123, 20);
            this.teNroMotor.TabIndex = 4;
            this.teNroMotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cdcMovilPropio
            // 
            this.cdcMovilPropio.BackColor = System.Drawing.SystemColors.Window;
            this.cdcMovilPropio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcMovilPropio.FormattingEnabled = true;
            this.cdcMovilPropio.Location = new System.Drawing.Point(452, 178);
            this.cdcMovilPropio.Name = "cdcMovilPropio";
            this.cdcMovilPropio.Size = new System.Drawing.Size(122, 21);
            this.cdcMovilPropio.Sorted = true;
            this.cdcMovilPropio.TabIndex = 3;
            // 
            // lblPatente
            // 
            this.lblPatente.BackColor = System.Drawing.Color.Transparent;
            this.lblPatente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(204, 68);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(75, 18);
            this.lblPatente.TabIndex = 6;
            this.lblPatente.Text = "Patente:";
            // 
            // lblDescripcionMovil
            // 
            this.lblDescripcionMovil.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionMovil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMovil.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcionMovil.Location = new System.Drawing.Point(59, 124);
            this.lblDescripcionMovil.Name = "lblDescripcionMovil";
            this.lblDescripcionMovil.Size = new System.Drawing.Size(86, 19);
            this.lblDescripcionMovil.TabIndex = 10;
            this.lblDescripcionMovil.Text = "Descripcion:";
            // 
            // teDescripcionMovil
            // 
            this.teDescripcionMovil.BackColor = System.Drawing.SystemColors.Window;
            this.teDescripcionMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teDescripcionMovil.Location = new System.Drawing.Point(161, 124);
            this.teDescripcionMovil.Name = "teDescripcionMovil";
            this.teDescripcionMovil.Size = new System.Drawing.Size(413, 20);
            this.teDescripcionMovil.TabIndex = 1;
            // 
            // lblModelo
            // 
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Black;
            this.lblModelo.Location = new System.Drawing.Point(82, 290);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(65, 18);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "Modelo:";
            // 
            // teNroChasis
            // 
            this.teNroChasis.BackColor = System.Drawing.SystemColors.Window;
            this.teNroChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.teNroChasis.Location = new System.Drawing.Point(162, 180);
            this.teNroChasis.Name = "teNroChasis";
            this.teNroChasis.Size = new System.Drawing.Size(123, 20);
            this.teNroChasis.TabIndex = 2;
            this.teNroChasis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNroMotor
            // 
            this.lblNroMotor.BackColor = System.Drawing.Color.Transparent;
            this.lblNroMotor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMotor.ForeColor = System.Drawing.Color.Black;
            this.lblNroMotor.Location = new System.Drawing.Point(40, 236);
            this.lblNroMotor.Name = "lblNroMotor";
            this.lblNroMotor.Size = new System.Drawing.Size(110, 18);
            this.lblNroMotor.TabIndex = 15;
            this.lblNroMotor.Text = "Numero Motor:";
            // 
            // lblNroChasis
            // 
            this.lblNroChasis.BackColor = System.Drawing.Color.Transparent;
            this.lblNroChasis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroChasis.ForeColor = System.Drawing.Color.Black;
            this.lblNroChasis.Location = new System.Drawing.Point(38, 180);
            this.lblNroChasis.Name = "lblNroChasis";
            this.lblNroChasis.Size = new System.Drawing.Size(107, 18);
            this.lblNroChasis.TabIndex = 14;
            this.lblNroChasis.Text = "Numero Chasis:";
            // 
            // AltaMovil
            // 
            this.AcceptButton = this.gbGrabar;
            this.CancelButton = this.gbCancel;
            this.ClientSize = new System.Drawing.Size(1008, 651);
            this.Controls.Add(this.xPanel1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AltaMovil";
            this.ShowIcon = false;
            this.Text = "Nuevo Movil";
            this.Load += new System.EventHandler(this.AltaMovil_Load);
            this.xPanel1.ResumeLayout(false);
            this.igEquipamiento.ResumeLayout(false);
            this.igDatosBasicosMovil.ResumeLayout(false);
            this.igDatosBasicosMovil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.ImgGroup igEquipamiento;
        private TNGS.NetControls.CDCheckedList clEquipamientos;
        private TNGS.NetControls.ImgGroup igDatosBasicosMovil;
        private TNGS.NetControls.TextEdit tePatente;
        private TNGS.NetControls.FullLabel lblAnotaciones;
        private TNGS.NetControls.FullLabel lblAnioFabricacion;
        private TNGS.NetControls.TextEdit teAnotaciones;
        private TNGS.NetControls.FullLabel lblMovilPropio;
        private TNGS.NetControls.NumberEdit neAnioFabric;
        private TNGS.NetControls.TextEdit teNroMotor;
        private TNGS.NetControls.CDCombo cdcMovilPropio;
        private TNGS.NetControls.FullLabel lblPatente;
        private TNGS.NetControls.FullLabel lblDescripcionMovil;
        private TNGS.NetControls.TextEdit teDescripcionMovil;
        private TNGS.NetControls.FullLabel lblModelo;
        private TNGS.NetControls.TextEdit teNroChasis;
        private TNGS.NetControls.FullLabel lblNroMotor;
        private TNGS.NetControls.FullLabel lblNroChasis;
        private TNGS.NetControls.GlassButton gbGrabar;
        private TNGS.NetControls.GlassButton gbLimpiarTodo;
        private TNGS.NetControls.GlassButton gbCancel;
        private TNGS.NetControls.CDCombo cdcModelo;
        private TNGS.NetControls.NumberEdit neKilometros;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.GlassButton btnDestildarTodoEqi;
        private TNGS.NetControls.GlassButton btnTildaTodos;
    }
}