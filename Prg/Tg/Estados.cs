#region Usings
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using WeifenLuo.WinFormsUI.Docking;
using TNGS.NetRoutines;
using TNGS.NetControls;
using TNGS.NetApp;
using Rivn;
#endregion

namespace Rivn.Tg
{
    //----------------------------------------------------------------------------
    //                         TNG Software UIL Generator
    //----------------------------------------------------------------------------
    // Fecha                     : 31/10/2013 16:12
    // Sistema                   : Rivn
    // Interface para la Entidad : Estado
    // Tipo de Interface         : Mantenimiento de Tabla Clasificadora
    //----------------------------------------------------------------------------
    // © 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    /// <summary>
    /// Formulario para Mantenimiento de la Tabla:Estados
    /// </summary>
    public partial class Estados : DockContent
    {
        #region Miembros de la Clase
            private Bel.EEstado m_entEstado= null;
            private StatMsg m_smResult= null;
            private ACLInfo m_aclInfo= null;
            private string m_strSort= "";
        #endregion

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Estados()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // Obtenemos los permisos ACL
            m_aclInfo= App.ACLInfo;

            // Aplicamos los nieves de seguridad
            App.ApplySecurity(this);

            // Iniciamos los objetos de la clase
            m_smResult= new StatMsg("Estados");

            // Fijamos el modo Skin
            xpnlBase.SkinFixed= App.WithSkin;
            frmEdicion.SkinFixed= App.WithSkin;
            grdDatos.SkinFixed= App.WithSkin;

            // Dockeamos el formulario
            ((MainFrame) App.GetMainWindow()).AddContent(this);

            // Fijamos la imagen del Frm de edicion
            frmEdicion.GroupImage= Icon.ToBitmap();
        }

        //--------------------------------------------------------------
        // Eventos del formulario y los controles
        //--------------------------------------------------------------

        /// <summary>
        /// Carga del Formulario
        /// </summary>
        private void Estados_Load(object sender, System.EventArgs e)
        {
            // Inicializamos el form
            App.ShowMsg("Inicializando el formulario...");

            // Llenamos las Combos (por Lista)
            cmbOperativo.AddStrCD("S", "SI", 0);
            cmbOperativo.AddStrCD("N", "NO", 0);

            // Pasamos a modo Operaciones, llenamos la grilla y 
            // damos foco al primer campo
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();

            // Todo listo
            App.HideMsg();
        }

