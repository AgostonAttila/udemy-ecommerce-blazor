namespace BlazorEcommerce.Server.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {           
            return new ServiceResponse<List<Category>>()
            {
                Data = await _context.Categories.ToListAsync()
            }; ;
        }

        public Task<ServiceResponse<Product>> GetCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
