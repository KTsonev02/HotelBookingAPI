using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MyBooksAPI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBooksAPI.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book Title",
                        Description = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        //Author = "First Author",
                        DateAdded = DateTime.Now
                    },
                    new Book()
                    {
                        Title = "second Book Title",
                        Description = "second Book Description",
                        IsRead = false,
                        Rate = 4,
                        Genre = "Biography",
                        //Author = "Second Author",
                        DateAdded = DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }

        
    }

}
    

