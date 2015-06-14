using OneIndiaInfo.Interfaces.APIClient;
using OneIndiaInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneIndiaInfo.Controllers
{
    public class PincodeController : Controller
    {
         private IOpenDataDistrictClient _districtClient;
         private IOpenDataPostOfficeClient _postOfficeClient;
        // GET: Question
        public PincodeController()
        { }
        public PincodeController(IOpenDataDistrictClient DistrictClient, IOpenDataPostOfficeClient PostOfficeClient)
        {
            _districtClient = DistrictClient;
            _postOfficeClient = PostOfficeClient;
        }
        // GET: Pincode
        public ActionResult Index()
        {
            var model = new HomePageViewModel() {SelectedPostOfficeDetail = new PostOfficeDetail()};
            return View(model);
        }


        [HttpPost]
        public JsonResult GetDistricts(string StateCode)
        {
           
            var distr = _districtClient.GetDistricts(StateCode);
            return Json(distr, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetPostOffices(string DistrictName)
        {
            var postOffices = _postOfficeClient.GetPostOffices(DistrictName);
            return Json(postOffices, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public PartialViewResult GetPostOfficeDetil(string PostOfficeId)
        {
            var postOfficeDetail = _postOfficeClient.GetPostOfficeDetail(Convert.ToInt32(PostOfficeId));
            return PartialView("PostOfficeDetailPartial", postOfficeDetail);

        }

        [HttpPost]
        public PartialViewResult GetPostOfficeDetilByPincode(string Pincode)
        {
            var postOfficeDetail = _postOfficeClient.GetPostOfficeDetilByPincode(Pincode);
            return PartialView("PostOfficeDetailPartial", postOfficeDetail);

        }
        
    }
}