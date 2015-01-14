Imports Microsoft.Win32
Imports System
Imports System.Collections.Generic


Public Class Registro_sistema
    'Funcion para controlar el registro de windows
    Function CargarValor(Path As String, Clave As String, Tipo As String)
        'carga los valores del registro del sistema

        Dim ClaveInterna As RegistryKey = Registry.LocalMachine.OpenSubKey(Path)
        If ClaveInterna Is Nothing Then
            If Tipo = "S" Or Tipo = "" Then
                Return ""
            Else
                Return 0
            End If

        Else
            Return ClaveInterna.GetValue(Clave)
        End If

    End Function


    Function GuardarValor(Path As String, Clave As String, Valor As String)
        'Guardamos valor del registro de sistema
        Try
            Registry.LocalMachine.CreateSubKey(Path).SetValue(Clave, Valor)
            Return True
        Catch ex As Exception
            MsgBox("Error guardando Registro", MsgBoxStyle.Critical)
            Return False
        End Try

    End Function

    Function EliminarValor(Path As String, Clave As String)
        'Eliminamos la Clave y valor
        Try
            Dim Borrado = Registry.LocalMachine.OpenSubKey(Path, True)
            Borrado.DeleteValue(Clave) ' Registry.LocalMachine.DeleteValue(Clave)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function
End Class
