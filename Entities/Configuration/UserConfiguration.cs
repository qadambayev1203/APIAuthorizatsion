using Entities.Model.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                    FirstName="Admin",
                    LastName="Boss",
                    Login="admin",
                    Password="admin",
                    Role=RoleEnum.Admin,
                    IsDeleted=false
                },
                 new User
                 {
                     Id = new Guid("0f8fad5b-d9cb-469f-a165-70867728950b"),
                     FirstName = "User",
                     LastName = "Employer",
                     Login = "user",
                     Password = "user",
                     Role = RoleEnum.User,
                     IsDeleted = false
                 });


        }
    }
}
