Imports Clases



Public Class SeleccionTenis
    Dim zapato As New TenisBase
    Dim listaModelos As New List(Of String)
    Dim listaTallas As New List(Of Double)
    Dim listaPrecios As New List(Of Double)



    Private Sub SeleccionTenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicializarLista()

        ComboBoxModelo.DataSource = listaModelos
        ComboBoxTalla.DataSource = listaTallas
        seleccionarPrecio()

    End Sub



    Public Sub inicializarLista()
        listaModelos.Add("Teni1")
        listaModelos.Add("Teni2")
        listaModelos.Add("Teni3")

        listaTallas.Add(25.0)
        listaTallas.Add(25.5)
        listaTallas.Add(26.0)
        listaTallas.Add(26.5)
        listaTallas.Add(27.0)
        listaTallas.Add(27.5)

        listaPrecios.Add(55.0)
        listaPrecios.Add(88.5)
        listaPrecios.Add(45.99)

    End Sub

    Public Sub seleccionarPrecio()
        EtiquetaPrecio.Text = listaPrecios(ComboBoxModelo.SelectedIndex)
    End Sub

    Private Sub ComboBoxModelo_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxModelo.SelectedValueChanged
        seleccionarPrecio()

    End Sub

    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click
        zapato.Precio = CType(EtiquetaPrecio.Text, Double)
        zapato.Modelo = ComboBoxModelo.Text
        zapato.Talla = CType(ComboBoxTalla.Text, Double)

    End Sub
End Class
