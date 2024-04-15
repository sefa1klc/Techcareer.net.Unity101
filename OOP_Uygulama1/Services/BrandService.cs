using OOP_Uygulama1.Exceptions;
using OOP_Uygulama1.Models;
using OOP_Uygulama1.Repository;

namespace OOP_Uygulama1.Services.Converter;

public class BrandService
{
    private BrandRepository _brandRepository;

    public BrandService()
    {
        _brandRepository = new BrandRepository();
    }

    public void GetAll()
    {
        List<Brand> brands = _brandRepository.GetAll();
        brands.ForEach(x => Console.WriteLine(x));
    }

    public void Add(Brand brand)
    {
        _brandRepository.Add(brand);
        
        Console.WriteLine($"Brand eklendi : \n {brand}");
    }

    public void GetById(int id)
    {
        try
        {
            Brand brand = _brandRepository.GetById(id);
            Console.WriteLine(brand);
        }
        catch (NotFoundException ex)
        {
            Console.WriteLine("Bir NotFoundException yakalandı.");
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _brandRepository.Delete(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bir NotFoundException yakalandı.");
            Console.WriteLine(ex.Message);
        }
    }
}