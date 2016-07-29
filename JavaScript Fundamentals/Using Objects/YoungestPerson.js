"use strict";

function solve(args) {
    var values = args,
        N = values.length,
        i,
        j = 0,
        persons = [];

    function personBuild(fName, lName, age) {
        var person = {
            firstName: fName,
            lastName: lName,
            age: +age,
            fullname: function () {
                return fName + ' ' + lName;
            }
        };

        return person;
    }



    for(i = 0; i < values.length; i += 3) {
        persons[j] = personBuild(values[i], values[i + 1], values[i + 2]);
        j += 1;
    }

    var minAge = persons[0].age,
        index = 0;

    for(i = 1; i < persons.length; i += 1) {
        if (minAge > persons[i].age) {
            minAge = persons[i].age;
            index = i;
        }
    }
    
    console.log(persons[index].fullname());
}

solve([
  'Gosho', 'Petrov', '32',
  'Bay', 'Ivan', '42',
  'John', 'Doe', '42'
]);