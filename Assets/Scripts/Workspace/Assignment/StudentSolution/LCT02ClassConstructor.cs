using UnityEngine;



// SKIP Lecture ...
namespace Assignment.StudentSolution.LCT02
{
    public class Dog
    {
        // properties including name, breed, age ...

        public string name;
        public string breed;
        public int age;

        // end of properties ...

        // สร้าง constructor ที่รับ parameter 3 ตัว และกำหนดค่าให้กับ properties ของ class
        // โดยทั้ง 3 parameter คือ name, breed, age ตามลำดับ
        public Dog(string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        /// behaviors ...

        public void Bark()
        {
            Debug.Log($"{name}: Woof!");
        }

        public void WagTail()
        {
            Debug.Log($"{name} is wagging its tail.");
        }

        public void StopBarking()
        {
            Debug.Log($"{name} stopped barking.");
        }

        // end of behaviors ...
    }

    public class LCT02ClassConstructor
    {
        Dog dog1;

        public void Start()
        {
            // สร้าง object dog1 ของ class Dog โดยใช้ constructor ที่รับ parameter 3 ตัว
            // และกำหนดค่าให้กับ properties ของ object นั้น
            // กำหนดให้ name = "Buddy", breed = "Golden Retriever", age = 3

            // Student code starts HERE ...
            dog1 = new Dog("Buddy", "Golden Retriever", 3);

            // ...
            // Student code ends HERE ...

            // เรียกใช้ method ของ object นั้น

            dog1.Bark();
            dog1.WagTail();
            dog1.StopBarking();
        }
    }
}
