#ExternalChecksum("T:\CODE\SMT\Solutions\ALENTEJO\Alentejo_SLA\App_Code\Pages\Job Browsing Controls\ucJobBrowser.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","C0F8AE253EB011CC19FBDC875DDCF100")
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

Imports SMT.Alentejo_SLA
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
Partial Public Class ucJobBrowser
    Inherits System.Windows.Controls.UserControl
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Canvas
    
    Friend WithEvents lblHeader As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblDateFilter As System.Windows.Controls.TextBlock
    
    Friend WithEvents cbDateRange As System.Windows.Controls.ComboBox
    
    Friend WithEvents lblStatusFilter As System.Windows.Controls.TextBlock
    
    Friend WithEvents cbStatusFilter As System.Windows.Controls.ComboBox
    
    Friend WithEvents txtUserFilter As System.Windows.Controls.TextBox
    
    Friend WithEvents btnUpdateTable As System.Windows.Controls.Button
    
    Friend WithEvents svJobs As System.Windows.Controls.ScrollViewer
    
    Friend WithEvents spJobs As System.Windows.Controls.StackPanel
    
    Friend WithEvents dzvMain As SMT.Alentejo_SLA.ucDeepZoomViewer
    
    Friend WithEvents cvWaitAnimation As System.Windows.Controls.Canvas
    
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
        System.Windows.Application.LoadComponent(Me, New System.Uri("/SMT.Alentejo_SLA;component/App_Code/Pages/Job%20Browsing%20Controls/ucJobBrowser"& _ 
                    ".xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Canvas)
        Me.lblHeader = CType(Me.FindName("lblHeader"),System.Windows.Controls.TextBlock)
        Me.lblDateFilter = CType(Me.FindName("lblDateFilter"),System.Windows.Controls.TextBlock)
        Me.cbDateRange = CType(Me.FindName("cbDateRange"),System.Windows.Controls.ComboBox)
        Me.lblStatusFilter = CType(Me.FindName("lblStatusFilter"),System.Windows.Controls.TextBlock)
        Me.cbStatusFilter = CType(Me.FindName("cbStatusFilter"),System.Windows.Controls.ComboBox)
        Me.txtUserFilter = CType(Me.FindName("txtUserFilter"),System.Windows.Controls.TextBox)
        Me.btnUpdateTable = CType(Me.FindName("btnUpdateTable"),System.Windows.Controls.Button)
        Me.svJobs = CType(Me.FindName("svJobs"),System.Windows.Controls.ScrollViewer)
        Me.spJobs = CType(Me.FindName("spJobs"),System.Windows.Controls.StackPanel)
        Me.dzvMain = CType(Me.FindName("dzvMain"),SMT.Alentejo_SLA.ucDeepZoomViewer)
        Me.cvWaitAnimation = CType(Me.FindName("cvWaitAnimation"),System.Windows.Controls.Canvas)
    End Sub
End Class
