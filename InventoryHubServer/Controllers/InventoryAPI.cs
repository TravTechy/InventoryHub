using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace InventoryHubServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryAPI : ControllerBase
    {
        private static List<Items> items = new List<Items>
        {
            new Items
            {
                Id = 1,
                Name = "Wireless Mouse",
                Description =
                    "A comfortable wireless mouse with ergonomic design and long battery life.",
                Quantity = 50,
                Price = 19.99m,
            },
            new Items
            {
                Id = 2,
                Name = "Bluetooth Speaker",
                Description =
                    "Portable Bluetooth speaker with high-quality sound and a built-in microphone.",
                Quantity = 30,
                Price = 39.99m,
            },
            new Items
            {
                Id = 3,
                Name = "Smartphone Stand",
                Description =
                    "Adjustable stand for smartphones with a sturdy base and flexible design.",
                Quantity = 100,
                Price = 12.49m,
            },
            new Items
            {
                Id = 4,
                Name = "Laptop Sleeve",
                Description =
                    "Protective sleeve for laptops with a soft interior and durable exterior.",
                Quantity = 70,
                Price = 24.99m,
            },
            new Items
            {
                Id = 5,
                Name = "Noise Cancelling Headphones",
                Description =
                    "Over-ear headphones with noise cancellation and premium sound quality.",
                Quantity = 25,
                Price = 149.99m,
            },
            new Items
            {
                Id = 6,
                Name = "4K UHD Monitor",
                Description =
                    "High-definition 4K monitor with vibrant color and wide viewing angles.",
                Quantity = 15,
                Price = 299.99m,
            },
            new Items
            {
                Id = 7,
                Name = "Wireless Earbuds",
                Description =
                    "True wireless earbuds with a long-lasting battery and high-quality sound.",
                Quantity = 40,
                Price = 89.99m,
            },
            new Items
            {
                Id = 8,
                Name = "Electric Toothbrush",
                Description =
                    "Rechargeable electric toothbrush with multiple cleaning modes and long battery life.",
                Quantity = 200,
                Price = 39.99m,
            },
            new Items
            {
                Id = 9,
                Name = "Smart Home Hub",
                Description =
                    "Home automation hub that connects and controls various smart home devices.",
                Quantity = 50,
                Price = 99.99m,
            },
            new Items
            {
                Id = 10,
                Name = "Fitness Tracker",
                Description =
                    "Wearable fitness tracker with heart rate monitor and step counting functionality.",
                Quantity = 100,
                Price = 29.99m,
            },
            new Items
            {
                Id = 11,
                Name = "Portable Power Bank",
                Description =
                    "Compact power bank with high capacity for charging devices on the go.",
                Quantity = 150,
                Price = 24.99m,
            },
            new Items
            {
                Id = 12,
                Name = "Smart Thermostat",
                Description =
                    "Wi-Fi-enabled smart thermostat with energy-saving features and mobile control.",
                Quantity = 60,
                Price = 149.99m,
            },
            new Items
            {
                Id = 13,
                Name = "Electric Kettle",
                Description =
                    "Fast-boiling electric kettle with temperature control and automatic shut-off.",
                Quantity = 75,
                Price = 29.99m,
            },
            new Items
            {
                Id = 14,
                Name = "Cordless Vacuum Cleaner",
                Description =
                    "Lightweight cordless vacuum with multiple attachments for various surfaces.",
                Quantity = 40,
                Price = 129.99m,
            },
            new Items
            {
                Id = 15,
                Name = "Smart Light Bulbs",
                Description =
                    "Set of two smart LED light bulbs that can be controlled with a mobile app.",
                Quantity = 60,
                Price = 39.99m,
            },
            new Items
            {
                Id = 16,
                Name = "Coffee Maker",
                Description =
                    "Programmable coffee maker with auto-shut off and brew strength settings.",
                Quantity = 80,
                Price = 49.99m,
            },
            new Items
            {
                Id = 17,
                Name = "Air Purifier",
                Description = "Portable air purifier with HEPA filtration for cleaner indoor air.",
                Quantity = 55,
                Price = 99.99m,
            },
            new Items
            {
                Id = 18,
                Name = "Standing Desk Converter",
                Description =
                    "Adjustable desk converter to easily switch between sitting and standing positions.",
                Quantity = 30,
                Price = 199.99m,
            },
            new Items
            {
                Id = 19,
                Name = "Smartwatch",
                Description =
                    "Stylish smartwatch with fitness tracking, notifications, and long battery life.",
                Quantity = 45,
                Price = 119.99m,
            },
            new Items
            {
                Id = 20,
                Name = "Waterproof Bluetooth Speaker",
                Description = "Portable waterproof Bluetooth speaker ideal for outdoor use.",
                Quantity = 35,
                Price = 69.99m,
            },
            new Items
            {
                Id = 21,
                Name = "Compact Digital Camera",
                Description =
                    "High-quality compact digital camera with a 12MP sensor and HD video recording.",
                Quantity = 20,
                Price = 199.99m,
            },
            new Items
            {
                Id = 22,
                Name = "Smart Light Switch",
                Description =
                    "Wi-Fi enabled light switch that can be controlled remotely via smartphone.",
                Quantity = 80,
                Price = 39.99m,
            },
            new Items
            {
                Id = 23,
                Name = "Blender",
                Description =
                    "Powerful countertop blender with multiple speed settings for smoothies and more.",
                Quantity = 60,
                Price = 49.99m,
            },
            new Items
            {
                Id = 24,
                Name = "Wireless Keyboard",
                Description = "Compact and ergonomic wireless keyboard for laptops and desktops.",
                Quantity = 120,
                Price = 29.99m,
            },
            new Items
            {
                Id = 25,
                Name = "Digital Smart Scale",
                Description = "Smart digital scale that tracks weight and syncs with health apps.",
                Quantity = 100,
                Price = 39.99m,
            },
            new Items
            {
                Id = 26,
                Name = "Car Phone Mount",
                Description = "Adjustable phone mount for easy and safe viewing while driving.",
                Quantity = 150,
                Price = 14.99m,
            },
            new Items
            {
                Id = 27,
                Name = "Portable Fan",
                Description =
                    "Rechargeable portable fan with adjustable speeds and long battery life.",
                Quantity = 90,
                Price = 19.99m,
            },
            new Items
            {
                Id = 28,
                Name = "USB-C Charger",
                Description = "Fast-charging USB-C charger for smartphones, tablets, and laptops.",
                Quantity = 200,
                Price = 15.99m,
            },
            new Items
            {
                Id = 29,
                Name = "Electric Grill",
                Description =
                    "Indoor electric grill with non-stick surface and adjustable temperature.",
                Quantity = 40,
                Price = 79.99m,
            },
            new Items
            {
                Id = 30,
                Name = "Smart Security Camera",
                Description =
                    "Wi-Fi enabled smart security camera with motion detection and cloud storage.",
                Quantity = 45,
                Price = 99.99m,
            },
            new Items
            {
                Id = 31,
                Name = "Handheld Vacuum",
                Description = "Portable and lightweight handheld vacuum for quick cleanups.",
                Quantity = 70,
                Price = 49.99m,
            },
            new Items
            {
                Id = 32,
                Name = "Electric Griddle",
                Description = "Large electric griddle for making pancakes, eggs, and more.",
                Quantity = 60,
                Price = 59.99m,
            },
            new Items
            {
                Id = 33,
                Name = "Phone Case",
                Description = "Durable phone case with shockproof protection and sleek design.",
                Quantity = 300,
                Price = 19.99m,
            },
            new Items
            {
                Id = 34,
                Name = "Smart Plugs",
                Description = "Set of smart plugs that can be controlled remotely via smartphone.",
                Quantity = 80,
                Price = 29.99m,
            },
            new Items
            {
                Id = 35,
                Name = "Electric Screwdriver",
                Description =
                    "Cordless electric screwdriver with multiple attachments for various tasks.",
                Quantity = 50,
                Price = 29.99m,
            },
            new Items
            {
                Id = 36,
                Name = "Smart Mirror",
                Description =
                    "Stylish smart mirror with built-in Bluetooth speakers and LED lighting.",
                Quantity = 30,
                Price = 249.99m,
            },
            new Items
            {
                Id = 37,
                Name = "Dumbbell Set",
                Description =
                    "Adjustable dumbbell set with multiple weight options for home workouts.",
                Quantity = 25,
                Price = 89.99m,
            },
            new Items
            {
                Id = 38,
                Name = "Kitchen Mixer",
                Description =
                    "Powerful stand mixer with various speed settings and attachments for baking.",
                Quantity = 45,
                Price = 199.99m,
            },
            new Items
            {
                Id = 39,
                Name = "Smart Glasses",
                Description =
                    "Stylish smart glasses with built-in speakers for hands-free calls and music.",
                Quantity = 20,
                Price = 149.99m,
            },
            new Items
            {
                Id = 40,
                Name = "Camping Tent",
                Description =
                    "Lightweight 2-person camping tent with easy setup and weather-resistant material.",
                Quantity = 35,
                Price = 79.99m,
            },
            new Items
            {
                Id = 41,
                Name = "Electric Shaver",
                Description =
                    "Rechargeable electric shaver with multiple attachments for a smooth shave.",
                Quantity = 50,
                Price = 39.99m,
            },
            new Items
            {
                Id = 42,
                Name = "Bicycle Helmet",
                Description =
                    "Durable and comfortable bicycle helmet with adjustable straps and ventilation.",
                Quantity = 60,
                Price = 29.99m,
            },
            new Items
            {
                Id = 43,
                Name = "Luggage Set",
                Description =
                    "3-piece luggage set with durable hard-shell cases and smooth-rolling wheels.",
                Quantity = 45,
                Price = 149.99m,
            },
            new Items
            {
                Id = 44,
                Name = "Memory Foam Pillow",
                Description =
                    "Ergonomically designed memory foam pillow for neck and back support.",
                Quantity = 100,
                Price = 24.99m,
            },
            new Items
            {
                Id = 45,
                Name = "Digital Alarm Clock",
                Description =
                    "Compact digital alarm clock with large display and adjustable sound settings.",
                Quantity = 200,
                Price = 14.99m,
            },
            new Items
            {
                Id = 46,
                Name = "Water Bottle",
                Description =
                    "Stainless steel water bottle with insulated design to keep beverages cold or hot.",
                Quantity = 150,
                Price = 19.99m,
            },
            new Items
            {
                Id = 47,
                Name = "Camera Tripod",
                Description =
                    "Adjustable tripod for cameras and smartphones, with stable base for shooting.",
                Quantity = 60,
                Price = 29.99m,
            },
            new Items
            {
                Id = 48,
                Name = "Electric Skateboard",
                Description =
                    "Fast and portable electric skateboard with smooth acceleration and long battery life.",
                Quantity = 10,
                Price = 299.99m,
            },
            new Items
            {
                Id = 49,
                Name = "Cordless Drill",
                Description =
                    "High-powered cordless drill with multiple speed settings and drill bits included.",
                Quantity = 50,
                Price = 89.99m,
            },
            new Items
            {
                Id = 50,
                Name = "Smart Pet Feeder",
                Description =
                    "Automated pet feeder with Wi-Fi connectivity and portion control for your pet.",
                Quantity = 45,
                Price = 79.99m,
            },
            new Items
            {
                Id = 51,
                Name = "Waterproof Jacket",
                Description =
                    "Lightweight and breathable waterproof jacket for outdoor activities.",
                Quantity = 75,
                Price = 59.99m,
            },
            new Items
            {
                Id = 52,
                Name = "Camping Stove",
                Description =
                    "Portable camping stove with adjustable heat settings for cooking in the outdoors.",
                Quantity = 40,
                Price = 39.99m,
            },
            new Items
            {
                Id = 53,
                Name = "LED Desk Lamp",
                Description =
                    "Energy-efficient LED desk lamp with adjustable brightness and touch control.",
                Quantity = 100,
                Price = 24.99m,
            },
            new Items
            {
                Id = 54,
                Name = "Leather Wallet",
                Description = "Sleek leather wallet with RFID blocking for secure card storage.",
                Quantity = 120,
                Price = 39.99m,
            },
            new Items
            {
                Id = 55,
                Name = "Bluetooth Headset",
                Description =
                    "Wireless Bluetooth headset with noise reduction and high-quality sound.",
                Quantity = 50,
                Price = 49.99m,
            },
            new Items
            {
                Id = 56,
                Name = "Smartphone Holder",
                Description =
                    "Adjustable smartphone holder with secure grip and multiple angles for easy viewing.",
                Quantity = 150,
                Price = 14.99m,
            },
        };

        [HttpGet("/allitems")]
        public ActionResult<IEnumerable<Items>> GetAllItems()
        {
            return Ok(items);
        }

        [HttpGet("/item/{id}")]
        public ActionResult<Items> GetItem(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
