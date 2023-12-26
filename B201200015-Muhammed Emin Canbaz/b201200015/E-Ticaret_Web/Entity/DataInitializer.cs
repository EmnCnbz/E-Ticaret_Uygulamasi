using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Ticaret_Web.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){Name="Kuruyemiş", Description="Kuruyemiş ürünleri"},
                new Category(){Name="Yaş Yemiş", Description="Yaş Yemiş ürünleri"},
                new Category(){Name="Lokum", Description="Lokum ürünleri"},
                new Category(){Name="Şeker", Description="Şeker ürünleri"},
                new Category(){Name="Pişmaniye", Description="Pişmaniye ürünleri"},
            };
            foreach(var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
{
    new Product(){Name="Fındık", Description="Kavrulmuş Fındık 5 Kilogram", Price=2200, Stock=500, IsApproved=true, CategoryId=1,IsHome=true, Image="findik.jpg"},
    new Product(){Name="Antep Fıstığı", Description="Antep Fıstığı 5 Kilogram", Price=2500, Stock=500, IsApproved=true, CategoryId=1,IsHome=true, Image="antep_fistigi.jpg"},
    new Product(){Name="Badem", Description="Kavrulmuş Badem 5 Kilogram", Price=2200, Stock=1000, IsApproved=true, CategoryId=1,IsHome=true,Image="badem.jpg"},
    new Product(){Name="Ay Çekirdeği", Description="Kavrulmuş Çekirdek 5 Kilogram", Price=1500, Stock=500, IsApproved=true, CategoryId=1,IsHome=true,Image="cekirdek.jpg"},
    new Product(){Name="Karışık", Description="Karışık Kuruyemiş 5 Kilogram", Price=2000, Stock=700, IsApproved=true, CategoryId=1,Image="karisik.jpg"},

    new Product(){Name="Kuru Kayısı", Description="Kuru Kayısı 5 Kilogram", Price=2000, Stock=500, IsApproved=true, CategoryId=2,IsHome=true,Image="kuru_kayisi.jpg"},
    new Product(){Name="Kuru üzüm", Description="Kuru Üzüm 5 Kilogram", Price=1200, Stock=500, IsApproved=true, CategoryId=2,IsHome=true,Image="kuru_uzum.jpg"},
    new Product(){Name="Kuru Erik", Description="Kuru Erik 5 Kilogram", Price=1800, Stock=500, IsApproved=true, CategoryId=2,IsHome=true,Image="kuru_erik.jpg"},

    new Product(){Name="Güllü Lokum", Description="Güllü Lokum 5 Kilogram", Price=1200, Stock=500, IsApproved=true, CategoryId=3,Image="gullu_lokum.jpg"},
    new Product(){Name="Fındıklı Lokum", Description="Fındıklı Lokum 5 Kilogram", Price=1500, Stock=500, IsApproved=true, CategoryId=3,IsHome=true,Image="findikli_lokum.jpg"},
    new Product(){Name="Fıstıklı Lokum", Description="Fıstıklı Lokum 5 Kilogram", Price=1500, Stock=500, IsApproved=true, CategoryId=3,IsHome=true,Image="fistikli_lokum.jpg"},
    new Product(){Name="Karışık Lokum", Description="Karışık Lokum 5 Kilogram", Price=1700, Stock=500, IsApproved=true, CategoryId=3,Image="karisik_lokum.jpg"},



    new Product(){Name="Karışık Meyveli Şeker", Description="Karışık Meyveli Şeker 5 Kilogram", Price=1000, Stock=500, IsApproved=true, CategoryId=4,IsHome=true,Image="meyveli_seker.jpg"},
    new Product(){Name="Sütlü Şeker", Description="Sütlü Şeker 5 Kilogram", Price=2200, Stock=900, IsApproved=true, CategoryId=4,IsHome=true,Image="sutlu_seker.jpg"},
    new Product(){Name="Kahveli Şeker", Description="Kahveli Şeker 5 Kilogram", Price=2200, Stock=800, IsApproved=true, CategoryId=4,IsHome=true,Image="kahveli_seker.jpg"},
    new Product(){Name="Yumuşak Meyveli Şeker", Description="Yumuşak Meyveli Şeker 5 Kilogram", Price=700, Stock=500, IsApproved=true, CategoryId=4,Image="yumusak_meyveli_seker.jpg"},
    new Product(){Name="Limonlu Şeker", Description="Limonlu Şeker 5 Kilogram", Price=2200, Stock=600, IsApproved=true, CategoryId=4,Image="limonlu_seker.png"},

};

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}