using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Directory.Service;

namespace Directory.Web.Controllers
{
    public class ProvinceController : Controller
    {
        private readonly IProvinceService _provinceService;
        //
        // GET: /Province/

        public ProvinceController(IProvinceService province)
        {
            _provinceService = province;
        }

        public ActionResult Index()
        {

            return View(_provinceService.List());
        }

        public ActionResult Create()
        {
            return View(new Province());
        }

        [HttpPost]
        public ActionResult Create(Province province)
        {
            _provinceService.Save(province);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(Province province)
        {
            _provinceService.Save(province);
            return RedirectToAction("Index");
        }

        public ActionResult Detail(int id)
        {
            return this.View(_provinceService.Get(id));
        }

        public ActionResult Delete(int id)
        {
            var province = _provinceService.Get(id);
            _provinceService.Delete(province);
            return RedirectToAction("Index");
        }
    }
}