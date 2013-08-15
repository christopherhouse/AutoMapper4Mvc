AutoMapper4Mvc

AutoMapper4Mvc is a small project that contains a couple of useful features for working with AutoMapper in ASP.Net MVC and Web API
projects.  

Attributes

AutoMapper4Mvc contains attributes that can be used to map a model returned by an MVC or Web API action to another type.  This
capability allows you to keep dependencies on AutoMapper and mapping code out of your controller.

Profile Loader

The ProfileLoader class contains a couple of methods that are useful for declaratively loading AutoMapepr profiles in your MVC application.
ProfileLoader.LoadProfiles is a static method that accepts an instance of a class that implements IProfileLoadStrategy.  AutoMapepr4Mvc contains
a couple of implementations of IProfileLoadStrategy:

	AllLoadedAssembliesStrategy - this class loads profiles in all currently loaded assemblies

	AssemblyListLoadStrategy - this class allows you to pass a list of specific assemblies that should be scanned for profiles

	RegexMatchAssemblyLoadStrategy - this class accepts a regex string that is used to match assembly names.  Matching assemblies will be scanned profiles

Examples

MVC Attribute

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

Web API Attribute

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

Profile Loader

    public class MvcApplication : System.Web.HttpApplication
	{
	  protected void Application_Start()
	  {
	    // Other code ommited
		ThirteenDaysAWeek.AutoMapper4Mvc.Configuration.ProfileLoader.LoadProfiles();
	  }
	}

In this example, all AutoMapper profiles contained in the web application and any assemblies it
references will be loaded at application start.