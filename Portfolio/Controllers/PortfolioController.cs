using Microsoft.AspNetCore.Mvc;
using Portfolio.Context;
using Portfolio.Models;
using Portfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {

        /// <summary>
        /// Tüm portföy verileri bu action altında dolduruluyor
        /// </summary>
        /// <returns></returns>
        public ActionResult Portfolio()

        {
            using (var context = new PortfolioContext())
            {
                About about = context.Abouts.FirstOrDefault();
                List<Experiences> experiences = context.Experiences.ToList();
                List<Education> educations = context.Educations.ToList();
                List<Skills> skills = context.Skills.ToList();
                PortfolioBaseViewModel portfolioBaseViewModel = new PortfolioBaseViewModel();
                portfolioBaseViewModel.About = about;
                portfolioBaseViewModel.Experiences = experiences;
                portfolioBaseViewModel.Educations = educations;
                portfolioBaseViewModel.Skills = skills;
                return View(portfolioBaseViewModel);

            }
        }
    }
}
