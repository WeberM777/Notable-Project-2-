﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Paradise.Models
{
    public class AdminMetadata
    {
        [Key]
        [Required]
        [Display(Name = "Admin ID")]
        public int admin_ID;
        [Required]
        [Display(Name = "Staff ID")]
        public int staff_ID;
        [Required]
        [StringLength(20)]
        [Display(Name = "UserName")]
        public string userName;
        [Required]
        [StringLength(20)]
        [Display(Name = "Password")]
        public string userPassword;
        [Required]
        [Display(Name = "Super Admin")]
        public bool superAdmin;
    }
    public class StaffMetadata
    {
        [Key]
        [Required]
        [Display(Name = "Staff ID")]
        public int staff_ID;
        [Required]
        [StringLength(30)]
        [Display(Name = "First Name")]
        public string firstName;
        [Required]
        [StringLength(30)]
        [Display(Name = "Last Name")]
        public string lastName;
        [Required]
        [StringLength(30)]
        [Display(Name = "Job Title")]
        public string jobTitle;
        [Required]
        [StringLength(30)]
        [Display(Name = "Position")]
        public string position;
        [Required]
        [StringLength(30)]
        [Display(Name = "Foundation")]
        public string foundation;
        [StringLength(30)]
        [Display(Name = "Email")]
        public string email;
        [Required]
        [StringLength(30)]
        [Display(Name = "Image Name")]
        public string imageName;
        [Required]
        [Display(Name = "Active")]
        public bool active;
    }
    public class DonorMetadata
    {
        [Key]
        [Required]
        [Display(Name = "Donor ID")]
        public int donor_ID;
        [Required]
        [StringLength(50)]
        [Display(Name = "Donor Name")]
        public string donorName;
        [Required]
        [StringLength(50)]
        [Display(Name = "Donor Level")]
        public string donorLevel;
        [Required]
        [StringLength(50)]
        [Display(Name = "Donor Years")]
        public string donorYear;
        [StringLength(11)]
        [RegularExpression("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]")]
        [Display(Name = "Phone Number")]
        public string phone;
        [StringLength(30)]
        [Display(Name = "Email")]
        public string email;
        [Required]
        [Display(Name = "Active")]
        public bool active;
    }
    public class ErrorMetadata
    {
        [Key]
        [Required]
        public int error_ID;
        [Required]
        [StringLength(1000)]
        public string errorDesc;
        [Required]
        public byte[] errorDate;
        [Required]
        public int admin_ID;
    }
    public class PageMetadata
    {
        [Key]
        [Required]
        public int page_ID;
        [StringLength(50)]
        public string pageDesc;
        [StringLength(20)]
        public string pageName;
        [AllowHtml]
        [Required]
        public string content { get; set; }
    }
}