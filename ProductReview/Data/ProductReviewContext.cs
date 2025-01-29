using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductReview.Domain;

namespace ProductReview.Data
{
    public class ProductReviewContext : DbContext
    {
        public ProductReviewContext (DbContextOptions<ProductReviewContext> options)
            : base(options)
        {
        }

        public DbSet<ProductReview.Domain.Make> Make { get; set; } = default!;
        public DbSet<ProductReview.Domain.Model> Model { get; set; } = default!;
        public DbSet<ProductReview.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<ProductReview.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<ProductReview.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<ProductReview.Domain.Customer> Customer { get; set; } = default!;
    }
}
