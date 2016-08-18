// This is what a function looks like:

var isEven = function (number) {
    var val = number % 2;
    return val == 0;
};

console.log("Are these even?");
console.log("96 : " + isEven(96));
console.log(" 7 : " + isEven(7));
console.log("23 : " + isEven(23));