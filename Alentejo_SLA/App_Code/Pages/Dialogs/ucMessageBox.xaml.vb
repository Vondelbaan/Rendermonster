﻿Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Partial Public Class ucMessageBox 
	Inherits UserControl

    Public Event evClosed()

	Public Sub New()
		' Required to initialize variables
		InitializeComponent()
	End Sub

End Class
