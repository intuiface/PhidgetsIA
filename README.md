# Phidgets Interface Assets for Intuiface

This project contains Phidgets Interface Asset for Intuiface Player & IntuiFace Composer.

The [Phidgets](http://www.phidgets.com//) Interface Asset enable you to communicate with Phidgets sensors and controllers from an Intuiface experience.
This Interface Asset was developed to communicate with an [8/8/8 Interface Kit](http://www.phidgets.com/products.php?category=0&product_id=1018_2), meaning it handles:
* 8 Logical inputs (ex: a button)
* 8 Analog inputs (ex: distance sensor)
* 8 Logical outputs (ex: a LED)

![Phidgets Board 8/8/8](Screenshots/Phidgets-board888.jpg "Phidgets Board" "width:350px")


It comes with a default Design Accelerator that will enable you to test your Phidget Interface Kit within Intuiface Composer quickly.

For more information, check the online documentation for [using Phidgets within Intuiface](https://support.intuiface.com/hc/en-us/articles/360007432171-Using-Phidgets-sensors-within-Intuiface)

![Phidgets Default Design Accelerator](Screenshots/Phidget-DA.jpg "Phidgets Design Accelerator" "width:350px")

# How to use Phidgets Interface Assets?

To be able to add Phidgets Interface Assets in Intuiface Composer, follow these steps: 
* Close all **Intuiface Composer** running instances. 
* Download the [latest released package here](https://github.com/intuilab/PhidgetsIA/releases)
* Extract the archive and copy the **Phidgets** folder to the path "[Drive]:\Users\\[UserName]\Documents\Intuiface\Interface Assets",
* Install the **driver** from [Phidgets.com](https://www.phidgets.com/docs21/OS_-_Windows)
* Launch **Intuiface Composer**,
* **Add an Interface Asset** and when you enter "Phidget" in the search bar, you can see the **Phidget 8-8-8** Interface Asset.

See more information on our support webpage: [using Phidgets within Intuiface](https://support.intuiface.com/hc/en-us/articles/360007432171-Using-Phidgets-sensors-within-Intuiface)

# How to build this project?

**PREREQUISITES**: you must have Visual Studio 2010 and .NET 4 installed.

The code language for Phidgets Interface Assets is C#.

To build this project, follow these steps:
* Open **Phidgets.sln** in Visual Studio 2010 or above,
* Build the solution in **Release** mode,
* Navigate to the root of the project, you can see a folder called **OutputAssemblies** which contains all the Phidgets Interface Assets.



-----

Copyright &copy; 2015 IntuiLab.

Released under the **MIT License**.



