#region Usings
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Xml;
using TNGS.NetRoutines;
using Rivn;
#endregion

namespace Rivn.Bel
{
    //----------------------------------------------------------------------------
    //                         TNG Software BEL Generator
    //----------------------------------------------------------------------------
    // Fecha                    : 20/09/2013 15:14
    // Sistema                  : Rivn
    // Clase para Administrar   : Tablas de Rivn.
    //----------------------------------------------------------------------------
    // � 1996-2013 by TNG Software                                      Gndr 5.20
    //----------------------------------------------------------------------------

    //****************************************************************************
    // Atencion!!!
    //    Esta clase fue generada por un programa en forma autom�tica. Cualquier
    //    modificaci�n que se realize sobre ella se perder� en la pr�xima
    //    regeneraci�n.
    //****************************************************************************

    #region Entidad: Categoria
    /// <summary>
    /// Clase que representa la Entidad: Categoria
    /// </summary>
    public sealed partial class ECategoria : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Categorias
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public ECategoria(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Categoria
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public ECategoria(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Categoria
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public ECategoria(string p_strXML,
                          bool p_bEsNueva)
        {
            // Fijamos la condicion de entidad nueva
            base.m_bNew= p_bEsNueva;

            // Obtenemos el Nodo de datos del XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXML;
            XmlNode l_xndData= l_xdocData.ChildNodes[0];

            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECategoria.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cat_rcd_cod"]= XMLRuts.ExtractXAttr(l_xndData, "cat_rcd_cod");
            l_drTemp["cat_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "cat_des_des");

            // Llenamos los campos fijos
            XML2FixedFields(ref l_drTemp, l_xndData);

            // Llamamos al metodo fijo
            fNewFromXML(ref l_drTemp, l_xndData);

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de los datos
            l_dtTemp.Rows.Add(l_drTemp);
            SetInternalData(l_dtTemp, l_dtTemp.Rows[0]);
        }

        /// <summary>
        /// Constructor 
        /// Privado para crear clases vacias
        /// </summary>
        /// <param name="p_dtDatos">DataTable con 1 registro con los datos de la entidad</param>
        private ECategoria(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vac�a: Categoria
        /// </summary>
        /// <returns>Entidad vacia: Categoria</returns>
        public static ECategoria NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECategoria.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cat_rcd_cod"]= "";
            l_drTemp["cat_des_des"]= "";

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECategoria l_entRet= new ECategoria(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Categoria
        /// </summary>
        /// <param name="p_strCod">codigo</param>
        /// <param name="p_strDes">descripcion</param>
        /// <returns>Entidad: Categoria</returns>
        public static ECategoria NewFilled(string p_strCod,
                                           string p_strDes)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(ECategoria.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["cat_rcd_cod"]= p_strCod;
            l_drTemp["cat_des_des"]= p_strDes;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            ECategoria l_entRet= new ECategoria(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la estructura de la tabla interna de la entidad
        /// </summary>
        public static DataColumn[] Struct
        {
            get {
                // Creamos el vector de DataColumns y lo llenamos
                DataColumn[] l_dcStruct= new DataColumn[6];

                l_dcStruct[0]= new DataColumn("cat_rcd_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("cat_des_des", typeof(string));
                ECategoria.FillFixedFields(ref l_dcStruct, 2);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// codigo
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["cat_rcd_cod"];}
            set {
                if (value.Trim().Length > 2) value= value.Trim().Substring(0,2);
                InternalData["cat_rcd_cod"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// descripcion
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["cat_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["cat_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// Devuelve la entidad [ECategoria] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [ECategoria] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "ECategoria", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cat_rcd_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "cat_des_des", Des));

                // Asignamos los campos fijos
                FixedFields2XML(l_xdocData, ref l_xndEntidad);

                // Llamamos al metodo fijo
                fAddXMLData(ref l_xdocData, ref l_xndEntidad);

                // Armamos el documento y lo devolvemos
                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad: Categorias
    /// <summary>
    /// Clase que representa la Lista-Entidad: Categorias
    /// </summary>
    public sealed partial class LECategorias : ListaEntidades
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Categorias
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECategorias(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LECategorias(string p_strXMLData) :
            base(ECategoria.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new ECategoria(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LECategorias(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vac�a: Categorias
        /// </summary>
        /// <returns>Lista-Entidad vacia: Categorias</returns>
        public static LECategorias NewEmpty()
        {
            return new LECategorias(ECategoria.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entECategoria">Entidad a agregar</param>
        public void AddEntity(ECategoria p_entECategoria)
        {
            base.AddEntity(p_entECategoria);
        }

        /// <summary>
        /// Remueve una entidad [Categoria] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "cat_rcd_cod = " + Ruts.Co(p_strCod);

            if (m_dtDatos.DefaultView.Count == 1) {
                // La borramos
                m_dtDatos.Rows.Remove(m_dtDatos.DefaultView[0].Row);
                l_iRet= 1;
            }

            // Quito el filtro
            m_dtDatos.DefaultView.RowFilter= "";
            return l_iRet;
        }

        /// <summary>
        /// Verifca si una entidad [Categoria] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (ECategoria l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Categorias
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator GetEnumerator() 
        {
            ECategoria l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new ECategoria(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Categorias
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (ECategoria l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Categorias
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETCategorias GetAsLET()
        {
            // Llenamos la lista tipada
            LETCategorias l_lentRet= new LETCategorias();

            foreach (ECategoria l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Categoria] por indice
        /// </summary>
        public new ECategoria this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Categoria con los datos de la fila
                return new ECategoria(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Categoria] por clave
        /// </summary>
        public ECategoria this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "cat_rcd_cod = " + Ruts.Co(p_strCod);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Categoria con los datos de la fila
                if (l_drData == null) return null;
                return new ECategoria(l_drData);
            }
        }

        /// <summary>
        /// Devuelve la ListaEntidad como XML en string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la ListaEntidad como XML
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                // Construimos el XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LECategorias", null);

                foreach (ECategoria l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Categorias
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Categorias
    /// </summary>
    public sealed partial class LETCategorias : LET<ECategoria>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Categorias
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LECategorias GetAsLE()
        {
            // Llenamos la lista
            LECategorias l_lentRet= LECategorias.NewEmpty();

            foreach (ECategoria l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Categoria] por clave
        /// </summary>
        public ECategoria this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (ECategoria l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == p_strCod)
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion

    #region Entidad: Equipamento
    /// <summary>
    /// Clase que representa la Entidad: Equipamento
    /// </summary>
    public sealed partial class EEquipamento : Entidad
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la entidad a partir de una Row de la tabla: Equipamiento
        /// </summary>
        /// <param name="p_drDatos">DataRow con los datos de la entidad</param>
        public EEquipamento(DataRow p_drDatos) :
            base(p_drDatos)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Equipamento
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        /// <param name="p_bEsNueva">T- La Entidad es Nueva / F- No</param>
        public EEquipamento(string p_strXML) :
            this(p_strXML, false)
        {
        }

        /// <summary>
        /// Construye una entidad desde un XML: Equipamento
        /// </summary>
        /// <param name="p_strXML">Datos en XML</param>
        public EEquipamento(string p_strXML,
                            bool p_bEsNueva)
        {
            // Fijamos la condicion de entidad nueva
            base.m_bNew= p_bEsNueva;

            // Obtenemos el Nodo de datos del XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXML;
            XmlNode l_xndData= l_xdocData.ChildNodes[0];

            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EEquipamento.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["eqi_cod_cod"]= XMLRuts.ExtractXAttr(l_xndData, "eqi_cod_cod");
            l_drTemp["eqi_des_des"]= XMLRuts.ExtractXAttr(l_xndData, "eqi_des_des");
            l_drTemp["eqi_imp_valor"]= XMLRuts.ExtractXAttr(l_xndData, "eqi_imp_valor", (decimal) 0);

            // Llenamos los campos fijos
            XML2FixedFields(ref l_drTemp, l_xndData);

            // Llamamos al metodo fijo
       //     fNewFromXML(ref l_drTemp, l_xndData);

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de los datos
            l_dtTemp.Rows.Add(l_drTemp);
            SetInternalData(l_dtTemp, l_dtTemp.Rows[0]);
        }

        /// <summary>
        /// Constructor 
        /// Privado para crear clases vacias
        /// </summary>
        /// <param name="p_dtDatos">DataTable con 1 registro con los datos de la entidad</param>
        private EEquipamento(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos p�blicos de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una entidad vac�a: Equipamento
        /// </summary>
        /// <returns>Entidad vacia: Equipamento</returns>
        public static EEquipamento NewEmpty()
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EEquipamento.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["eqi_cod_cod"]= "";
            l_drTemp["eqi_des_des"]= "";
            l_drTemp["eqi_imp_valor"]= 0;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EEquipamento l_entRet= new EEquipamento(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }

        /// <summary>
        /// Construye una entidad con datos de parametro: Equipamento
        /// </summary>
        /// <param name="p_strCod">cod</param>
        /// <param name="p_strDes">des</param>
        /// <param name="p_dcValor">valor</param>
        /// <returns>Entidad: Equipamento</returns>
        public static EEquipamento NewFilled(string p_strCod,
                                             string p_strDes,
                                             decimal p_dcValor)
        {
            // Creamos una tabla compatible con la entidad
            DataTable l_dtTemp= new DataTable();
            l_dtTemp.Columns.AddRange(EEquipamento.Struct);

            // Creamos una row a partir de la tabla creada y la
            // llenamos con los valores iniciales
            DataRow l_drTemp= l_dtTemp.NewRow();

            l_drTemp["eqi_cod_cod"]= p_strCod;
            l_drTemp["eqi_des_des"]= p_strDes;
            l_drTemp["eqi_imp_valor"]= p_dcValor;

            // Agregamos la Row creada a la tabla creada y creamos
            // una entidad a partir de la DataTable de 1 registro
            l_dtTemp.Rows.Add(l_drTemp);
            EEquipamento l_entRet= new EEquipamento(l_dtTemp);
            l_dtTemp.Dispose();
            return l_entRet;
        }
        #endregion

        #region Formateadores
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la estructura de la tabla interna de la entidad
        /// </summary>
        public static DataColumn[] Struct
        {
            get {
                // Creamos el vector de DataColumns y lo llenamos
                DataColumn[] l_dcStruct= new DataColumn[7];

                l_dcStruct[0]= new DataColumn("eqi_cod_cod", typeof(string));
                l_dcStruct[1]= new DataColumn("eqi_des_des", typeof(string));
                l_dcStruct[2]= new DataColumn("eqi_imp_valor", typeof(decimal));
                EEquipamento.FillFixedFields(ref l_dcStruct, 3);

                // Devolvemos el vector creado
                return l_dcStruct;
            }
        }

        /// <summary>
        /// cod
        /// </summary>
        public string Cod
        {
            get {return (string) InternalData["eqi_cod_cod"];}
            set {
                if (value.Trim().Length > 4) value= value.Trim().Substring(0,4);
                InternalData["eqi_cod_cod"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// des
        /// </summary>
        public string Des
        {
            get {return ((string) InternalData["eqi_des_des"]).Trim();}
            set {
                if (value.Trim().Length > 30) value= value.Trim().Substring(0,30);
                InternalData["eqi_des_des"]= value.Trim().ToUpper();
            }
        }

        /// <summary>
        /// valor
        /// </summary>
        public decimal Valor
        {
            get {return (decimal) InternalData["eqi_imp_valor"];}
            set {InternalData["eqi_imp_valor"]= value;}
        }

        /// <summary>
        /// Devuelve la entidad [EEquipamento] como XMLDocument en formato string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la entidad [EEquipamento] como XMLDocument
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                //Creamos un Nodo de un Documento XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "EEquipamento", null);

                // Asignamos los atributos al nodo
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "eqi_cod_cod", Cod));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "eqi_des_des", Des));
                l_xndEntidad.Attributes.Append(XMLRuts.CreateXAttr(l_xdocData, "eqi_imp_valor", Valor));

                // Asignamos los campos fijos
                FixedFields2XML(l_xdocData, ref l_xndEntidad);

                // Llamamos al metodo fijo
       //         fAddXMLData(ref l_xdocData, ref l_xndEntidad);

                // Armamos el documento y lo devolvemos
                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad: Equipamiento
    /// <summary>
    /// Clase que representa la Lista-Entidad: Equipamiento
    /// </summary>
    public sealed partial class LEEquipamiento : ListaEntidades
    {
        #region Constructores
        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de una Tabla: Equipamiento
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEEquipamiento(DataTable p_dtDatos) :
            base(p_dtDatos)
        {
        }

        /// <summary>
        /// Constructor
        /// Llena la lista-entidad a partir de un XML
        /// </summary>
        /// <param name="p_dtDatos">DataTable con los datos de la entidad</param>
        public LEEquipamiento(string p_strXMLData) :
            base(EEquipamento.Struct)
        {
            // Creamos el documento XML
            XmlDocument l_xdocData= new XmlDocument();
            l_xdocData.InnerXml= p_strXMLData;
            XmlElement l_xelTemp= l_xdocData.DocumentElement;

            // Agregamos cada item a la LE
            foreach (XmlNode l_xndItem in l_xelTemp.ChildNodes)
                AddEntity(new EEquipamento(l_xndItem.OuterXml));
        }

        /// <summary>
        /// Constructor
        /// Constuye la lista-entidad vacia a partir de una lista de columnas
        /// correspondiente a una entidad
        /// </summary>
        /// <param name="p_dcEstructura">Columnas de la estructura</param>
        private LEEquipamiento(DataColumn[] p_dcEstructura) :
            base(p_dcEstructura)
        {
        }
        #endregion

        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Construye una lista-entidad vac�a: Equipamiento
        /// </summary>
        /// <returns>Lista-Entidad vacia: Equipamiento</returns>
        public static LEEquipamiento NewEmpty()
        {
            return new LEEquipamiento(EEquipamento.Struct);
        }

        /// <summary>
        /// Agrega una entidad a la lista
        /// </summary>
        /// <param name="p_entEEquipamento">Entidad a agregar</param>
        public void AddEntity(EEquipamento p_entEEquipamento)
        {
            base.AddEntity(p_entEEquipamento);
        }

        /// <summary>
        /// Remueve una entidad [Equipamento] por clave
        /// </summary>
        public int RemoveEntity(string p_strCod)
        {
            // Buscamos la fila mediante un filtro
            int l_iRet= 0;

            m_dtDatos.DefaultView.RowFilter= 
                "eqi_cod_cod = " + Ruts.Co(p_strCod);

            if (m_dtDatos.DefaultView.Count == 1) {
                // La borramos
                m_dtDatos.Rows.Remove(m_dtDatos.DefaultView[0].Row);
                l_iRet= 1;
            }

            // Quito el filtro
            m_dtDatos.DefaultView.RowFilter= "";
            return l_iRet;
        }

        /// <summary>
        /// Verifca si una entidad [Equipamento] esta en la lista
        /// </summary>
        public bool Contains(string p_strCod)
        {
            using (EEquipamento l_entTemp= this[p_strCod])
            {
                // Indicamos si existe o no
                return (l_entTemp != null);
            }
        }

        /// <summary>
        /// Devuelve el enumerador de la lista-entidades: Equipamiento
        /// </summary>
        /// <returns>Enumerador de las entidades en la lista</returns>
        public new IEnumerator GetEnumerator() 
        {
            EEquipamento l_entTemp= null;

            foreach (DataRowView l_drvTemp in m_dtDatos.DefaultView) {
                l_entTemp= new EEquipamento(l_drvTemp.Row);
                yield return l_entTemp;
            }
        }

        /// <summary>
        /// Devuelve la lista entidad como un array de entidades: Equipamiento
        /// </summary>
        /// <returns>Array de entidades</returns>
        public ArrayList GetAsArray()
        {
            // Llenamos el array con las entidades
            ArrayList l_alRet= new ArrayList();

            foreach (EEquipamento l_entItem in this)
                l_alRet.Add(l_entItem);

            return l_alRet;
        }

        /// <summary>
        /// Devuelve la lista entidad como una LET: Equipamiento
        /// </summary>
        /// <returns>Lista Entidad Tipada</returns>
        public LETEquipamiento GetAsLET()
        {
            // Llenamos la lista tipada
            LETEquipamiento l_lentRet= new LETEquipamiento();

            foreach (EEquipamento l_entItem in this)
                l_lentRet.Add(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Equipamento] por indice
        /// </summary>
        public new EEquipamento this[long p_lRow]
        {
            get {
                // Recuperamos la fila solicitada
                DataRow l_drDatos= base[(int) p_lRow];
                if (l_drDatos == null) return null;

                // Devolvemos una entidad Equipamento con los datos de la fila
                return new EEquipamento(l_drDatos);
            }
        }

        /// <summary>
        /// Indexer para acceder a cada entidad [Equipamento] por clave
        /// </summary>
        public EEquipamento this[string p_strCod]
        {
            get {
                // Buscamos la fila mediante un filtro
                DataRow l_drData= null;

                m_dtDatos.DefaultView.RowFilter= 
                    "eqi_cod_cod = " + Ruts.Co(p_strCod);

                if (m_dtDatos.DefaultView.Count == 1)
                    l_drData= m_dtDatos.DefaultView[0].Row;

                // Quito el filtro
                m_dtDatos.DefaultView.RowFilter= "";

                // Devolvemos una entidad Equipamento con los datos de la fila
                if (l_drData == null) return null;
                return new EEquipamento(l_drData);
            }
        }

        /// <summary>
        /// Devuelve la ListaEntidad como XML en string
        /// </summary>
        public string XMLData
        {
            get {return XMLEncode.InnerXml;}
        }

        /// <summary>
        /// Devuelve la ListaEntidad como XML
        /// </summary>
        public XmlDocument XMLEncode
        {
            get {
                // Construimos el XML
                XmlDocument l_xdocData= new XmlDocument();
                XmlNode l_xndEntidad= l_xdocData.CreateNode(XmlNodeType.Element, "LEEquipamiento", null);

                foreach (EEquipamento l_entDExtra in this)
                    l_xndEntidad.AppendChild(l_xdocData.ImportNode(l_entDExtra.XMLEncode.ChildNodes[0], false));

                l_xdocData.AppendChild(l_xndEntidad);
                return l_xdocData;
            }
        }
        #endregion
    }
    #endregion

    #region Lista-Entidad-Tipada: Equipamiento
    /// <summary>
    /// Clase que representa la Lista-Entidad-Tipada: Equipamiento
    /// </summary>
    public sealed partial class LETEquipamiento : LET<EEquipamento>
    {
        #region Metodos publicos de la clase
        //---------------------------------------------------------------
        // Metodos publicos
        //---------------------------------------------------------------

        /// <summary>
        /// Devuelve la lista entidad tipada como una LE: Equipamiento
        /// </summary>
        /// <returns>Lista Entidad</returns>
        public LEEquipamiento GetAsLE()
        {
            // Llenamos la lista
            LEEquipamiento l_lentRet= LEEquipamiento.NewEmpty();

            foreach (EEquipamento l_entItem in this)
                l_lentRet.AddEntity(l_entItem);

            return l_lentRet;
        }
        #endregion

        #region Propiedades de la clase
        //---------------------------------------------------------------
        // Propiedades de la clase
        //---------------------------------------------------------------

        /// <summary>
        /// Indexer para acceder a cada entidad [Equipamento] por clave
        /// </summary>
        public EEquipamento this[string p_strCod]
        {
            get {
                // Buscamos la entidad
                foreach (EEquipamento l_entItem in this) {
                    // Si existe -> la devolvemos
                    if (l_entItem.Cod == p_strCod)
                        return l_entItem;
                }

                // No existe
                return null;
            }
        }
        #endregion
    }
    #endregion
}
