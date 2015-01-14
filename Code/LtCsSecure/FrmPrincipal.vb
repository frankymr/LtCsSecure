Imports LatchSDK
Imports System.ServiceProcess

Public Class FrmPrincipal
    Public ObjetoWMI As Object
    Public ProgramasWMI As Object

    Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.AliceBlue
        Dim Glass As New rtaGlassEffectsLib.rtaGlassEffect
        Glass.TopBarSize = 20
        Glass.BottomBarSize = 60
        Glass.LeftBarSize = 17
        Glass.RightBarSize = 15
        Glass.ShowEffect(Me)
        Carga_Valores()


    End Sub

    Sub BtParear_Click(sender As Object, e As EventArgs) Handles BtParear.Click
        Dim AccountId As String
        If TxtPareo.Text.Length <> 0 Then
            Dim Respuesta As LatchSDK.LatchResponse = LtCs.Procesos.Pair(TxtPareo.Text.Trim)
            If Respuesta.Data IsNot Nothing AndAlso Respuesta.Data.ContainsKey("accountId") Then
                AccountId = Respuesta.Data("accountId").ToString
                LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa, "AccountId", AccountId)
                BtParear.Enabled = False
                BtUnpair.Enabled = True
            Else
                TxtPareo.Text = ""
                MsgBox("Error pareando dispositivo", MsgBoxStyle.Exclamation, "Atencion")
            End If
        End If

    End Sub

    Sub BtUnpair_Click(sender As Object, e As EventArgs) Handles BtUnpair.Click

        Dim AccountId = LtCs.registro.CargarValor(LtCs.Variables_Globales.Reg_programa, "AccountId", "S")
        Dim Respuesta As LatchSDK.LatchResponse = LtCs.Procesos.Unpair(AccountId)
        If Respuesta.Data Is Nothing Then
            LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa, "AccountId", "") 'vaciamos
            BtUnpair.Enabled = False
            BtParear.Enabled = True
            TxtPareo.Text = ""
        Else
            MsgBox("Error liberando Licencia de Pareo", MsgBoxStyle.Exclamation, "Atención")
        End If
    End Sub

    Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click
        LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa, "IdAplicacion", TxtIdAplicacion.Text.Trim)
        LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa, "Secreto", TxtSecreto.Text.Trim)

    End Sub

    Function Carga_Valores()

        TxtIdAplicacion.Text = LtCs.IdAplicacion
        TxtSecreto.Text = LtCs.Secreto
        TxtIdOpLogin.Text = LtCs.IdOpLogin
        TxtBloqFolder.Text = LtCs.IdBloqFolder
        TxtBloqUSB.Text = LtCs.IdbloqUSB
        TxtBloqProg.Text = LtCs.IdBloqProg



        Me.PanelRegistro.Visible = True
        Me.PanelConfigurar.Visible = False

        If LtCs.IdOpLogin <> "" Then
            'la aplicacion ya esta pareada
            BtParear.Enabled = False
            BtUnpair.Enabled = True
            Me.PanelRegistro.Visible = False
            Me.PanelConfigurar.Visible = True
            'cargamos la lista de apliaciones para bloqueo
            Cargar_Bloqueos()
            Try
                Dim ServiciosPc As ServiceController = New ServiceController("LtCsSecureSrv")
                If ServiciosPc.DisplayName = "LtCsSecureSrv" Then
                    'no existe servicio
                    BtActivar.Text = "Desactivar"
                End If
            Catch ex As Exception

            End Try
        End If

    End Function

    Function Cargar_Bloqueos()
        Me.ListBoxFolder.Items.Clear()
        Me.ListBoxProgram.Items.Clear()
        'Carpetas bloqueadas
        Dim Contador As Integer = 1
        Try
            Do While Contador <> 99 ' limite de carpetas a bloquear
                Me.ListBoxFolder.Items.Add(LtCs.registro.CargarValor(LtCs.Variables_Globales.Reg_programa & "Folder", "Carpeta" & Contador, "S"))
                Contador += 1
            Loop

        Catch ex As Exception
            Contador = 99
        End Try
        'Programas bloqueados
        Contador = 1
        Try
            Do While Contador <> 99 ' limite de carpetas a bloquear
                Me.ListBoxProgram.Items.Add(LtCs.registro.CargarValor(LtCs.Variables_Globales.Reg_programa & "Program", "Prog" & Contador, "S"))
                Contador += 1
            Loop

        Catch ex As Exception
            Contador = 99

        End Try

        'cargamos si esta activado el modulo de bloqueo de carpetas
        ChkFolderBloq.Checked = LtCs.ModFolderBloq
        '        'Cargamos si esta activado bloqueo de escritura a USB
        ChkProgBloq.Checked = LtCs.ModProgBloq
        '     'Cargamos si esta activado bloqueo de Programas
        ChkUsbPort.Checked = LtCs.ModUSBPortBloq

    End Function

    Sub BtFolderAdd_Click(sender As Object, e As EventArgs) Handles BtFolderAdd.Click

        Try
            With FolderBrowser
                .Reset()
                .Description = "Seleccione una Carpeta a bloquear"
                .SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
                .ShowNewFolderButton = False
                .RootFolder = Environment.SpecialFolder.Desktop
                Dim Respuesta As DialogResult = .ShowDialog
                If Respuesta = Windows.Forms.DialogResult.OK Then
                    Me.ListBoxFolder.Items.Add(.SelectedPath)
                    LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa & "Folder", "Carpeta" & Me.ListBoxFolder.Items.Count, .SelectedPath)
                End If
                .Dispose()
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Sub BtFolderDel_Click(sender As Object, e As EventArgs) Handles BtFolderDel.Click
        Try
            If Me.ListBoxFolder.SelectedIndex <> -1 Then
                LtCs.registro.EliminarValor(LtCs.Variables_Globales.Reg_programa & "Folder", "Carpeta" & Me.ListBoxFolder.SelectedIndex + 1)
                Me.ListBoxFolder.Items.Remove(Me.ListBoxFolder.SelectedItem)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Sub BtRegistro_Click(sender As Object, e As EventArgs) Handles BtRegistro.Click
        LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa, "IdBloqFolder", TxtBloqFolder.Text.Trim)
        LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa, "IdBloqUSB", TxtBloqUSB.Text.Trim)
        LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa, "IdBloqProg", TxtBloqProg.Text.Trim)
    End Sub

    Sub BtProgramAdd_Click(sender As Object, e As EventArgs) Handles BtProgramAdd.Click
        Try
            With FileBrowser
                .Reset()
                .Title = "Seleccione un Fichero a bloquear"
                .DefaultExt = "*.exe"
                .Filter = "Ejecutables|*.exe"
                .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                .RestoreDirectory = True
                Dim Respuesta As DialogResult = .ShowDialog
                If Respuesta = Windows.Forms.DialogResult.OK Then
                    Me.ListBoxProgram.Items.Add(.SafeFileName)
                    LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa & "\\Program", "Prog" & Me.ListBoxProgram.Items.Count, .SafeFileName)
                End If
                .Dispose()
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Sub BtProgramDel_Click(sender As Object, e As EventArgs) Handles BtProgramDel.Click
        Try
            If Me.ListBoxProgram.SelectedIndex <> -1 Then
                LtCs.registro.EliminarValor(LtCs.Variables_Globales.Reg_programa & "Program", "Prog" & Me.ListBoxProgram.SelectedIndex + 1)
                Me.ListBoxProgram.Items.Remove(Me.ListBoxProgram.SelectedItem)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub ChkFolderBloq_Click(sender As Object, e As EventArgs) Handles ChkFolderBloq.Click
        If ChkFolderBloq.Checked = True Then
            LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa & "Modulos", "FolderBloq", ChkFolderBloq.Checked)
            LtCs.ModFolderBloq = ChkFolderBloq.Checked
            BloqueaCarpetas()
        Else
            'comprobamos y si valida desbloqueamos
            If Comprueba_remoto(LtCs.IdBloqFolder) = True Then
                ChkFolderBloq.Checked = False
                LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa & "Modulos", "FolderBloq", ChkFolderBloq.Checked)
                LtCs.ModFolderBloq = ChkFolderBloq.Checked
                BloqueaCarpetas()
            Else
                ChkFolderBloq.Checked = True
            End If
        End If


    End Sub

    Private Sub ChkProgBloq_Click(sender As Object, e As EventArgs) Handles ChkProgBloq.Click
        If ChkProgBloq.Checked = True Then
            LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa & "Modulos", "ProgBloq", ChkProgBloq.Checked)
            LtCs.ModProgBloq = ChkProgBloq.Checked
        Else
            'comprobamos y si valida desbloqueamod
            If Comprueba_remoto(LtCs.IdBloqProg) = True Then
                ChkProgBloq.Checked = False
                LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa & "Modulos", "ProgBloq", ChkProgBloq.Checked)
                LtCs.ModProgBloq = ChkProgBloq.Checked
            Else
                ChkProgBloq.Checked = True
            End If
        End If

    End Sub

    Private Sub ChkUsbPort_Click(sender As Object, e As EventArgs) Handles ChkUsbPort.Click
        If ChkUsbPort.Checked = True Then
            LtCs.registro.GuardarValor(LtCs.Variables_Globales.Reg_programa & "Modulos", "UsbPort", ChkProgBloq.Checked)
            LtCs.ModUSBPortBloq = ChkUsbPort.Checked
            BloquearUSB()
        Else
            If Comprueba_remoto(LtCs.IdbloqUSB) = True Then
                ChkUsbPort.Checked = False
                LtCs.ModUSBPortBloq = ChkUsbPort.Checked
                BloquearUSB()
            Else
                ChkUsbPort.Checked = True
            End If
        End If

    End Sub


    Function Comprueba_remoto(Operacion As String)
        Dim Respuesta As LatchSDK.LatchResponse

        If Operacion = "" Then
            Respuesta = LtCs.Procesos.Status(LtCs.IdOpLogin)
        Else
            Respuesta = LtCs.Procesos.OperationStatus(LtCs.IdOpLogin, Operacion.Trim) 'para todo sin operacion dependiente
        End If
        If Respuesta.Data IsNot Nothing AndAlso Respuesta.Data.ContainsKey("operations") Then
            Dim DictionaryOper As Dictionary(Of String, Object) = Respuesta.Data("operations")
            If DictionaryOper.ContainsKey(Operacion.Trim) Then
                Dim DictionaryStatus As Dictionary(Of String, Object) = DictionaryOper(Operacion.Trim)
                If DictionaryStatus.ContainsKey("status") Then
                    If DictionaryStatus("status") = "on" Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End If
        End If
        Return False

    End Function

    Private Sub BtRegistrar_Click(sender As Object, e As EventArgs) Handles BtRegistrar.Click
        Me.PanelRegistro.Visible = True
        Me.PanelConfigurar.Visible = False
    End Sub

    Private Sub BtConfigurar_Click(sender As Object, e As EventArgs) Handles BtConfigurar.Click
        Carga_Valores()
        Me.PanelRegistro.Visible = False
        Me.PanelConfigurar.Visible = True
    End Sub

    Function BloqueaCarpetas()
        Dim CatalogoIni, CatalogoFin As String
        If LtCs.ModFolderBloq Then
            CatalogoIni = ""
            CatalogoFin = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        Else
            CatalogoIni = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
            CatalogoFin = ""
        End If
        Dim Contador As Integer = 1
        Try
            Do While Contador <> 99 ' limite de carpetas a bloquear
                Dim Carpeta As String = LtCs.registro.CargarValor(LtCs.Variables_Globales.Reg_programa & "Folder", "Carpeta" & Contador, "S")
                Rename(Carpeta.Trim & CatalogoIni.Trim, Carpeta.Trim & CatalogoFin.Trim)
                Contador += 1
            Loop

        Catch ex As Exception
            Contador = 99

        End Try

    End Function

    Function BloquearUSB()
        LtCs.registro.GuardarValor("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies\\", "WriteProtect", LtCs.ModUSBPortBloq)
    End Function

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Me.Close()
    End Sub

    Private Sub BtActivar_Click(sender As Object, e As EventArgs) Handles BtActivar.Click
        If BtActivar.Text = "Activar" Then

            Shell("installutil LtCsSecureSrv.exe", AppWinStyle.Hide, True)
            Shell("net start LtcsSecureSrv", AppWinStyle.Hide, True)
            BtActivar.Text = "Desactivar"
        Else
            Shell("net stop LtcsSecureSrv", AppWinStyle.Hide, True)
            Shell("installutil /u LtCsSecureSrv.exe", AppWinStyle.Hide, True)
            BtActivar.Text = "Activar"
        End If
    End Sub

    Private Sub ChkUsbPort_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUsbPort.CheckedChanged

    End Sub

    Private Sub BtAyuda_Click(sender As Object, e As EventArgs) Handles BtAyuda.Click
        Acercade.ShowDialog()
    End Sub

    Private Sub ChkFolderBloq_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFolderBloq.CheckedChanged

    End Sub
End Class
