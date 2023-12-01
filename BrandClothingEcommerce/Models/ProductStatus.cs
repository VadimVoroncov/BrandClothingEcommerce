using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrandClothingEcommerce.Models
{
    public enum ProductStatus
    {
        // В товарах
        inGoods = 1,
        // Нет в наличии
        isOutOfStock = 2,
        // Ошибка при добавлении
        errorWhenAdding = 3
    }
}
