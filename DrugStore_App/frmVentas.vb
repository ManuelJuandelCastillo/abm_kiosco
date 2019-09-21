
Public Class frmVentas

    Sub cambioBtnTxt()
        btnNuevaVenta.Enabled = Not btnNuevaVenta.Enabled
        btnCanelar.Enabled = Not btnCanelar.Enabled
        btnGrabar.Enabled = Not btnGrabar.Enabled
        btnSelecciona.Enabled = Not btnSelecciona.Enabled
        btnAgregar.Enabled = Not btnAgregar.Enabled

        txtSelecciono.Enabled = Not txtSelecciono.Enabled
        txtCantidad.Enabled = Not txtCantidad.Enabled
    End Sub

    Sub restablecer()
        Vw_ventasBindingSource.Filter = "NroVenta=0"
        lblVentas.Text = 0
        txtSelecciono.Text = ""
        lblTotal.Text = "0.00"
        lblDesc.Text = "Desripcion de producto"
        lblStock.Text = "Stock actual"
        lblImporte.Text = "Valor unitario"
        txtCantidad.Text = ""
        lblSubt.Text = "Subtotal"
    End Sub

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DrugStoreDataSet.Numeracion' Puede moverla o quitarla según sea necesario.
        Me.NumeracionTableAdapter.Fill(Me.DrugStoreDataSet.Numeracion)
        'TODO: esta línea de código carga datos en la tabla 'DrugStoreDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.DrugStoreDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'DrugStoreDataSet.vw_ventas' Puede moverla o quitarla según sea necesario.
        Me.Vw_ventasTableAdapter.Fill(Me.DrugStoreDataSet.vw_ventas)
        'TODO: esta línea de código carga datos en la tabla 'DrugStoreDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DrugStoreDataSet.Productos)
        Me.Vw_ventasBindingSource.Filter = "NroVenta=0"

        ProductosDataGridView.BringToFront()
    End Sub

    Private Sub BtnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        cambioBtnTxt()
        txtSelecciono.Focus()
        Try
            lblVentas.Text = NumeracionTableAdapter.NumeroVeenta + 1
        Catch
            lblVentas.Text = 1
        End Try
    End Sub

    Private Sub TxtSelecciono_TextChanged(sender As Object, e As EventArgs) Handles txtSelecciono.TextChanged
        If Trim(txtSelecciono.Text) = "" Then
            Me.ProductosBindingSource.RemoveFilter()
            Me.ProductosDataGridView.Visible = False
        Else
            Me.ProductosBindingSource.Filter = "descripcion LIKE '*" & Trim(txtSelecciono.Text) & "*'"
            Me.ProductosDataGridView.Visible = True
            Me.ProductosDataGridView.Width = 608
        End If
    End Sub

    Private Sub BtnSelecciona_Click(sender As Object, e As EventArgs) Handles btnSelecciona.Click
        With ProductosDataGridView
            If ProductosDataGridView.Rows.Count = 0 Then Exit Sub
            lblDesc.Tag = ProductosDataGridView.CurrentRow.Cells(0).Value
            lblDesc.Text = ProductosDataGridView.CurrentRow.Cells(2).Value
            lblStock.Text = ProductosDataGridView.CurrentRow.Cells(4).Value
            lblImporte.Text = Format(ProductosDataGridView.CurrentRow.Cells(7).Value, "c")

        End With

        txtSelecciono.Text = ""
        txtCantidad.Focus()
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If Trim(txtCantidad.Text) = "" Then lblSubt.Text = 0 : Exit Sub
        If IsNumeric(Trim(txtCantidad.Text)) Then
            lblSubt.Text = txtCantidad.Text * lblImporte.Text
        End If
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        VentasTableAdapter.AgregarVenta(Date.Now, lblVentas.Text, lblDesc.Tag, txtCantidad.Text, lblImporte.Text, lblSubt.Text)
        Me.Vw_ventasTableAdapter.Fill(Me.DrugStoreDataSet.vw_ventas)
        Me.Vw_ventasBindingSource.Filter = "nroventa = " & CSng(lblVentas.Text)

        lblTotal.Text = CSng(lblTotal.Text) + CSng(lblSubt.Text)

        lblDesc.Text = "Descripcion de producto"
        lblStock.Text = "Stock actual"
        lblImporte.Text = "Importe unitario"
        lblSubt.Text = "subtotal"
        txtCantidad.Text = ""

        txtSelecciono.Focus()
    End Sub

    Private Sub BtnCanelar_Click(sender As Object, e As EventArgs) Handles btnCanelar.Click
        If MsgBox("Está seguro de cancelar de venta?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            VentasTableAdapter.CancelarVenta(lblVentas.Text)
            cambioBtnTxt()
            restablecer()
        End If
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        NumeracionTableAdapter.GenerarTicket()
        cambioBtnTxt()
        restablecer()
        MsgBox("La venta se ha registrado exitosamente.")
    End Sub

End Class