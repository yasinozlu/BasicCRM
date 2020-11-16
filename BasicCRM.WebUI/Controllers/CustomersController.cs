using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCRM.Business.Abstract;
using BasicCRM.Core.Utilities.Results;
using BasicCRM.DataAccess.Concrete.EntityFramework;
using BasicCRM.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasicCRM.WebUI.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
     
        public IActionResult Index()
        {
            var result = _customerService.GetList();
            var obj = new List<Models.Customer>();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    var customer = new Models.Customer();
                    customer.CustomerId = item.CustomerId;
                    customer.CustomerName = item.CustomerName;
                    customer.CustomerSurname = item.CustomerSurname;
                    customer.CustomerPhone = item.CustomerPhone;
                    customer.CustomerAddress = item.CustomerAddress;
                    customer.RegistrationDate = item.RegistrationDate;
                    obj.Add(customer);
                }
                return View(obj);
            }
            return BadRequest(result.Message);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            var obj = new Models.Customer();
            if (result.Success)
            {
                obj.CustomerName = customer.CustomerName;
                obj.CustomerSurname = customer.CustomerSurname;
                obj.CustomerPhone = customer.CustomerPhone;
                obj.CustomerAddress = customer.CustomerAddress;


                return RedirectToAction("Index");
            }
            return BadRequest(result.Message);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var result = _customerService.GetById(id);
            var obj = new Models.Customer();
            if (result.Success)
            {
                obj.CustomerId = result.Data.CustomerId;
                obj.CustomerName = result.Data.CustomerName;
                obj.CustomerSurname = result.Data.CustomerSurname;
                obj.CustomerPhone = result.Data.CustomerPhone;
                obj.CustomerAddress = result.Data.CustomerAddress;
                obj.RegistrationDate = result.Data.RegistrationDate;

                return View(obj);
            }
            return BadRequest(result.Message);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var result = _customerService.GetById(id);
            var obj = new Models.Customer();
            if (result.Success)
            {
                obj.CustomerId = result.Data.CustomerId;
                obj.CustomerName = result.Data.CustomerName;
                obj.CustomerSurname = result.Data.CustomerSurname;
                obj.CustomerPhone = result.Data.CustomerPhone;
                obj.CustomerAddress = result.Data.CustomerAddress;
                obj.RegistrationDate = result.Data.RegistrationDate;

                return View(obj);
            }
            return BadRequest(result.Message);
        }
        [HttpPost, ActionName("Edit")]
        public IActionResult Update(Customer customer)

        { 
            var result = _customerService.Update(customer);
            
            if (result.Success)
            {
               
                return RedirectToAction("Index");
            }
            return BadRequest(result.Message);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var result = _customerService.GetById(id);
            var obj = new Models.Customer();
            if (result.Success)
            {
                obj.CustomerId = result.Data.CustomerId;
                obj.CustomerName = result.Data.CustomerName;
                obj.CustomerSurname = result.Data.CustomerSurname;
                obj.CustomerPhone = result.Data.CustomerPhone;
                obj.CustomerAddress = result.Data.CustomerAddress;
                obj.RegistrationDate = result.Data.RegistrationDate;

                return View(obj);
            }
            return BadRequest(result.Message);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
           
            var result = _customerService.Delete(id);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }
            return BadRequest(result.Message);
        }


    }
}
