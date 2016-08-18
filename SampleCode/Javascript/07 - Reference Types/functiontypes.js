function sum(num1, num2){
	return num1 + num2;
}

var anothersum = sum;

sum = null;

console.log(anothersum(20, 30));

var pets = [
{ name: 'Woot', type: 'dog', age: 8},
{ name: 'Angry Cat', type: 'cat', age: 14},
{ name: 'Dash', type: 'dog', age: 7},
{ name: 'Pi', type: 'parrot', age: 2}
];

var dogs = pets
	.filter(function (notapet) {
		return notapet.type === 'dog';
	})
	.map(function (pet) {
		return pet.name;
	});

/*var TotalDogYears = pets
	.filter(function (notapet) {
		return notapet.type === 'dog';
	})
	.map(function (pet) {
		return pet.age;
	})
	.reduce(function (runningTotal, age) {
		return (runningTotal || 0) + age;
	});*/


var TotalDogYears = pets
	.filter((notapet) => notapet.type === 'dog')
	.map((pet) => pet.age)
	.reduce((runningTotal, age) => (runningTotal || 0) + age);

	
	
console.log(dogs);
console.log(TotalDogYears);