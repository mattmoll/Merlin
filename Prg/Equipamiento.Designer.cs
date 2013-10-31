#region Usings
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
#endregion

namespace Rivn.
{
    public partial class Equipamiento : DockContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private TNGS.NetControls.XPanel xpnlBase;
        private TNGS.NetControls.GlassButton cmdSalir;
        private System.Windows.Forms.Label lblTitle;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton cmdPrint;
        private TNGS.NetControls.GlassButton cmdNuevo;
        private TNGS.NetControls.GlassButton cmdModificar;
        private TNGS.NetControls.GlassButton cmdPurgar;
        private TNGS.NetControls.ImgGroup frmEdicion;
        private System.Windows.Forms.Label lblCod;
        private TNGS.NetControls.TextEdit txtCod;
        private System.Windows.Forms.Label lblDes;
        private TNGS.NetControls.TextEdit txtDes;
        private System.Windows.Forms.Label lblValor;
        private TNGS.NetControls.DecimalEdit txtValor;
        private TNGS.NetControls.GlassButton cmdDesHab;
        private TNGS.NetControls.GlassButton cmdHab;
        private TNGS.NetControls.GlassButton cmdGrabar;
        private TNGS.NetControls.GlassButton cmdCancelar;
        private TNGS.NetControls.FullGrid grdDatos;
        private TNGS.NetControls.TSContainer tsContainer1;
        private RibbonStyle.TabPageSwitcher tabPageSwitcher1;
        private RibbonStyle.TabStripPage tabStripPage1;
        private TNGS.NetControls.TSPanel tsPanel2;
        private TNGS.NetControls.TSPanel tsPanel1;
        private TNGS.NetControls.TSBase tsBase1;
        private RibbonStyle.Tab tab1;

