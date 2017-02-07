using System.Linq;
using System.Web.Http.ModelBinding;

namespace DotNetLearningService.Helpers
{
    public static class ErrorMessageForKey
    {
        public static string GetErrorMessageForKey(this ModelStateDictionary dictionary, string key)
        {
            return dictionary[key].Errors.First().ErrorMessage;
        }
    }
}