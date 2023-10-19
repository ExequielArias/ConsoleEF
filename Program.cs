using System;
using System.Linq;
using ConsoleEF.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogContext()) 
            {
                //Grabar
                var p = new Post();
                p.Title = "El Patito";
                p.Body = "Se escapó un patito del lago";
                context.Posts.Add(p);
                context.SaveChanges();


                //Listar todos los datos de una tabla 
                foreach (var post in context.Posts.ToList())
                {
                    Console.WriteLine(post.Title + " " + post.Body);
                }
            }
        }
    }
}
