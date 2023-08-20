using FPTBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace COMP1640.Data.SeedData
{
    public class SeedDataToDb
    {
        public static void Seed(ModelBuilder builder)
        {
            SeedRoles(builder);
            SeedUsers(builder);
            SeedUserRoles(builder);
            SeedStore(builder);
            SeedBook(builder);
            SeedCategory(builder);
        }
        public static void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<CategoryModel>().HasData(
                new CategoryModel()
                {
                    Id = "101",
                    Name = "Fantasy literature",
                    IsApprove = true,
                },

                new CategoryModel()
                {
                    Id = "102",
                    Name = "Romance",
                    IsApprove = true,
                });
        }
        public static void SeedStore(ModelBuilder builder)
        {
            builder.Entity<StoreModel>().HasData(
                new StoreModel()
                {
                    Id = "101",
                    Name = "Book Depository",
                    StoreOwnerId = "202",
                },
             
                new StoreModel()
                {
                    Id = "102",
                    Name = "Books Wagon",
                    StoreOwnerId = "203",

                });
        }
        public static void SeedBook(ModelBuilder builder)
        {
            builder.Entity<BookModel>().HasData(
               new BookModel()
               {
                      ISBN = "9780751565355",
                      Title = "Harry Potter and the Cursed Child - Parts I & II : The Official Script Book of the Original West End Production",
                      Cost = 24.09,
                      Author = "J. K. Rowling",
                      CategoryID = "101",
                      ImageURL = "https://res.cloudinary.com/dnj7dje92/image/upload/v1680630725/9780751565355_gflcmw.jpg",
                      Description = "Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne.\r\n\r\nBased on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne, Harry Potter and the Cursed Child is the eighth story in the Harry Potter series and the first official Harry Potter story to be presented on stage. The play will receive its world premiere in London’s West End on 30th July 2016. It was always difficult being Harry Potter and it isn’t much easier now that he is an overworked employee of the Ministry of Magic, a husband, and father of three school-age children. While Harry grapples with a past that refuses to stay where it belongs, his youngest son Albus must struggle with the weight of a family legacy he never wanted. As past and present fuse ominously, both father and son learn the uncomfortable truth: sometimes, darkness comes from unexpected places.",
                      StoreID = "101"
               },
                      new BookModel()
                      {
                          ISBN = "9780751565351231235",
                          Title = "The Official Script Book of the Original West End Production",
                          Cost = 123.094,
                          Author = "J Rowling",
                          CategoryID = "101",
                          ImageURL = "https://res.cloudinary.com/dnj7dje92/image/upload/v1680630725/9780751565355_gflcmw.jpg",
                          Description = "Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne.\r\n\r\nBased on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, a new play by Jack Thorne, Harry Potter and the Cursed Child is the eighth story in the Harry Potter series and the first official Harry Potter story to be presented on stage. The play will receive its world premiere in London’s West End on 30th July 2016. It was always difficult being Harry Potter and it isn’t much easier now that he is an overworked employee of the Ministry of Magic, a husband, and father of three school-age children. While Harry grapples with a past that refuses to stay where it belongs, his youngest son Albus must struggle with the weight of a family legacy he never wanted. As past and present fuse ominously, both father and son learn the uncomfortable truth: sometimes, darkness comes from unexpected places.",
                          StoreID = "101"
                      },
               new BookModel()
               {
                   ISBN = "9781471156267",
                   Title = "It Ends With Us: The most heartbreaking novel you'll ever read : The most heartbreaking novel you'll ever read",
                   Cost = 16.33,
                   Author = "Colleen Hoover",
                   CategoryID = "102",
                   ImageURL = "https://res.cloudinary.com/dnj7dje92/image/upload/v1680631224/3_gaxnnl.jpg",
                   Description = "A brave and heartbreaking novel that digs its claws into you and doesn't let go, long after you've finished it' Anna Todd, author of the After series 'A glorious and touching read, a forever keeper' USA Today 'Will break your heart while filling you with hope' Sarah Pekkanen, Perfect Neighbors SOMETIMES THE ONE WHO LOVES YOU IS THE ONE WHO HURTS YOU THE MOST. Lily hasn't always had it easy, but that's never stopped her from working hard for the life she wants. She's come a long way from the small town in Maine where she grew up - she graduated from college, moved to Boston, and started her own business. So when she feels a spark with a gorgeous neurosurgeon named Ryle Kincaid, everything in Lily's life suddenly seems almost too good to be true. Ryle is assertive, stubborn, maybe even a little arrogant. He's also sensitive, brilliant, and has a total soft spot for Lily, but Ryle's complete aversion to relationships is disturbing. Even as Lily finds herself becoming the exception to his 'no dating' rule, she can't help but wonder what made him that way in the first place. As questions about her new relationship overwhelm her, so do thoughts of Atlas Corrigan - her first love and a link to the past she left behind. He was her kindred spirit, her protector. When Atlas suddenly reappears, everything Lily has built with Ryle is threatened. With this bold and deeply personal novel, It Ends With Us is a heart-wrenching story and an unforgettable tale of love that comes at the ultimate price.",
                   StoreID = "102"
               },


               new BookModel()
               {
                   ISBN = "9781408708989",
                   Title = "Fantastic Beasts and Where to Find Them : The Original Screenplay",
                   Cost = 21.26,
                   Author = "J. K. Rowling",
                   CategoryID = "102",
                   ImageURL = "https://res.cloudinary.com/dnj7dje92/image/upload/v1680630919/2_oou1a0.jpg",
                   Description = "J.K. Rowling's screenwriting debut is captured in this exciting hardcover edition of the Fantastic Beasts and Where to Find Them screenplay.\r\nWhen Magizoologist Newt Scamander arrives in New York, he intends his stay to be just a brief stopover. However, when his magical case is misplaced and some of Newt's fantastic beasts escape, it spells trouble for everyone...Fantastic Beasts and Where to Find Them marks the screenwriting debut of J.K. Rowling, author of the beloved and internationally bestselling Harry Potter books. Featuring a cast of remarkable characters, this is epic, adventure-packed storytelling at its very best. Whether an existing fan or new to the wizarding world, this is a perfect addition to any reader's bookshelf.",
                   StoreID = "102"
               });
        }

        public static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<RoleModel>().HasData(
                new RoleModel()
                {
                    Id = "101",
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                },
                new RoleModel()
                {
                    Id = "102",
                    Name = "StoreOwner",
                    NormalizedName = "StoreOwner".ToUpper()
           
                },            
                new RoleModel()
                {
                    Id = "103",
                    Name = "Customer",
                    NormalizedName = "Customer".ToUpper()
                });
        }
        public static void SeedUsers(ModelBuilder builder)
        {
            PasswordHasher<AppUserModel> hasher = new PasswordHasher<AppUserModel>();

            builder.Entity<AppUserModel>().HasData(
                new AppUserModel()
                {
                    Id = "201",
                    UserName = "admin@gmail.com",
                    NormalizedUserName = "admin@gmail.com".ToUpper(),
                    Email = "admin@gmail.com",
                    NormalizedEmail = "admin@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    EmailConfirmed = true,
                    FullName = "Nguyen Van Admin"


                },
                new AppUserModel()
                {
                    Id = "202",
                    UserName = "storeowner1@gmail.com",
                    NormalizedUserName = "storeowner1@gmail.com".ToUpper(),
                    Email = "storeowner1@gmail.com",
                    NormalizedEmail = "storeowner1@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    EmailConfirmed = true,
                    FullName = "Nguyen Van Store"


                },
                new AppUserModel()
                {
                    Id = "203",
                    UserName = "storeowner2@gmail.com",
                    NormalizedUserName = "storeowner2@gmail.com".ToUpper(),
                    Email = "storeowner2@gmail.com",
                    NormalizedEmail = "storeowner2@gmail.com".ToUpper(),
                    PasswordHash = hasher.HashPassword(null, "Default@123"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    EmailConfirmed = true,
                    FullName = "Nguyen Van Store"


                },
                 new AppUserModel()
                 {
                     Id = "204",
                     UserName = "customer@gmail.com",
                     NormalizedUserName = "customer@gmail.com".ToUpper(),
                     Email = "customer@gmail.com",
                     NormalizedEmail = "customer@gmail.com".ToUpper(),
                     PasswordHash = hasher.HashPassword(null, "Default@123"),
                     SecurityStamp = Guid.NewGuid().ToString("D"),
                     EmailConfirmed = true,
                     FullName = "Nguyen Van Customer"


                 });
              
          
        }
      
        public static void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
              new IdentityUserRole<string>
              {
                  UserId = "201",
                  RoleId = "101"

              },
              new IdentityUserRole<string>
              {
                  UserId = "202",
                  RoleId = "102"

              },
              new IdentityUserRole<string>
              {
                  UserId = "203",
                  RoleId = "102"

              },
              new IdentityUserRole<string>
              {
                  UserId = "204",
                  RoleId = "103"

              });
        }
    }
}
