using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        
        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            //ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);

            List<Dictionary<string, string>> searchResults;

            // Fetch results
            if (searchType == "all")
            {
                ViewBag.jobs = JobData.FindByValue(searchTerm);
                return View("Index");
            }

            else 
            {
                /*
                List<string> values = new List<string>();

                foreach (Dictionary<string, string> job in ViewBag.Jobs)
                {
                    foreach (KeyValuePair<string, string> column in ViewBag.jobs)
                    {
                        if (!values.Contains(job[searchTerm]))
                        {
                            values.Add(job[searchTerm]);
                        }
                    }
                }
                */
                 ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
                 return View("Index");

            }
            


        }

        

    }
}

            