using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clast.Data.Interfaces;
using Clast.Data.Models;

namespace Clast.Data.Mocks
{
    public class MockLaptops : ILaptop
    {
        private readonly ILaptopCategory _laptopsCategory=new MockCategory();
        public IEnumerable<Laptop> Laptops
        {
            get
            {
                return new List<Laptop>
                {
                    new Laptop
                    {
                        Name = "Lenovo Legion 7i 15 inch",
                        ShortDesc = "Точно откалиброван для разрушения",
                        LongDesc = "До 10 - го поколения Intel ® ™ процессоры HK-Series Ядро i9 Графический адаптер NVIDIA® GeForce RTX ™ в максимальной комплектации.Молниеносные панели с высокой частотой обновления\r\nРеволюционная клавиатура TrueStrike от Lenovo\r\nТочно изготовленное шасси с кожухом из высококачественного алюминия", 
                        Img = "/img/lenovolegion.jpg", 
                        Price = 900, 
                        IsFavourite = true,
                        IsAvailable = true, 
                        LaptopCategory = _laptopsCategory.LaptopCategories.Last()
                    },
                    new Laptop
                    {
                        Name = "Lenovo Thinkpad E495",
                        ShortDesc = "Создан для легкой и эффективной работы в любых условиях",
                        LongDesc = "Этот ноутбук сочетает в себе высокую производительность AMD и легендарную долговечность ThinkPad. Его дискретный модуль доверительной платформы (TPM) и биометрическое устройство распознавания отпечатков пальцев (поставляется опционально) помогают защитить ваши данные, а множество портов и разъемов позволяют с легкостью работать в многозадачном режиме. Стильный ноутбук Lenovo ThinkPad E495 с такими опциями, как система хранения данных с двумя накопителями, FHD-дисплей и клавиатура с подсветкой, – это идеальный выбор для профессионалов, проводящих много времени в дороге.\r\n",
                        Img = "/img/thinkpade495.jpg",
                        Price = 700,
                        IsFavourite = true,
                        IsAvailable = true,
                        LaptopCategory = _laptopsCategory.LaptopCategories.First()
                    },   new Laptop
                    {
                        Name = "MacBook Pro 2019",
                        ShortDesc = "Процессор 2,0 ГГц, 4‑ядерный Intel Core i5 с графическим процессором Intel Iris Plus Graphics Накопитель 512 ГБ",
                        LongDesc = "Процессор 2,0 ГГц, 4‑ядерный Intel Core i5 10‑го поколения с графическим процессором Intel Iris Plus Graphics Ускорение Turbo Boost до 3,8 ГГц  16 ГБ памяти SSD‑накопитель 512 ГБ¹ Дисплей Retina 13 дюймов с технологией True Tone Клавиатура Magic Keyboard Touch Bar и Touch ID Трекпад Force Touch Четыре порта Thunderbolt 3",
                        Img = "/img/macbook.jpg",
                        IsFavourite = true,
                        IsAvailable = true,
                        LaptopCategory = _laptopsCategory.LaptopCategories.First()
                    },
                };
            }
        }

        public IEnumerable<Laptop> GetFavLaptops => throw new NotImplementedException();

        public Laptop GetLaptop(int laptopId)
        {
            throw new NotImplementedException();
        }
    }
}
