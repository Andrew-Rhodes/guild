//alert("Hello");

var myObj = new Object();
myObj.Width = 150;
myObj.Height = 200;
myObj.MyRandomProperty = "something";

myObj.Witdh = 200;

for (var prop in myObj){
	console.log(prop + " = " + myObj.prop);
}

var anotherObj = {
	Width : 150,
	Height : 200,
	MyRandomProperty : "something",
	Witdh : 200
};

if (myObj === anotherObj){
	console.log("They're equal");
}else{
	console.log("They're not equal");
}

var myObj2 = new Object();
myObj2.Width = 150;
myObj2.Height = 200;
myObj2.MyRandomProperty = "something";

myObj2.Witdh = 200;

if (myObj == myObj2){
	console.log("They're equal");
}else{
	console.log("They're not equal");
}

myObj3 = myObj;
if (myObj === myObj3){
	console.log("They're equal");
}else{
	console.log("They're not equal");
}