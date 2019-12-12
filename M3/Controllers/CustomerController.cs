using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using M3.Models;
using System.Data.Entity;
using M3.ViewModels;

namespace M3.Controllers 
{
	public class CustomerController : Controller
	{
		private ApplicationDbContext _context;

		public CustomerController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}
		public ViewResult Index()
		{

			return View();
		}

		public ActionResult Details(int id)
		{
			var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

			if (customer == null)
				return HttpNotFound();

			return View(customer);
		}

		public ActionResult New()
		{
			var membershiptypes = _context.MembershipTypes.ToList();
			var viewModel = new CustomerFormViewModel()
			{
				Customer = new Customer(),
				MembershipTypes = membershiptypes
			};
			return View("CustomerForm", viewModel);
		}

		[HttpPost] 
		[ValidateAntiForgeryToken]
		public ActionResult Save(Customer customer)
		{
			if (!ModelState.IsValid)
			{
				var viewModel = new CustomerFormViewModel
				{
					Customer = customer,
					MembershipTypes = _context.MembershipTypes.ToList()
				};
				return View("CustomerForm", viewModel);
			}
			if (customer.Id == 0)
				_context.Customers.Add(customer);
			else
			{
				var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

				//TryUpdateModel(customerInDb, "" new string[]{"Name", "email", "etc"});

				customerInDb.Name = customer.Name;
				customerInDb.street_address = customer.street_address;
				customerInDb.city_address = customer.city_address;
				customerInDb.state_address = customer.state_address;
				customerInDb.zip_address = customer.zip_address;
				customerInDb.phone_address = customer.phone_address;
				customerInDb.email_address = customer.email_address;

				customerInDb.birthdate = customer.birthdate;
				customerInDb.MembershipTypeId = customer.MembershipTypeId;
				customerInDb.issubscribed = customer.issubscribed;

			}
			_context.SaveChanges();
			return RedirectToAction("Index", "Customer");
		}

		public ActionResult Edit(int id)
		{
			var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customer == null)
				return HttpNotFound();

			var viewModel = new CustomerFormViewModel
			{
				Customer = customer,
				MembershipTypes = _context.MembershipTypes.ToList()
			};
			return View("CustomerForm", viewModel);
		}


	}
}