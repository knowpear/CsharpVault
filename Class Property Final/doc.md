## 類的屬性
- 在C#中，属性是一种用于访问和设置对象成员变量的语法。您可以使用自动属性和手动字段来实现属性。以下是自动属性和手动字段的区别：
    - 自动属性：自动属性是一种简化的属性语法，它使用{get; set;}来自动实现属性的getter和setter方法。在使用自动属性时，编译器会自动为您生成一个私有的字段来存储属性的值。例如：public string Name { get; set; }。
    - 手动字段：手动字段是一种手动实现的字段，您需要手动实现getter和setter方法来访问和设置该字段的值。例如：private string name; public string GetName() { return name; } public void SetName(string value) { name = value; }。
- 因此，自动属性和手动字段是不同的语法和用途，您可以根据需要选择使用哪种语法来实现属性。如果您只需要一个简单的属性来访问和设置成员变量的值，则可以使用自动属性。如果您需要更复杂的逻辑来访问和设置成员变量的值，则可以使用手动字段和自定义getter和setter方法。