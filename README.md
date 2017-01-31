# Phidgets Interface Assets for IntuiFace

This project contains Phidgets Interface Asset for IntuiFace Player & IntuiFace Composer.

The [Phidgets](http://www.phidgets.com//) Interface Asset enable you to communicate with Phidgets sensors and controllers from an IntuiFace experience.
This Interface Asset was developed to communicate with an [8/8/8 Interface Kit](http://www.phidgets.com/products.php?category=0&product_id=1018_2), meaning it handles:
* 8 Logical inputs (ex: a button)
* 8 Analog inputs (ex: distance sensor)
* 8 Logical outputs (ex: a LED)

![Phidgets Board 8/8/8](Screenshots/Phidgets-board888.jpg "Phidgets Board" "width:350px")


It comes with a default Design Accelerator that will enable you to test your Phidget Interface Kit within IntuiFace Composer quickly.

For more information, check the online documentation for [using Phidgets within IntuiFace](http://support.intuilab.com/kb/a-quick-overview/using-phidgets-within-intuiface)

![Phidgets Default Design Accelerator](Screenshots/Phidget-DA.jpg "Phidgets Design Accelerator" "width:350px")

# How to build this project?

**PREREQUISITES**: you must have Visual Studio 2010 and .NET 4 installed.

The code language for Phidgets Interface Assets is C#.

To build this project, follow these steps:
* Open **Phidgets.sln** in Visual Studio 2010 or above,
* Build the solution in **Release** mode,
* Navigate to the root of the project, you can see a folder called **OutputAssemblies** which contains all the Phidgets Interface Assets.

# How to use Phidgets Interface Assets?

To be able to add Phidgets Interface Assets in IntuiFace Composer, follow these steps: 
* Copy the **Phidgets** folder from the **OutputAssemblies** to the path "[Drive]:\Users\\[UserName]\Documents\IntuiFace\Interface Assets",
* Launch **IntuiFace Composer**,
* Add an Interface Asset and when you enter "Phidget" in the search bar, you can see the **Phidget 8-8-8** Interface Asset.



See more information on our support webpage: [using Phidgets within IntuiFace](http://support.intuilab.com/kb/a-quick-overview/using-phidgets-within-intuiface)

-----

Copyright &copy; 2015 IntuiLab.

Released under the **MIT License**.



