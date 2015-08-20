﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rivn.Bll;
using Rivn.Bll.ObjetosSoporte;
using Rivn.Bel;
using TNGS;
using TNGS.NetApp;
using TNGS.NetRoutines;
using TNGS.NetControls;
using WeifenLuo.WinFormsUI.Docking;


namespace Rivn.Mv
{
    public partial class Moviles : DockContent
    {
        #region Miembros de la Clase
        public enum ModoForm { Inicio, EdicionBase,Edicion };
        public enum OpGrid { Igual,Todas, Km, Combus, Equip, Estados };
        private Bel.LEMoviles m_LEMoviles = null;
        private Bel.EMovil m_entMovil = null;
        private Bel.LEEstados m_LEEdsEstados = null;
        //Los de abajo podrian no estar hay que ver
        private AsociadosMovil m_AMAsocMoviles = null;
        private StatMsg m_smResult = null;
        private ACLInfo m_aclInfo = null;
        #endregion

        #region Constructores

        public Moviles()
        {
            InitializeComponent();
            // Obtenemos los permisos ACL
            m_aclInfo = App.ACLInfo;

            // Aplicamos los nieves de seguridad
            App.ApplySecurity(this);

            // Iniciamos los objetos de la clase
            m_smResult = new StatMsg();

            // Dockeamos el formulario
            ((MainFrame)App.GetMainWindow()).AddContent(this);

            TraerInfoBase();
            TraerInfoEstados();
            //LlenarComboEstados();
            SwitchTo(ModoForm.Inicio);
            m_AMAsocMoviles = new AsociadosMovil(ref m_smResult);

        }


        #endregion


        #region Relleno De Datos


