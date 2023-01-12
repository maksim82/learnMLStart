using list;
using System.Collections;

ArrayList list = new ArrayList();
list.Add(new Person("maks", 12).toaString());
list.Add(new Person("any", 17).toaString());
list.Add(new Person("adrian", 16).toaString());
list.Add(new Person("alex", 5).toaString());
list.Add(new Person("joj", 10).toaString());
list.Add(new Person("mark", 22).toaString());
list.Add(new Person("mari", 19).toaString());
list.Add(new Person("gabe", 43).toaString());

foreach (object o in list)
{
    Console.WriteLine(o);
}