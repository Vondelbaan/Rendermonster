﻿#ExternalChecksum("..\..\..\..\src\Forms\JobViewer.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","C87CE77AB82DB31FA3207BAC834C6EA0")
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

Imports SMT.Alentejo.SystemDashboard
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Forms.Integration
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes


'''<summary>
'''JobViewer
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class JobViewer
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\..\src\Forms\JobViewer.xaml",7)
    Friend WithEvents TabControl1 As System.Windows.Controls.TabControl
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\src\Forms\JobViewer.xaml",8)
    Friend WithEvents tpOverview As System.Windows.Controls.TabItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\src\Forms\JobViewer.xaml",10)
    Friend WithEvents tpViewer As System.Windows.Controls.TabItem
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\src\Forms\JobViewer.xaml",11)
    Friend WithEvents jobViewer As SMT.Alentejo.SystemDashboard.ucJobViewer
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/SMT.Alentejo.SystemDashboard;component/src/forms/jobviewer.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\..\src\Forms\JobViewer.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.TabControl1 = CType(target,System.Windows.Controls.TabControl)
            Return
        End If
        If (connectionId = 2) Then
            Me.tpOverview = CType(target,System.Windows.Controls.TabItem)
            Return
        End If
        If (connectionId = 3) Then
            Me.tpViewer = CType(target,System.Windows.Controls.TabItem)
            Return
        End If
        If (connectionId = 4) Then
            Me.jobViewer = CType(target,SMT.Alentejo.SystemDashboard.ucJobViewer)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class