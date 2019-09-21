Public Class frmABMproductos
    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DrugStoreDataSet)

    End Sub

    Private Sub FrmABMproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DrugStoreDataSet.Categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.DrugStoreDataSet.Categorias)
        'TODO: esta línea de código carga datos en la tabla 'DrugStoreDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DrugStoreDataSet.Productos)

    End Sub

    Private Sub TxtBuscarDesc_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarDesc.TextChanged
        If Trim(txtBuscarDesc.Text) = "" Then
            Me.ProductosBindingSource.RemoveFilter()
        Else
            Me.ProductosBindingSource.Filter = "descripcion LIKE '*" & Trim(txtBuscarDesc.Text) & "*'"
        End If
    End Sub

    Private Sub LimpiarBinding_Click(sender As Object, e As EventArgs) Handles LimpiarBinding.Click
        Me.ProductosBindingSource.RemoveFilter()
        txtBuscarDesc.Text = ""
    End Sub
End Class