using Portfolio.Core.Interfaces.Management;
using System.Reflection;

namespace Portfolio.Infrastructure.Common.Helpers
{
    public class ModelHelper : IModelHelper
    {
        public string GetModelFields<T>()
        {
            var retString = string.Empty;
            var bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
            var listFields = typeof(T).GetProperties(bindingFlags).Select(f => f.Name).ToList();

            foreach (string field in listFields)
                retString += field + ",";

            return retString;
        }
        public string ValidateModelFields<T>(string fields)
        {
            var retString = string.Empty;
            var bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public;
            var listFields = typeof(T).GetProperties(bindingFlags).Select(f => f.Name).ToList();
            var arrayFields = fields.Split(',');

            foreach (var field in arrayFields)
            {
                if (listFields.Contains(field.Trim(), StringComparer.OrdinalIgnoreCase))
                    retString += field + ",";
            };

            return retString;
        }
    }
}
