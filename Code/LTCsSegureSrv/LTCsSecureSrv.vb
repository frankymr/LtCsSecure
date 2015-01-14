Imports System
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Security.Permissions
Imports System.Collections.Generic
Imports System.Linq

Public Class LTCsSecureSrv

    Public ObjetoWMI As Object
    Public ProgramasWMI As Object
    Public SrvTimer As New System.Timers.Timer


    Protected Overrides Sub OnStart(ByVal args() As String)

        EventLog1.WriteEntry("LtCsSecure OnStart")
        SrvTimer.Interval = 20000 ' 10 seconds
        AddHandler SrvTimer.Elapsed, AddressOf Me.OnTimer
        SrvTimer.Enabled = True
        SrvTimer.Start()
        Inicializar()
    End Sub

    Protected Overrides Sub OnStop()
        EventLog1.WriteEntry("LtCsSecure OnStop.", EventLogEntryType.Information)
    End Sub

    Public Sub New()
        MyBase.New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        If Not System.Diagnostics.EventLog.SourceExists("LtCsSecureLog") Then
            System.Diagnostics.EventLog.CreateEventSource("LtCsSecureLog",
            "Registro")
        End If
        EventLog1.Source = "LtCsSecureLog"
        EventLog1.Log = "Registro"

    End Sub

    Private Sub OnTimer(sender As Object, e As Timers.ElapsedEventArgs)
        EventLog1.WriteEntry("LtCsSecure Monitor", EventLogEntryType.Information)
        Try
            ' Se deshabilita temporalmente el timer
            SrvTimer.Enabled = False
            Inicializar()
        Catch ex As Exception
        Finally
            SrvTimer.Interval = 20000
            SrvTimer.Enabled = True
        End Try

    End Sub

    Public Function Inicializar() As Boolean

        EventLog1.WriteEntry("LtCsSecure Inicializar", EventLogEntryType.Information)

        'comprobamos el modulo de control de carpetas seguras
        Inicializa_FolderBloq()

        'comprobamos el modulo de control de escritura sobre USB
        Inicializa_USBBloq()

        'comprobamos el modulo de control de bloqueo de programas
        Inicializa_ProgBloq()

    End Function
    Public Function Inicializa_ProgBloq()

        If LtCs.ModProgBloq = False Then Exit Function

        'cargamos lista
        Dim Contador As Integer = 1
        'Dim Listado As Collection
        Dim Listado As New Collection
        Try
            Do While Contador <> 99 ' limite de carpetas a bloquear
                Dim Valor As String = LtCs.registro.CargarValor(LtCs.Variables_Globales.Reg_programa & "Program", "Prog" & Contador, "S")
                If Valor = Nothing Then
                    Contador = 99
                    Exit Do
                Else
                    Listado.Add(Valor)
                End If
                Contador += 1
            Loop

        Catch ex As Exception
            Contador = 99
        End Try


        Try
            ObjetoWMI = GetObject("winmgmts:")
            If (ObjetoWMI) IsNot Nothing Then
                ProgramasWMI = ObjetoWMI.InstancesOf("win32_process")
                For Each Prog In Listado
                    For Each Aplicativo In ProgramasWMI
                        If UCase(Aplicativo.name) = UCase(Prog.ToString) Then
                            Aplicativo.terminate(0)
                        End If
                    Next
                Next
            End If
        Catch ex As Exception
            'saltamos
        End Try


    End Function

    Public Function Inicializa_USBBloq()
        'bloqueo de puertos usb para escritura
        LtCs.registro.GuardarValor("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies\\", "WriteProtect", LtCs.ModUSBPortBloq)

    End Function

    Public Function Inicializa_FolderBloq()

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
    Function Comprueba_Remoto()


    End Function
End Class
