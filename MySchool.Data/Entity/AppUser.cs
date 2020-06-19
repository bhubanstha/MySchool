using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool.Data.Entity
{
    public class AppUser: IdentityUser<int>
    {

    }

    public class UserRole: IdentityRole<int>
    {

    }


}
