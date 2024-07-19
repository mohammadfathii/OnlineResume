using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineResume.Data;
using OnlineResume.Models;
using OnlineResume.Models.ViewModels.Education;
using OnlineResume.Models.ViewModels.Experience;
using OnlineResume.Models.ViewModels.Language;
using OnlineResume.Models.ViewModels.PersonalData;

namespace OnlineResume.Controllers
{
	[Authorize]
	public class PanelController : Controller
	{
        private readonly AppDBContext context;

        public PanelController(AppDBContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
		{
			return View();
		}

		public IActionResult Experience()
		{
			var experiences = context.Experiences.ToList();

			return View(experiences);
		}


        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
		public IActionResult CreateExperience(CreateExperienceViewModel experience)
		{
            if (ModelState.IsValid == false)
            {
                return View(experience);
            }

            var exp = new Experience()
            {
                Title = experience.Title,
                Description = experience.Description,
                PersonalDataId = 1
            };

            context.Experiences.Add(exp);
            context.SaveChanges();

            return RedirectToAction("Experience");
        }


        public IActionResult RemoveExperience(int Id)
        {
            if (Id <= 0)
            {
                return RedirectToAction("Index");
            }

            var exp = context.Experiences.FirstOrDefault(e => e.Id == Id);

            if (exp == null)
            {
                return RedirectToAction("Index");
            }


            context.Experiences.Remove(exp);
            context.SaveChanges();

            return RedirectToAction("Index");
        }



        public IActionResult Education()
        {
            var educations = context.Educations.ToList();

            return View(educations);
        }


        public IActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEducation(CreateEducationViewModel education)
        {
            if (!ModelState.IsValid)
            {
                return View(education);
            }

            var educ = new Education()
            {
                Title = education.Title,
                Image = "",
                PersonalDataId = 1
            };

            context.Educations.Add(educ);
            context.SaveChanges();

            return RedirectToAction("Education");
        }


        public IActionResult RemoveEducation(int Id)
        {
            if (Id <= 0)
            {
                return RedirectToAction("Index");
            }

            var edu = context.Educations.FirstOrDefault(e => e.Id == Id);

            if (edu == null)
            {
                return RedirectToAction("Index");
            }


            context.Educations.Remove(edu);
            context.SaveChanges();

            return RedirectToAction("Index");
        }





        public IActionResult Language()
        {
            var languages = context.Languages.ToList();

            return View(languages);
        }


        public IActionResult CreateLanguage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateLanguage(CreateLanguageViewModel language)
        {
            if (!ModelState.IsValid)
            {
                return View(language);
            }

            context.Languages.Add(new Language()
            {
                Name = language.Name,
                SkillRate = language.SkillRate,
                PersonalDataId = 1
            });
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult RemoveLanguage(int Id)
        {
            if (Id <= 0)
            {
                return RedirectToAction("Index");
            }

            var lang = context.Languages.FirstOrDefault(e => e.Id == Id);

            if (lang == null)
            {
                return RedirectToAction("Index");
            }


            context.Languages.Remove(lang);
            context.SaveChanges();

            return RedirectToAction("Index");
        }



        public IActionResult PersonalData()
        {
            var personaldata = context.PersonalData.FirstOrDefault(p => p.Id == 1);

            return View(new PersonalDataViewModel()
            {
                FullName = personaldata.FullName,
                Email = personaldata.Email,
                PhoneNumber = personaldata.PhoneNumber,
                Age = personaldata.Age,
                BirthDay = personaldata.BirthDay,
                AboutMe = personaldata.AboutMe
            });
        }

        [HttpPost]
        public IActionResult PersonalData(PersonalDataViewModel personalData)
        {
            if (!ModelState.IsValid)
            {
                return View(personalData);
            }
            var personal = context.PersonalData.FirstOrDefault(p => p.Id == 1);

            personal.Email = personalData.Email;
            personal.PhoneNumber = personalData.PhoneNumber;
            personal.Age = personalData.Age;
            personal.BirthDay = personalData.BirthDay;
            personal.AboutMe = personalData.AboutMe;
            personal.FullName = personalData.FullName;

            context.PersonalData.Update(personal);
            context.SaveChanges();

            return RedirectToAction("PersonalData");
        }



        public IActionResult Projects()
        {
            var projects = context.Projects.ToList();

            return View(projects);
        }


        public IActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProject(Project project)
        {
            if (!ModelState.IsValid)
            {
                return View(project);
            }

            context.Projects.Add(project);
            context.SaveChanges();

            return RedirectToAction("CreateProject");
        }





        public IActionResult Skills()
        {
            var skills = context.Skills.ToList();

            return View(skills);
        }


        public IActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }

            context.Skills.Add(skill);
            context.SaveChanges();

            return RedirectToAction("CreateSkill");
        }






        public IActionResult SoftSkills()
        {
            var SoftSkills = context.SoftSkills.ToList();

            return View(SoftSkills);
        }


        public IActionResult CreateSoftSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSoftSkill(SoftSkills skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }

            context.SoftSkills.Add(skill);
            context.SaveChanges();

            return RedirectToAction("CreateSoftSkill");
        }

    }
}
