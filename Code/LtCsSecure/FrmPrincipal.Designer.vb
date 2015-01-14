<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtGuardar = New System.Windows.Forms.Button()
        Me.TxtIdOpLogin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSecreto = New System.Windows.Forms.TextBox()
        Me.TxtIdAplicacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtUnpair = New System.Windows.Forms.Button()
        Me.BtParear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPareo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelOper = New System.Windows.Forms.Panel()
        Me.TxtBloqProg = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtBloqUSB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtRegistro = New System.Windows.Forms.Button()
        Me.TxtBloqFolder = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtProgramDel = New System.Windows.Forms.Button()
        Me.BtProgramAdd = New System.Windows.Forms.Button()
        Me.ListBoxProgram = New System.Windows.Forms.ListBox()
        Me.ChkProgBloq = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChkFolderBloq = New System.Windows.Forms.CheckBox()
        Me.ChkUsbPort = New System.Windows.Forms.CheckBox()
        Me.BtFolderDel = New System.Windows.Forms.Button()
        Me.BtFolderAdd = New System.Windows.Forms.Button()
        Me.ListBoxFolder = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.ChkActivar = New System.Windows.Forms.CheckBox()
        Me.FileBrowser = New System.Windows.Forms.OpenFileDialog()
        Me.PanelRegistro = New System.Windows.Forms.Panel()
        Me.BtRegistrar = New System.Windows.Forms.Button()
        Me.BtConfigurar = New System.Windows.Forms.Button()
        Me.PanelConfigurar = New System.Windows.Forms.Panel()
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.BtAyuda = New System.Windows.Forms.Button()
        Me.BtActivar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelOper.SuspendLayout()
        Me.PanelRegistro.SuspendLayout()
        Me.PanelConfigurar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtGuardar)
        Me.Panel1.Controls.Add(Me.TxtIdOpLogin)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtSecreto)
        Me.Panel1.Controls.Add(Me.TxtIdAplicacion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(10, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 141)
        Me.Panel1.TabIndex = 0
        '
        'BtGuardar
        '
        Me.BtGuardar.Location = New System.Drawing.Point(283, 109)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(85, 24)
        Me.BtGuardar.TabIndex = 10
        Me.BtGuardar.Text = "Guardar"
        Me.BtGuardar.UseVisualStyleBackColor = True
        '
        'TxtIdOpLogin
        '
        Me.TxtIdOpLogin.Enabled = False
        Me.TxtIdOpLogin.Location = New System.Drawing.Point(86, 83)
        Me.TxtIdOpLogin.Name = "TxtIdOpLogin"
        Me.TxtIdOpLogin.Size = New System.Drawing.Size(282, 20)
        Me.TxtIdOpLogin.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Id.Op.Login:"
        '
        'TxtSecreto
        '
        Me.TxtSecreto.Location = New System.Drawing.Point(86, 56)
        Me.TxtSecreto.Name = "TxtSecreto"
        Me.TxtSecreto.Size = New System.Drawing.Size(282, 20)
        Me.TxtSecreto.TabIndex = 7
        '
        'TxtIdAplicacion
        '
        Me.TxtIdAplicacion.Location = New System.Drawing.Point(86, 27)
        Me.TxtIdAplicacion.Name = "TxtIdAplicacion"
        Me.TxtIdAplicacion.Size = New System.Drawing.Size(282, 20)
        Me.TxtIdAplicacion.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Secreto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Id. Aplicación:"
        '
        'BtUnpair
        '
        Me.BtUnpair.Enabled = False
        Me.BtUnpair.Location = New System.Drawing.Point(287, 16)
        Me.BtUnpair.Name = "BtUnpair"
        Me.BtUnpair.Size = New System.Drawing.Size(75, 23)
        Me.BtUnpair.TabIndex = 3
        Me.BtUnpair.Text = "Desparear"
        Me.BtUnpair.UseVisualStyleBackColor = True
        '
        'BtParear
        '
        Me.BtParear.Location = New System.Drawing.Point(206, 16)
        Me.BtParear.Name = "BtParear"
        Me.BtParear.Size = New System.Drawing.Size(75, 23)
        Me.BtParear.TabIndex = 2
        Me.BtParear.Text = "Parear"
        Me.BtParear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Parear:"
        '
        'TxtPareo
        '
        Me.TxtPareo.Location = New System.Drawing.Point(100, 16)
        Me.TxtPareo.Name = "TxtPareo"
        Me.TxtPareo.Size = New System.Drawing.Size(100, 20)
        Me.TxtPareo.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtUnpair)
        Me.Panel2.Controls.Add(Me.TxtPareo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BtParear)
        Me.Panel2.Location = New System.Drawing.Point(13, 172)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 52)
        Me.Panel2.TabIndex = 1
        '
        'PanelOper
        '
        Me.PanelOper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOper.Controls.Add(Me.TxtBloqProg)
        Me.PanelOper.Controls.Add(Me.Label10)
        Me.PanelOper.Controls.Add(Me.TxtBloqUSB)
        Me.PanelOper.Controls.Add(Me.Label8)
        Me.PanelOper.Controls.Add(Me.BtRegistro)
        Me.PanelOper.Controls.Add(Me.TxtBloqFolder)
        Me.PanelOper.Controls.Add(Me.Label7)
        Me.PanelOper.Controls.Add(Me.Label6)
        Me.PanelOper.Location = New System.Drawing.Point(60, 230)
        Me.PanelOper.Name = "PanelOper"
        Me.PanelOper.Size = New System.Drawing.Size(291, 167)
        Me.PanelOper.TabIndex = 2
        '
        'TxtBloqProg
        '
        Me.TxtBloqProg.Location = New System.Drawing.Point(135, 96)
        Me.TxtBloqProg.Name = "TxtBloqProg"
        Me.TxtBloqProg.Size = New System.Drawing.Size(139, 20)
        Me.TxtBloqProg.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Id.Bloqueo Programas:"
        '
        'TxtBloqUSB
        '
        Me.TxtBloqUSB.Location = New System.Drawing.Point(135, 70)
        Me.TxtBloqUSB.Name = "TxtBloqUSB"
        Me.TxtBloqUSB.Size = New System.Drawing.Size(139, 20)
        Me.TxtBloqUSB.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Id.Bloqueo USB:"
        '
        'BtRegistro
        '
        Me.BtRegistro.Location = New System.Drawing.Point(23, 129)
        Me.BtRegistro.Name = "BtRegistro"
        Me.BtRegistro.Size = New System.Drawing.Size(251, 24)
        Me.BtRegistro.TabIndex = 11
        Me.BtRegistro.Text = "Registrar"
        Me.BtRegistro.UseVisualStyleBackColor = True
        '
        'TxtBloqFolder
        '
        Me.TxtBloqFolder.Location = New System.Drawing.Point(135, 44)
        Me.TxtBloqFolder.Name = "TxtBloqFolder"
        Me.TxtBloqFolder.Size = New System.Drawing.Size(139, 20)
        Me.TxtBloqFolder.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Id.Bloqueo Carpetas: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Panel De Operaciones"
        '
        'BtProgramDel
        '
        Me.BtProgramDel.Location = New System.Drawing.Point(99, 325)
        Me.BtProgramDel.Name = "BtProgramDel"
        Me.BtProgramDel.Size = New System.Drawing.Size(75, 23)
        Me.BtProgramDel.TabIndex = 11
        Me.BtProgramDel.Text = "Eliminar"
        Me.BtProgramDel.UseVisualStyleBackColor = True
        '
        'BtProgramAdd
        '
        Me.BtProgramAdd.Location = New System.Drawing.Point(18, 325)
        Me.BtProgramAdd.Name = "BtProgramAdd"
        Me.BtProgramAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtProgramAdd.TabIndex = 10
        Me.BtProgramAdd.Text = "Añadir"
        Me.BtProgramAdd.UseVisualStyleBackColor = True
        '
        'ListBoxProgram
        '
        Me.ListBoxProgram.FormattingEnabled = True
        Me.ListBoxProgram.Location = New System.Drawing.Point(18, 211)
        Me.ListBoxProgram.Name = "ListBoxProgram"
        Me.ListBoxProgram.Size = New System.Drawing.Size(361, 108)
        Me.ListBoxProgram.TabIndex = 9
        '
        'ChkProgBloq
        '
        Me.ChkProgBloq.AutoSize = True
        Me.ChkProgBloq.Location = New System.Drawing.Point(128, 188)
        Me.ChkProgBloq.Name = "ChkProgBloq"
        Me.ChkProgBloq.Size = New System.Drawing.Size(59, 17)
        Me.ChkProgBloq.TabIndex = 8
        Me.ChkProgBloq.Text = "Activar"
        Me.ChkProgBloq.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Programas a Bloquear:"
        '
        'ChkFolderBloq
        '
        Me.ChkFolderBloq.AutoSize = True
        Me.ChkFolderBloq.Location = New System.Drawing.Point(120, 14)
        Me.ChkFolderBloq.Name = "ChkFolderBloq"
        Me.ChkFolderBloq.Size = New System.Drawing.Size(59, 17)
        Me.ChkFolderBloq.TabIndex = 6
        Me.ChkFolderBloq.Text = "Activar"
        Me.ChkFolderBloq.UseVisualStyleBackColor = True
        '
        'ChkUsbPort
        '
        Me.ChkUsbPort.AutoSize = True
        Me.ChkUsbPort.Location = New System.Drawing.Point(14, 379)
        Me.ChkUsbPort.Name = "ChkUsbPort"
        Me.ChkUsbPort.Size = New System.Drawing.Size(236, 17)
        Me.ChkUsbPort.TabIndex = 5
        Me.ChkUsbPort.Text = "Bloquear Puertos USB (Acceso de Escritura)"
        Me.ChkUsbPort.UseVisualStyleBackColor = True
        '
        'BtFolderDel
        '
        Me.BtFolderDel.Location = New System.Drawing.Point(99, 147)
        Me.BtFolderDel.Name = "BtFolderDel"
        Me.BtFolderDel.Size = New System.Drawing.Size(75, 23)
        Me.BtFolderDel.TabIndex = 3
        Me.BtFolderDel.Text = "Eliminar"
        Me.BtFolderDel.UseVisualStyleBackColor = True
        '
        'BtFolderAdd
        '
        Me.BtFolderAdd.Location = New System.Drawing.Point(18, 147)
        Me.BtFolderAdd.Name = "BtFolderAdd"
        Me.BtFolderAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtFolderAdd.TabIndex = 2
        Me.BtFolderAdd.Text = "Añadir"
        Me.BtFolderAdd.UseVisualStyleBackColor = True
        '
        'ListBoxFolder
        '
        Me.ListBoxFolder.FormattingEnabled = True
        Me.ListBoxFolder.Location = New System.Drawing.Point(18, 33)
        Me.ListBoxFolder.Name = "ListBoxFolder"
        Me.ListBoxFolder.Size = New System.Drawing.Size(361, 108)
        Me.ListBoxFolder.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Carpetas a Bloquear:"
        '
        'ChkActivar
        '
        Me.ChkActivar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkActivar.Appearance = System.Windows.Forms.Appearance.Button
        Me.ChkActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkActivar.ForeColor = System.Drawing.Color.Black
        Me.ChkActivar.Location = New System.Drawing.Point(12, 496)
        Me.ChkActivar.Name = "ChkActivar"
        Me.ChkActivar.Size = New System.Drawing.Size(8, 25)
        Me.ChkActivar.TabIndex = 3
        Me.ChkActivar.Text = "Activar Servicios"
        Me.ChkActivar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkActivar.UseVisualStyleBackColor = True
        '
        'PanelRegistro
        '
        Me.PanelRegistro.Controls.Add(Me.PanelOper)
        Me.PanelRegistro.Controls.Add(Me.Panel1)
        Me.PanelRegistro.Controls.Add(Me.Panel2)
        Me.PanelRegistro.Location = New System.Drawing.Point(17, 26)
        Me.PanelRegistro.Name = "PanelRegistro"
        Me.PanelRegistro.Size = New System.Drawing.Size(393, 404)
        Me.PanelRegistro.TabIndex = 4
        '
        'BtRegistrar
        '
        Me.BtRegistrar.Location = New System.Drawing.Point(15, 447)
        Me.BtRegistrar.Name = "BtRegistrar"
        Me.BtRegistrar.Size = New System.Drawing.Size(95, 42)
        Me.BtRegistrar.TabIndex = 5
        Me.BtRegistrar.Text = "Registro"
        Me.BtRegistrar.UseVisualStyleBackColor = True
        '
        'BtConfigurar
        '
        Me.BtConfigurar.Location = New System.Drawing.Point(116, 447)
        Me.BtConfigurar.Name = "BtConfigurar"
        Me.BtConfigurar.Size = New System.Drawing.Size(95, 42)
        Me.BtConfigurar.TabIndex = 6
        Me.BtConfigurar.Text = "Configurar"
        Me.BtConfigurar.UseVisualStyleBackColor = True
        '
        'PanelConfigurar
        '
        Me.PanelConfigurar.Controls.Add(Me.ChkFolderBloq)
        Me.PanelConfigurar.Controls.Add(Me.Label5)
        Me.PanelConfigurar.Controls.Add(Me.ListBoxFolder)
        Me.PanelConfigurar.Controls.Add(Me.BtProgramDel)
        Me.PanelConfigurar.Controls.Add(Me.BtFolderDel)
        Me.PanelConfigurar.Controls.Add(Me.BtProgramAdd)
        Me.PanelConfigurar.Controls.Add(Me.BtFolderAdd)
        Me.PanelConfigurar.Controls.Add(Me.ListBoxProgram)
        Me.PanelConfigurar.Controls.Add(Me.ChkUsbPort)
        Me.PanelConfigurar.Controls.Add(Me.ChkProgBloq)
        Me.PanelConfigurar.Controls.Add(Me.Label9)
        Me.PanelConfigurar.Location = New System.Drawing.Point(17, 26)
        Me.PanelConfigurar.Name = "PanelConfigurar"
        Me.PanelConfigurar.Size = New System.Drawing.Size(393, 403)
        Me.PanelConfigurar.TabIndex = 7
        '
        'BtSalir
        '
        Me.BtSalir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSalir.BackColor = System.Drawing.Color.Transparent
        Me.BtSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtSalir.Image = Global.LtCsSecure.My.Resources.Resources.salir2
        Me.BtSalir.Location = New System.Drawing.Point(368, 447)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(48, 42)
        Me.BtSalir.TabIndex = 13
        Me.BtSalir.UseVisualStyleBackColor = False
        '
        'BtAyuda
        '
        Me.BtAyuda.BackColor = System.Drawing.Color.Transparent
        Me.BtAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtAyuda.Image = Global.LtCsSecure.My.Resources.Resources.icono_ayuda
        Me.BtAyuda.Location = New System.Drawing.Point(315, 447)
        Me.BtAyuda.Name = "BtAyuda"
        Me.BtAyuda.Size = New System.Drawing.Size(40, 42)
        Me.BtAyuda.TabIndex = 12
        Me.BtAyuda.UseVisualStyleBackColor = False
        '
        'BtActivar
        '
        Me.BtActivar.Location = New System.Drawing.Point(213, 447)
        Me.BtActivar.Name = "BtActivar"
        Me.BtActivar.Size = New System.Drawing.Size(95, 42)
        Me.BtActivar.TabIndex = 14
        Me.BtActivar.Text = "Activar"
        Me.BtActivar.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(427, 491)
        Me.Controls.Add(Me.BtActivar)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtAyuda)
        Me.Controls.Add(Me.PanelConfigurar)
        Me.Controls.Add(Me.BtConfigurar)
        Me.Controls.Add(Me.BtRegistrar)
        Me.Controls.Add(Me.PanelRegistro)
        Me.Controls.Add(Me.ChkActivar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de Control Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelOper.ResumeLayout(False)
        Me.PanelOper.PerformLayout()
        Me.PanelRegistro.ResumeLayout(False)
        Me.PanelConfigurar.ResumeLayout(False)
        Me.PanelConfigurar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtParear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPareo As System.Windows.Forms.TextBox
    Friend WithEvents BtUnpair As System.Windows.Forms.Button
    Friend WithEvents TxtIdOpLogin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtSecreto As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdAplicacion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtFolderDel As System.Windows.Forms.Button
    Friend WithEvents BtFolderAdd As System.Windows.Forms.Button
    Friend WithEvents ListBoxFolder As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PanelOper As System.Windows.Forms.Panel
    Friend WithEvents TxtBloqFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtRegistro As System.Windows.Forms.Button
    Friend WithEvents ChkActivar As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUsbPort As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtBloqUSB As System.Windows.Forms.TextBox
    Friend WithEvents ChkFolderBloq As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ChkProgBloq As System.Windows.Forms.CheckBox
    Friend WithEvents BtProgramDel As System.Windows.Forms.Button
    Friend WithEvents BtProgramAdd As System.Windows.Forms.Button
    Friend WithEvents ListBoxProgram As System.Windows.Forms.ListBox
    Friend WithEvents FileBrowser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TxtBloqProg As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PanelRegistro As System.Windows.Forms.Panel
    Friend WithEvents BtRegistrar As System.Windows.Forms.Button
    Friend WithEvents BtConfigurar As System.Windows.Forms.Button
    Friend WithEvents PanelConfigurar As System.Windows.Forms.Panel
    Friend WithEvents BtAyuda As System.Windows.Forms.Button
    Friend WithEvents BtSalir As System.Windows.Forms.Button
    Friend WithEvents BtActivar As System.Windows.Forms.Button

End Class