        /// <summary>
        /// Hace Upfull de todos los moviles con sus tablas hijo
        /// </summary>
        private void TraerInfoBase()
        {
            m_LEMoviles = Bll.Moviles.UpFull(true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
        }



        /// <summary>
        /// Hace traer la infomracion de los estados disponibles
        /// </summary>
        private void TraerInfoEstados()
        {
            m_LEEdsEstados = Bll.Tablas.EdsUpFull(true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;

        }

        /// <summary>
        /// Llena la tree con todos los moviles activos
        /// </summary>
        private void LlenarTreeMoviles()
        {
            ListaEntidades l_LEMovilesTree = Bll.Moviles.fArmarTree(true, ref m_smResult);
            ftrMoviles.FillFromStrLEntidad(l_LEMovilesTree, "mov_ecd_patente", "mov_des_des", 2, "Nivel","Imagen", "Imagen");
            ftrMoviles.ExpandAll();
            if (MsgRuts.AnalizeError(this, m_smResult)) return;


        }


        /// <summary>
        /// Llena la grid de los Estados con el historial de los estados que tuvo un movil
        /// </summary>
        private void LlenarGridEstados()
        {
            if (m_AMAsocMoviles.Estados.Count != 0)
            {
                //m_entMovil.MovilesEstado.Sort("mve_fyh_fecha desc");
                fgMovilEstados.FillFromLEntidad(m_AMAsocMoviles.Estados);
                fgMovilEstados.ColWitdhs = "105;105;105;0;";
            }
           
        }



        /// <summary>
        /// Se llenan los datos importantes del movil
        /// </summary>
        private void LlenarDatos()
        {
            tePatente.Text = m_entMovil.Patente;
            teModelo.Text = GetModelo(m_entMovil.Modelo);
            // ordenamos por fecha descendentemente para que quede primero el ultimo estado (actual).
            m_entMovil.MovilesEstado.Sort(String.Format("{0} desc", Bel.EMovilEstado.FechaCmp));
            teEstado.Text = GetEstado(m_entMovil.MovilesEstado[0]);
      
        }

        private string GetEstado(EMovilEstado eMovilEstado)
        {
            EEstado l_eEstado = Bll.Tablas.EdsGet(eMovilEstado.Codestado, true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;
            string l_strEstado = l_eEstado.Des;

            return l_strEstado;
        }



        /// <summary>
        /// Se llena la grid con el historial de carga de combustible
        /// </summary>
        private void LlenarGridCombustible()
        {

            if (m_AMAsocMoviles.Combustibles.Count != 0)
            {
                fgCombustibles.FillFromLEntidad(m_AMAsocMoviles.Combustibles);
                fgCombustibles.ColWitdhs = "57;57;100;100;";
            }
        }


        /// <summary>
        /// Se llena la grid de kilometros con el historial del kilometraje
        /// </summary>
        private void LlenarGridKm()
        {
            //m_entMovil.MovilesKms = Bll.Moviles.MvkmFGet(m_entMovil.Patente, true, ref m_smResult);
            if (m_AMAsocMoviles.Kms.Count != 0)
            {

                fgKm.FillFromLEntidad(m_AMAsocMoviles.Kms);
                fgKm.ColWitdhs = "157;157;";
            }
        }



        /// <summary>
        /// Se llena el equipamiento del movil seleccionado
        /// </summary>
        private void LlenarGridEquipamiento()
        {
            if (m_AMAsocMoviles.Equipamiento.Count != 0)
            {
                  //Propiedad .Colwitdhs (para el ancho de las columnas) colwitdhs
                fgEquipamiento.FillFromLEntidad(m_AMAsocMoviles.Equipamiento);
                fgEquipamiento.ColWitdhs = "0;"+(fgEquipamiento.Size.Width -5).ToString()+";";
            }
        }


        /// <summary>
        /// Se limpian los campos
        /// </summary>
        private void LimpiarCampos()
        {
            teModelo.Clear();
            tePatente.Clear();
        }

        #endregion

        #region Eventos

        /// <summary>
        /// Se realiza el llenado de datos y el seteo del miembro Entidad Movil Luego de elegir un Movil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ftrMoviles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string l_strCodigo = ftrMoviles.SelectedNodeAsCDI.StrCode;
            if (l_strCodigo == "0") return;
            m_entMovil = m_LEMoviles[ftrMoviles.SelectedNodeAsCDI.StrCode];
            m_entMovil.MovilesEstado = Bll.Moviles.MvesFGet(m_entMovil.Patente, true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;
            SwitchTo(ModoForm.EdicionBase, OpGrid.Igual);
        }


        #region Clicks


        /// <summary>
        /// Permite modificar un Movil y setea el evento ante la modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gbModificarMovil_Click(object sender, EventArgs e)
        {
            m_entMovil.MovilesEquip = m_AMAsocMoviles.EquipamientoTip;
            AltaMovil l_formAltaMovil = new AltaMovil(m_entMovil, true);
            ((MainFrame)App.GetMainWindow()).AddContent(l_formAltaMovil);
            l_formAltaMovil.m_evChangedMovil += new AltaMovil.ChangedMovilEventHandler(movilChanged);
        }



        /// <summary>
        /// Abre ventana de AltaMoviles modificada para cambiar los equipamientos que tiene disponible el movil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gbModificarEq_Click(object sender, EventArgs e)
        {
            m_entMovil.MovilesEquip = m_AMAsocMoviles.EquipamientoTip;
            AltaMovil l_formAltaMovil = new AltaMovil(m_entMovil, false);
            ((MainFrame)App.GetMainWindow()).AddContent(l_formAltaMovil);
            l_formAltaMovil.m_evChangedMovil += new AltaMovil.ChangedMovilEventHandler(equipChanged);
        }


        /// <summary>
        /// Borrado de un Movil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void gbBorrarMovil_Click(object sender, EventArgs e)
        {
            if (!BorradoSeguro()) return;
            Bll.Moviles.Remove(m_entMovil.Patente,m_entMovil.FxdVersion, ref m_smResult);
            m_entMovil = null;
            SwitchTo(ModoForm.Inicio, OpGrid.Igual);
            MsgRuts.AnalizeError(this, m_smResult);
        }

        /// <summary>
        /// Agrega un nuevo Movil y engancha el evento al metodo movilChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gbNuevoMovil_Click(object sender, EventArgs e)
        {
            AltaMovil l_formAltaMovil = new AltaMovil();
            ((MainFrame)App.GetMainWindow()).AddContent(l_formAltaMovil);
            l_formAltaMovil.m_evChangedMovil += new AltaMovil.ChangedMovilEventHandler(movilChanged);
            
            
        }


        /// <summary>
        /// Manejo de evento para la modificacion o alta de un movil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="s"></param>
        private void movilChanged(object sender, EventArgs s)
        {
            SwitchTo(ModoForm.Inicio);


        }
        /// <summary>
        /// Metodo de manejo de evento del formulario de AltaMovil al modificar un equipamiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="s"></param>
        private void equipChanged(object sender, EventArgs s)
        {
            SwitchTo(ModoForm.Edicion, OpGrid.Equip);


        }  



        /// <summary>
        /// Lanza el formulario de carga de combustible y luego graba en la base el resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gbAgregarCombustible_Click(object sender, EventArgs e)
        {
            MovilCombustible l_frmMovilCombustible = new MovilCombustible();
            l_frmMovilCombustible.ShowDialog();
            if (l_frmMovilCombustible.DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            EMovilCombus l_EMComMovilCombustible = EMovilCombus.NewEmpty();
            l_EMComMovilCombustible.Codestacion = l_frmMovilCombustible.Estacion;
            l_EMComMovilCombustible.Fecha = DateTime.Now;
            l_EMComMovilCombustible.Litros = l_frmMovilCombustible.Litros;
            l_EMComMovilCombustible.Patente = m_entMovil.Patente;
            l_EMComMovilCombustible.Importe = l_frmMovilCombustible.Importe;
            Bll.Moviles.MvcoSave(l_EMComMovilCombustible, ref m_smResult);
            SwitchTo(ModoForm.Edicion, OpGrid.Combus);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;


        }
        /// <summary>
        /// Ingresar un nuevo kilometraje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void gbNuevoKM_Click(object sender, EventArgs e)
        {
            NuevoKm l_frmNuevoKm = new NuevoKm();
            l_frmNuevoKm.ShowDialog();
            if (l_frmNuevoKm.DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            if (l_frmNuevoKm.Kilometros < DameUltimoKms()) {MsgRuts.ShowMsg(this, "El kilometraje que intenta ingresar es menor al ultimo kilometraje ingresado"); return;}
            EMovilKms l_EMKmMovilKm = Bel.EMovilKms.NewEmpty();
            l_EMKmMovilKm.Fecha = DateTime.Now;
            l_EMKmMovilKm.Km = l_frmNuevoKm.Kilometros;
            l_EMKmMovilKm.Patente = tePatente.Text;
            Bll.Moviles.MvkmSave(l_EMKmMovilKm, ref m_smResult);
            SwitchTo(ModoForm.Edicion, OpGrid.Km);
            if (MsgRuts.AnalizeError(this, m_smResult)) return;



        }

        /// <summary>
        /// Cambia el estado del form y llena las grillas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ftrMoviles_DoubleClick(object sender, EventArgs e)
        {
            SwitchTo(ModoForm.Edicion, OpGrid.Todas);
        }


        /// <summary>
        /// Metodo que permite modificar El Estado de un movil seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gbModificarEstado_Click(object sender, EventArgs e)
        {
            ModificarEstado l_frmModificarEstado = new ModificarEstado(m_LEEdsEstados);
            l_frmModificarEstado.ShowDialog();
            if (l_frmModificarEstado.DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }

            if (l_frmModificarEstado.Estado == DameUltimoEstado()) { MsgRuts.ShowMsg(this,"El estado al cual esta modificando es igual al estado actual"); return; };

            EMovilEstado l_EMEstMovilEstado;
            //creamos la entidad y la llenamos con sus datos y la guardamos
            l_EMEstMovilEstado = Bel.EMovilEstado.NewEmpty();
            l_EMEstMovilEstado.Codestado = l_frmModificarEstado.Estado;
            l_EMEstMovilEstado.Fecha = DateTime.Now;
            l_EMEstMovilEstado.Patente = m_entMovil.Patente;
            l_EMEstMovilEstado.Km = DameUltimoKms();

            Bll.Moviles.MvesSave(l_EMEstMovilEstado, ref m_smResult);
            SwitchTo(ModoForm.Edicion, OpGrid.Estados);




            if (MsgRuts.AnalizeError(this, m_smResult)) return;
        }
        #endregion
        #endregion

        #region Otros Metodos
        /// <summary>
        /// Cambia el modo del formulario
        /// </summary>
        private void SwitchTo(ModoForm p_fmNewMode, OpGrid p_goNewGState = 0)
        {
            // Fijamos el nuevo modo del formulario
            switch (p_fmNewMode)
            {
                case ModoForm.Inicio: { ModoInicio(); break; }
                case ModoForm.Edicion: { ModoEdicion(); break; }
                case ModoForm.EdicionBase: { ModoEdicionBase(); break; }
                default: { MsgRuts.ShowMsg(this, "Invalid mode"); break; }
            }

            // Fijamos el nuevo estado de la grilla
            switch (p_goNewGState)
            {
                case OpGrid.Combus: { TraerInfoBase(); LlenarGridCombustible(); break; }
                case OpGrid.Equip: { TraerInfoBase(); LlenarGridEquipamiento(); break; }
                case OpGrid.Estados: { TraerInfoBase(); LlenarGridEstados(); break; }
                case OpGrid.Km: { TraerInfoBase(); LlenarGridKm(); break; }
                case OpGrid.Todas: { TraerInfoBase(); LlenarGrids(); break; }
                case OpGrid.Igual: {break;}
                default: { break; }
            }
        }

        /// <summary>
        /// Metodo del Modo Inicio del Formulario
        /// </summary>
        private void ModoInicio()
        {

            TraerInfoBase();
            TraerInfoEstados();
            LlenarTreeMoviles();

            teEstado.Enabled = false;
            gbModificarMovil.Enabled = false;
            gbNuevoMovil.Enabled = true;
            gbBorrarMovil.Enabled = false;
            pnlOpcionesEspecificas.Enabled = false;
            pnlOpcionesGenerales.Enabled = true;
        }

        /// <summary>
        /// Metodo que setea el formulario para ver datos resumidos del movil
        /// </summary>
        private void ModoEdicionBase()
        {
            LlenarDatos();
            LimpiarEditables();
            fgCombustibles.Clear();
            fgEquipamiento.Clear();
            fgKm.Clear();
            fgMovilEstados.Clear();
            gbBorrarMovil.Enabled = true;
            gbModificarMovil.Enabled = true;
            pnlOpcionesEspecificas.Enabled = false;
            pnlOpcionesGenerales.Enabled = true;
        }

        /// <summary>
        /// Metodo del modo edicion
        /// </summary>
        private void ModoEdicion()
        {
            LlenarDatos();
            LimpiarEditables();
            m_AMAsocMoviles.CargarDatos(m_entMovil.Patente);
            teEstado.Text = m_LEEdsEstados[DameUltimoEstado()].Des;
            gbBorrarMovil.Enabled = true;
            gbModificarMovil.Enabled = true;
            tgrpMoviles.Enabled = true;
            pnlOpcionesEspecificas.Enabled = true;
            pnlOpcionesGenerales.Enabled = false;


        }


        /// <summary>
        /// Llena todas las grids
        /// </summary>
        private void LlenarGrids()
        {
            LlenarGridCombustible();
            LlenarGridEquipamiento();
            LlenarGridEstados();
            LlenarGridKm();
        }

        /// <summary>
        /// Limpia campos editables (hay que sacarlo)
        /// </summary>
        private void LimpiarEditables()
        {
            return;
        }




        /// <summary>
        /// Devuelve 5 primeros estados de un movil
        /// </summary>
        /// <param name="p_LEMEEstadosDeMovil">Lista Entidad tipada MOviles Estado</param>
        /// <returns></returns>
        private LEMovilesEstado Dame5PrimerosEstados(LEMovilesEstado p_LEMEEstadosDeMovil)
        {
           LEMovilesEstado l_LEMEPrimerosCincoMovilesEstados = LEMovilesEstado.NewEmpty();
           long l_lngMaximo = Math.Min(p_LEMEEstadosDeMovil.Count - 1, 4);
           for (long i = 0; i <= l_lngMaximo; i++)
            {
                l_LEMEPrimerosCincoMovilesEstados.AddEntity(p_LEMEEstadosDeMovil[i]);
            }
            return l_LEMEPrimerosCincoMovilesEstados;
        }

        /// <summary>
        /// Devuelve 5 primeras cargas de combustible de un movil
        /// </summary>
        /// <param name="p_LEMEEstadosDeMovil">Lista entidad tipada</param>
        /// <returns></returns>
        private LEMovilesCombus Dame5PrimerosCombustibles(LEMovilesCombus p_LEMECombusDeMovil)
        {
            LEMovilesCombus l_LEMEPrimerosCincoMovilesCombustibles = LEMovilesCombus.NewEmpty();
            long l_lngMaximo = Math.Min(p_LEMECombusDeMovil.Count - 1, 4);
            for (long i = 0; i <= l_lngMaximo; i++)
            {
                l_LEMEPrimerosCincoMovilesCombustibles.AddEntity(p_LEMECombusDeMovil[i]);
            }
            return l_LEMEPrimerosCincoMovilesCombustibles;
        }


        /// <summary>
        /// Devuelve lista entidad con los primeros 5 registros de kms
        /// </summary>
        /// <param name="p_LEMEEstadosDeMovil">Lista entidad tipada de estados</param>
        /// <returns></returns>
        private LEMovilesKms Dame5PrimerosKms(LEMovilesKms p_LEMEKmsDeMovil)
        {
            LEMovilesKms l_LEMEPrimerosCincoMovilesKms = LEMovilesKms.NewEmpty();
            long l_lngMaximo = Math.Min(p_LEMEKmsDeMovil.Count - 1, 4);
            for (long i = 0; i <= l_lngMaximo; i++)
            {
                l_LEMEPrimerosCincoMovilesKms.AddEntity(p_LEMEKmsDeMovil[i]);
            }
            return l_LEMEPrimerosCincoMovilesKms;
        }



        /// <summary>
        /// dispara ventana que avisa al usuario que los datos ingresados no son correctos
        /// </summary>
        private void DatosInvalidos()
        {
            MessageBox.Show("Alguno de los datos no han sido ingresados correctamente", "Datos Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        /// <summary>
        /// Pregunta al usuario si esta seguro que quiere borrar
        /// </summary>
        /// <returns></returns>
        private bool BorradoSeguro()
        {
            DialogResult l_drResult = MessageBox.Show("¿Está seguro que desea borrar?", "Borrado", MessageBoxButtons.YesNo);
            if (l_drResult == System.Windows.Forms.DialogResult.Yes)
                return true;
            else return false;
        }


        /// <summary>
        /// Metodo que devuelve la descripcion del modelo al pasarle su codigo
        /// </summary>
        /// <param name="p_strCodModelo">Codigo de Modelo</param>
        /// <returns>Devuelve la descripción del modelo</returns>
        private string GetModelo(string p_strCodModelo)
        {
            EModelo l_EmodModelo =  Bll.Tablas.ModGet(p_strCodModelo, true, ref m_smResult);
            if (MsgRuts.AnalizeError(this, m_smResult)) return null;
            string l_strModelo = l_EmodModelo.Des;
           
            return l_strModelo;
            
        }

        /// <summary>
        /// Me devuelve el ultimo estado ingresado
        /// </summary>
        /// <returns></returns>
        private string DameUltimoEstado()
        {
            return m_AMAsocMoviles.Estados.InternalData.Table.Rows[0]["mve_rcd_codestado"].ToString();
        }



        /// <summary>
        /// Me da el ultimo kilometraje ingresado
        /// </summary>
        /// <returns></returns>
        private int DameUltimoKms()
        {
            return (int)m_AMAsocMoviles.Kms.InternalData.Table.Rows[0]["mkm_nro_km"];
        }



        #endregion



    }
}