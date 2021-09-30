﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GaspApp.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Account
    {
        public Guid Id {  get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string DisplayName { get; set; }

    }
}