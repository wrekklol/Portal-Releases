public class ExampleBehaviour : IScriptBehaviour
{
    public string BehaviourName => "ExampleBehaviour";

    public void Init()
    {
        Print("Hello from Behaviour Initialization!");
    }

    public void Run()
    {
        Print("Hello from Behaviour Run!");

        // Finds a template from your "Templates" folder in your module folder, and clicks it!
        //WaitUntilFound("Example Template")?.Draw().Click();
    }
}
