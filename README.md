# _Pierre's Bakery_

#### _This app was created to test basic C# methods and the testing framework of .Net_

#### By _Joel Stockamp_

## Description

_A user should be able to interact with the console and determine the number of occurances of a particular word in a given block of text._

## Setup/Installation Requirements

* download this package from github: https://github.com/stockampj/WordCounter.git
* open a terminal and navigate to the project folder
* enter the command "dotnet run"


## Specs

|Spec|Input|Output|
|--|--|--|
|a word that matches the user input will return true |user searches pat for pat |true|
|a word that matches the user input will return true |user searches hat for pat |false|
|a word that matches the user input in a phrase will return true |user searches for  this in "this place"|true|
|a word that matches the user input in a phrase will return true |user searches for this in "that place"|false|
|the program will track the number of matches |user searches "an" in "an apple, an orange"|2|
|partial matches are ignored|user searches "an" in "an apple and an orange"|2|

## Known Bugs

_No known bugs_

## Support and contact details

_Please let me know if you want to chat: stockampj@gmail.com_

## Technologies Used

_C#, VSCode NuGet_

### License

*MIT License*

Copyright (c) 2019 **_Joel Stockamp_**