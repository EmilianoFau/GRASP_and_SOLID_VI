using System;
namespace Full_GRASP_And_SOLID;

public class RecipeTimer : TimerClient
{
    public Recipe Recipe {get; set;}
    public RecipeTimer(Recipe recipe)
    {
        this.Recipe = recipe;
    }
    public void InitializeTimer()
    {
        CountdownTimer timer = new CountdownTimer();
        timer.Register(Recipe.GetCookTime(), this);
    }
    public void TimeOut()
    {
        Recipe.Cooked = true;
    }
}