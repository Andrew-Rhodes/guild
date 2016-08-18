var person = {
	name: "Victor",
	city: "Avon Lake",
	state: "OH"
};

var jsonText = JSON.stringify(person, ["name", "state"]);

//alert(jsonText);

var newPerson = JSON.parse(jsonText);

//alert(newPerson.city);

var movie = {
	title: "Ghostbusters",
	actors: [
		"Bill Murray",
		"Dan Aykroyd"
	],
	year: 1985,
	toJSON: function (){
		return { title: this.title, actors: this.actors};
	}
};

alert(JSON.stringify(movie));