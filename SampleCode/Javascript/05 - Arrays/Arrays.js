var myColors= ["blue", "red", "green", "brown"];
console.log(myColors + "\n");

var myNumbers = [5, 10, 15, 20];
console.log(myNumbers + "\n");

var myMixedArray = [5, "something", true, "orange"];
console.log(myMixedArray + "\n");

for (var i = 0; i < myColors.length; i++) {
    console.log("The color " + myColors[i] + " is at position " + i);
}

console.log("\n");

var letters = [];
letters.push("A");
letters.push("B", "C");
console.log(letters);
console.log(letters.pop());
console.log(letters);

var moreLetters = [];
moreLetters.unshift("A");
moreLetters.unshift("B", "C");
console.log(moreLetters);
console.log(moreLetters.shift());
console.log(moreLetters);