﻿//=================================================
// Copyright(c) Coalition of Good-Hearted Engineers
// Free To Use For Your Comfort and Peace !
//=================================================


using System;

namespace IjaraUy.API.Models.Foundations.Guests
{
    public class Guest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public GenderType Gender { get; set; }


    }
}
