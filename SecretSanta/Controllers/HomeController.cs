using System;
using System.Linq;
using System.Web.Mvc;
using SecretSanta.Models;

namespace SecretSanta.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            SelectGroupViewModel vm = new SelectGroupViewModel()
            {
                Groups = new SelectList(context.Groups.OrderBy(x => x.Name).ToList(), "Id", "Name")
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult Person(Guid Id)
        {
            PersonViewModel vm = new PersonViewModel { GroupId = Id };
            return View("Person", vm);
        }

        [HttpPost]
        public ActionResult Distribution(Guid groupId, string firstName, string lastName)
        {
            DistributionViewModel vm = new DistributionViewModel();

            ApplicationDbContext context = new ApplicationDbContext();

            var group = context.Groups.Include("Members").FirstOrDefault(x => x.Id == groupId);
            vm.Budget = group.Budget;
            vm.GroupName = group.Name;
            var members = group.Members.ToList();

            firstName = firstName.Trim().ToLower();
            lastName = lastName.Trim().ToLower();

            var person = members.FirstOrDefault(x => x.FirstName.ToLower() == firstName && x.LastName.ToLower() == lastName);

            Member member;

            //Person exists
            if (person != null)
            {
                vm.PersonExists = true;

                //Person should be assigned
                if (person.Receiver == null)
                {
                    member = members.FirstOrDefault(
                        //Already got present
                        x => !x.HasGotPresent &&
                        //You can't give to yourself
                        x.Id != person.Id &&
                        //You can't give to someone has given to you
                        x.Receiver != person.Id
                        //You can't give to someone who has already given something
                        && x.Receiver == null);
                    if(member == null)
                    {
                        member = members.FirstOrDefault(
                        //Already got present
                        x => !x.HasGotPresent &&
                        //You can't give to yourself
                        x.Id != person.Id &&
                        //You can't give to someone has given to you
                        x.Receiver != person.Id);
                        if(member == null)
                        {
                            member = members.FirstOrDefault(x => !x.HasGotPresent && x.Id != person.Id);
                        }
                    }
                    member.HasGotPresent = true;
                    person.Receiver = member.Id;
                }//Already assigned
                else
                {
                    vm.AlreadyAssigned = true;
                    member = members.FirstOrDefault(x => x.Id == person.Receiver.Value);
                }
                vm.Name = member.FirstName + " " + member.LastName;
            }
            else
            {
                vm.PersonExists = false;
            }

            context.SaveChanges();

            return View("Distribution", vm);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}