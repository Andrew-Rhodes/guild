var myArray = ['blue', 1, true];

DisplayArray(myArray);

myArray[5] = "new item";

DisplayArray(myArray);

var fruits = ["apple"]; // apple
fruits.push("orange");	// apple, orange
fruits.unshift("pear");	// pear, apple, orange

DisplayArray(fruits);

var fruits2 = fruits.concat("mango", "peach"); // pear, apple, orange, mango, peach

DisplayArray(fruits2);

var fruits3 = fruits2.slice(2, 5);

DisplayArray(fruits3);

function DisplayArray(myArray){
	console.log("Array length is " + myArray.length);

	for (var item in myArray){
		console.log(item + " - " + myArray[item]);
	}
	
	for (i = 0; i < myArray.length; i++){
		console.log(i + " - " + myArray[i]);
	}
}