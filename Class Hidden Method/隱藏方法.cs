/*
#### Hidden Method隱藏方法
- 如果签名相同的⽅法在基类和派⽣类中都进⾏了声明，但是该⽅法没有分别声明为virtual和override，派⽣类就会隐藏基类⽅法
- 要使⽤new关键字进⾏声明
    - 不加new, 直接同名重寫也是隱藏方法
- we.隱藏方法和虛方法的區別
	- 隱藏方法只有在聲明的對象是子類對象的時候才會調用
	- 虛方法重寫override聲明對象是父類, 實例化時子類時也會調用該虛方法
- it's recommended to use virtual methods when you want to allow derived classes to customize the behavior of a method, and to use hidden methods sparingly, as they can sometimes lead to confusion and unexpected behavior.- chatGPT
 */
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

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat barks");
        }
    }

    internal class 隱藏方法
    {
        static void Main(string[] args)
        {
            //#### 基本用法
            Dog dog = new Dog();
            dog.MakeSound(); //Output: "Dog barks"

            //#### 雜交用法
            //1.雜交隱藏方法測試
            Animal dog2 = new Dog();
            
            dog2.MakeSound(); //Output: "Animal makes a sound"
            
            //2.雜交虛方法override測試
                //雜交方法中隱藏方法不起重寫作用, 而虛方法override起作用
            Animal cat = new Cat();
            cat.MakeSound(); //Output: "Cat barks"

            //3.雜交方法強制調用重寫syntax
            ((Dog)dog2).MakeSound(); //Output: "Dog barks" //rote死記硬背
             //we use type casting to cast the Animal variable back to a Dog variable using the syntax ((Dog)dog2).
             //This allows us to call the hidden MakeSound method in the Dog class explicitly, which outputs the specific sound for dogs.
        }
    }
}