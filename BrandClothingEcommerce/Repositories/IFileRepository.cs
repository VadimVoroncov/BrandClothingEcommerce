namespace BrandClothingEcommerce.Repositories
{
    public interface IFileRepository
    {
        Tuple<int, string> SaveImage(IFormFile imageFile);
        public bool DeleteImage(string imageFileName);

    } 
}