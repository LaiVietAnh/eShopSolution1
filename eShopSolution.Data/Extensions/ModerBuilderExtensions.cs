using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Extensions
{
    public static class ModerBuilderExtensions
    {


        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tieng Viet", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = true }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    ID = 1 ,
                    IsShowOnHome = true,
                    ParentID = null,
                    SortOrder = 1,
                    Status = Enums.Status.Active,   
                },
                new Category()
                {   ID = 2 ,
                    IsShowOnHome = true,
                    ParentID = null,
                    SortOrder = 2,
                    Status = Enums.Status.Active,   
                }
            );
            modelBuilder.Entity<CategoryTranslation>().HasData(
                    new CategoryTranslation(){ Id = 1, CategoryId = 1, Name = "Áo nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                    new CategoryTranslation(){ Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt product for men", SeoTitle = "The shirt product for men" },
                    new CategoryTranslation(){ Id = 3, CategoryId = 2, Name = "Áo nữ", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" },
                    new CategoryTranslation(){ Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en-US", SeoAlias = "women-shirt", SeoDescription = "The shirt product for women", SeoTitle = "The shirt product for women" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1, 
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                    
                    
                }
            );
            modelBuilder.Entity<ProductTranslation>().HasData(
                    new ProductTranslation()
                    {
                        Id = 1,
                        ProductId = 1,
                        Name = "Áo nam",
                        LanguageId = "vi-VN",
                        SeoAlias = "ao-nam",
                        SeoDescription = "Sản phẩm áo thời trang nam",
                        SeoTitle = "Sản phẩm áo thời trang nam",
                        Details = "Mô tả sản phẩm",
                        Description = "Mô tả sản phẩm"
                    },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Men Shirt",
                        LanguageId = "en-US",
                        SeoAlias = "men-shirt",
                        SeoDescription = "The shirt product for men",
                        SeoTitle = "The shirt product for men",
                        Details = "Description of product",
                        Description = "Description of product"
                    }
            );
            modelBuilder.Entity<ProductInCategory>().HasData(
                    new ProductInCategory() {ProductId = 1,CategoryId = 1}
            );
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "vietanhwork15@gmail.com",
                NormalizedEmail = "vietanhwork15@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Anh",
                LastName = "Viet",
                Dob = new DateTime(2024, 10, 01)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

        }
    }
}
