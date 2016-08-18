console.log("Here are several useful functions for dealing with strings in JavaScript:");

// length
console.log("length will give you the number of characters");
var myString = "Apple";
console.log("The string Apple has " + myString.length + " characters." + "\n");


// range select
console.log("a string's characters can be accessed individually by position (starting with 0) with substring ");
console.log("Apple.substring(0,3) : " + myString.substring(0,3) + "\n");
console.log("Note that the first index is inclusive and the last index is exclusive!");
console.log("Apple.substring(2,4) : " + myString.substring(2,4) + "\n");
console.log("Note that javascript doesn't mind if you go over max!");
console.log("Apple.substring(3,12) : " + myString.substring(3,12) + "\n");


// single select
console.log("If we just want one char we can use charAt():");
console.log("Apple.charAt(3) : " + myString.charAt(3) + "\n");


// searching
console.log("indexOf() lets you test to see if a string exists, it will give you the index of the start.  It returns -1 if not found");
console.log("This is my string indexOf('my') : " + "This is my string".indexOf("my") + "\n");


// regex
console.log("JavaScript supports regular expressions with match:");
//select integers only
var intRegex = /[0-9 -()+]+$/;  

var myNumber = '999';
var myInt = myNumber.match(intRegex);
console.log("Is 999 an int? " + myInt);

myString = 'banana';
var myInt = myString.match(intRegex);
console.log("How about banana, is that an int? " + myInt + "\n");


// replacement
console.log("JavaScript does replacements as well:");
console.log("'I love columbus'.replace('columbus', 'cleveland') : " + 'I love columbus'.replace('columbus', 'cleveland') + "\n");


console.log("We can also split on any character into an array: ");
console.log("100 Maple St., Akron, OH, 44311");

var words = "100 Maple St.,Akron,OH,44311".split(",");
console.log(words[0]);
console.log(words[1]);
console.log(words[2]);
console.log(words[3]);



