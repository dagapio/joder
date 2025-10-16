Imports System.Drawing
Imports System.Windows.Forms

Namespace RegistroJugador_VB
    Partial Class FrmRegistroJugador
        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer

        ''' <summary>
        '''  Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        ''' <summary>
        '''  Required method for Designer support - do not modify
        '''  the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.tableLayout = New TableLayoutPanel()
            Me.lblNombre = New Label()
            Me.lblApellido = New Label()
            Me.lblSexo = New Label()
            Me.lblEdad = New Label()
            Me.lblCorreo = New Label()
            Me.lblClave = New Label()
            Me.lblConfirmar = New Label()
            Me.txtNombre = New TextBox()
            Me.txtApellido = New TextBox()
            Me.cboSexo = New ComboBox()
            Me.numEdad = New NumericUpDown()
            Me.txtCorreo = New TextBox()
            Me.txtClave = New TextBox()
            Me.txtConfirmar = New TextBox()
            Me.flowButtons = New FlowLayoutPanel()
            Me.btnRegistrar = New Button()
            Me.btnCancelar = New Button()
            CType(Me.numEdad, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayout.SuspendLayout()
            Me.flowButtons.SuspendLayout()
            Me.SuspendLayout()
            '
            'tableLayout
            '
            Me.tableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            Me.tableLayout.ColumnCount = 2
            Me.tableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.0F))
            Me.tableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65.0F))
            Me.tableLayout.Controls.Add(Me.lblNombre, 0, 0)
            Me.tableLayout.Controls.Add(Me.txtNombre, 1, 0)
            Me.tableLayout.Controls.Add(Me.lblApellido, 0, 1)
            Me.tableLayout.Controls.Add(Me.txtApellido, 1, 1)
            Me.tableLayout.Controls.Add(Me.lblSexo, 0, 2)
            Me.tableLayout.Controls.Add(Me.cboSexo, 1, 2)
            Me.tableLayout.Controls.Add(Me.lblEdad, 0, 3)
            Me.tableLayout.Controls.Add(Me.numEdad, 1, 3)
            Me.tableLayout.Controls.Add(Me.lblCorreo, 0, 4)
            Me.tableLayout.Controls.Add(Me.txtCorreo, 1, 4)
            Me.tableLayout.Controls.Add(Me.lblClave, 0, 5)
            Me.tableLayout.Controls.Add(Me.txtClave, 1, 5)
            Me.tableLayout.Controls.Add(Me.lblConfirmar, 0, 6)
            Me.tableLayout.Controls.Add(Me.txtConfirmar, 1, 6)
            Me.tableLayout.Controls.Add(Me.flowButtons, 0, 7)
            Me.tableLayout.Dock = DockStyle.Fill
            Me.tableLayout.Location = New Point(0, 0)
            Me.tableLayout.Margin = New Padding(0)
            Me.tableLayout.Name = "tableLayout"
            Me.tableLayout.Padding = New Padding(10)
            Me.tableLayout.RowCount = 8
            Me.tableLayout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            Me.tableLayout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            Me.tableLayout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            Me.tableLayout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            Me.tableLayout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            Me.tableLayout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            Me.tableLayout.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            Me.tableLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 60.0F))
            Me.tableLayout.Size = New Size(564, 341)
            Me.tableLayout.TabIndex = 0
            '
            'lblNombre
            '
            Me.lblNombre.Anchor = AnchorStyles.Left
            Me.lblNombre.AutoSize = True
            Me.lblNombre.Location = New Point(3, 10)
            Me.lblNombre.Margin = New Padding(3, 10, 3, 0)
            Me.lblNombre.Name = "lblNombre"
            Me.lblNombre.Size = New Size(60, 17)
            Me.lblNombre.TabIndex = 0
            Me.lblNombre.Text = "Nombre"
            '
            'lblApellido
            '
            Me.lblApellido.Anchor = AnchorStyles.Left
            Me.lblApellido.AutoSize = True
            Me.lblApellido.Location = New Point(3, 59)
            Me.lblApellido.Margin = New Padding(3, 10, 3, 0)
            Me.lblApellido.Name = "lblApellido"
            Me.lblApellido.Size = New Size(59, 17)
            Me.lblApellido.TabIndex = 2
            Me.lblApellido.Text = "Apellido"
            '
            'lblSexo
            '
            Me.lblSexo.Anchor = AnchorStyles.Left
            Me.lblSexo.AutoSize = True
            Me.lblSexo.Location = New Point(3, 108)
            Me.lblSexo.Margin = New Padding(3, 10, 3, 0)
            Me.lblSexo.Name = "lblSexo"
            Me.lblSexo.Size = New Size(37, 17)
            Me.lblSexo.TabIndex = 4
            Me.lblSexo.Text = "Sexo"
            '
            'lblEdad
            '
            Me.lblEdad.Anchor = AnchorStyles.Left
            Me.lblEdad.AutoSize = True
            Me.lblEdad.Location = New Point(3, 157)
            Me.lblEdad.Margin = New Padding(3, 10, 3, 0)
            Me.lblEdad.Name = "lblEdad"
            Me.lblEdad.Size = New Size(38, 17)
            Me.lblEdad.TabIndex = 6
            Me.lblEdad.Text = "Edad"
            '
            'lblCorreo
            '
            Me.lblCorreo.Anchor = AnchorStyles.Left
            Me.lblCorreo.AutoSize = True
            Me.lblCorreo.Location = New Point(3, 206)
            Me.lblCorreo.Margin = New Padding(3, 10, 3, 0)
            Me.lblCorreo.Name = "lblCorreo"
            Me.lblCorreo.Size = New Size(48, 17)
            Me.lblCorreo.TabIndex = 8
            Me.lblCorreo.Text = "Correo"
            '
            'lblClave
            '
            Me.lblClave.Anchor = AnchorStyles.Left
            Me.lblClave.AutoSize = True
            Me.lblClave.Location = New Point(3, 255)
            Me.lblClave.Margin = New Padding(3, 10, 3, 0)
            Me.lblClave.Name = "lblClave"
            Me.lblClave.Size = New Size(42, 17)
            Me.lblClave.TabIndex = 10
            Me.lblClave.Text = "Clave"
            '
            'lblConfirmar
            '
            Me.lblConfirmar.Anchor = AnchorStyles.Left
            Me.lblConfirmar.AutoSize = True
            Me.lblConfirmar.Location = New Point(3, 304)
            Me.lblConfirmar.Margin = New Padding(3, 10, 3, 0)
            Me.lblConfirmar.Name = "lblConfirmar"
            Me.lblConfirmar.Size = New Size(111, 17)
            Me.lblConfirmar.TabIndex = 12
            Me.lblConfirmar.Text = "Confirmar clave"
            '
            'txtNombre
            '
            Me.txtNombre.Dock = DockStyle.Fill
            Me.txtNombre.Location = New Point(199, 7)
            Me.txtNombre.Margin = New Padding(3, 7, 3, 3)
            Me.txtNombre.MaxLength = 100
            Me.txtNombre.Name = "txtNombre"
            Me.txtNombre.Size = New Size(362, 25)
            Me.txtNombre.TabIndex = 1
            '
            'txtApellido
            '
            Me.txtApellido.Dock = DockStyle.Fill
            Me.txtApellido.Location = New Point(199, 56)
            Me.txtApellido.Margin = New Padding(3, 7, 3, 3)
            Me.txtApellido.MaxLength = 100
            Me.txtApellido.Name = "txtApellido"
            Me.txtApellido.Size = New Size(362, 25)
            Me.txtApellido.TabIndex = 3
            '
            'cboSexo
            '
            Me.cboSexo.Dock = DockStyle.Fill
            Me.cboSexo.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cboSexo.FormattingEnabled = True
            Me.cboSexo.Location = New Point(199, 105)
            Me.cboSexo.Margin = New Padding(3, 7, 3, 3)
            Me.cboSexo.Name = "cboSexo"
            Me.cboSexo.Size = New Size(362, 25)
            Me.cboSexo.TabIndex = 5
            '
            'numEdad
            '
            Me.numEdad.Dock = DockStyle.Left
            Me.numEdad.Location = New Point(199, 154)
            Me.numEdad.Margin = New Padding(3, 7, 3, 3)
            Me.numEdad.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
            Me.numEdad.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
            Me.numEdad.Name = "numEdad"
            Me.numEdad.Size = New Size(120, 25)
            Me.numEdad.TabIndex = 7
            '
            'txtCorreo
            '
            Me.txtCorreo.Dock = DockStyle.Fill
            Me.txtCorreo.Location = New Point(199, 203)
            Me.txtCorreo.Margin = New Padding(3, 7, 3, 3)
            Me.txtCorreo.MaxLength = 150
            Me.txtCorreo.Name = "txtCorreo"
            Me.txtCorreo.Size = New Size(362, 25)
            Me.txtCorreo.TabIndex = 9
            '
            'txtClave
            '
            Me.txtClave.Dock = DockStyle.Fill
            Me.txtClave.Location = New Point(199, 252)
            Me.txtClave.Margin = New Padding(3, 7, 3, 3)
            Me.txtClave.MaxLength = 100
            Me.txtClave.Name = "txtClave"
            Me.txtClave.Size = New Size(362, 25)
            Me.txtClave.TabIndex = 11
            Me.txtClave.UseSystemPasswordChar = True
            '
            'txtConfirmar
            '
            Me.txtConfirmar.Dock = DockStyle.Fill
            Me.txtConfirmar.Location = New Point(199, 301)
            Me.txtConfirmar.Margin = New Padding(3, 7, 3, 3)
            Me.txtConfirmar.MaxLength = 100
            Me.txtConfirmar.Name = "txtConfirmar"
            Me.txtConfirmar.Size = New Size(362, 25)
            Me.txtConfirmar.TabIndex = 13
            Me.txtConfirmar.UseSystemPasswordChar = True
            '
            'flowButtons
            '
            Me.tableLayout.SetColumnSpan(Me.flowButtons, 2)
            Me.flowButtons.AutoSize = True
            Me.flowButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink
            Me.flowButtons.Controls.Add(Me.btnRegistrar)
            Me.flowButtons.Controls.Add(Me.btnCancelar)
            Me.flowButtons.Dock = DockStyle.Fill
            Me.flowButtons.FlowDirection = FlowDirection.RightToLeft
            Me.flowButtons.Location = New Point(3, 328)
            Me.flowButtons.Margin = New Padding(3)
            Me.flowButtons.Name = "flowButtons"
            Me.flowButtons.Padding = New Padding(0, 10, 0, 10)
            Me.flowButtons.Size = New Size(558, 55)
            Me.flowButtons.TabIndex = 14
            Me.flowButtons.WrapContents = False
            '
            'btnRegistrar
            '
            Me.btnRegistrar.AutoSize = True
            Me.btnRegistrar.AutoSizeMode = AutoSizeMode.GrowAndShrink
            Me.btnRegistrar.Margin = New Padding(10, 10, 0, 10)
            Me.btnRegistrar.Name = "btnRegistrar"
            Me.btnRegistrar.Padding = New Padding(10, 5, 10, 5)
            Me.btnRegistrar.Size = New Size(87, 35)
            Me.btnRegistrar.TabIndex = 0
            Me.btnRegistrar.Text = "Registrar"
            Me.btnRegistrar.UseVisualStyleBackColor = True
            '
            'btnCancelar
            '
            Me.btnCancelar.AutoSize = True
            Me.btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink
            Me.btnCancelar.DialogResult = DialogResult.Cancel
            Me.btnCancelar.Margin = New Padding(10, 10, 0, 10)
            Me.btnCancelar.Name = "btnCancelar"
            Me.btnCancelar.Padding = New Padding(10, 5, 10, 5)
            Me.btnCancelar.Size = New Size(84, 35)
            Me.btnCancelar.TabIndex = 1
            Me.btnCancelar.Text = "Cancelar"
            Me.btnCancelar.UseVisualStyleBackColor = True
            '
            'FrmRegistroJugador
            '
            Me.AcceptButton = Me.btnRegistrar
            Me.AutoScaleDimensions = New SizeF(7.0F, 17.0F)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnCancelar
            Me.ClientSize = New Size(584, 361)
            Me.Controls.Add(Me.tableLayout)
            Me.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.Margin = New Padding(3, 4, 3, 4)
            Me.MaximizeBox = False
            Me.Name = "FrmRegistroJugador"
            Me.Padding = New Padding(0)
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Registro de Jugador"
            CType(Me.numEdad, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayout.ResumeLayout(False)
            Me.tableLayout.PerformLayout()
            Me.flowButtons.ResumeLayout(False)
            Me.flowButtons.PerformLayout()
            Me.ResumeLayout(False)
        End Sub

        Private tableLayout As TableLayoutPanel
        Private lblNombre As Label
        Private lblApellido As Label
        Private lblSexo As Label
        Private lblEdad As Label
        Private lblCorreo As Label
        Private lblClave As Label
        Private lblConfirmar As Label
        Private txtNombre As TextBox
        Private txtApellido As TextBox
        Private cboSexo As ComboBox
        Private numEdad As NumericUpDown
        Private txtCorreo As TextBox
        Private txtClave As TextBox
        Private txtConfirmar As TextBox
        Private flowButtons As FlowLayoutPanel
        Private btnRegistrar As Button
        Private btnCancelar As Button
    End Class
End Namespace
