#ExternalChecksum("T:\CODE\SMT\Solutions\ALENTEJO\Alentejo_SLA\App_Code\Pages\ucUSER_Billing.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","9029843EF4691DA8293EA9AA18175448")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3053
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class ucUSER_Billing
    Inherits System.Windows.Controls.UserControl
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Canvas
    
    Friend WithEvents tbCurrentBalance As System.Windows.Controls.TextBlock
    
    Friend WithEvents cbCurrency As System.Windows.Controls.ComboBox
    
    Friend WithEvents txtCreditToAdd As System.Windows.Controls.TextBox
    
    Friend WithEvents btnGoToPayPal As System.Windows.Controls.Button
    
    Friend WithEvents lbAccountTransactions As System.Windows.Controls.ListBox
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        System.Windows.Application.LoadComponent(Me, New System.Uri("/SMT.Alentejo_SLA;component/App_Code/Pages/ucUSER_Billing.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Canvas)
        Me.tbCurrentBalance = CType(Me.FindName("tbCurrentBalance"),System.Windows.Controls.TextBlock)
        Me.cbCurrency = CType(Me.FindName("cbCurrency"),System.Windows.Controls.ComboBox)
        Me.txtCreditToAdd = CType(Me.FindName("txtCreditToAdd"),System.Windows.Controls.TextBox)
        Me.btnGoToPayPal = CType(Me.FindName("btnGoToPayPal"),System.Windows.Controls.Button)
        Me.lbAccountTransactions = CType(Me.FindName("lbAccountTransactions"),System.Windows.Controls.ListBox)
    End Sub
End Class