#ExternalChecksum("T:\CODE\SMT\Solutions\ALENTEJO\Alentejo_SLA\App_Code\Pages\Job Viewer Controls\ucJobViewer.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","07184BA789905841BFA38542A148EFE6")
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

Imports Microsoft.Windows.Controls
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
Partial Public Class ucJobViewer
    Inherits System.Windows.Controls.UserControl
    
    Friend WithEvents cvLayoutRoot As System.Windows.Controls.Canvas
    
    Friend WithEvents elPROG_JobSubmitted As System.Windows.Shapes.Ellipse
    
    Friend WithEvents elPROG_PreProcessing As System.Windows.Shapes.Ellipse
    
    Friend WithEvents elPROG_Rendering As System.Windows.Shapes.Ellipse
    
    Friend WithEvents elPROG_Finalization As System.Windows.Shapes.Ellipse
    
    Friend WithEvents elPROG_Complete As System.Windows.Shapes.Ellipse
    
    Friend WithEvents lblProgress As System.Windows.Controls.TextBlock
    
    Friend WithEvents svConsole As System.Windows.Controls.ScrollViewer
    
    Friend WithEvents spConsole As System.Windows.Controls.StackPanel
    
    Friend WithEvents cvConsoleWaitAnimation As System.Windows.Controls.Canvas
    
    Friend WithEvents bdImageSample As System.Windows.Controls.Border
    
    Friend WithEvents imgSample As System.Windows.Controls.Image
    
    Friend WithEvents cvImageWaitAnimation As System.Windows.Controls.Canvas
    
    Friend WithEvents lblImageFileName As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblJobName As System.Windows.Controls.TextBlock
    
    Friend WithEvents cvClose As System.Windows.Controls.Canvas
    
    Friend WithEvents rtCLOSE_CLICK_CATCH As System.Windows.Shapes.Rectangle
    
    Friend WithEvents hlTerminateResubmitRender As System.Windows.Controls.HyperlinkButton
    
    Friend WithEvents hlCloneRender As System.Windows.Controls.HyperlinkButton
    
    Friend WithEvents spExpanders As System.Windows.Controls.StackPanel
    
    Friend WithEvents exRenderInfo As Microsoft.Windows.Controls.Expander
    
    Friend WithEvents bdRenderInfo As System.Windows.Controls.Border
    
    Friend WithEvents lblSTAT_Benchmark As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblSTAT_SampleLevel As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblSTAT_Cores As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblSTAT_Time_Elapsed As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblSTAT_Time_Start As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblSTAT_Cost_Current As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblSTAT_CameraName As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblSTAT_Time_End As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblSTAT_JobFile As System.Windows.Controls.TextBlock
    
    Friend WithEvents lblSTAT_Resolution As System.Windows.Controls.TextBlock
    
    Friend WithEvents exFileList As Microsoft.Windows.Controls.Expander
    
    Friend WithEvents bdFileList As System.Windows.Controls.Border
    
    Friend WithEvents lbFILE_FileList As System.Windows.Controls.ListBox
    
    Friend WithEvents cvFilesWaitAnimation As System.Windows.Controls.Canvas
    
    Friend WithEvents hlDownloadSelectedFile As System.Windows.Controls.HyperlinkButton
    
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
        System.Windows.Application.LoadComponent(Me, New System.Uri("/SMT.Alentejo_SLA;component/App_Code/Pages/Job%20Viewer%20Controls/ucJobViewer.xa"& _ 
                    "ml", System.UriKind.Relative))
        Me.cvLayoutRoot = CType(Me.FindName("cvLayoutRoot"),System.Windows.Controls.Canvas)
        Me.elPROG_JobSubmitted = CType(Me.FindName("elPROG_JobSubmitted"),System.Windows.Shapes.Ellipse)
        Me.elPROG_PreProcessing = CType(Me.FindName("elPROG_PreProcessing"),System.Windows.Shapes.Ellipse)
        Me.elPROG_Rendering = CType(Me.FindName("elPROG_Rendering"),System.Windows.Shapes.Ellipse)
        Me.elPROG_Finalization = CType(Me.FindName("elPROG_Finalization"),System.Windows.Shapes.Ellipse)
        Me.elPROG_Complete = CType(Me.FindName("elPROG_Complete"),System.Windows.Shapes.Ellipse)
        Me.lblProgress = CType(Me.FindName("lblProgress"),System.Windows.Controls.TextBlock)
        Me.svConsole = CType(Me.FindName("svConsole"),System.Windows.Controls.ScrollViewer)
        Me.spConsole = CType(Me.FindName("spConsole"),System.Windows.Controls.StackPanel)
        Me.cvConsoleWaitAnimation = CType(Me.FindName("cvConsoleWaitAnimation"),System.Windows.Controls.Canvas)
        Me.bdImageSample = CType(Me.FindName("bdImageSample"),System.Windows.Controls.Border)
        Me.imgSample = CType(Me.FindName("imgSample"),System.Windows.Controls.Image)
        Me.cvImageWaitAnimation = CType(Me.FindName("cvImageWaitAnimation"),System.Windows.Controls.Canvas)
        Me.lblImageFileName = CType(Me.FindName("lblImageFileName"),System.Windows.Controls.TextBlock)
        Me.lblJobName = CType(Me.FindName("lblJobName"),System.Windows.Controls.TextBlock)
        Me.cvClose = CType(Me.FindName("cvClose"),System.Windows.Controls.Canvas)
        Me.rtCLOSE_CLICK_CATCH = CType(Me.FindName("rtCLOSE_CLICK_CATCH"),System.Windows.Shapes.Rectangle)
        Me.hlTerminateResubmitRender = CType(Me.FindName("hlTerminateResubmitRender"),System.Windows.Controls.HyperlinkButton)
        Me.hlCloneRender = CType(Me.FindName("hlCloneRender"),System.Windows.Controls.HyperlinkButton)
        Me.spExpanders = CType(Me.FindName("spExpanders"),System.Windows.Controls.StackPanel)
        Me.exRenderInfo = CType(Me.FindName("exRenderInfo"),Microsoft.Windows.Controls.Expander)
        Me.bdRenderInfo = CType(Me.FindName("bdRenderInfo"),System.Windows.Controls.Border)
        Me.lblSTAT_Benchmark = CType(Me.FindName("lblSTAT_Benchmark"),System.Windows.Controls.TextBlock)
        Me.lblSTAT_SampleLevel = CType(Me.FindName("lblSTAT_SampleLevel"),System.Windows.Controls.TextBlock)
        Me.lblSTAT_Cores = CType(Me.FindName("lblSTAT_Cores"),System.Windows.Controls.TextBlock)
        Me.lblSTAT_Time_Elapsed = CType(Me.FindName("lblSTAT_Time_Elapsed"),System.Windows.Controls.TextBlock)
        Me.lblSTAT_Time_Start = CType(Me.FindName("lblSTAT_Time_Start"),System.Windows.Controls.TextBlock)
        Me.lblSTAT_Cost_Current = CType(Me.FindName("lblSTAT_Cost_Current"),System.Windows.Controls.TextBlock)
        Me.lblSTAT_CameraName = CType(Me.FindName("lblSTAT_CameraName"),System.Windows.Controls.TextBlock)
        Me.lblSTAT_Time_End = CType(Me.FindName("lblSTAT_Time_End"),System.Windows.Controls.TextBlock)
        Me.lblSTAT_JobFile = CType(Me.FindName("lblSTAT_JobFile"),System.Windows.Controls.TextBlock)
        Me.lblSTAT_Resolution = CType(Me.FindName("lblSTAT_Resolution"),System.Windows.Controls.TextBlock)
        Me.exFileList = CType(Me.FindName("exFileList"),Microsoft.Windows.Controls.Expander)
        Me.bdFileList = CType(Me.FindName("bdFileList"),System.Windows.Controls.Border)
        Me.lbFILE_FileList = CType(Me.FindName("lbFILE_FileList"),System.Windows.Controls.ListBox)
        Me.cvFilesWaitAnimation = CType(Me.FindName("cvFilesWaitAnimation"),System.Windows.Controls.Canvas)
        Me.hlDownloadSelectedFile = CType(Me.FindName("hlDownloadSelectedFile"),System.Windows.Controls.HyperlinkButton)
    End Sub
End Class