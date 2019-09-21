<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMproductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim CodProveedorLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim StockMinimoLabel As System.Windows.Forms.Label
        Dim PrecioCostoLabel As System.Windows.Forms.Label
        Dim PrecioVentaLabel As System.Windows.Forms.Label
        Dim ActivoLabel As System.Windows.Forms.Label
        Dim CategoriaIDLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABMproductos))
        Me.DrugStoreDataSet = New DrugStore_App.DrugStoreDataSet()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New DrugStore_App.DrugStoreDataSetTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New DrugStore_App.DrugStoreDataSetTableAdapters.TableAdapterManager()
        Me.ProductosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.CodProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.StockMinimoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioCostoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioVentaTextBox = New System.Windows.Forms.TextBox()
        Me.ActivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriasTableAdapter = New DrugStore_App.DrugStoreDataSetTableAdapters.CategoriasTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtBuscarDesc = New System.Windows.Forms.TextBox()
        Me.LimpiarBinding = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CodProveedorLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        StockMinimoLabel = New System.Windows.Forms.Label()
        PrecioCostoLabel = New System.Windows.Forms.Label()
        PrecioVentaLabel = New System.Windows.Forms.Label()
        ActivoLabel = New System.Windows.Forms.Label()
        CategoriaIDLabel1 = New System.Windows.Forms.Label()
        CType(Me.DrugStoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosBindingNavigator.SuspendLayout()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.BackColor = System.Drawing.Color.Transparent
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(200, 178)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 16)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.BackColor = System.Drawing.Color.Transparent
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(139, 236)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(83, 16)
        DescripcionLabel.TabIndex = 5
        DescripcionLabel.Text = "Descripcion:"
        DescripcionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CodProveedorLabel
        '
        CodProveedorLabel.AutoSize = True
        CodProveedorLabel.BackColor = System.Drawing.Color.Transparent
        CodProveedorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodProveedorLabel.Location = New System.Drawing.Point(119, 264)
        CodProveedorLabel.Name = "CodProveedorLabel"
        CodProveedorLabel.Size = New System.Drawing.Size(103, 16)
        CodProveedorLabel.TabIndex = 7
        CodProveedorLabel.Text = "Cod Proveedor:"
        CodProveedorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.BackColor = System.Drawing.Color.Transparent
        StockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockLabel.Location = New System.Drawing.Point(177, 295)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(45, 16)
        StockLabel.TabIndex = 9
        StockLabel.Text = "Stock:"
        StockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StockMinimoLabel
        '
        StockMinimoLabel.AutoSize = True
        StockMinimoLabel.BackColor = System.Drawing.Color.Transparent
        StockMinimoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StockMinimoLabel.Location = New System.Drawing.Point(131, 320)
        StockMinimoLabel.Name = "StockMinimoLabel"
        StockMinimoLabel.Size = New System.Drawing.Size(91, 16)
        StockMinimoLabel.TabIndex = 11
        StockMinimoLabel.Text = "Stock Minimo:"
        StockMinimoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrecioCostoLabel
        '
        PrecioCostoLabel.AutoSize = True
        PrecioCostoLabel.BackColor = System.Drawing.Color.Transparent
        PrecioCostoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioCostoLabel.Location = New System.Drawing.Point(134, 348)
        PrecioCostoLabel.Name = "PrecioCostoLabel"
        PrecioCostoLabel.Size = New System.Drawing.Size(88, 16)
        PrecioCostoLabel.TabIndex = 13
        PrecioCostoLabel.Text = "Precio Costo:"
        PrecioCostoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrecioVentaLabel
        '
        PrecioVentaLabel.AutoSize = True
        PrecioVentaLabel.BackColor = System.Drawing.Color.Transparent
        PrecioVentaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioVentaLabel.Location = New System.Drawing.Point(134, 376)
        PrecioVentaLabel.Name = "PrecioVentaLabel"
        PrecioVentaLabel.Size = New System.Drawing.Size(88, 16)
        PrecioVentaLabel.TabIndex = 15
        PrecioVentaLabel.Text = "Precio Venta:"
        PrecioVentaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ActivoLabel
        '
        ActivoLabel.AutoSize = True
        ActivoLabel.BackColor = System.Drawing.Color.Transparent
        ActivoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActivoLabel.Location = New System.Drawing.Point(174, 404)
        ActivoLabel.Name = "ActivoLabel"
        ActivoLabel.Size = New System.Drawing.Size(48, 16)
        ActivoLabel.TabIndex = 17
        ActivoLabel.Text = "Activo:"
        ActivoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CategoriaIDLabel1
        '
        CategoriaIDLabel1.AutoSize = True
        CategoriaIDLabel1.BackColor = System.Drawing.Color.Transparent
        CategoriaIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaIDLabel1.Location = New System.Drawing.Point(152, 206)
        CategoriaIDLabel1.Name = "CategoriaIDLabel1"
        CategoriaIDLabel1.Size = New System.Drawing.Size(70, 16)
        CategoriaIDLabel1.TabIndex = 18
        CategoriaIDLabel1.Text = "Categoria:"
        CategoriaIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DrugStoreDataSet
        '
        Me.DrugStoreDataSet.DataSetName = "DrugStoreDataSet"
        Me.DrugStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.DrugStoreDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager.NumeracionTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.UpdateOrder = DrugStore_App.DrugStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ProductosBindingNavigator
        '
        Me.ProductosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductosBindingNavigator.AutoSize = False
        Me.ProductosBindingNavigator.BackColor = System.Drawing.Color.Transparent
        Me.ProductosBindingNavigator.BindingSource = Me.ProductosBindingSource
        Me.ProductosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProductosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ProductosBindingNavigatorSaveItem, Me.BindingNavigatorAddNewItem})
        Me.ProductosBindingNavigator.Location = New System.Drawing.Point(0, 452)
        Me.ProductosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductosBindingNavigator.Name = "ProductosBindingNavigator"
        Me.ProductosBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 1, 15)
        Me.ProductosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductosBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProductosBindingNavigator.Size = New System.Drawing.Size(553, 55)
        Me.ProductosBindingNavigator.TabIndex = 0
        Me.ProductosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.BackColor = System.Drawing.Color.DodgerBlue
        Me.BindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Margin = New System.Windows.Forms.Padding(30, 1, 0, 2)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(105, 37)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 37)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        Me.BindingNavigatorCountItem.Visible = False
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.BackColor = System.Drawing.Color.OrangeRed
        Me.BindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.White
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(70, 37)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        Me.BindingNavigatorMoveFirstItem.Visible = False
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 40)
        Me.BindingNavigatorSeparator.Visible = False
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        Me.BindingNavigatorPositionItem.Visible = False
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 40)
        Me.BindingNavigatorSeparator1.Visible = False
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        Me.BindingNavigatorMoveNextItem.Visible = False
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 37)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        Me.BindingNavigatorMoveLastItem.Visible = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 40)
        Me.BindingNavigatorSeparator2.Visible = False
        '
        'ProductosBindingNavigatorSaveItem
        '
        Me.ProductosBindingNavigatorSaveItem.BackColor = System.Drawing.Color.LimeGreen
        Me.ProductosBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.White
        Me.ProductosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductosBindingNavigatorSaveItem.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.ProductosBindingNavigatorSaveItem.Name = "ProductosBindingNavigatorSaveItem"
        Me.ProductosBindingNavigatorSaveItem.Size = New System.Drawing.Size(101, 37)
        Me.ProductosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(228, 175)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(104, 22)
        Me.IdTextBox.TabIndex = 2
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(228, 233)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(205, 22)
        Me.DescripcionTextBox.TabIndex = 6
        '
        'CodProveedorTextBox
        '
        Me.CodProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "CodProveedor", True))
        Me.CodProveedorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodProveedorTextBox.Location = New System.Drawing.Point(228, 261)
        Me.CodProveedorTextBox.Name = "CodProveedorTextBox"
        Me.CodProveedorTextBox.Size = New System.Drawing.Size(104, 22)
        Me.CodProveedorTextBox.TabIndex = 8
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Stock", True))
        Me.StockTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockTextBox.Location = New System.Drawing.Point(228, 289)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(104, 22)
        Me.StockTextBox.TabIndex = 10
        '
        'StockMinimoTextBox
        '
        Me.StockMinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "StockMinimo", True))
        Me.StockMinimoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockMinimoTextBox.Location = New System.Drawing.Point(228, 317)
        Me.StockMinimoTextBox.Name = "StockMinimoTextBox"
        Me.StockMinimoTextBox.Size = New System.Drawing.Size(104, 22)
        Me.StockMinimoTextBox.TabIndex = 12
        '
        'PrecioCostoTextBox
        '
        Me.PrecioCostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "PrecioCosto", True))
        Me.PrecioCostoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioCostoTextBox.Location = New System.Drawing.Point(228, 345)
        Me.PrecioCostoTextBox.Name = "PrecioCostoTextBox"
        Me.PrecioCostoTextBox.Size = New System.Drawing.Size(104, 22)
        Me.PrecioCostoTextBox.TabIndex = 14
        '
        'PrecioVentaTextBox
        '
        Me.PrecioVentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "PrecioVenta", True))
        Me.PrecioVentaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrecioVentaTextBox.Location = New System.Drawing.Point(228, 373)
        Me.PrecioVentaTextBox.Name = "PrecioVentaTextBox"
        Me.PrecioVentaTextBox.Size = New System.Drawing.Size(104, 22)
        Me.PrecioVentaTextBox.TabIndex = 16
        '
        'ActivoCheckBox
        '
        Me.ActivoCheckBox.Checked = True
        Me.ActivoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ActivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "Activo", True))
        Me.ActivoCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivoCheckBox.Location = New System.Drawing.Point(228, 401)
        Me.ActivoCheckBox.Name = "ActivoCheckBox"
        Me.ActivoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ActivoCheckBox.TabIndex = 18
        Me.ActivoCheckBox.UseVisualStyleBackColor = True
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.DrugStoreDataSet
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "CategoriaID", True))
        Me.ComboBox1.DataSource = Me.CategoriasBindingSource
        Me.ComboBox1.DisplayMember = "NombreCat"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(228, 203)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(205, 24)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "IdCat"
        '
        'txtBuscarDesc
        '
        Me.txtBuscarDesc.Location = New System.Drawing.Point(134, 120)
        Me.txtBuscarDesc.Name = "txtBuscarDesc"
        Me.txtBuscarDesc.Size = New System.Drawing.Size(205, 20)
        Me.txtBuscarDesc.TabIndex = 1
        '
        'LimpiarBinding
        '
        Me.LimpiarBinding.BackColor = System.Drawing.Color.DodgerBlue
        Me.LimpiarBinding.FlatAppearance.BorderSize = 0
        Me.LimpiarBinding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LimpiarBinding.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimpiarBinding.ForeColor = System.Drawing.Color.White
        Me.LimpiarBinding.Location = New System.Drawing.Point(345, 116)
        Me.LimpiarBinding.Name = "LimpiarBinding"
        Me.LimpiarBinding.Size = New System.Drawing.Size(132, 26)
        Me.LimpiarBinding.TabIndex = 21
        Me.LimpiarBinding.Text = "Limpiar busqueda"
        Me.LimpiarBinding.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Buscar:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 100)
        Me.Panel1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(165, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 59)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Productos"
        '
        'frmABMproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DrugStore_App.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(553, 507)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LimpiarBinding)
        Me.Controls.Add(Me.txtBuscarDesc)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(CategoriaIDLabel1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(CodProveedorLabel)
        Me.Controls.Add(Me.CodProveedorTextBox)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(StockMinimoLabel)
        Me.Controls.Add(Me.StockMinimoTextBox)
        Me.Controls.Add(PrecioCostoLabel)
        Me.Controls.Add(Me.PrecioCostoTextBox)
        Me.Controls.Add(PrecioVentaLabel)
        Me.Controls.Add(Me.PrecioVentaTextBox)
        Me.Controls.Add(ActivoLabel)
        Me.Controls.Add(Me.ActivoCheckBox)
        Me.Controls.Add(Me.ProductosBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmABMproductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmABMproductos"
        CType(Me.DrugStoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosBindingNavigator.ResumeLayout(False)
        Me.ProductosBindingNavigator.PerformLayout()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrugStoreDataSet As DrugStoreDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As DrugStoreDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As DrugStoreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents CodProveedorTextBox As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents StockMinimoTextBox As TextBox
    Friend WithEvents PrecioCostoTextBox As TextBox
    Friend WithEvents PrecioVentaTextBox As TextBox
    Friend WithEvents ActivoCheckBox As CheckBox
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents CategoriasTableAdapter As DrugStoreDataSetTableAdapters.CategoriasTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtBuscarDesc As TextBox
    Friend WithEvents LimpiarBinding As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
