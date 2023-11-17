﻿using Autofac;
using DigiCV.Application.Features.Training.Services;
using DigiCV.Domain.Entities;
using DigiCV.Infrastructure.Features.Services;
using System.ComponentModel.DataAnnotations;

namespace DigiCV.Web.Models.Letter
{
    public class LetterCreateModel
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "It should contains atleast {1} characters")]
        [MaxLength(30, ErrorMessage = "It can not have more than {1} characters")]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Date, ErrorMessage = "Must be a valid date")]
        //[Range(typeof(DateTime), "1/1/2000", "1/1/2100",
        //ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime SendingDate { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "It should contains atleast {1} characters")]
        [MaxLength(30, ErrorMessage = "It can not have more than {1} characters")]
        public string SenderName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Must be a valid Email")]
        public string SenderEmail { get; set; }
        [Required]
        [Phone(ErrorMessage = "Must be a valid contact number")]
        public string SenderPhone { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "It should contains atleast {1} characters")]
        public string SenderAddress { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "It should contains atleast {1} characters")]
        public string SenderAddressEx { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "It should contains atleast {1} characters")]
        [MaxLength(50, ErrorMessage = "It can not have more than {1} characters")]
        public string Recipient { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "It should contains atleast {1} characters")]
        [MaxLength(50, ErrorMessage = "It can not have more than {1} characters")]
        public string CompanyName { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "It should contains atleast {1} characters")]
        public string CompanyAddress { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "It should contains atleast {1} characters")]
        public string Subject { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "It should contains atleast {1} characters")]
        [MaxLength(20, ErrorMessage = "It can not have more than {1} characters")]
        public string RecipientAddressing { get; set; }
        [Required]
        [MinLength(200, ErrorMessage = "It should contains atleast {1} characters")]
        public string Body { get; set; }

        private ICoverLetterService _coverLetterService;
        public LetterCreateModel()
        {
        }
        public LetterCreateModel(ICoverLetterService coverLetterService)
        {
            _coverLetterService = coverLetterService;
        }
        internal void ResolveDependency(ILifetimeScope scope)
        {
            _coverLetterService = scope.Resolve<ICoverLetterService>();
        }
        internal Guid CreateCoverLetter()
        {
            if (!string.IsNullOrWhiteSpace(Title))
            {
                CoverLetter coverLetter = new CoverLetter();
                coverLetter.UserId = UserId;
                coverLetter.Title = Title;
                coverLetter.SendingDate = SendingDate;
                coverLetter.SenderName = SenderName;
                coverLetter.SenderEmail = SenderEmail;
                coverLetter.SenderPhone = SenderPhone;
                coverLetter.SenderAddress = SenderAddress;
                coverLetter.SenderAddressEx = SenderAddressEx;
                coverLetter.Recipient = Recipient;
                coverLetter.CompanyName = CompanyName;
                coverLetter.CompanyAddress = CompanyAddress;
                coverLetter.RecipientAddressing = RecipientAddressing;
                coverLetter.Subject = Subject;
                coverLetter.Body = Body;
                return _coverLetterService.CreateCoverLetter(coverLetter);
            }
            return Guid.Empty;
        }
    }
}
