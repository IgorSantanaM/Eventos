
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Events.IO.Application.ViewModels
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }


        public SelectList Categories()
        {
            return new SelectList(ListCategories(), "Id", "Name");
        }
        public List<CategoryViewModel> ListCategories()
        {
            var categoriesList = new List<CategoryViewModel>()
            {
                new CategoryViewModel(){Id = new Guid("0775e665-e24d-48f6-b18a-c1a10b6cd5b9"), Name = "Congress"},
                new CategoryViewModel(){Id = new Guid("c084b340-80eb-4ecd-968f-b6891c6c6beb"), Name =  "MeetUp"},
                new CategoryViewModel(){Id = new Guid("a0ef4c04-cf75-4732-b6ee-47fecd440742"), Name =  "WorkShop"}
            };
            return categoriesList;
        }
    }
}
