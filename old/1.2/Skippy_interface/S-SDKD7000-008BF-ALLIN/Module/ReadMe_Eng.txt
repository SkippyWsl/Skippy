Nikon Type0004 Module SDK Revision.10 summary


Usage
 Control the camera.


Supported camera
 D7000


Environment of operation
 [Windows]
    Windows 8.1 64bit edition
    (Windows 8.1 / Pro / Enterprise) 
    Windows 10 64bit edition
    * Please set Camera to PTP mode by SET UP menu (on camera body). If the 
      camera is set to Mass Storage, you can not control it by Windows.
    * You must install "microsoft visual c++ redistributable package for visual studio 2017"

 [Macintosh]
    macOS 10.14.6(Mojave)
    macOS 10.15.7(Catalina)
    macOS 11.4(Big Sur)
    * 64bit mode only (32bit mode is not supported)
    * Please set Camera to PTP mode by SET UP menu (on camera body). If the 
      camera is set to Mass Storage, you can not control it by Macintosh.


Contents
 [Windows]
    Documents
      MAID3(E).pdf : Basic interface specification
      MAID3Type0004(E).pdf : Extended interface specification used 
                                                              by Type0004 Module
      Usage of Type0004 Module(E).pdf : Notes for using Type0004 Module
      Type0004 Sample Guide(E).pdf : The usage of a sample program

    Binary Files
      Type0004.md3 : Type0004 Module for Win
      NkdPTP.dll : Driver for PTP mode used by Win

    Header Files
      Maid3.h : Basic header file of MAID interface
      Maid3d1.h : Extended header file for Type0004 Module
      NkTypes.h : Definitions of the types used in Maid3.h
      NkEndian.h : Definitions of the types used in this program
      Nkstdint.h : Definitions of the types used in this program

    Sample Program
      Type0004CtrlSample(Win) : Project for Microsoft Visual Studio 2017


 [Macintosh]
    Documents
      MAID3(E).pdf : Basic interface specification
      MAID3Type0004(E).pdf : Extended interface specification used by 
                                                                Type0004 Module
      Usage of Type0004 Module(E).pdf : Notes for using Type0004 Module
      Type0004 Sample Guide(E).pdf : The usage of a sample program
      [Mac OS] Notice about using Module SDK(E).txt : Notes for using SDK
                                                                on Mac OS

    Binary Files
        Type0004 Module.bundle : Type0004 Module for Mac
        libNkPTPDriver2.dylib : PTP driver for Mac
        Royalmile.framework : PTP driver for Mac

    Header Files
      Maid3.h : Basic header file of MAID interface
      Maid3d1.h : Extended header file for Type0004 Module
      NkTypes.h : Definitions of the types used in Maid3.h
      NkEndian.h : Definitions of the types used in this program
      Nkstdint.h : Definitions of the types used in this program

    Sample Program
      Type0004CtrlSample(Mac) : Sample program project for Xcode 10.0(BaseSDK : macOS)

Limitations
 This module cannot control two or more cameras.
