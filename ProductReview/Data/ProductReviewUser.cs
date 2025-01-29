﻿using Microsoft.AspNetCore.Identity;

namespace ProductReview.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ProductReviewUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
