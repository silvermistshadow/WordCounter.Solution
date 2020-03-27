# _Word Counter_

#### _Checks how frequently word appears in sentence, 3-18-2020_

#### By _**BM**_

## Description

_A program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence._

#### Specs ####
    0: 
        recognize if two letters are identical
        input: 'c', 'c'
        output: true

        input:  'a', 'b' 
        output: false
    1:
        check that two letters are identical regardless of casing
        input:  'a', 'A' 
        output: true
    2:
        recognize if two words are the same
        input:  'cat', 'cat' 
        output: true
        input:  'cat', 'CAT' 
        output: true
        input:  'cat', 'dog' 
        output: false

    3:
        ignore punctuation and non-letters when checking words
        input: 'c at', 'cat'
        output: true
        input: 'c3at', 'cat'
        output: true
        input: "cat", "Cat."
        output: true

    4:
        ignore partial matches
        input: "cat", "cathedral"
        output: false

    5:
        check for a whole word in a sentence
        input: "fox", "The quick brown fox jumped over the lazy dog"
        output: true

    6:
        count the number of times a whole word appears in a sentence
        input: "poop", "How many poops did the cat leave in the poop box, it was already full of POOP."
        output: 3

## Setup/Installation Requirements

* _Requires .NET framework_
* _download/clone repo_
* _dotnet run_

## Technologies Used

_.NET Framework_

### License

*MIT*