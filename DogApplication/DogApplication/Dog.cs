using System;
using System.Collections.Generic;
using System.Text;

namespace DogApplication
{
    class Dog
    {
        // access modifiers
        // public - everyone can see
        // internal - everyone in the same assembly (aka project) can see
        // protected - everyone who is a subclass of dog can see( even if it is in another project)
        // private - only this class can see

        //for class members, private is default.
        //(for classes, internal is default - only public and internal are possible

        //constructor
        //there is always at least one constructor
        // -- if you don't write one, you get a default one like "Dog()()" (zero param, zero extra behavior)

        public Dog(string name, int age)
        {
            //within a class , "this" is a way to refer to current instacne of that class
            
            this.name = name;
            if(age < 0)
            {
                throw new ArgumentOutOfRangeException();
                // an exception is how we represent and handle "errors" during runtime
            }
            this.age = age;
        }

        //fields
        private int age;
        private string name;

        // property
        //public int Age { get; set; }
        //this is an "auto property"

        public int Age
        {
            get
            {
                return age; // the backing fiels of the property
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                age = value;
            }
        }



        //better than public fields, is getter and setter methods like java
        //but better than than that is properties

        public string GetName()
        {
            return name;
        }

        public void SetName()
        {
            //validation goes here - this is public, field is private
            //all the consumers of this class don't have to worry about validating their changes to fields

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            this.name = name;
        }
    }
}