        /// <summary>
        /// Liberamos los recursos utilizados
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
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
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdDatos = new TNGS.NetControls.FullGrid();
            this.cmdExcel = new TNGS.NetControls.GlassButton();
            this.cmdPrint = new TNGS.NetControls.GlassButton();
            this.cmdNuevo = new TNGS.NetControls.GlassButton();
            this.cmdModificar = new TNGS.NetControls.GlassButton();
            this.cmdPurgar = new TNGS.NetControls.GlassButton();
            this.cmdSalir = new TNGS.NetControls.GlassButton();
            this.frmEdicion = new TNGS.NetControls.ImgGroup();
            this.cmdGrabar = new TNGS.NetControls.GlassButton();
            this.cmdDesHab = new TNGS.NetControls.GlassButton();
            this.cmdHab = new TNGS.NetControls.GlassButton();
            this.cmdCancelar = new TNGS.NetControls.GlassButton();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabPageSwitcher1 = new RibbonStyle.TabPageSwitcher();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tsPanel2 = new TNGS.NetControls.TSPanel();
            this.tsPanel1 = new TNGS.NetControls.TSPanel();
            this.tsBase1 = new TNGS.NetControls.TSBase();
            this.tab1 = new RibbonStyle.Tab();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new TNGS.NetControls.TextEdit();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtDes = new TNGS.NetControls.TextEdit();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new TNGS.NetControls.DecimalEdit();
            this.xpnlBase.SuspendLayout();
            this.tsContainer1.SuspendLayout();
            this.tabPageSwitcher1.SuspendLayout();
            this.tabStripPage1.SuspendLayout();
            this.tsPanel2.SuspendLayout();
            this.tsPanel1.SuspendLayout();
            this.tsBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.frmEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlBase
            // 
            this.xpnlBase.BackColor1 = SystemColors.Control;
            this.xpnlBase.BackColor2 = SystemColors.Control;
            this.xpnlBase.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                 this.tsContainer1,
                                                                                 this.lblTitle,
                                                                                 this.grdDatos,
                                                                                 this.cmdPrint,
                                                                                 this.cmdExcel,
                                                                                 this.frmEdicion});
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(600, 414);
            this.xpnlBase.TabIndex = 0;
            // 
            // tsContainer1
            // 
            this.tsContainer1.Controls.Add(this.tabPageSwitcher1);
            this.tsContainer1.Controls.Add(this.tsBase1);
            this.tsContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsContainer1.Location = new System.Drawing.Point(0, 0);
            this.tsContainer1.Name = "tsContainer1";
            this.tsContainer1.Size = new System.Drawing.Size(750, 115);
            this.tsContainer1.TabIndex = 22;
            // 
            // tabPageSwitcher1
            // 
            this.tabPageSwitcher1.Controls.Add(this.tabStripPage1);
            this.tabPageSwitcher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageSwitcher1.Location = new System.Drawing.Point(0, 26);
            this.tabPageSwitcher1.Name = "tabPageSwitcher1";
            this.tabPageSwitcher1.SelectedTabStripPage = this.tabStripPage1;
            this.tabPageSwitcher1.Size = new System.Drawing.Size(750, 89);
            this.tabPageSwitcher1.TabIndex = 1;
            this.tabPageSwitcher1.TabStrip = this.tsBase1;
            this.tabPageSwitcher1.Text = "tabPageSwitcher1";
            // 
            // tabStripPage1
            // 
            this.tabStripPage1.Caption = "";
            this.tabStripPage1.Controls.Add(this.tsPanel2);
            this.tabStripPage1.Controls.Add(this.tsPanel1);
            this.tabStripPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStripPage1.Location = new System.Drawing.Point(4, 0);
            this.tabStripPage1.Name = "tabStripPage1";
            this.tabStripPage1.Opacity = 255;
            this.tabStripPage1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabStripPage1.Size = new System.Drawing.Size(742, 87);
            this.tabStripPage1.Speed = 8;
            this.tabStripPage1.TabIndex = 0;
            // 
            // tsPanel2
            // 
            this.tsPanel2.Caption = "Edici�n";
            this.tsPanel2.Controls.Add(this.cmdHab);
            this.tsPanel2.Controls.Add(this.cmdCancelar);
            this.tsPanel2.Controls.Add(this.cmdGrabar);
            this.tsPanel2.Controls.Add(this.cmdDesHab);
            this.tsPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel2.Location = new System.Drawing.Point(268, 3);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Opacity = 255;
            this.tsPanel2.Size = new System.Drawing.Size(276, 85);
            this.tsPanel2.Speed = 1;
            this.tsPanel2.TabIndex = 1;
            // 
            // tsPanel1
            // 
            this.tsPanel1.Caption = "Operaciones";
            this.tsPanel1.Controls.Add(this.cmdSalir);
            this.tsPanel1.Controls.Add(this.cmdPurgar);
            this.tsPanel1.Controls.Add(this.cmdModificar);
            this.tsPanel1.Controls.Add(this.cmdNuevo);
            this.tsPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel1.Location = new System.Drawing.Point(0, 3);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Opacity = 255;
            this.tsPanel1.Size = new System.Drawing.Size(268, 85);
            this.tsPanel1.Speed = 1;
            this.tsPanel1.TabIndex = 0;
            // 
            // tsBase1
            // 
            this.tsBase1.AutoSize = false;
            this.tsBase1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBase1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tab1});
            this.tsBase1.Location = new System.Drawing.Point(0, 0);
            this.tsBase1.Name = "tsBase1";
            this.tsBase1.Padding = new System.Windows.Forms.Padding(60, 3, 30, 0);
            this.tsBase1.SelectedTab = this.tab1;
            this.tsBase1.ShowItemToolTips = false;
            this.tsBase1.Size = new System.Drawing.Size(750, 26);
            this.tsBase1.TabIndex = 0;
            this.tsBase1.TabOverlap = 0;
            this.tsBase1.Text = "tsBase1";
            // 
            // tab1
            // 
            this.tab1.AutoSize = false;
            this.tab1.Checked = true;
            this.tab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(154)))));
            this.tab1.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(114, 23);
            this.tab1.TabStripPage = this.tabStripPage1;
            this.tab1.Text = "Mantenimiento";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 126);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 16);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Equipamiento:";
            // 
            // grdDatos
            // 
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdDatos.CaptionFilterColor = System.Drawing.Color.FromArgb(((System.Byte)(73)), ((System.Byte)(206)), ((System.Byte)(72)));
            this.grdDatos.CaptionVisible = false;
            this.grdDatos.DataInString = false;
            this.grdDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdDatos.Hide1900 = true;
            this.grdDatos.Location = new System.Drawing.Point(4, 142);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ShowTotals = false;
            this.grdDatos.Size = new System.Drawing.Size(592, 112);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.WithCheckBoxes = false;
            this.grdDatos.DataDClick += new TNGS.NetRoutines.DataDClickEventHandler(this.grdDatos_DataDClick);
            this.grdDatos.Advance += new TNGS.NetRoutines.AdvanceEventHandler(this.grdDatos_Advance);
            this.grdDatos.HeaderClick += new TNGS.NetRoutines.HeaderClickEventHandler(this.grdDatos_HeaderClick);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.FixedImage = TNGS.NetControls.FixedGlassButtons.bExcel;
            this.cmdExcel.Location = new System.Drawing.Point(545, 118);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.PCode = "TNGS.EXCEL";
            this.cmdExcel.Size = new System.Drawing.Size(26, 24);
            this.cmdExcel.TabIndex = 1;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrint.FixedImage = TNGS.NetControls.FixedGlassButtons.bPrint;
            this.cmdPrint.Location = new System.Drawing.Point(570, 118);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.PCode = "TNGS.PRINT";
            this.cmdPrint.Size = new System.Drawing.Size(26, 24);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.FixedImage = TNGS.NetControls.FixedGlassButtons.tNew;
            this.cmdNuevo.ImageOnTop = true;
            this.cmdNuevo.Location = new System.Drawing.Point(8, 4);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(62, 62);
            this.cmdNuevo.TabIndex = 3;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.FixedImage = TNGS.NetControls.FixedGlassButtons.tModify;
            this.cmdModificar.ImageOnTop = true;
            this.cmdModificar.Location = new System.Drawing.Point(72, 4);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(62, 62);
            this.cmdModificar.TabIndex = 4;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdPurgar
            // 
            this.cmdPurgar.FixedImage = TNGS.NetControls.FixedGlassButtons.Agrupa;
            this.cmdPurgar.Location = new System.Drawing.Point(151, 35);
            this.cmdPurgar.Name = "cmdPurgar";
            this.cmdPurgar.Size = new System.Drawing.Size(104, 26);
            this.cmdPurgar.TabIndex = 5;
            this.cmdPurgar.Text= "Compactar";
            this.cmdPurgar.Click += new System.EventHandler(this.cmdPurgar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.FixedImage = TNGS.NetControls.FixedGlassButtons.Quit;
            this.cmdSalir.Location = new System.Drawing.Point(151, 7);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(104, 26);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmEdicion
            // 
            this.frmEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.frmEdicion.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                               this.lblCod,
                                                                               this.txtCod,
                                                                               this.lblDes,
                                                                               this.txtDes,
                                                                               this.lblValor,
                                                                               this.txtValor});
            this.frmEdicion.BackgroundColor = SystemColors.Control;
            this.frmEdicion.BackgroundGradientColor = SystemColors.Control;
            this.frmEdicion.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.frmEdicion.BorderColor = System.Drawing.Color.Black;
            this.frmEdicion.BorderThickness = 1F;
            this.frmEdicion.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmEdicion.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEdicion.GroupImage = null;
            this.frmEdicion.GroupTitle = " Equipamento ";
            this.frmEdicion.Location = new System.Drawing.Point(4, 260);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 10;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(592, 150);
            this.frmEdicion.TabIndex = 21;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.FixedImage = TNGS.NetControls.FixedGlassButtons.tSave;
            this.cmdGrabar.ImageOnTop = true;
            this.cmdGrabar.Location = new System.Drawing.Point(8, 4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(62, 62);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Graba";
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdDesHab
            // 
            this.cmdDesHab.FixedImage = TNGS.NetControls.FixedGlassButtons.Disable;
            this.cmdDesHab.Location = new System.Drawing.Point(151, 35);
            this.cmdDesHab.Name = "cmdDesHab";
            this.cmdDesHab.Size = new System.Drawing.Size(113, 26);
            this.cmdDesHab.TabIndex = 11;
            this.cmdDesHab.Text = "Deshabilitar";
            this.cmdDesHab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDesHab.Click += new System.EventHandler(this.cmdDesHab_Click);
            // 
            // cmdHab
            // 
            this.cmdHab.FixedImage = TNGS.NetControls.FixedGlassButtons.Enable;
            this.cmdHab.Location = new System.Drawing.Point(151, 7);
            this.cmdHab.Name = "cmdHab";
            this.cmdHab.Size = new System.Drawing.Size(113, 26);
            this.cmdHab.TabIndex = 11;
            this.cmdHab.Text = "Habilitar";
            this.cmdHab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdHab.Click += new System.EventHandler(this.cmdDesHab_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.FixedImage = TNGS.NetControls.FixedGlassButtons.tCancel;
            this.cmdCancelar.ImageOnTop = true;
            this.cmdCancelar.Location = new System.Drawing.Point(72, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(62, 62);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancela";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // lblCod
            // 
            this.lblCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(4, 10);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(104, 22);
            this.lblCod.TabIndex = 106;
            this.lblCod.Text = "cod:";
            this.lblCod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(114, 18);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(44, 22);
            this.txtCod.TabIndex = 6;
            this.txtCod.MaxLength = 4;
            this.txtCod.Text = "";
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.EmptyValid = false;
            this.txtCod.Multiline = false;
            this.txtCod.OnlyDigits = false;
            // 
            // lblDes
            // 
            this.lblDes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(4, 18);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(104, 22);
            this.lblDes.TabIndex = 107;
            this.lblDes.Text = "des:";
            this.lblDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDes
            // 
            this.txtDes.Enabled = false;
            this.txtDes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(114, 26);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(44, 22);
            this.txtDes.TabIndex = 7;
            this.txtDes.MaxLength = 30;
            this.txtDes.Text = "";
            this.txtDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDes.EmptyValid = false;
            this.txtDes.Multiline = false;
            this.txtDes.OnlyDigits = false;
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(4, 26);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(104, 22);
            this.lblValor.TabIndex = 108;
            this.lblValor.Text = "valor:";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(114, 34);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(44, 22);
            this.txtValor.TabIndex = 8;
            this.txtValor.Decimals = 2;
            this.txtValor.MaxLength = 10;
            this.txtValor.Decimal = 0;
            this.txtValor.NegativeValid = true;
            this.txtValor.ZeroValid = true;
            // 
            // Equipamiento
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.xpnlBase);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Equipamiento";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TabText = "Mantenimiento de Equipamiento";
            this.Load += new System.EventHandler(this.Equipamiento_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Equipamiento_FormClosed);
            this.xpnlBase.ResumeLayout(false);
            this.tsContainer1.ResumeLayout(false);
            this.tabPageSwitcher1.ResumeLayout(false);
            this.tabStripPage1.ResumeLayout(false);
            this.tsPanel2.ResumeLayout(false);
            this.tsPanel1.ResumeLayout(false);
            this.tsBase1.ResumeLayout(false);
            this.tsBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.frmEdicion.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}