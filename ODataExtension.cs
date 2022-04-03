using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace ODataWebAPI
{
    public static class ODataExtension
    {
        public   static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Book>("Books");
            builder.EntitySet<Press>("Presses");
            return builder.GetEdmModel();
        }
    }
}
