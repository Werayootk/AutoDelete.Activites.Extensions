[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0) ![License](https://img.shields.io/nuget/v/AutoDelete.Activites.Extensions.UiPath)
![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/NugetIcon.PNG)
## AutoDelete.Activites.Extensions
This project create for RPA UiPath autodelete files

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

What things you need to install the software and how to install them

![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/UIPath.png)
1. UiPath Stodio software please download this url : https://www.uipath.com/
2. Basic skill in UiPath 

### Installing

A step by step series of examples that tell you how to get a development env running

1. Download example project from this repo "AutoDelete.Activites.Extensions/Example UiPath AutoDelete Test/AutoDelete/".
2. Extract into "Example UiPath AutoDelete Test/AutoDelete/" your path. 
3. Create directory for test this example use path is "D:\Test_AutoDelete".
4. Create some file may be text file for testing.  ❗ ❗Don't use important file for testing.

### Set up example project

A step by step series of examples that tell you how to get a nuget package env

1. Open "UiPath Studio" => Open Example project is your extract as above.
![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/Packref.PNG)
2. Rigth-click Dependencies => Manage
![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/Addnuget.PNG)
3. Select nuget.org => serach "AutoDelete.Activites.Extensions" => Install and then Save
![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/Pathtool.png)
4. After finish download nuget package choose tab Activities and search tool "AutoDelete".

### Example Use-case

A step by step series of examples that tell you how to get use AutoDelete

1. Place the Activity as in the image below.

![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/fullflow.PNG)

2. Define variable follow image as below.

![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/DefineVar.PNG)

3. Assign value start date you want to delete follow image as below.
![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/asssignStr.PNG)
4. Assign value end date you want to delete follow image as below.
![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/asssignEnd.PNG)
5. Assign value path directory date you want to delete follow image as below.
![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/asssignPath.PNG)
6. Assign value AutoDelete follow image as below.
![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/setautodelete.PNG)
7. Checking directory was created following image as below.
![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/Simple.PNG)
8. Test Run , and Checking directory was empty following image as below.
![](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/images/Empty.PNG)

## License

This project is licensed under the  Apache-2.0 License - see the [LICENSE](https://github.com/Werayootk/AutoDelete.Activites.Extensions/blob/main/LICENSE) file for details

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc

## TO DO check-list
- [x] Project Title :wave:
- [x] Getting Started
- [x] Prerequisites
- [x] Installing
- [x] Example Use Case
- [x] License

