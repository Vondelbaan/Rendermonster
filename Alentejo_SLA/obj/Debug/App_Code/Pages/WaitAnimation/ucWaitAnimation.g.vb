#ExternalChecksum("T:\CODE\SMT\Solutions\ALENTEJO\Alentejo_SLA\App_Code\Pages\WaitAnimation\ucWaitAnimation.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","64C05639F6CBCF29FE1B4CF6717159D9")
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
Partial Public Class ucWaitAnimation
    Inherits System.Windows.Controls.UserControl
    
    Friend WithEvents RetrievalCircleAnimation As System.Windows.Media.Animation.Storyboard
    
    Friend WithEvents RetrieveStoredLinksMask As System.Windows.Controls.Grid
    
    Friend WithEvents brdWaitAnimationRetrieveStoredLinks As System.Windows.Controls.Border
    
    Friend WithEvents waitAnimationCircle1 As System.Windows.Shapes.Ellipse
    
    Friend WithEvents waitAnimationCircle2 As System.Windows.Shapes.Ellipse
    
    Friend WithEvents waitAnimationCircle3 As System.Windows.Shapes.Ellipse
    
    Friend WithEvents waitAnimationCircle4 As System.Windows.Shapes.Ellipse
    
    Friend WithEvents waitAnimationCircle5 As System.Windows.Shapes.Ellipse
    
    Friend WithEvents waitAnimationCircle6 As System.Windows.Shapes.Ellipse
    
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
        System.Windows.Application.LoadComponent(Me, New System.Uri("/SMT.Alentejo_SLA;component/App_Code/Pages/WaitAnimation/ucWaitAnimation.xaml", System.UriKind.Relative))
        Me.RetrievalCircleAnimation = CType(Me.FindName("RetrievalCircleAnimation"),System.Windows.Media.Animation.Storyboard)
        Me.RetrieveStoredLinksMask = CType(Me.FindName("RetrieveStoredLinksMask"),System.Windows.Controls.Grid)
        Me.brdWaitAnimationRetrieveStoredLinks = CType(Me.FindName("brdWaitAnimationRetrieveStoredLinks"),System.Windows.Controls.Border)
        Me.waitAnimationCircle1 = CType(Me.FindName("waitAnimationCircle1"),System.Windows.Shapes.Ellipse)
        Me.waitAnimationCircle2 = CType(Me.FindName("waitAnimationCircle2"),System.Windows.Shapes.Ellipse)
        Me.waitAnimationCircle3 = CType(Me.FindName("waitAnimationCircle3"),System.Windows.Shapes.Ellipse)
        Me.waitAnimationCircle4 = CType(Me.FindName("waitAnimationCircle4"),System.Windows.Shapes.Ellipse)
        Me.waitAnimationCircle5 = CType(Me.FindName("waitAnimationCircle5"),System.Windows.Shapes.Ellipse)
        Me.waitAnimationCircle6 = CType(Me.FindName("waitAnimationCircle6"),System.Windows.Shapes.Ellipse)
    End Sub
End Class
