using System;

namespace HelloEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Level = Level.Employee;

            Person boss = new Person();
            boss.Level = Level.Boss;

            Console.WriteLine(boss.Level > person.Level);
            Console.WriteLine((int)Level.Employee);
            Console.WriteLine((int)Level.Manager);
            Console.WriteLine((int)Level.Boss);
            Console.WriteLine((int)Level.BigBoss);
        }
        enum Level
        {
            //如果枚举没有赋值就是从0开始，如果赋值了下一个枚举变量就是上一个赋值的枚举值加1
            Employee=100,
            Manager,
            Boss=200,
            BigBoss
        }
        class Person
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public Level Level { get; set; }
        }
    }
}
