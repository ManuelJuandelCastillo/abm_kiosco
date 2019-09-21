Public Class frmSTKM
    Private Sub FrmSTKM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DrugStoreDataSet.stockminimo' Puede moverla o quitarla según sea necesario.
        Me.StockminimoTableAdapter.Fill(Me.DrugStoreDataSet.stockminimo)

    End Sub
End Class