//#### chatGPT here's a simple example of a hidden method in C#:
namespace Class_Hidden_Method
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class Dog : Animal
    {
        public new void MakeSound() //Hidden Method, 用new 聲明
        {
            Console.WriteLine("Dog barks");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //#### 基本用法
            Dog dog = new Dog();
            dog.MakeSound(); //Output: "Dog barks"

            //#### 雜交用法
            Animal dog2 = new Dog();
            
            dog2.MakeSound(); //Output: "Animal makes a sound"

            ((Dog)dog2).MakeSound(); //Output: "Dog barks" //rote死記硬背
             //we use type casting to cast the Animal variable back to a Dog variable using the syntax ((Dog)dog2).
             //This allows us to call the hidden MakeSound method in the Dog class explicitly, which outputs the specific sound for dogs.
        }
    }
}