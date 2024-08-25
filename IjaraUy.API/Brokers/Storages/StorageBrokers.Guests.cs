//=================================================
// Copyright(c) Coalition of Good-Hearted Engineers
// Free To Use For Your Comfort and Peace !
//=================================================


using IjaraUy.API.Models.Foundations.Guests;
using Microsoft.EntityFrameworkCore;

namespace IjaraUy.API.Brokers.Storages
{
    public partial class StorageBrokers
    {
        public DbSet<Guest> Guests {get;set;}
    }
}
