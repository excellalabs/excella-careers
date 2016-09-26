![Excella Logo](RawResources/ExcellaLogoBig.png)

#Excella Careers
Excella Careers is a cross platform mobile application that displays the current career opportunities with Excella Consulting and offers the ability to share links to those opportunities via email, SMS, social media, etc. Excella Careers is supported by **iPhone** and **Android**.

##Technical Details
Excella Careers is written in **C#** and leverages **Xamarin** to support a cross-platform solution. The solution is divided into four distinct projects.

###`ExcellaCareers`
This is a Portable Code Library (PCL) containing business logic that can be shared across all platform-specific projects.

###`ExcellaCareers.iOS`
This is the ***iOS*** (iPhone, iPad) platform project. It conains the UI and platform-specfic application logic for the iOS operating system.

###`ExcellaCareers.Android`
This is the ***Android*** platform project. It conains the UI and platform-specfic application logic for the Android operating system.

###`ExcellaCareers.Tests`
This is the unit test project. It contains tests for the ExcellaCareers PCL project.

##Development Setup
Xamarin development requires [Visual Studio](https://www.visualstudio.com/en-us/downloads/download-visual-studio-vs.aspx "Visual Studio Download") on Windows (Community Edition is sufficient) or [Xamarin Studio](https://www.xamarin.com/download "Xamarin Studio Download") on MacOS. Detailed installation instructions can be found on the [Xamarin website](https://developer.xamarin.com/guides/cross-platform/getting_started/installation/ "Xamarin Installation"). Android development, testing, and deployment can be done from Windows or Mac. iOS development can be done from Windows or Mac, but testing and deployment require a Mac running [Xcode](https://itunes.apple.com/us/app/xcode/id497799835?mt=12 "Xcode Download"). When an Xamarin.iOS application is opened in Visual Studio the user should be prompted to connect to a Mac on the network, but in case of difficulties detailed instructions can be found [here](https://developer.xamarin.com/guides/ios/getting_started/installation/windows/connecting-to-mac/ "Connecting to the Mac").

##Testing on a Device
Visual Studio and Xamarin Studio offer iOS and Android emulators, but eventually you will want to test on an actual device. Setup for [Android device testing](https://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/debug-on-device/ "Debug on an Android Device") and [iOS device testing](https://developer.xamarin.com/guides/ios/getting_started/installation/device_provisioning/ "iOS Device Provisioning") can be found on the Xamarin website.
