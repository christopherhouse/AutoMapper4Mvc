#AutoMapper4Mvc

This is a small project that contains MVC and Web API ActionFilter attributes for invoking AutoMapper after controller actions execute.
This enables an MVC or Web API controller action to return a model of one type and to have that model transformed to another type via
AutoMapper.  Since AutoMapper is invoked in the attribute, your controller doesn't have any mapping code and doesn't have a dependency
on AutoMapper.


##Examples

###MVC

    public class HomeController : Controller
    {
      private readonly IProductService _productService;
      
      [AutoMap(typeof(ProductCollection), typeof(ProductListViewModel))]
      public ActionResult Index()
      {
	    return View(_productService.GetProductList());
      }
    }

In the above example, the view for this controller action would receive a model
of type ProductListViewModel

###Web API

    public class ProductsController : ApiController
    {
      private readonly IProductService _productService;
      
      [AutoMap(typeof(ProductCollection), typeof(List<Product>))]
      public ProductCollection Get()
      {
        return _productService.GetProductList();
      }
    }

In this example, a client that calls /products would receive a List<Product> response.