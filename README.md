# Project 3 - Perspective

## NOTE - THIS PROJECT INTENDED USE IS FOR VR (OCULUS/OCULUS QUEST 2, BUT CAN BE USED IN PC TOO)
This project's intended use is VR on oculus headsets. You will be able to do different things including grabbing and picking up models, hitting models against each other, listening to different sounds models might have, switching between different variations of the project through a menu system, and exploring new models/areas that each variation of the project will provide. All of this was written in Unity with the help of creating models in Blender. (NOTE - Check below for more instructions on each world and how to traverse them with a description. There will also be a more specific explanation of the controls below as well)

Website Documentation for Projects:
https://sites.google.com/uic.edu/project-3/home?authuser=4

## Software Versions required

Unity 2019.4.28f1 - https://unity3d.com/get-unity/download/archive

VRTK Verison 4 - https://github.com/ExtendRealityLtd/VRTK

Blender 2.93.4 - https://www.blender.org/download/

Unity Hub (Latest version) - https://unity.com/

## How to run/install project

1. Create a folder with any name. 
![New Folder](/DocumentPictures/New_Folder.PNG)


2. 
* Go inside the directory and open up a Git Bash and run the following command:
`git clone https://github.com/ddanciu2/CS428Project3.git`
![Clone Project](/DocumentPictures/Git_Clone.PNG)


* If Git Bash is not available, download the zip file and move it into the directory you
created and unzip the file there.

![Clone Project](/DocumentPictures/Zip_Location.PNG)
![Clone Project](/DocumentPictures/Zip_Extract.PNG)


3. Go to the [Unity Website](https://unity.com/) and do the following to get Unity Hub.
* Click "Get Started"
![Unity](/DocumentPictures/Unity_GetStarted.PNG)

* Click Individual > Personal
![Personal Unity](/DocumentPictures/Unity_Personal.PNG)

* Click Download for Windows (Or your respective platform), let it configure and run it.
![Download](/DocumentPictures/Unity_DownloadV.PNG)

* Add the correct Unity version by going to the [Unity Archive](https://unity3d.com/get-unity/download/archive), click Unity 2019.x and click the green Unity Hub download icon for Unity 2019.4.28f1 verison

![Download Version](/DocumentPictures/Unity_Version.PNG)

* Make sure to install the following:
    1. Unity
    2. Documentation
    3. Windows Build Support (Mono) so it can run on the classroom PC
    4. Android Build Support (for running on the Oculus Quest)
    5. Mac Build Support if you want to develop on a mac
    6. Linux Build Support if you want to develop on a linux machine

6. Go to Unity Hub, click add and select the CS428Project3 folder that you cloned

7. Run Project Method:
* If you wish to run the project on your laptop/PC, turn on the "CameraRigs.SpatialSimulator" and turn off "CameraRigs.UnityXR" for each scene. This can be done by clicking each scene within the Scenes folder (Assets > Scenes). Click run/play ontop of the Unity. Make sure you are on the PC platform starting by going to File > Build Settings > Click on "PC" > Click on "Switch Platform" button. Use the following controls:
    * Mouse to look around
    * Move around with WASD
    * Q key to teleport
    * E key to turn interact with things (Click buttons, turn on/off lamp)
    * 1 key to control player, 2 key to control left hand, 3 key to control right hand
    * Left click to grab objects (Make sure to be controlling player then)
    * Left shift to bring up menu to switch worlds
        * Hover over the square with the pointer by pressing/holding E and let go of E after your pointer is hovering over the square/world you want to pick.
    * Left control ("CTRL") to bring up menu to do 90 degree increments. (ONLY CAN BE ACCESSED IN DANCING ON CEILING VERSION)
        * Hover over the square with the pointer by pressing/holding E and let go of E after your pointer is hovering over the 90 degree direction you want to pick.

* If you wish to run the project off your headset, turn on the "CameraRigs.UnityXR" and turn off "CameraRigs.SpatialSimulator" for each scene. This can be done by clicking each scene within the Scenes folder (Assets > Scenes). This should be done before you build the APK file. Make sure you are on the Android platform starting by going to File > Build Settings > Click on "Android" > Click on "Switch Platform" button. Use the following controls:
    * Look around with head movement
    * Teleport with left joystick click
    * Interact with right joystick click
    * Side triggers to grab objects
    * X button on left controller to bring up menu to switch worlds
        * Hover over the square with the right controller pointer and do a right joystick click to pick that world.
    * A button on right controller to bring up menu to do 90 degree increments. (ONLY CAN BE ACCESSED IN DANCING ON CEILING VERSION)
        * Hover over the square with the right controller pointer and do a right joystick click to do a 90 degree rotation in that direction.

![Oculus Driver](/DocumentPictures/Unity_XR.PNG)
* Unity screenshot showing where to uncheck/check UnityXR or SpatialSimulator

8. (Windows) Build APK/run on headset (continued)

* Switch to Android Platform by going to the top of the Unity page, File > Build Settings.
    * Click on Android and Switch Platform
    * Check to see that you can see your device under "Run Device"
    * Click Player Settings > Player > (Android Tab) Other Settings > (Check the following)
        * Version: 4.4
        * Minimum API Level: Android 4.4 "KitKat" (API level 19)
    * Go back to Build Settings > Build > (Save APK file to known location)


9. (Windows Method) Before you run the project, you must follow the steps here to run the APK file, located [here](https://uploadvr.com/how-to-sideload-apps-oculus-go/)

* Your headset should be connected to the PC/laptop and accept the access to your data

* Go on your headset and enable the following: Settings > Developer > Turn on "USB Connection Debugging"

* Go to the [Oculus Dashboard](https://dashboard.oculus.com/), create an organization, accept the developer agreement, and enable Developer Mode

* Install the Oculus Driver [here](https://developer.oculus.com/downloads/package/oculus-go-adb-drivers/). Extract the zip and go within the folder, right click the file "android_winusb" and click install

![Oculus Driver](/DocumentPictures/Install_ABDdriver.PNG)


* Install ADB software [here], scroll down to the Downloads section and download the SDK for your respective platform. Extract the zip file to use the contents.

![Oculus Driver](/DocumentPictures/Install_ABDSDK.PNG)

* Open up a command prompt where you got extracted your SDK tools and run the following command: adb install -r (APK file location)

![Oculus Driver](/DocumentPictures/APK_FileInstall.PNG)

* This success message should come up aftewards

![Oculus Driver](/DocumentPictures/Cmd_Success.PNG)

9. Oculus startup

* Go onto to your Oculus and do the following: open apps > (Top right corner) click on "All (#)" > click on "Unknown Sources" > Click on your APK file/project

* Wait for startup and enjoy experiencing the phobias
