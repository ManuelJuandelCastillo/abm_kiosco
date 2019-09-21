<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.btnCanelar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.txtSelecciono = New System.Windows.Forms.TextBox()
        Me.btnSelecciona = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblSubt = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Vw_ventasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vw_ventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DrugStoreDataSet = New DrugStore_App.DrugStoreDataSet()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumeracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New DrugStore_App.DrugStoreDataSetTableAdapters.TableAdapterManager()
        Me.ProductosTableAdapter = New DrugStore_App.DrugStoreDataSetTableAdapters.ProductosTableAdapter()
        Me.Vw_ventasTableAdapter = New DrugStore_App.DrugStoreDataSetTableAdapters.vw_ventasTableAdapter()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New DrugStore_App.DrugStoreDataSetTableAdapters.VentasTableAdapter()
        Me.NumeracionTableAdapter = New DrugStore_App.DrugStoreDataSetTableAdapters.NumeracionTableAdapter()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_ventasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_ventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugStoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNuevaVenta.FlatAppearance.BorderSize = 0
        Me.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaVenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaVenta.ForeColor = System.Drawing.Color.White
        Me.btnNuevaVenta.Location = New System.Drawing.Point(39, 12)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Size = New System.Drawing.Size(120, 35)
        Me.btnNuevaVenta.TabIndex = 0
        Me.btnNuevaVenta.Text = "Nueva venta"
        Me.btnNuevaVenta.UseVisualStyleBackColor = False
        '
        'btnCanelar
        '
        Me.btnCanelar.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCanelar.Enabled = False
        Me.btnCanelar.FlatAppearance.BorderSize = 0
        Me.btnCanelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanelar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCanelar.ForeColor = System.Drawing.Color.White
        Me.btnCanelar.Location = New System.Drawing.Point(175, 12)
        Me.btnCanelar.Name = "btnCanelar"
        Me.btnCanelar.Size = New System.Drawing.Size(120, 35)
        Me.btnCanelar.TabIndex = 1
        Me.btnCanelar.Text = "Cancelar venta"
        Me.btnCanelar.UseVisualStyleBackColor = False
        '
        'btnGrabar
        '
        Me.btnGrabar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.FlatAppearance.BorderSize = 0
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabar.ForeColor = System.Drawing.Color.White
        Me.btnGrabar.Location = New System.Drawing.Point(310, 12)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(120, 35)
        Me.btnGrabar.TabIndex = 2
        Me.btnGrabar.Text = "Grabar venta"
        Me.btnGrabar.UseVisualStyleBackColor = False
        '
        'lblVentas
        '
        Me.lblVentas.AutoSize = True
        Me.lblVentas.BackColor = System.Drawing.Color.Transparent
        Me.lblVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentas.Location = New System.Drawing.Point(623, 18)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(19, 20)
        Me.lblVentas.TabIndex = 3
        Me.lblVentas.Text = "0"
        Me.lblVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSelecciono
        '
        Me.txtSelecciono.Enabled = False
        Me.txtSelecciono.Location = New System.Drawing.Point(39, 104)
        Me.txtSelecciono.Name = "txtSelecciono"
        Me.txtSelecciono.Size = New System.Drawing.Size(324, 20)
        Me.txtSelecciono.TabIndex = 4
        '
        'btnSelecciona
        '
        Me.btnSelecciona.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSelecciona.Enabled = False
        Me.btnSelecciona.FlatAppearance.BorderSize = 0
        Me.btnSelecciona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelecciona.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelecciona.ForeColor = System.Drawing.Color.White
        Me.btnSelecciona.Location = New System.Drawing.Point(387, 97)
        Me.btnSelecciona.Name = "btnSelecciona"
        Me.btnSelecciona.Size = New System.Drawing.Size(100, 31)
        Me.btnSelecciona.TabIndex = 5
        Me.btnSelecciona.Text = "Seleccionar"
        Me.btnSelecciona.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(538, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Venta:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Location = New System.Drawing.Point(36, 176)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(121, 13)
        Me.lblDesc.TabIndex = 7
        Me.lblDesc.Text = "descripcion de producto"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.BackColor = System.Drawing.Color.Transparent
        Me.lblStock.Location = New System.Drawing.Point(184, 176)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(68, 13)
        Me.lblStock.TabIndex = 7
        Me.lblStock.Text = "Stock Actual"
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.BackColor = System.Drawing.Color.Transparent
        Me.lblImporte.Location = New System.Drawing.Point(275, 176)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(79, 13)
        Me.lblImporte.TabIndex = 7
        Me.lblImporte.Text = "Importe unitario"
        '
        'lblSubt
        '
        Me.lblSubt.AutoSize = True
        Me.lblSubt.BackColor = System.Drawing.Color.Transparent
        Me.lblSubt.Location = New System.Drawing.Point(515, 176)
        Me.lblSubt.Name = "lblSubt"
        Me.lblSubt.Size = New System.Drawing.Size(50, 13)
        Me.lblSubt.TabIndex = 7
        Me.lblSubt.Text = "SubTotal"
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(387, 172)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 8
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(596, 162)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(73, 31)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewCheckBoxColumn1})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(23, 125)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.Size = New System.Drawing.Size(0, 150)
        Me.ProductosDataGridView.TabIndex = 15
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(562, 443)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 38)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Vw_ventasDataGridView
        '
        Me.Vw_ventasDataGridView.AllowUserToAddRows = False
        Me.Vw_ventasDataGridView.AllowUserToDeleteRows = False
        Me.Vw_ventasDataGridView.AutoGenerateColumns = False
        Me.Vw_ventasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Vw_ventasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_ventasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Vw_ventasDataGridView.DataSource = Me.Vw_ventasBindingSource
        Me.Vw_ventasDataGridView.Location = New System.Drawing.Point(39, 199)
        Me.Vw_ventasDataGridView.Name = "Vw_ventasDataGridView"
        Me.Vw_ventasDataGridView.ReadOnly = True
        Me.Vw_ventasDataGridView.Size = New System.Drawing.Size(630, 241)
        Me.Vw_ventasDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NroVenta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NroVenta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 270
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PrecioUnitario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PrecioUnitario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Subtotal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Vw_ventasBindingSource
        '
        Me.Vw_ventasBindingSource.DataMember = "vw_ventas"
        Me.Vw_ventasBindingSource.DataSource = Me.DrugStoreDataSet
        '
        'DrugStoreDataSet
        '
        Me.DrugStoreDataSet.DataSetName = "DrugStoreDataSet"
        Me.DrugStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CategoriaID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CategoriaID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 250
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CodProveedor"
        Me.DataGridViewTextBoxColumn10.HeaderText = "CodProveedor"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Stock"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 70
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "StockMinimo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "StockMinimo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PrecioCosto"
        Me.DataGridViewTextBoxColumn13.HeaderText = "PrecioCosto"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PrecioVenta"
        Me.DataGridViewTextBoxColumn14.HeaderText = "PrecioVenta"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 70
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Activo"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 40
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.DrugStoreDataSet
        '
        'NumeracionBindingSource
        '
        Me.NumeracionBindingSource.DataMember = "Numeracion"
        Me.NumeracionBindingSource.DataSource = Me.DrugStoreDataSet
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
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Vw_ventasTableAdapter
        '
        Me.Vw_ventasTableAdapter.ClearBeforeFill = True
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.DrugStoreDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'NumeracionTableAdapter
        '
        Me.NumeracionTableAdapter.ClearBeforeFill = True
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DrugStore_App.My.Resources.Resources.fondo
        Me.ClientSize = New System.Drawing.Size(693, 490)
        Me.Controls.Add(Me.Vw_ventasDataGridView)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblSubt)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelecciona)
        Me.Controls.Add(Me.txtSelecciono)
        Me.Controls.Add(Me.lblVentas)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnCanelar)
        Me.Controls.Add(Me.btnNuevaVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta al publico"
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_ventasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_ventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugStoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevaVenta As Button
    Friend WithEvents btnCanelar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents lblVentas As Label
    Friend WithEvents txtSelecciono As TextBox
    Friend WithEvents btnSelecciona As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblImporte As Label
    Friend WithEvents lblSubt As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents DrugStoreDataSet As DrugStoreDataSet
    Friend WithEvents TableAdapterManager As DrugStoreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosTableAdapter As DrugStoreDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents lblTotal As Label
    Friend WithEvents Vw_ventasBindingSource As BindingSource
    Friend WithEvents Vw_ventasTableAdapter As DrugStoreDataSetTableAdapters.vw_ventasTableAdapter
    Friend WithEvents Vw_ventasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As DrugStoreDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents NumeracionBindingSource As BindingSource
    Friend WithEvents NumeracionTableAdapter As DrugStoreDataSetTableAdapters.NumeracionTableAdapter
End Class
