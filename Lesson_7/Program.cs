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

        ferm.AnimalFeeding();
        ferm.GetEatFromAnimals();
        ferm.AnumalMating();



    }




}
