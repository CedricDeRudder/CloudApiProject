using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class DBInitializer
    {
        public static void Initialize(MountainContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Mountains.Any())
            {
                var mountain1 = new Mountain()
                {
                    Name = "Annapurna I",
                    Location = "Himalaya",
                    Height = 8091
                };
                var mountain2 = new Mountain()
                {
                    Name = "Nanga Parbat",
                    Location = "Pakistan",
                    Height = 8126
                };
                var mountain3 = new Mountain()
                {
                    Name = "Manaslu",
                    Location = "",
                    Height = 8163
                };
                var mountain4 = new Mountain()
                {
                    Name = "Dhaulagiri I",
                    Location = "Nepal",
                    Height = 8167
                };
                var mountain5 = new Mountain()
                {
                    Name = "Cho Oyu",
                    Location = "Centrale Himalaya",
                    Height = 8201
                };
                var mountain6 = new Mountain()
                {
                    Name = "Makalu",
                    Location = "Grens van Nepal en Tibet",
                    Height = 8485
                };
                var mountain7 = new Mountain()
                {
                    Name = "Lhotse",
                    Location = "",
                    Height = 8516
                };
                var mountain8 = new Mountain()
                {
                    Name = "Kangchenjunga",
                    Location = "",
                    Height = 8586
                };
                var mountain9 = new Mountain()
                {
                    Name = "K2",
                    Location = "Karakoram",
                    Height = 8611
                };
                var mountain10 = new Mountain()
                {
                    Name = "Mount Everest",
                    Location = "Grens van Nepal en Tibet",
                    Height = 8848
                };


                context.Mountains.Add(mountain1);
                context.Mountains.Add(mountain2);
                context.Mountains.Add(mountain3);
                context.Mountains.Add(mountain4);
                context.Mountains.Add(mountain5);
                context.Mountains.Add(mountain6);
                context.Mountains.Add(mountain7);
                context.Mountains.Add(mountain8);
                context.Mountains.Add(mountain9);
                context.Mountains.Add(mountain10);

                context.SaveChanges();
            }
        }
    }
}