        /// <summary>
        /// Cierre del formulario
        /// </summary>
        private void Estados_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Liberamos el menu
            App.LockMenu(false);
        }

        /// <summary>
        /// Reporte del estado de avance de la grilla
        /// </summary>
        private void grdDatos_Advance(object sender, TNGS.NetRoutines.AdvanceEventArgs e)
        {
            // Marcamos el estado de avance de la operacion en la grilla
            App.Advance(e.Percent);
        }

        /// <summary>
        /// Dobleclick en la grilla
        /// </summary>
        private void grdDatos_DataDClick(object sender, DataDClicEventArgs e)
        {
            // Simulamos modificar
            cmdModificar_Click(this, EventArgs.Empty);
        }

        /// <summary>
        /// Dieron click en el header de la grilla
        /// </summary>
        private void grdDatos_HeaderClick(object sender, MouseEventArgs e)
        {
            // Si es boton izquierdo
            if (e.Button == MouseButtons.Left) {
                // Si cambio el sort simple
                if (m_strSort != grdDatos.GridOrder) {
                    // Grabamos el nuevo sort
                    m_strSort= grdDatos.GridOrder;
                    App.SetStrURegistry(false, "GridFormat", "EstadosGrdSort", m_strSort);
                    return;
                }
            }

            // Si es boton derecho
            if (e.Button == MouseButtons.Right) {
                // Si cambio el sort simple
                if (m_strSort != "") {
                    // Quitamos el orden, grabamos y recargamos
                    m_strSort= "";
                    App.SetStrURegistry(false, "GridFormat", "EstadosGrdSort", m_strSort);
                    FillGrid();
                    return;
                }
            }
        }

        /// <summary>
        /// Cambio el ancho de la columnas
        /// </summary>
        private void GrdColumn_WidthChanged(object sender, EventArgs e)
        {
            // Guardamos el ancho de las columnas
            App.SetStrURegistry(false, "GridFormat", "EstadosGrdWidths", grdDatos.ColWitdhs);
        }

        //--------------------------------------------------------------
        // Operaciones
        //--------------------------------------------------------------

        /// <summary>
        /// Exporta la grilla en Excel
        /// </summary>
        private void cmdExcel_Click(object sender, System.EventArgs e)
        {
            App.ShowMsg("Generando planilla...");
            App.InitAdvance("Excel:");
            grdDatos.ExportToExcel(false, false, "", "Estados", ref m_smResult);
            App.EndAdvance();
            App.HideMsg();
        }

        /// <summary>
        /// Imprime la grilla
        /// </summary>
        private void cmdPrint_Click(object sender, System.EventArgs e)
        {
            App.ShowMsg("Imprimiendo datos...");
            App.InitAdvance("Imprimiendo:");
            grdDatos.Print(App.ROParams["EMPRESA"].VStr, App.Programa.Nombre,
                           "Lista de Estados", "");
            App.EndAdvance();
            App.HideMsg();
        }

        /// <summary>
        /// Genera un Nuevo registro en la tabla
        /// </summary>
        private void cmdNuevo_Click(object sender, System.EventArgs e)
        {
            // Creamos una nueva entidad, pasamos a modo de edicion y
            // damos foco al primer campo
            m_entEstado= Bel.EEstado.NewEmpty();
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            txtCod.Focus();
        }

        /// <summary>
        /// Modifica el registro seleccionado de la grilla
        /// </summary>
        private void cmdModificar_Click(object sender, System.EventArgs e)
        {
            // Si no hay item seleccionado -> salimos
            int l_iRow= grdDatos.CurrentRowIndex;
            if (l_iRow == -1) return;

            // Obtenemos la entidad del item seleccionado en la grilla
            App.ShowMsg("Recuperando Datos...");
            m_smResult.UilReset("cmdModificar_Click");
            m_entEstado= Bll.Tablas.EdsGet((string) grdDatos.GetMatrixValueObj(l_iRow, 1),
                                           false, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Tenemos la entidad. Pasamos a modo de edicion y damos foco
            // al campo que corresponda
            SwitchTo(FormModes.Edit, GridOps.DontFill);
            if (m_entEstado.EstaBorrada) {
                cmdCancelar.Focus();
            }
            else {
                txtTxtcontingencia.Focus();
            }
            App.HideMsg();
        }

        /// <summary>
        /// Purga los registros deshabilitados
        /// </summary>
        private void cmdPurgar_Click(object sender, EventArgs e)
        {
            // Pedimos una confirmacion
            if (MsgRuts.AskUser(this, "Atención!!!!\r\n" +
                                      "La compactación de la tabla borra en forma " +
                                      "definitiva los items deshabilitados. " +
                                      "¿Confirma la compactación?",
                                      /*App.Usuario.Usuario +*/ "EstadosPurge") == DialogResult.No) return;

            // Purgamos la tabla
            App.ShowMsg("Compactando la tabla...");
            m_smResult.UilReset("cmdPurgar_Click");
            Bll.Tablas.EdsPurge(ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Terminamos
            App.HideMsg();
            MsgRuts.ShowMsg(this, "La tabla ha sido compactada.");
            FillGrid();
        }

        /// <summary>
        /// Finaliza el formulario
        /// </summary>
        private void cmdSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Cancela la edicion
        /// </summary>
        private void cmdCancelar_Click(object sender, System.EventArgs e)
        {
            // Pasamos a modo Operaciones y damos foco a la grilla
            SwitchTo(FormModes.Operations, GridOps.DontFill);
            grdDatos.Focus();
        }

        /// <summary>
        /// Habilita/Deshabilita el registro
        /// </summary>
        private void cmdDesHab_Click(object sender, System.EventArgs e)
        {
            // Realizamos la operacion
            App.ShowMsg("Procesando...");
            m_smResult.UilReset("cmdDesHab_Click");
            Bll.Tablas.EdsEnabled(m_entEstado.EstaBorrada,
                                  m_entEstado.Cod,
                                  m_entEstado.FxdVersion,
                                  ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Pasamos a modo Operaciones, rellenamos la grilla y 
            // le damos foco
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();
            App.HideMsg();
        }

        /// <summary>
        /// Graba el registro en edicion
        /// </summary>
        private void cmdGrabar_Click(object sender, System.EventArgs e)
        {
            // Pasamos los datos a la Entidad
            m_entEstado.Cod= txtCod.Text;
            m_entEstado.Des= txtDes.Text;
            m_entEstado.Txtcontingencia= txtTxtcontingencia.Text;
            m_entEstado.Operativo= cmbOperativo.SelectedStrCode;

            // Tratamos de grabar la entidad
            App.ShowMsg("Grabando...");
            m_smResult.UilReset("cmdGrabar_Click");
            Bll.Tablas.EdsSave(m_entEstado, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Pasamos a modo Operaciones, rellenamos la grilla y 
            // le damos foco
            SwitchTo(FormModes.Operations, GridOps.Fill);
            grdDatos.Focus();
            App.HideMsg();
        }

        //--------------------------------------------------------------
        // Metodos privados
        //--------------------------------------------------------------

        /// <summary>
        /// Llena la grilla con los datos de la tabla
        /// </summary>
        private void FillGrid()
        {
            // Recuperamos los datos para la grilla
            App.ShowMsg("Recuperando datos...");
            m_smResult.UilReset("FillGrid");
            Bel.LEEstados l_lentEstados= Bll.Tablas.EdsUpFull(false, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

            // Asignamos a la grilla
            App.InitAdvance("Cargando:");
            grdDatos.Focus();
            grdDatos.FillFromLEntidad(l_lentEstados, "deleted");
            grdDatos.ColWitdhs= App.GetStrURegistry(false, "GridFormat", "EstadosGrdWidths", "");
            grdDatos.GridOrder= App.GetStrURegistry(false, "GridFormat", "EstadosGrdSort", "");
            App.EndAdvance();

            // Fijamos el evento de cambio de ancho de la grilla
            if (l_lentEstados.Count > 0)
                foreach (DataGridColumnStyle l_dcsItem in grdDatos.TableStyles[0].GridColumnStyles)
                    l_dcsItem.WidthChanged += new EventHandler(GrdColumn_WidthChanged);

            // Ya la llenamos
            App.HideMsg();
        }

        /// <summary>
        /// Cambia el modo del formulario
        /// </summary>
        private void SwitchTo(FormModes p_fmNewMode, GridOps p_goNewGState)
        {
            // Fijamos el nuevo modo del formulario
            switch (p_fmNewMode) {
                case FormModes.Operations   : {OperationMode(); break;}
                case FormModes.Edit         : {EditMode(); break;}
                default                     : {MsgRuts.ShowMsg(this, "Invalid mode"); break;}
            }

            // Fijamos el nuevo estado de la grilla
            switch (p_goNewGState) {
                case GridOps.Fill   : {FillGrid(); break;}
                default             : {break;}
            }
        }

        /// <summary>
        /// Pone el formulario en modo: Operaciones
        /// </summary>
        private void OperationMode()
        {
            // Deshabilitamos el frame
            txtCod.NormalDisable= true;
            txtCod.Enabled= false;
            txtDes.NormalDisable= true;
            txtDes.Enabled= false;
            txtTxtcontingencia.NormalDisable= true;
            txtTxtcontingencia.Enabled= false;
            cmbOperativo.NormalDisable= true;
            cmbOperativo.Enabled= false;
            cmdCancelar.Enabled= false;
            cmdGrabar.Enabled= false;
            cmdDesHab.Enabled= false;
            cmdHab.Enabled= false;

            // Blanqueamos los campos
            txtCod.Text= "";
            txtDes.Text= "";
            txtTxtcontingencia.Text= "";
            cmbOperativo.SelectedStrCode= "";

            // Habilitamos la grilla y los controles operativos
            cmdNuevo.Enabled= true;
            cmdModificar.Enabled= true;
            cmdPurgar.Enabled= true;
            cmdSalir.Enabled= true;
            cmdPrint.Enabled= true;
            cmdExcel.Enabled= true;
            grdDatos.Enabled= true;

            // Procesamos los comandos ACL
            cmdNuevo.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[1].VStr == "S"));
            cmdModificar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[3].VStr == "S"));
            cmdPurgar.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[5].VStr == "S"));

            // El ESC sale del formulario
            CancelButton= cmdSalir;
        }

        /// <summary>
        /// Pone el formulario en modo: Edicion
        /// </summary>
        private void EditMode()
        {
            // Llenamos los campos a partir de la entidad a editar
            txtCod.Text= m_entEstado.Cod;
            txtDes.Text= m_entEstado.Des;
            txtTxtcontingencia.Text= m_entEstado.Txtcontingencia;
            cmbOperativo.SelectedStrCode= m_entEstado.Operativo;

            // Habilitamos el frame
            txtCod.NormalDisable= false;
            txtCod.Enabled= m_entEstado.EsNueva;
            txtDes.NormalDisable= false;
            txtDes.Enabled= m_entEstado.EsNueva;
            txtTxtcontingencia.NormalDisable= false;
            txtTxtcontingencia.Enabled= !m_entEstado.EstaBorrada;
            cmbOperativo.NormalDisable= false;
            cmbOperativo.Enabled= !m_entEstado.EstaBorrada;
            cmdCancelar.Enabled= true;
            cmdGrabar.Enabled= !m_entEstado.EstaBorrada;
            cmdDesHab.Enabled= ((!m_entEstado.EsNueva) &&(!m_entEstado.EstaBorrada));
            cmdHab.Enabled= !cmdDesHab.Enabled;

            // Procesamos los comandos ACL
            cmdHab.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[4].VStr == "S"));
            cmdDesHab.Visible= ((m_aclInfo[0].VStr == "S") || (m_aclInfo[2].VStr == "S"));

            // Dehabilitamos la grilla y los controles operativos
            cmdNuevo.Enabled= false;
            cmdModificar.Enabled= false;
            cmdPurgar.Enabled= false;
            cmdSalir.Enabled= false;
            cmdPrint.Enabled= false;
            cmdExcel.Enabled= false;
            grdDatos.Enabled= false;

            // El ESC sale de la edicion
            CancelButton= cmdCancelar;
        }

        private void tsPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
