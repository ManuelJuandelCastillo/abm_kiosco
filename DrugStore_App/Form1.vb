Public Class frmMain

    Private Sub BtnSTKMinimo_Click(sender As Object, e As EventArgs) Handles btnSTKMinimo.Click
        frmSTKM.Show()
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        frmVentas.Show()
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        frmABMproductos.Show()
    End Sub

    Private Sub BtnABMcat_Click_1(sender As Object, e As EventArgs) Handles btnABMcat.Click
        frmABMcategorias.Show()
    End Sub
End Class
