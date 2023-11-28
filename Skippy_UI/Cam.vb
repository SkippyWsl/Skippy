Option Explicit On
Imports System.Runtime.InteropServices
Public Module Cam
    Public Declare Function initialize Lib "Skippy_interface" () As Integer
    Public Declare Function setcam Lib "Skippy_interface" () As Integer
    Public Declare Function unloadSDK Lib "Skippy_interface" () As Integer
    Public Declare Function focus Lib "Skippy_interface" (seconds As Integer) As Boolean
    Public Declare Function picture Lib "Skippy_interface" () As Boolean
    Public Declare Function newpath Lib "Skippy_interface" (<MarshalAs(UnmanagedType.LPWStr)> Path As String, <MarshalAs(UnmanagedType.LPWStr)> prefix As String, no As Integer) As Boolean
    Public Declare Function preview Lib "Skippy_interface" () As IntPtr
    Public Declare Function bufferunlock Lib "Skippy_interface" () As Boolean
    Public Declare Function buffersize Lib "Skippy_interface" () As Integer
    Public Declare Function battleft Lib "Skippy_interface" () As Integer
End Module
