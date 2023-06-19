using icebox_dynamic_starter_picture_server.Models;
using Microsoft.Extensions.Logging;

namespace icebox_dynamic_starter_picture_server.ModelBuilderExtenstion
{
    public static class Extensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Images>().HasData(
                new Images
                {
                    ImageId = 1,
                    Path = "images1/jpg",
                    Type = "Eid"
                },
                new Images
                {
                    ImageId = 2,
                    Path = "images2/jpg",
                    Type = "Ramadan"
                },
                new Images
                {
                    ImageId = 3,
                    Path = "images3/jpg",
                    Type = "Hajj"
                },
                new Images
                {
                    ImageId = 4,
                    Path = "images4/jpg",
                    Type = "New Year"
                },
                new Images
                {
                    ImageId = 5,
                    Path = "images5/jpg",
                    Type = "Default"
                }
            );

        }
        public static void MachineSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Machine>().HasData(
                new Machine
                {
                    Id = 1,
                    Ip = "192.168.0.1",
                    Location = "Miami",
                    Name = "Icebox",
                    Image = null, 
                    ImageId = null
                },
                new Machine
                {
                    Id = 2,
                    Ip = "192.168.0.2",
                    Location = "California",
                    Name = "Icebox",
                    ImageId = null,
                },
                new Machine
                {
                    Id = 3,
                    Ip = "192.168.0.3",
                    Location = "Washington",
                    Name = "Icebox",
                    Image = null, 
                    ImageId = null
                },
                new Machine
                {
                    Id = 4,
                    Ip = "192.168.0.4",
                    Location = "Boston",
                    Name = "Icebox",
                    Image = null,
                    ImageId = null
                },
                new Machine
                {
                    Id = 5,
                    Ip = "192.168.0.5",
                    Location = "St. Jons",
                    Name = "Icebox",
                    Image = null, 
                    ImageId = null
                },
                new Machine
                {
                    Id = 6,
                    Ip = "192.168.0.6",
                    Location = "Florida",
                    Name = "Icebox",
                    Image = null,
                    ImageId = null
                },
                new Machine
                {
                    Id = 7,
                    Ip = "192.168.0.7",
                    Location = "Audi",
                    Name = "Icebox",
                    Image = null,
                    ImageId = null
                },
                new Machine
                {
                    Id = 8,
                    Ip = "192.168.0.8",
                    Location = "New Jersey",
                    Name = "Icebox",
                    Image = null,
                    ImageId = null
                },
                new Machine
                {
                    Id = 9,
                    Ip = "192.168.0.9",
                    Location = "Karachi",
                    Name = "Icebox",
                    Image = null,
                    ImageId = null
                }
            );
        }
    }
}