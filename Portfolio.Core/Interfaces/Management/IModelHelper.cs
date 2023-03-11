namespace Portfolio.Core.Interfaces.Management
{
    public interface IModelHelper
    {
        string GetModelFields<T>();
        string ValidateModelFields<T>(string fields);
    }
}
