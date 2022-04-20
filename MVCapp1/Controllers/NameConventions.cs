using Microsoft.AspNetCore.Mvc.ApplicationModels;
public class NameConventions : IControllerModelConvention
{
    public string Name { set; get; } = "Maks";
    public void Apply(ControllerModel controller)
    {
        controller.ControllerName = controller.ControllerName.Replace($"Controller{Name}", string.Empty);
    }
}