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

            person.Skill = Skill.Drive | Skill.Cook | Skill.Program | Skill.Teach;
            //打印出来的值是累加的15，这是枚举的比特位用法
            Console.WriteLine(person.Skill);
            //看一个人是否具备煮饭功能
            Console.WriteLine((person.Skill & Skill.Cook)> Skill.Cook);
        }
        enum Level
        {
            //如果枚举没有赋值就是从0开始，如果赋值了下一个枚举变量就是上一个赋值的枚举值加1
            Employee=100,
            Manager,
            Boss=200,
            BigBoss
        }
        enum Skill
        {
            Drive = 1,
            Cook = 2,
            Program =4,
            Teach = 8,
        }
        class Person
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public Level Level { get; set; }
            public Skill Skill { get; set; }
        }
    }
}
