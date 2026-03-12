namespace StructLearning
{
    struct Student
    {
        public string name;
        public int age;
        public int classes;
        public string major;

        public Student()
        {
            name = "Li";
            age = 18;
            classes = 1;
            major = "Software Engineering";
        }

        public Student(string name, int age, int classes, string major)
        {
            this.name = name;
            this.age = age;
            this.classes = classes;
            this.major = major;
        }

        public void PrintThing()
        {
            Console.WriteLine($"{name},{age},{classes},{major}");
        }
    }

    struct Rectangle
    {
        public double row;
        public double col;
        public double area;
        public double perimeter;

        public Rectangle(int row, int col)
        {
            this.row = row;
            this.col = col;
            area = row * col;
            perimeter = 2 * (row + col);
        }

        public void Print2()
        {
            Console.WriteLine($"{row},{col},{area},{perimeter}");
        }
    }

    struct Aotuman
    {
        public string name;
        public int hp;
        public int atk;
        public int def;

        public Aotuman(string name, int hp, int atk, int def)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
        }

        public void Atk(ref Monster monster)
        {
            monster.hp -= atk - monster.def;
            Console.WriteLine($"Monster = {monster.hp}");

        }

        //public int Def(ref Monster monster)
        //{
        //    hp -= def < monster.atk ? monster.atk - monster.def : 0;
        //    return monster.hp;
        //}
    
    }

    struct Monster
    {
        public string name;
        public int hp;
        public int atk;
        public int def;

        public Monster(string name, int hp, int atk, int def)
        {
            this .name = name;
            this .hp = hp;
            this .atk = atk;
            this .def = def;
        }

        public void Atk(ref Aotuman aotuman)
        {
            aotuman.hp -= atk - aotuman.def;
            Console.WriteLine($"Aotuman = {aotuman.hp}");

        }

        //public int Def(ref Aotuman aotuman)
        //{
        //    hp -= def < aotuman.atk ? aotuman.atk - aotuman.def : 0;
        //    return aotuman.hp;
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Student st1;
            //Student st2;
            //st1 = new Student("Alice", 18, 1, "ff7");
            //st2 = new Student();
            //st1.PrintThing();
            //st2.PrintThing();

            //Rectangle rec = new Rectangle(4, 5);
            //rec.Print2();

            Random r = new Random();
            Aotuman aotuman = new Aotuman("Alice", 10, r.Next(4,6), 3);
            Monster monster = new Monster("Leix",10, r.Next(4, 5), 3);
            while (true)
            {
                aotuman.Atk( ref monster);
                if (monster.hp <= 0)
                {
                    Console.WriteLine($"{aotuman.name}win");
                    break;
                }

                monster.Atk(ref aotuman);
                if (aotuman.hp <= 0)
                {
                    Console.WriteLine($"{monster.name}win");
                    break;
                }
                Console.ReadKey(true);
            }
        }
    }
}
