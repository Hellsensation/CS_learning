namespace Lesson_7;

using static Methods;
class Program
{
    static void Main(string[] args)
    {
        Ferm ferm = new Ferm();

        Cow cow1 = new Cow(satiety:20, sex: "male" );
        Cow cow2 = new Cow(satiety:20, sex: "female" );
        ferm.cows.Add(cow1);
        ferm.cows.Add(cow2);

        Chicken chicken1 = new Chicken(satiety: 20, sex: "male");
        Chicken chicken2 = new Chicken(satiety: 20, sex: "female");
        ferm.chickens.Add(chicken1);
        ferm.chickens.Add(chicken2);


        Pig pig1 = new Pig(satiety: 20, sex: "male");
        Pig pig2 = new Pig(satiety: 20, sex: "female");
        ferm.pigs.Add(pig1);
        ferm.pigs.Add(pig2);


        ferm.AnimalFeeding();
        ferm.GetEatFromAnimals();
        ferm.AnumalMating();
        ferm.AnimalCount();
    }
}
