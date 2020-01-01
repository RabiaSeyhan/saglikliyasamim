using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace webOdevi.Models
{
    public class EgzersizListemInitializer: DropCreateDatabaseIfModelChanges<EgzersizListemContext>
    {
        public static List<YemekTarifi> Liste { get; internal set; }

        protected override void Seed(EgzersizListemContext context)
        {
            List<YemekTarifi> Tarifler = new List<YemekTarifi>()
            {
                 new YemekTarifi(){YemekAdi="Hafif Çorba",YemekMalzemeler=

                " • 1 kg kabak " +
                " • Yarım kg patates   " +
                " • 5 tane havuç  " +
                " • 50 gr taze zencefil" +
                " • 1 çay kaşığı pul biber" +
                " • 1 dolu çay kaşığı tuz" +
                " • 1 çay kaşığı karabiber" , YemekHazirlanisi="1 kg kabağı, yarım kg patatesi ve 5 tane havucu doğrayıp" +
                " büyük bir tencereye ekleyin.50 gr taze zencefili de ince ince kıyıp tencereye " +
                "ekleyin.Sonrasında  birer çay kaşığı tuz, pul biber ve karabiber ekleyin.Üzerini bir " +
                "parmak geçecek kadarsu ekleyin ve tencerenin kapağını kapatıp 20 dk pişmeye bırakın 20 dk sonrasında " +
                "kapağını açıp çorbayı blenderdan pürüzsüz olana dek çekin.Afiyet olsun.",Resim="/imgg/455.jpg",yemid=1},
                 new YemekTarifi (){YemekAdi="Körili Çorba",YemekMalzemeler="• 4 yemek kaşığı hindistan cevizi ya da zeytin yağı " +
                 " • 3 çay kaşığı taze limon suyu  • 6 su bardağı tavuk suyu  • deniz tuzu • 5 su bardağı ince halkalar halinde doğranmış havuç" +
                 "• karabiber  • 2 su bardağı doğranmış havuç  • 2 çay kaşığı limon kabuğu rendesi  • 2 çay kaşığı köri tozu • 1 tatlı kaşığı taze zencefil, doğranmış" +
                 "• 1 çay kaşığı kişniş • ½ çay kaşığı toz hardal",YemekHazirlanisi="Orta boy bir tencereyi ocağa alın ve Hindistan cevizi yağını " +
                 "(ya da zeytinyağı) tencereye alın.İçerisine kişniş, hardal tohumları ya da hardal tozu, köri ve " +
                 "doğranmış zencefili de tencereye atıp bir dakika karıştırın. Üzerine biraz da tuz ve karabiber serpin.Doğranmış soğanları da" +
                 "ilave edin ve soğanlar " +
                 "yumuşayana kadar karıştırarak pişirin. Daha sonra tavuk suyunu da ekleyin." +
                 "Havuçları halka halka doğrayın ve onları da tencereye atıp, orta ateşte yaklaşık 30 dakika pişirin." +
                 " Çorba piştikten sonra, el blender’ı kullanarak malzemeleri pürüzsüz bir kıvam elde edene kadar " +
                 "blender’dan geçirin. Limon suyu ve maydanoz yaprakları ile süsleyerek servis edin.",Resim="/imgg/kcorba.jpg", yemid=2},
                   new YemekTarifi (){YemekAdi="Elmalı Balkabağı Çorbası",YemekMalzemeler=" • 4 yemek kaşığı tereyağı  • 1 adet soğan, doğranmış • 1 adet elma" +
                   " • 2 çay kaşığı kurutulmuş adaçayı • 2 çorba kasesi doğranmış balkabağı • 4 su bardağı tavuk suyu • ½ su bardağı Hindistan cevizi sütü" +
                   " • muskat cevizi • deniz tuzu  • karabiber ",YemekHazirlanisi=" Bir tencereyi ocağa alın ve orta ateşte altını yakın. Tereyağı" +
                   " tencerede eritin. Yağ eriyince,ince doğranmış soğanları tencereye alın ve yumuşayınca, soyulup çekirdeği çıkarılmış " +
                   "elmaları ve kurutulmuş adaçayını da ekleyin. Ara sıra karıştırarak 7-8 dakika pişirin.Doğranmış balkabağını da tencerenin içine atın. " +
                   "Daha sonra tavuk suyunu da ekleyin ve kabaklar iyice yumuşayana kadar kaynatın. Balkabağının piştiğini kontrol etmek için çatal" +
                   " batırma yöntemini deneyebilirsiniz.Karışım soğumaya başlayınca blender’dan geçirin.   Ardından içerisine Hindistan cevizi sütünü de" +
                   " ekleyin ve çorbayı kısık ateşte ocağa alıp yeniden ısıtın. İçerisine deniz tuzu, karabiber ve taze rendelediğiniz muskat cevizi de " +
                   "ekleyip, sıcak olarak servis edin.",Resim="/imgg/balll.jpg", yemid=3 },
                   new YemekTarifi (){YemekAdi="Bostana Salatası",YemekMalzemeler=" • 4 tane orta boy domates • 5 dal taze soğan • 5-6 adet sivri biber • 1 soğan" +
                   " • 1 salatalık • yarım bağ maydanoz • 1 diş sarımsak • 3 çorba kaşığı nar ekşisi • 1 tatlı kaşığı tuz • 1 limon " +
                   "• 6 çorba kaşığı zeytinyağı ",YemekHazirlanisi=">4 adet domatesi soyun. Soyduğunuz domatesleri, 5 dal taze soğanı, 1 kuru soğanı " +
                   "1 adet salatalığı, yarım bağ maydanozu incecik doğrayıp büyük bir kasede birleştirin.1 diş sarımsağı havanda ezin. Üzerine 6 çorba kaşığı " +
                   "zeytinyağı,3 çorba kaşığı nar ekşisi, 1 limonun suyu ve 1 tatlı kaşığı tuzu ekleyip karıştırın.Sosu salataya ekleyip karıştırın.Salata " +
                   "bir saat kadar beklerse suyunu güzelce salacak ve çok daha lezzetli olacaktır. Buzdolabında iyice soğutup" +
                   " yemenizi şiddetle tavsiye ederim. Yoksa içine birkaç tane buz bile atabilirsiniz. ",Resim="/imgg/bostana.jpg", yemid=4},
                   new YemekTarifi (){YemekAdi="Siyezli Mercimek Salatası",YemekMalzemeler="  • 1 su bardağı yeşil mercimek • Yarım su bardağı siyez bulguru " +
                   "• 1/3 bağ dereotu • 2 tane kırmızı kapya biber • 3 tane salatalık turşusu• 4 çorba kaşığı zeytinyağı • 2 çorba kaşığı sirke " +
                   "• 2 çorba kaşığı soya • Yarım çay kaşığı pul biber • Limon",YemekHazirlanisi=" 1 su bardağı yeşil mercimeği yıkayın ve " +
                   "tencerede 20 dakika kadar haşlayın.Yarım su bardağı siyez bulgurunu yıkayın ve tencerede 30 dakika kadar haşlayın.2 kırmızı" +
                   " kapya biberi küp küp doğrayın.3 salatalık turşusunu küp küp doğrayın.Haşlanan yeşil mercimeği ve siyez bulgurunu süzdükten " +
                   "sonra bir kapta karıştırın.Üzerine 4 çorba kaşığı zeytinyağını, 2 çorba kaşığı sirkeyi, 2 çorba kaşığı soya sosunu ve yarım" +
                   " çay kaşığı pul biberi ekleyin ve hepsi birbiriyle özdeşene kadar karıştırın.Hazırladığınız salatanızı tabağa koyun hafif " +
                   "dinlenince isteğinize göre limon sıkabilirsiniz, afiyet olsun.",Resim="/imgg/siyezli.jpg", yemid=5},
                   new YemekTarifi (){YemekAdi="Avokado Salatası",YemekMalzemeler=" • 2 kutu, 300 gr, ton balığı • 1 adet avokado • Yarım limon" +
                   " • 2 çorba kaşığı zeytinyağı  • 1 çay kaşığı tuz • 1 çay kaşığı karabiber",YemekHazirlanisi="2 kutu ton " +
                   "balığına, 1 adet avokadoyu ekleyin.Üzerine yarım limonun suyunu sıkın. 2 çorba kaşığı zeytinyağı, birer çay" +
                   " kaşığı tuz ve karabiber ekleyin.Hepsini karıştırın.",Resim="/imgg/avakado.jpg", yemid=6},
                   new YemekTarifi (){YemekAdi="Mantarlı Lahana ",YemekMalzemeler=" • 1/5 lahana • 10 adet mantar • 2 dal taze soğan • 2 çorba kaşığı zeytinyağı" +
                   "• 4 parça ceviz içi • 1 bardak süt • 1 iri diş sarımsak • 1 çay kaşığı tuz • 1 çay kaşığı karabiber • Çeyrek muskat",
                       YemekHazirlanisi ="1/5 lahanayı makarna gibi uzun uzun kesin. Ardından elinizle birkaç kez sıkarak gevşetin.Ardından" +
                   " 10 adet mantarı hafif dişe gelecek şekilde kalınca dilimleyin.Ufak bir tencereye" +
                   " 1 çorba kaşığı zeytinyağı koyup ısıtın. İçine 1 iri diş sarımsağı dilimleyip zeytinyağına" +
                   " ekleyin.Ardından mantarları da peyderpey yağ ve sarımsağın üzerine ekleyin.Mantarların" +
                   " yer yer kahverengileşinceye kadar yüksek ateşte ve karıştırarak kavurun.Üzerine" +
                   " 1 bardağa yakın süt koyup kısık orta ateşte pişirin. Bu süt biraz uçuğ bizim makarnamızın " +
                   "krema gibi sosu haline gelecek. Üzerine bir çay kaşığı tuz, yaırm çay kaşığı karabiber ve" +
                   " çeyrek muskat rendeleyin.Gneiş bir tavaya 1 çorba kaşığı zeytinyağı koyup ısıtın. İçine " +
                   "lahanaları ekleyip yüksek ateşte kavurmaya başlayın.Mantar gibi lahanayı da altını kısmadan," +
                   "suyunu saldırmadan arada karıştırarak kavurmalısınız.Bu sırada içine kabaca doğranmış 4 parça" +
                   " iç cevizi ekleyin ve kavurmaya devam edin. Ağız tadınıza göre tuz ekleyin. Mantarlı sosu da " +
                   "ekleyip altını kapatın. 2 dal taze soğanın yeşil kısımlarını ince ince dilimleyip makarnaya " +
                   "ekleyin. Lezzetini biraz daha arttırmak isterseniz içine bir kaç kaşık soya da koyabilirsiniz. " +
                   "Kalan karabiberi ve muskatı da son olarak üzerine serpince kremalı makarnanız emrinize amade.",Resim="/imgg/mantarli.jpg", yemid=7},
                   new YemekTarifi (){YemekAdi="Leblebili,Bol Sebzeli Mücver",YemekMalzemeler ="   • 4 adet havuç • 2 adet kabak • 4 diş sarımsak • 100 gr sarı leblebi" +
                   " • 3 yumurta • 1 tatlı kaşığı tuz • 1 tatlı kaşığı karabiber • 5 çorba kaşığı zeytinyağı • 1/3 bağ maydanoz" +
                   " • 1 paket kabartma tozu • 120 gr kaşar peyniri • susam • Süzme yoğurt • çörek otu", YemekHazirlanisi ="100 gr leblebiyi mutfak" +
                   " robotunda iyice un olana dek çekin.4 adet havucu ve 2 adetkabağı kabaca doğrayıp mutfak robotuna ekleyin.4 diş sarımsağı da koyup tüm sebzeleri"+
                   " çekin.Tüm sebzeleri çekince büyük bir kaseye alıp üzerine 3 yumurta kırın.Birer tatlı"+
                   " kaşığı tuz, karabiber, 1 paket kabartma tozu ve 3 çorba kaşığı zeytinyağı ekleyin."+
                   " 1/3 bağ maydanozu ince ince kıyıp kaseye ekleyin.Tüm malzemeler iyice karışana kadar"+
                   " karıştırın.Ufak bir fırın tepsisini 2 çorba kaşığı zeytinyağıyla yağlayıp karışımı içine"+
                    "dökün.Üzerini düzleyip 120 gr rendelenmiş kaşarı serpin.Son olarak susam ve çörek otunu"+
                   " şeritler halinde dökün.200 derecede, altlı, üstlü çalışan fırının tabanına mücveri tepsiyle"+
                  "  koyup 20 dakika pişirin.Sonra orta rafa alıp fırın telinin üzerinde de 10 dakika pişirin."+
                   " Servis ederken, üzerine süzme yoğurt da koymayı unutmayın",Resim="/imgg/leblebili.jpg", yemid=8},
                   new YemekTarifi (){ YemekAdi=" Kıymalı Karnabahar ",YemekMalzemeler =" • 100 gr çift yağsız kıyma • 1 orta boy soğan  • 1/3 karnabahar • 2 diş sarımsak " +
                   "• 1 çorba kaşığı zeytinyağı • 6 çorba kaşığı domates püresi • 4 çorba kaşığı yoğurt", YemekHazirlanisi ="100 gr yağsız kıymayı" +
                   " bir tavada kavurun ve robottan çektiğiniz 1 soğanı kıymaya ekleyin.Kıymalar güzelce kahverengi olana dek kavurun. " +
                   "Arada içine birkaç kaşık su ekleyip tavadaki güzellikleri sıyırabilirsiniz.Karnabaharın 1/3 ünü ince ince dilimleyip 1 çorba kaşığı" +
                   " zeytinyağı ile tavada yüksek ateşte 2 dakika kavurun. Sonra içine 2 diş sarımsağı doğrayıp" +
                   " ekleyin. 2 dakika  daha kavurduktan sonra bir parça su ekleyin yumuşayınca kenara alın.Bir" +
                   " sos tenceresinde, 6-7 çorba kaşığı domates püresini ısıtın. Tabağa sırasıyla önce Karnabaharları"+
                    "koyun. Üzerine domates  püresinden gezdirin. Tabağın iki yanına 3-4 çorba kaşığı yoğurdu"+
                    "koyup en son üzerine kavrulmuş kıymayı da koyup servis edebilirsiniz.",Resim="/imgg/iskender.jpg", yemid=9}
            };
            foreach (var item in Tarifler)
            {
                context.tarifler.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        
    




            List <EgzesizOnerileri> Egzersizler = new List<EgzesizOnerileri>()
            {
                new EgzesizOnerileri () { Resim ="/1/i1.jpg", ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/i2.jpg",ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () {Resim ="/1/i3.jpg",ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () {Resim ="/1/i5.jpg",ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/i4.jpg",ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/i6.jpg",ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/i7.jpg",ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () {  Resim ="/1/i8.jpg",ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/i9.jpg",ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/i11.jpg",ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/i12.jpg",ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/sıcrama.jpg",ekle=false,aciklama="Isınma Hareketi"},
                new EgzesizOnerileri () {  Resim ="/1/10.jpg", ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/11.jpg",ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"},
                new EgzesizOnerileri () {Resim ="/1/12.jpg",ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/4.jpg",ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/5.jpg",ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/6.jpg",ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"},
                new EgzesizOnerileri () {Resim ="/1/7.jpg",ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"},
                new EgzesizOnerileri () {  Resim ="/1/8.jpg",ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"},
                new EgzesizOnerileri () {Resim ="/1/9.jpg",ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/i10.jpg",ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"},
                new EgzesizOnerileri () { Resim ="/1/r1.jpg",ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"},
                new EgzesizOnerileri () {Resim ="/1/1111.jpg",ekle=false,aciklama="Zayıflama ve Sıkılaşma Hareketi"}


            };
            foreach (var egzersiz in Egzersizler)
            {
                context.egzersizOnerileri.Add(egzersiz);
            }
            context.SaveChanges();

            base.Seed(context);

            List<magaza> Magazalar = new List<magaza>()
            {
                 new magaza (){resim ="/imgc/minder.jpg", isim="PİLATES MİNDERİ",fiyat=51.40},
                 new magaza (){resim="/imgc/pbandi.jpg",isim="PİLATES BANDI",fiyat=13.90},
                 new magaza (){resim="/imgc/prottozu.jpg",isim="PROTEİN TOZU 908 Gr ",fiyat=129.00},
                 new magaza (){resim="/imgc/ddambil.jpg",isim="DAMBIL 20 Kg",fiyat=113.70},
                 new magaza (){resim="/imgc/su.jpg",isim="ORJİNAL SU MATARASI",fiyat=99.99},
                 new magaza (){resim="/imgc/sporatlet.jpg",isim="KADIN SPORCU ATLETİ ",fiyat=59.99}

            };
            foreach (var item in Magazalar)
            {
                context.magazalar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);

            List<Yorum> Yorumlar = new List<Yorum>()
            {
              new Yorum(){KullaniciAdi="Admin",yorum="Saygılı bir çerçevede bizden neler beklediğinizi söylerseniz yapmaya çalışırız:)"}
            };

            foreach (var ite in Yorumlar)
            {
                context.yorumlar.Add(ite);
            }
            context.SaveChanges();


            base.Seed(context);
        }
    }

}
