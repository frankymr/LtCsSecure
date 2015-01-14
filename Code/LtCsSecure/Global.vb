Imports LatchSDK

Namespace LtCs
    Public Module Variables_Globales


        'varor de registro a guardar 
        Public registro As New Registro_sistema
        Public Const Reg_programa As String = "SOFTWARE\\Idesys\\LsCsSecure\\"
        Public IdAplicacion As String = registro.CargarValor(Variables_Globales.Reg_programa, "IdAplicacion", "S")
        Public Secreto As String = registro.CargarValor(Variables_Globales.Reg_programa, "Secreto", "S")

        Public IdOpLogin As String = registro.CargarValor(Variables_Globales.Reg_programa, "AccountId", "S")
        Public IdBloqFolder As String = registro.CargarValor(Variables_Globales.Reg_programa, "IdBloqFolder", "S")
        Public IdbloqUSB As String = registro.CargarValor(Variables_Globales.Reg_programa, "IdBloqUSB", "S")
        Public IdBloqProg As String = registro.CargarValor(Variables_Globales.Reg_programa, "IdBloqProg", "S")


        Public ModFolderBloq As Boolean = registro.CargarValor(Variables_Globales.Reg_programa & "Modulos", "FolderBloq", "0")
        Public ModUSBPortBloq As Boolean = registro.CargarValor(Variables_Globales.Reg_programa & "Modulos", "UsbPort", "0")
        Public ModProgBloq As Boolean = registro.CargarValor(Variables_Globales.Reg_programa & "Modulos", "ProgBloq", "0")

        Public Procesos As Latch = New Latch(IdAplicacion.Trim & "", Secreto.Trim & "")





    End Module

End Namespace
