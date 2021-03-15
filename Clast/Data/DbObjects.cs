using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clast.Data.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Clast.Data
{
    public static class DbObjects
    {
        public static void Initial(AppDbContext appDb)
        {
        

            
            if (!appDb.Categories.Any())
            {
                appDb.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!appDb.Laptops.Any())
            {
                appDb.AddRange
                (
                    new Laptop
                    {
                        Name = "Lenovo Legion 7i 15 inch",
                        ShortDesc = "Точно откалиброван для разрушения",
                        LongDesc =
                            "До 10 - го поколения Intel ® ™ процессоры HK-Series Ядро i9 Графический адаптер NVIDIA® GeForce RTX ™ в максимальной комплектации.Молниеносные панели с высокой частотой обновления\r\nРеволюционная клавиатура TrueStrike от Lenovo\r\nТочно изготовленное шасси с кожухом из высококачественного алюминия",
                        Img = "/img/lenovolegion.jpg",
                        Price = 900,
                        IsFavourite = true,
                        IsAvailable = true,
                        LaptopCategory = Categories["Игровой"]
                    },
                    new Laptop
                    {
                        Name = "Lenovo Thinkpad E495",
                        ShortDesc = "Создан для легкой и эффективной работы в любых условиях",
                        LongDesc =
                            "Этот ноутбук сочетает в себе высокую производительность AMD и легендарную долговечность ThinkPad. Его дискретный модуль доверительной платформы (TPM) и биометрическое устройство распознавания отпечатков пальцев (поставляется опционально) помогают защитить ваши данные, а множество портов и разъемов позволяют с легкостью работать в многозадачном режиме. Стильный ноутбук Lenovo ThinkPad E495 с такими опциями, как система хранения данных с двумя накопителями, FHD-дисплей и клавиатура с подсветкой, – это идеальный выбор для профессионалов, проводящих много времени в дороге.\r\n",
                        Img = "/img/thinkpade495.jpg",
                        Price = 700,
                        IsFavourite = false,
                        IsAvailable = true,
                        LaptopCategory = Categories["Бизнес-ноутбук"]
                    }, new Laptop
                    {
                        Name = "MacBook Pro 2019",
                        ShortDesc =
                            "Процессор 2,0 ГГц, 4‑ядерный Intel Core i5 с графическим процессором Intel Iris Plus Graphics Накопитель 512 ГБ",
                        LongDesc =
                            "Процессор 2,0 ГГц, 4‑ядерный Intel Core i5 10‑го поколения с графическим процессором Intel Iris Plus Graphics Ускорение Turbo Boost до 3,8 ГГц  16 ГБ памяти SSD‑накопитель 512 ГБ¹ Дисплей Retina 13 дюймов с технологией True Tone Клавиатура Magic Keyboard Touch Bar и Touch ID Трекпад Force Touch Четыре порта Thunderbolt 3",
                        Img = "/img/macbook.jpg",
                        Price = 10000,
                        IsFavourite = true,
                        IsAvailable = true,
                        LaptopCategory = Categories["Бизнес-ноутбук"]
                    });



            }

            appDb.SaveChanges();

        }

        private static Dictionary<string, LaptopCategory> categories;
            public static Dictionary<string, LaptopCategory> Categories
            {
            get
                {
                    if (categories==null)
                    {
                        var list = new LaptopCategory[]
                        {
                            new LaptopCategory {CategoryName = "Бизнес-ноутбук", Desc = "Для работы"},
                            new LaptopCategory {CategoryName = "Игровой", Desc = "Для игр"}
                        };
                        categories = new Dictionary<string, LaptopCategory>();
                        foreach (LaptopCategory cate in list)
                        {
                            categories.Add(cate.CategoryName, cate);
                        }

                       
                    }
                    return categories;
            }
           


        }
        

    }
}
