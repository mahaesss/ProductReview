using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductReview.Configurations.Entities;
using ProductReview.Data;

namespace ProductReview.Data
{
    public class ProductReviewContext(DbContextOptions<ProductReviewContext> options) : IdentityDbContext<ProductReviewUser>(options)
    {
        public DbSet<ProductReview.Domain.Make> Make { get; set; } = default!;
        public DbSet<ProductReview.Domain.Model> Model { get; set; } = default!;
        public DbSet<ProductReview.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<ProductReview.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<ProductReview.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<ProductReview.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}
