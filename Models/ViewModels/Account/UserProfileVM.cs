﻿using MVC_Store.Models.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Store.Models.ViewModels.Account
{

    public class UserProfileVM
    {
        public UserProfileVM()
        {

        }

        public UserProfileVM(UserDTO row)
        {
            Id = row.Id;
            FirstName = row.FirstName;
            LastName = row.LastName;
            EmailAdress = row.EmailAdress;
            Username = row.Username;
            Password = row.Password;
        }
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string EmailAdress { get; set; }
        [Required]
        [DisplayName("User Name")]
        public string Username { get; set; }
        public string Password { get; set; }
        [DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}