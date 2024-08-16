using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using ChatWithFriends.Models;
using System;
using CoreMvc5_CookieAuthentication.Services;
using ChatWithFriends.Interfaces;

namespace ChatWithFriends.Data
{
    public class AccountContext : DbContext
    {
        private readonly IHashService _hashService;
        public AccountContext(DbContextOptions<AccountContext> options, IHashService hashService) : base(options)
        {
            _hashService = hashService;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = "U001", Name = "弟弟", Password = _hashService.SHA512Hash("123")},
                new User { Id = "U002", Name = "姐姐", Password = _hashService.SHA512Hash("123")},
                new User { Id = "U003", Name = "媽媽", Password = _hashService.SHA512Hash("123")},
                new User { Id = "U004", Name = "爸爸", Password = _hashService.SHA512Hash("123")},
                new User { Id = "U005", Name = "阿嬤", Password = _hashService.SHA512Hash("123")},
                new User { Id = "U006", Name = "舅舅", Password = _hashService.SHA512Hash("123")},
                new User { Id = "U007", Name = "舅媽", Password = _hashService.SHA512Hash("123")},
                new User { Id = "U008", Name = "禹涵", Password = _hashService.SHA512Hash("123")},
                new User { Id = "U009", Name = "禹晴", Password = _hashService.SHA512Hash("123")},
                new User { Id = "U010", Name = "禹淇", Password = _hashService.SHA512Hash("123")}
            );
        }
    }
}
