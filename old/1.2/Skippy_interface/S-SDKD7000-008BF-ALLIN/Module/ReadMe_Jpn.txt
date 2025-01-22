Nikon Type0004 Module SDK Revision.10 概要


■用途
 カメラのコントロールを行う。


■サポートするカメラ
 D7000


■動作環境
 [Windows]
	Windows 8.1 64bit版
	(Windows 8.1 / Pro / Enterprise)
	Windows 10 64bit版
	※カメラ本体の通信モード(セットアップメニュー/USB)をPTPに設定して下さい。
	カメラがMass Storageに設定されていると、Windowsからコントロールすることはできません。
	※"Visual Studio 2017 の Visual C++ 再頒布可能パッケージ"のインストールが必要


 [Macintosh]
	macOS 10.14.6(Mojave)
	macOS 10.15.7(Catalina)
	macOS 11.4(Big Sur)
	※64bitモードのみ（32bitモードは非サポート）
	※カメラ本体の通信モード(セットアップメニュー/USB)をPTPに設定して下さい。
	カメラがMass Storageに設定されていると、Macintoshからコントロールすることはできません。


■内容物
 [Windows]
    Documents
      MAID3(J).pdf : 基本インターフェース仕様
      MAID3Type0004(J).pdf : Type0004 Moduleで使用される拡張インターフェース仕様
      Usage of Type0004 Module(J).pdf : Type0004 Module を使用する上での注意事項
      Type0004 Sample Guide(J).pdf : サンプルプログラムの使用方法

    Binary Files
      Type0004.md3 : Windows用 Type0004 Module本体
      NkdPTP.dll : Windows用　PTPドライバ
 
    Header Files
      Maid3.h : MAIDインターフェース基本ヘッダ
      Maid3d1.h : Type0004用MAIDインターフェース拡張ヘッダ
      NkTypes.h : 上記ヘッダで使用する型の定義
      NkEndian.h : 本プログラムで使用する型の定義
      Nkstdint.h : 本プログラムで使用する型の定義

    Sample Program
      Type0004CtrlSample(Win) : Microsoft Visual Studio 2017 用プロジェクト


 [Macintosh]
    Documents
      MAID3(J).pdf : 基本インターフェース仕様
      MAID3Type0004(J).pdf : Type0004 Moduleで使用される拡張インターフェース仕様
      Usage of Type0004 Module(J).pdf : Type0004 Module を使用する上での注意事項
      Type0004 Sample Guide(J).pdf : サンプルプログラムの使用方法
      [Mac OS] Notice about using Module SDK(J).txt : Mac OSで使用する上での注意事項

    Binary Files
        Type0004 Module.bundle : Macintosh用 Type0004 Module本体 
        libNkPTPDriver2.dylib : Macintosh用 PTP ドライバ
        Royalmile.framework : Macintosh用 PTP ドライバ

    Header Files
      Maid3.h : MAIDインターフェース基本ヘッダ
      Maid3d1.h : Type0004用MAIDインターフェース拡張ヘッダ
      NkTypes.h : 上記ヘッダで使用する型の定義
      NkEndian.h : 本プログラムで使用する型の定義
      Nkstdint.h : 本プログラムで使用する型の定義

    Sample Program
      Type0004CtrlSample(Mac) : Xcode 10.0用のサンプルプログラムプロジェクト(BaseSDK : macOS)   

■制限事項
 本Module SDKを利用してコントロールできるカメラは1台のみです。
 複数台のコントロールには対応していません。
