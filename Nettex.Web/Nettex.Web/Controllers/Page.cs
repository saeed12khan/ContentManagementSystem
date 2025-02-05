﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Nettex.Core;
using Nettex.Core.Entities;
using Nettex.Service;
using Nettex.WebMVC.Framework.Controllers;
using Nettex.WebMVC.Framework.Helpers;
using Nettex.WebMVC.Framework.UI;
using Nettex.WebMVC.Framework.Utilities;
using Nettex.WebMVC.Models;

namespace Nettex.WebMVC.Controllers
{
    public class PageController : BaseController
    {
        #region Fields

        private readonly ISettingService settingService;
        private readonly IPostService postService;
        private readonly ICategoryService categoryService;
        private readonly IUrlService urlService;
        private readonly IContactService contactService;
        private readonly ISubscriberService subscriberService;
        private readonly IJobService jobService;
        private readonly IApplyJobService applyJobService;

        #endregion Fields

        #region Ctor

        public PageController(ISettingService _settingService,
            IPostService _postService,
            ICategoryService _categoryService,
            IUrlService _urlService,
            IContactService _contactService,
            ISubscriberService _subscriberService,
                        IJobService _jobService,
            IApplyJobService _applyJobService)
        {
            settingService = _settingService;
            postService = _postService;
            categoryService = _categoryService;
            urlService = _urlService;
            contactService = _contactService;
            subscriberService = _subscriberService;
            jobService = _jobService;
            applyJobService = _applyJobService;
        }

        #endregion Ctor

        #region Methods
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult AboutMe()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            var contact = new ContactModel();
            return View(contact);
        }
        public ActionResult ContactUs2()
        {
            return View();
        }
        public ActionResult ContactUs3()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Jobs()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Help()
        {
            return View();
        }
        public ActionResult Pricing()
        {
            return View();
        }
        public ActionResult Faqs()
        {
            return View();
        }


        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactModel model)
        {
            var alert = HtmlHelper.Nettex().Alert();

            if (string.IsNullOrEmpty(model.Email))
                return Json(alert.Text("Email can not be emty.").Color(BootstrapColor.Danger).ToHtmlString(), JsonRequestBehavior.AllowGet);

            if (ModelState.IsValid)
            {
                var contact = new Contact()
                {
                    FullName = model.Name,
                    Email = model.Email,
                    Message = model.Message,
                    Subject = model.Subject,
                    DateUtc = DateTime.UtcNow
                };

                var result = contactService.Save(contact);
                if (result)
                    return Json(alert.Text("Thank you, your email successfully added.").Color(BootstrapColor.Success).ToHtmlString(), JsonRequestBehavior.AllowGet);
            }

            return Json(alert.Text("Something is wrong, please try again.").Color(BootstrapColor.Danger).ToHtmlString(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Subscribe(SubscriberModel model)
        {
            var alert = HtmlHelper.Nettex().Alert();

            if (string.IsNullOrEmpty(model.Email))
                return Json(alert.Text("Email can not be emty.").Color(BootstrapColor.Danger).ToHtmlString(), JsonRequestBehavior.AllowGet);

            if (ModelState.IsValid)
            {
                if (!(new EmailAddressAttribute().IsValid(model.Email)))
                    return Json(alert.Text("Please enter a valid email.").Color(BootstrapColor.Danger).ToHtmlString(), JsonRequestBehavior.AllowGet);

                var sub = subscriberService.GetByEmail(model.Email);
                if (sub != null)
                    return Json(alert.Text("Email is already exist.").Color(BootstrapColor.Danger).ToHtmlString(), JsonRequestBehavior.AllowGet);

                var subscriber = new Subscriber()
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    IsActive = true,
                    SubscribeDateUtc = DateTime.UtcNow
                };

                var result = subscriberService.Save(subscriber);
                if (result)
                {
                    return Json(alert.Text("Thank you, your email successfully added.").Color(BootstrapColor.Success).ToHtmlString(), JsonRequestBehavior.AllowGet);
                }
            }
            return Json(alert.Text("Something is wrong, please try again.").Color(BootstrapColor.Danger).ToHtmlString(), JsonRequestBehavior.AllowGet);
        }


        public ActionResult JobDetail(int? Id)
        {
            if (!Id.HasValue)
                return HomePage();

            var job = jobService.GetById(Id.Value);

            if (job == null)
                return NotFound();


            if (!job.IsActive || job.IsDelete)
                return NotFound();

            string cookieKey = string.Format(CookieConstant.PORTFOLIO_VIEW, job.Id);
            if (!CookieHelper.Exists(cookieKey))
            {
                CookieHelper.Set(cookieKey, WebHelper.IpAddress, 1);
                job.ViewCount += 1;
                jobService.Update(job);
            }

            var model = new JobDetailModel
            {
                Id = job.Id,
                Title = job.Title,
                Description = job.Description,
                Url = job.Url,
                CreateDate = job.CreateDateUtc,
                UpdateDate = job.UpdateDateUtc,
                ViewCount = job.ViewCount,
                SallaryMax = job.SallaryMax,
                SallaryMin = job.SallaryMin,
                Location = job.Location,
                WorkType = job.JobType,
                CategoryName = job.Category.Name
            };

            model.ApplyJob = new ApplyJobModel();
            model.ApplyJob.JobId = job.Id;

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult ApplyJob(JobDetailModel model)
        {
            var alert = HtmlHelper.Nettex().Alert();

            if (string.IsNullOrEmpty(model.ApplyJob.Email))
                return Json(alert.Text("Email can not be emty.").Color(BootstrapColor.Warning).ToHtmlString(), JsonRequestBehavior.AllowGet);

            if (ModelState.IsValid)
            {
                ApplyJob applyJob = new ApplyJob();
                applyJob.FullName = model.ApplyJob.FullName;
                applyJob.Email = model.ApplyJob.Email;
                applyJob.Phone = model.ApplyJob.Phone;
                applyJob.Message = model.ApplyJob.Message;
                applyJob.JobId = model.ApplyJob.JobId;
                applyJob.ApplyDateUtc = DateTime.UtcNow;
                applyJob.IsActive = true;

                var result = applyJobService.Save(applyJob);
                if (result)
                    return Json(alert.Text("Thank you, your email successfully added.").Color(BootstrapColor.Success).ToHtmlString(), JsonRequestBehavior.AllowGet);
            }

            return Json(alert.Text("Something is wrong, please try again.").Color(BootstrapColor.Danger).ToHtmlString(), JsonRequestBehavior.AllowGet);
        }

        #endregion Methods
    }
}