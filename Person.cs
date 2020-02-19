using System;

namespace Persons

{
class Person {
    private string name;       //atributo
    
    static public string bloodColor = "red";

    public Person(string name) {           //Esto es el metodo contructor : modificador de acceso- public , private / 

        this.name = name;

    }

    public void SayHello (){
        Console.WriteLine("Hello, my name is " + this.name );
    }

    static public void PrintRace () {
        Console.WriteLine("Human");

    }
}

}