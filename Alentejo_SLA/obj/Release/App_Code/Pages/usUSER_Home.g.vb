#ExternalChecksum("T:\CODE\SMT\Solutions\ALENTEJO\Alentejo_SLA\App_Code\Pages\usUSER_Home.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","62BA4C8E92AFBBF081AD28DEC67C3482")
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
Partial Public Class ucUSER_Home
    Inherits System.Windows.Controls.UserControl
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Canvas
    
    Friend WithEvents btnStartJob As System.Windows.Controls.Button
    
    Friend WithEvents btnReviewJobs As System.Windows.Controls.Button
    
    Friend WithEvents hlDownloadFile As System.Windows.Controls.HyperlinkButton
    
    Friend WithEvents lbRecentJobs As System.Windows.Controls.ListBox
    
    Friend WithEvents cvImageWaitAnimation As System.Windows.Controls.Canvas
    
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
        System.Windows.Application.LoadComponent(Me, New System.Uri("/SMT.Alentejo_SLA;component/App_Code/Pages/usUSER_Home.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Canvas)
        Me.btnStartJob = CType(Me.FindName("btnStartJob"),System.Windows.Controls.Button)
        Me.btnReviewJobs = CType(Me.FindName("btnReviewJobs"),System.Windows.Controls.Button)
        Me.hlDownloadFile = CType(Me.FindName("hlDownloadFile"),System.Windows.Controls.HyperlinkButton)
        Me.lbRecentJobs = CType(Me.FindName("lbRecentJobs"),System.Windows.Controls.ListBox)
        Me.cvImageWaitAnimation = CType(Me.FindName("cvImageWaitAnimation"),System.Windows.Controls.Canvas)
    End Sub
End Class
