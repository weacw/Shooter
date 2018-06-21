public class RenderFeature : Feature
{
    public RenderFeature(Contexts context)
    {
        Add(new CreateCharacterSystem(context));
    }
}
