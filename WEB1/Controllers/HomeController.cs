using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB1.Models;

namespace WEB1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ContactModel model = GetData().Contacts;

            return View(model);
        }

        public ActionResult Catalog()
        {
            List<ItemModel> items = GetData().Items;

            return View(items);
        }

        public ActionResult Buy(string name)
        {
            ItemModel item = null;
            foreach(ItemModel m in GetData().Items)
            {
                if(m.Name == name)
                {
                    item = m;
                    break;
                }
            }

            if(Session["preces"] == null)
            {
                Session["preces"] = new List<ItemModel>();
            }
            (Session["preces"] as List<ItemModel>).Add(item);

            return RedirectToAction("Catalog");
        }

        public static ShopModel GetData()
        {
            return new ShopModel()
            {
                ShopName = "JZ shop",
                Contacts = new ContactModel()
                {
                    Phone = "22113344",
                    Mail = "jz@inbox.lv",
                    Location = new AdressModel()
                    {
                        Country = "Latvija",
                        City = "Rīga",
                        Street = "Ganu iela",
                        HouseNo = "54",
                        AppartmentNo = 23,
                    }
                },
                Items = new List<ItemModel>()
                {
                    new ItemModel()
                    {
                        Name = "Mobilais",
                        Price = new PriceModel()
                        {
                            Amount = 550,
                            Currency = "$",
                        }
                    },
                     new ItemModel()
                    {
                        Name = "TV",
                        Price = new PriceModel()
                        {
                            Amount = 950,
                            Currency = "$",
                        }
                    },
                      new ItemModel()
                    {
                        Name = "Auto",
                        Price = new PriceModel()
                        {
                            Amount = 15000,
                            Currency = "$",
                        }
                    },
                       new ItemModel()
                    {
                        Name = "Bikses",
                        Price = new PriceModel()
                        {
                            Amount = 65,
                            Currency = "$",
                        }
                    },
                        new ItemModel()
                    {
                        Name = "Cepure",
                        Price = new PriceModel()
                        {
                            Amount = 25,
                            Currency = "$",
                        }
                    },
                }
            };
        }
    }
}