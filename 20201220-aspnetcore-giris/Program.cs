using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace _20201220_aspnetcore_giris
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();

            // var linuxCategory = new Category {Name = "Linux"};
            // var windowsCategory = new Category {Name = "Windows"};
            //
            // db.Categories.Add(linuxCategory);
            // db.Categories.Add(windowsCategory);
            //
            // var linuxPost = new Post {Title = "Linux is hot", Content = "I love it", Category = linuxCategory};
            // var windowsPost = new Post
            //     {Title = "Windows is great", Content = "Very nice.", Category = windowsCategory};
            //
            // db.Posts.Add(linuxPost);
            // db.Posts.Add(windowsPost);
            //
            // db.SaveChanges();

            var postList = db.Posts.ToList();
            // postList.ForEach(x => Console.WriteLine($"Title: {x.Title}, Content: {x.Content}"));
            foreach (var post in postList)
            {
                var category = db.Categories.Find(post.CategoryId);
                Console.WriteLine($"Category: {category.Name}, Title: {post.Title}, Content: {post.Content}");
            }
        }
    }
}

        
        
