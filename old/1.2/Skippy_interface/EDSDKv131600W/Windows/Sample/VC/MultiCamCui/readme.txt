## Operating environment
 We recommend using this sample with "windows terminal" because it uses ESC character (\033) for screen control.

## Install build tools
 Visual Studio 2019 version 16.5 or later
 Build it as a cmake project.

## Build Method
 1.Unzip MultiCamCui.zip.

 2.Start Visual Studio.

 3.Click "Open a local folder,"
   Select the folder created by unzipping MultiCamCui.zip.

 4.Choose between x64-Debug or x64-Release
   If you want to run the sample app on another PC rather than a build machine, you must build it with x 64 -Release.

 5.Build -> Build All

##How to use the sample app
 1.Connect the camera to your PC with a USB cable.

 2.Run MultiCamCui.exe.
   The top menu lists the detected cameras.

 3.Select the camera you want to connect.
   ex.
   - Select camera No.2 to No.5
     Enter "2-5"

   - Select camera No.3
     Enter "3"

   - Select all listed cameras
     Enter "a"

   - Quit the app
     Enter "x"

   * The camera number changes in the order you connect the camera to your PC.

 4.Control menu
   The control menu is the following:
   [ 1] Take Picture and download
   [ 2] Press Halfway
   [ 3] Press Completely
   [ 4] Press Off
   [ 5] TV
   [ 6] AV
   [ 7] ISO
   [ 8] White Balance
   [ 9] Drive Mode
   [10] AE Mode (read only)
   [11] Get Live View
   [12] File Download

   Select the item number you want to control.
   The following is a description of the operation for each input number.
   *Enter "r" key to move to "Top Menu"

   [ 1]
    Press and release the shutter button without AF action,
    create a "cam + number" folder in the folder where MultiCamCui.exe is located
    and save the pictures taken with each camera.

    * If you can't shoot, change the mode dial to "M" and then try again.
    * The camera number changes in the order you connect the camera to your PC.

   [ 2]
    Press the shutter button halfway.

   [ 3]
    Press the shutter button completely.
    When Drive mode is set to continuous shooting,
    Continuous shooting is performed.

   [ 4]
    Release the shutter button.

   [ 5]
    Set Tv settings.

   [ 6]
    Set Av settings.

   [ 7]
    Set ISO settings.

   [ 8]
    Set White Balance settings.

   [ 9]
    Set Drive mode settings

   [10]
    Refers to AE mode settings (not configurable)

   [11]
    Get one live view image.
    In the folder where MultiCamCui.exe is located
    Automatically create a "cam number" folder and save each camera's image.

   [12]
    Download all picture File in the camera's card to PC.
    In the folder where MultiCamCui.exe is located
    automatically create a "cam number" folder and save each camera's image.

   * Some settings may not be available depending on the mode dial of the camera.
     If you can't set, change the mode dial to "M" and then try again.
