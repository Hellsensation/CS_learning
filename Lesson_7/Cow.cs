using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_7
{
    internal class Cow
    {
        public string? Sex { get; set; }
        public string? Name { get; set; }
        public int? Satiety { get; set; }
        public int? _milk {  get; private set; }
        
        public Cow(int satiety,  string sex)
        {
            Sex = sex;
            Satiety = satiety;
        }

        enum CowSex
        {
            male = 0,
            female = 1
        }
        

        public void ToEat(int food)
        {
            Satiety += food;
            _milk += 1;
            Program.Print($"Дали корове поесть\nУровень сытости:{Satiety}\nКол-во молока: {_milk} литров", ConsoleColor.DarkGreen);
        }

        public void GiveMilk ()
        {
            _milk -= 1;
            Program.Print($"Подоили корову\nКол-во молока: {_milk} литров", ConsoleColor.Green);
        }

        public Cow DoSex(Cow cow)
        {
            Random random = new Random();
            random.Next(cow);
            if(cow.Sex != Sex)
            {
                Cow newCow = new Cow(satiety: 10, sex: CowSex);
                Program.Print($"Коровы переспали и на свет появился теленок!", ConsoleColor.Yellow);
                return newCow;
            }
            return null;
        }

    }
}
