public class NewBehaviour : IScriptBehaviour
{
    public string BehaviourName => "NewBehaviour";

    public void Init()
    {
        Print("Hello from Behaviour Initialization!");
    }

    public void Run()
    {
        Print("Hello from Behaviour Run!");

        // Finds a template from your "Templates" folder in your module folder, and click it!
        //WaitUntilFound("Your Template Name Here")?.Draw().Click();
    }
}
