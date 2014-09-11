using Microsoft.AspNet.Mvc;

public class ValuesController : Controller
{
    // GET /values
    public string Get()
    {
        return "Values";
    }

    // GET /values/1
    public string Get(int id)
    {
        return "Value " + id.ToString();
    }

    // POST /values
    public ActionResult Post()
    {
        return new HttpStatusCodeResult(201);
    }
}    