﻿using IMS.Infrastructure.IRepository;
using IMS.Models.Entity;
using IMS.web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IMS.web.Controllers
{
   // [Authorize]
    public class StoreInfoController : Controller
    {
        private readonly ICrudService<StoreInfo> _storeCrudService;
        private readonly UserManager<ApplicationUser> _userManager;
        public StoreInfoController(ICrudService<StoreInfo> storeCrudService)
        {
            _storeCrudService = storeCrudService;
        }

        public async Task<IActionResult> AllStore()
        {
            var storeInfoList = await _storeCrudService.GetAllAsync();
            return View(storeInfoList);
        }

        [HttpGet]

        public async Task<IActionResult> ManageStore(int id)
        {
            StoreInfo storeInfo = new StoreInfo();
            if (id > 0)
            {
                storeInfo = await _storeCrudService.GetAsync(id);
            }

            return View(storeInfo);
        }

        [HttpPost]
        public async Task<IActionResult> ManageStore(StoreInfo storeInfo)
        {
            /*var userId = _userManager.GetUserId(HttpContext.User);*/
            if (storeInfo.Id == 0)
            {
                storeInfo.CreatedDate = DateTime.Now;
                storeInfo.CreatedBy = "";
                await _storeCrudService.InsertAsync(storeInfo);
                TempData["success"] = "Data Added Successfully..";
            }
            else
            {
                var OrgStoreInfo = await _storeCrudService.GetAsync(storeInfo.Id);
                OrgStoreInfo.StoreName = storeInfo.StoreName;
                OrgStoreInfo.Address = storeInfo.Address;
                OrgStoreInfo.PhoneNumber = storeInfo.PhoneNumber;
                OrgStoreInfo.PanNo = storeInfo.PanNo;
                OrgStoreInfo.RegistrationNo = storeInfo.RegistrationNo;
                OrgStoreInfo.IsActive = storeInfo.IsActive;
                OrgStoreInfo.UpdatedDate = DateTime.Now;
                OrgStoreInfo.UpdatedBy = storeInfo.UpdatedBy;
                await _storeCrudService.UpdateAsync(storeInfo);
                TempData["success"] = "Data Updated Successfully..";
            }
            return RedirectToAction(nameof(AllStore));
        }


    }
}
