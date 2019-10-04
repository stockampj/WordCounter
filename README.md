|Spec|Input|Output|
|--|--|--|
|a word that matches the user input will return true |user searches pat for pat |true|
|a word that matches the user input will return true |user searches hat for pat |false|
|a word that matches the user input in a phrase will return true |user searches for  this in "this place"|true|
|a word that matches the user input in a phrase will return true |user searches for this in "that place"|false|
|the program will track the number of matches |user searches "an" in "an apple, an orange"|2|
|partial matches are ignored|user searches "an" in "an apple and an orange"|2|