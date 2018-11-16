# Project Title

Word Frequency Counter

## Description

This project will take a word and check to see how many times that word appears in a sentance.


### Installing

In it's current state this program is meant to prove test methods. To run this file open the folder in the terminal and navigate to the WordCounter.Test subdirectory. Once inside, run ``` dotnet test ``` in the console to observe if the test methods pass or fail.

## Running the tests

Navigate to the WordCounter.Test subdirectory, run ``` dotnet test ``` in the console to observe if the test methods pass or fail.

### Break down into end to end tests

_Behavior 1_
Can create a new WordFrequencyCounter object

_Behavior 2_
Can correctly capture a letter and return the letter if it is a match to the same letter
Input: a
Output: a

_Behavior 3_
Can correctly capture and return a sentence.
Input: "Hello this is a sentence"
Output: "Hello this is a sentence"

_Behavior 4_
Can split sentence into a list of words
Input: "Hello this is a sentence"
Output {"Hello", "this", "is", "a", "sentence"}

_Behavior 5_
Can count the instances of one letter in an array
Input: Word = a // Sentence = "Look at a word that a user can enter"
Output: count = 2

```
Give an example
```


## Built With

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - The web framework used
* [Maven](https://maven.apache.org/) - Dependency Management
* [ROME](https://rometools.github.io/rome/) - Used to generate RSS Feeds


## Authors

* **Chris Rudnicky** -

## License

This project is licensed under the MIT License

## Acknowledgments
