using System.Web.Mvc;
using Directory.Service;
using Directory.Web.Models;

namespace Directory.Web.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IProvinceService _provinceService;

        public CityController(ICityService cityService, IProvinceService provinceService)
        {
            _cityService = cityService;
            _provinceService = provinceService;
        }

        //
        // GET: /City/
        public ActionResult Index()
        {
            return View(_cityService.List());
        }

        public ActionResult Create()
        {
            var provinces = _provinceService.List();
            ViewBag.Provinces = new SelectList(provinces, "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(CityViewModel cityViewModel)
        {
            var province = _provinceService.Get(cityViewModel.ProvinceId);
            var city = new City { Name = cityViewModel.Name };

            if (province != null)
                city.Province = province;

            _cityService.Save(city);
            return RedirectToAction("Index");

        }

        public ActionResult Details(int id)
        {
            var provinces = _provinceService.List();
            var city = _cityService.Get(id);
            ViewBag.Provinces = new SelectList(provinces, "Id", "Name", city.Province == null? null: city.Province.Name);

            var cityViewModel = new CityViewModel
            {
                Id = city.Id,
                Name = city.Name,
                ProvinceId = city.Province == null ? 0 : city.Province.Id
            };

            return View(cityViewModel);
        }

        public ActionResult Delete(int id)
        {
            var city = _cityService.Get(id);
            _cityService.Delete(city);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(CityViewModel cityViewModel)
        {
            var city = _cityService.Get(cityViewModel.Id);
            city.Name = cityViewModel.Name;
            var province = _provinceService.Get(cityViewModel.ProvinceId);

            if (province != null)
                city.Province = province;

            _cityService.Save(city);
            return RedirectToAction("Index");
        }
    }
}