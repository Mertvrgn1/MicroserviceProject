using MicroserviceProject.Catalog.Api.Features.Categories.Create;

namespace MicroserviceProject.Catalog.Api.Features.Categories
{
    public static class CategoryEndpointExtension
    {
        public static void AddCategoryGroupEndpointExtenison(this WebApplication app)
        {
            app.MapGroup("api/categories").CreateCategoryGroupItemEndpoint();
        }
    }
}
