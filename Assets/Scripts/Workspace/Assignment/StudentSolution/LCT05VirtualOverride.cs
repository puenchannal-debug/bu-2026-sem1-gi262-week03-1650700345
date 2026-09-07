using UnityEngine;


namespace Assignment.StudentSolution.LCT05
{
    public class Animal
    {
        // 0. make MakeSound method to virtual method
        public virtual void MakeSound()
        {
            Debug.Log("Generic animal sound");
        }
    }

    public class Dog : Animal
    {
        // student code here ...
        // 1. declare overridden MakeSound() method

        public override void MakeSound()
        {
            Debug.Log("Dog: Woof!");
        }
    }

    public class Cat : Animal
    {
        // student code here ...
        // 2. declare overridden MakeSound() method

        public override void MakeSound()
        {
            Debug.Log("Cat: Meow!");
        }
    }



    public class LCT05VirtualOverride
    {
        public void Start()
        {
            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();

            Animal animal = new Animal();
            animal.MakeSound();
        }
    }
}
