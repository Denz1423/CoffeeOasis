using server.Entities;
using Microsoft.AspNetCore.Identity;

namespace server.Data
{
    public static class Dbinitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "bob",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }
            
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Velvet Sunrise",
                    Description =
                        "A robust blend with a rich, full-bodied flavor. Perfect for those who crave an intense coffee experience.",
                    Price = 13.00,
                    PictureUrl = "/images/products/VelvetSunrise.png",
                    Brand = "Sunrise Brews",
                    Type = "Strong",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Midnight Mocha Magic",
                    Description = "Delicate and smooth, this coffee offers a subtle, gentle taste with a hint of chocolate undertones.",
                    Price = 11.50,
                    PictureUrl = "/images/products/MidnightMochaMagic.png",
                    Brand = "Sunrise Brews",
                    Type = "Weak",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Caramelized Bliss",
                    Description =
                        "A harmonious balance between strength and subtlety, this coffee boasts a caramelized sweetness that lingers on the palate.",
                    Price = 12.00,
                    PictureUrl = "/images/products/CaramelizedBliss.png",
                    Brand = "Sunrise Brews",
                    Type = "Medium",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ethiopian Euphoria",
                    Description =
                        "A bold coffee inspired by the mountains of Ethiopia, known for its vibrant and exotic flavor.",
                    Price = 14.00,
                    PictureUrl = "/images/products/EthiopianEuphoria.png",
                    Brand = "Global Harvest",
                    Type = "Strong",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Java Jewel",
                    Description =
                        "A mellow coffee that embodies the serenity of Indonesian coffee plantations with a gentle, soothing taste.",
                    Price = 12.50,
                    PictureUrl = "/images/products/JavaJewel.png",
                    Brand = "Global Harvest",
                    Type = "Weak",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Sumatra Serenade",
                    Description =
                        "A medium roast coffee with a symphony of flavors, including earthy notes and a touch of spice.",
                    Price = 13.00,
                    PictureUrl = "/images/products/SumatraSerenade.png",
                    Brand = "Global Harvest",
                    Type = "Medium",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Colombian Cascade",
                    Description =
                        "A powerful coffee, capturing the essence of Colombian coffee culture, known for its bold and invigorating character.",
                    Price = 15.00,
                    PictureUrl = "/images/products/ColombianCascade.png",
                    Brand = "Andes Aromas",
                    Type = "Strong",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Arabica Aurora",
                    Description =
                        "A mild coffee that awakens the senses with its subtle, bright nuances, reminiscent of the Andean sunrise.",
                    Price = 12.00,
                    PictureUrl = "/images/products/ArabicaAurora.png",
                    Brand = "Andes Aromas",
                    Type = "Weak",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Peruvian Peaks",
                    Description =
                        "An inviting medium roast with flavors as breathtaking as the Peruvian mountains, featuring a smooth, well-rounded taste.",
                    Price = 13.00,
                    PictureUrl = "/images/products/PeruvianPeaks.png",
                    Brand = "Andes Aromas",
                    Type = "Medium",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Tanzanian Treasures",
                    Description =
                        "A bold coffee from the heart of Africa, offering a taste of adventure and a rich, intense flavor.",
                    Price = 14.00,
                    PictureUrl = "/images/products/TanzanianTreasures.png",
                    Brand = "Island Harmony",
                    Type = "Strong",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Hawaiian Hula",
                    Description =
                        "A gentle and relaxing coffee, inspired by the tranquil rhythms of Hawaii's hula dance, with a mild, soothing taste.",
                    Price = 12.50,
                    PictureUrl = "/images/products/HawaiianHula.png",
                    Brand = "Island Harmony",
                    Type = "Weak",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Kenyan Kiss",
                    Description =
                        "A medium roast coffee with a kiss of Kenyan brightness, known for its vibrant and captivating profile.",
                    Price = 13.00,
                    PictureUrl = "/images/products/KenyanKiss.png",
                    Brand = "Island Harmony",
                    Type = "Medium",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Costa Rican Comfort",
                    Description =
                        "A strong coffee that embodies the comfort of Costa Rica, with a rich and invigorating flavor.",
                    Price = 14.00,
                    PictureUrl = "/images/products/CostaRicanComfort.png",
                    Brand = "Latin Luxe",
                    Type = "Strong",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Mexican Mingle",
                    Description =
                        "A gentle and social coffee, capturing the essence of Mexican gatherings with a mild and welcoming taste.",
                    Price = 11.50,
                    PictureUrl = "/images/products/MexicanMingle.png",
                    Brand = "Latin Luxe",
                    Type = "Weak",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Guatemalan Gourmet",
                    Description =
                        "A medium roast coffee with gourmet undertones, offering a balanced and delightful flavor experience.",
                    Price = 13.00,
                    PictureUrl = "/images/products/GuatemalanGourmet.png",
                    Brand = "Latin Luxe",
                    Type = "Medium",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Brazilian Breeze",
                    Description =
                        "A strong coffee inspired by the vibrant spirit of Brazil, with a bold and lively flavor.",
                    Price = 14.00,
                    PictureUrl = "/images/products/BrazilianBreeze.png",
                    Brand = "Amazon Admire",
                    Type = "Strong",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Vietnamese Velvet",
                    Description = "A smooth and elegant coffee, as refined as the velvet textures of Vietnam, featuring a mild and luxurious taste.",
                    Price = 12.50,
                    PictureUrl = "/images/products/VietnameseVelvet.png",
                    Brand = "Amazon Admire",
                    Type = "Weak",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Papua New Guinea Paradise",
                    Description =
                        "A medium roast coffee that transports you to the paradise of Papua New Guinea, with a well-balanced and exotic flavor.",
                    Price = 13.00,
                    PictureUrl = "/images/products/PapuaNewGuineaParadise.png",
                    Brand = "Amazon Admire",
                    Type = "Medium",
                    QuantityInStock = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();

        }
    }
}