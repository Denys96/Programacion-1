﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCargos
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
        Me.btnCancelarCargo = New System.Windows.Forms.Button()
        Me.btnSeleccionarCargo = New System.Windows.Forms.Button()
        Me.grdBuscarCargo = New System.Windows.Forms.DataGridView()
        Me.lblBuscarCargo = New System.Windows.Forms.Label()
        Me.txtBuscarCargo = New System.Windows.Forms.TextBox()
        Me.idCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscarCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarCargo
        '
        Me.btnCancelarCargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCargo.Location = New System.Drawing.Point(810, 563)
        Me.btnCancelarCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarCargo.Name = "btnCancelarCargo"
        Me.btnCancelarCargo.Size = New System.Drawing.Size(160, 41)
        Me.btnCancelarCargo.TabIndex = 19
        Me.btnCancelarCargo.Text = "Cancelar"
        Me.btnCancelarCargo.UseVisualStyleBackColor = True
        '
        'btnSeleccionarCargo
        '
        Me.btnSeleccionarCargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarCargo.Location = New System.Drawing.Point(460, 563)
        Me.btnSeleccionarCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarCargo.Name = "btnSeleccionarCargo"
        Me.btnSeleccionarCargo.Size = New System.Drawing.Size(315, 41)
        Me.btnSeleccionarCargo.TabIndex = 18
        Me.btnSeleccionarCargo.Text = "Seleccionar Cargo"
        Me.btnSeleccionarCargo.UseVisualStyleBackColor = True
        '
        'grdBuscarCargo
        '
        Me.grdBuscarCargo.AllowUserToAddRows = False
        Me.grdBuscarCargo.AllowUserToDeleteRows = False
        Me.grdBuscarCargo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarCargo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCargo, Me.cargo})
        Me.grdBuscarCargo.Location = New System.Drawing.Point(29, 78)
        Me.grdBuscarCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarCargo.Name = "grdBuscarCargo"
        Me.grdBuscarCargo.ReadOnly = True
        Me.grdBuscarCargo.RowHeadersWidth = 102
        Me.grdBuscarCargo.RowTemplate.Height = 40
        Me.grdBuscarCargo.Size = New System.Drawing.Size(941, 474)
        Me.grdBuscarCargo.TabIndex = 17
        '
        'lblBuscarCargo
        '
        Me.lblBuscarCargo.AutoSize = True
        Me.lblBuscarCargo.Location = New System.Drawing.Point(26, 19)
        Me.lblBuscarCargo.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarCargo.Name = "lblBuscarCargo"
        Me.lblBuscarCargo.Size = New System.Drawing.Size(68, 17)
        Me.lblBuscarCargo.TabIndex = 16
        Me.lblBuscarCargo.Text = "BUSCAR:"
        '
        'txtBuscarCargo
        '
        Me.txtBuscarCargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarCargo.Location = New System.Drawing.Point(99, 16)
        Me.txtBuscarCargo.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarCargo.Name = "txtBuscarCargo"
        Me.txtBuscarCargo.Size = New System.Drawing.Size(871, 22)
        Me.txtBuscarCargo.TabIndex = 15
        '
        'idCargo
        '
        Me.idCargo.DataPropertyName = "idCargo"
        Me.idCargo.HeaderText = "ID"
        Me.idCargo.MinimumWidth = 6
        Me.idCargo.Name = "idCargo"
        Me.idCargo.ReadOnly = True
        Me.idCargo.Visible = False
        Me.idCargo.Width = 125
        '
        'cargo
        '
        Me.cargo.DataPropertyName = "cargo"
        Me.cargo.HeaderText = "CARGO"
        Me.cargo.MinimumWidth = 6
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        Me.cargo.Width = 125
        '
        'frmBuscarCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(997, 621)
        Me.Controls.Add(Me.btnCancelarCargo)
        Me.Controls.Add(Me.btnSeleccionarCargo)
        Me.Controls.Add(Me.grdBuscarCargo)
        Me.Controls.Add(Me.lblBuscarCargo)
        Me.Controls.Add(Me.txtBuscarCargo)
        Me.Name = "frmBuscarCargos"
        Me.Text = "Busqueda de Cargos"
        CType(Me.grdBuscarCargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarCargo As Button
    Friend WithEvents btnSeleccionarCargo As Button
    Friend WithEvents grdBuscarCargo As DataGridView
    Friend WithEvents idCargo As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents lblBuscarCargo As Label
    Friend WithEvents txtBuscarCargo As TextBox
End Class