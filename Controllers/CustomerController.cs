using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

public class CustomerController : Controller
{
    public JsonResult Get()
    {
        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer(1, "André", "Baltieri"));
        return Json(customers);
    }
}    
