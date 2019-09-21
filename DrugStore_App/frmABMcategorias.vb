Public Class frmABMcategorias
    Private Sub CategoriasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoriasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DrugStoreDataSet)

    End Sub

    Private Sub FrmABMcategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DrugStoreDataSet.Categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.DrugStoreDataSet.Categorias)

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        CategoriasBindingSource.EndEdit()
        CategoriasTableAdapter.Update(DrugStoreDataSet.Categorias)
        MsgBox("Se ha actualizado la tabla Categorias.")
    End Sub
End Class