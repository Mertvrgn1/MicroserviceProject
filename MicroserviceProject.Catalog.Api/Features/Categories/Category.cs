using MicroserviceProject.Catalog.Api.Features.Courses;
using MicroserviceProject.Catalog.Api.Repository;

namespace MicroserviceProject.Catalog.Api.Features.Categories
{
    public class Category : BaseEntiy
    {
        public string Name { get; set; } = default!;
        public List<Course>? Courses { get; set; }
    }
}
