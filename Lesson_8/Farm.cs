using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8;

class Farm
{
    public List<Cow> cows = [];
    public List<Chicken> chickens = [];
    public List<Pig> pigs = [];

    public EventHandler<AnimalActionsArgs> AnimalAction ;

    public void GiveFood(int num)
    {
        AnimalAction.Invoke(this, new AnimalActionsArgs()
        {
            Action = ActionTypes.GiveFood,
            Value = num,

        });
    }
}


enum ActionTypes
{
    GiveFood,
    GiveOffspring
    
}


class AnimalActionsArgs : EventArgs
{
    public int Value { get; set; }
    public ActionTypes Action { get; set; }
}

