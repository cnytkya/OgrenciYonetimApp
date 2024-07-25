using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgfenciYonetimApp
{
    public class Ogrenci //internal erişim belirteci, Ogrenci sınıfının yalnızca aynı assembly (derleme) içinde erişilebilir olduğunu belirtir.
    {//Ogrenci Sınıfın adıdır. Bu sınıf öğrenci ile ilgili bilgileri tutar.
     //property
        public string Ad { get; set; } //public erişim belirteci, Ad özelliğinin diğer sınıflar ve kod bölümleri tarafından erişilebilir olduğunu belirtir.

        public string Soyad { get; set; }
        public int Yas { get; set; }
        public int Numara { get; set; }

        //Bu kod parçası, Ogrenci adında bir sınıf tanımlar ve bu sınıf içinde dört özellik (property) bulunur: Ad, Soyad, Yas, ve Numara. Her bir özellik public erişim belirtecine sahiptir, bu da bu özelliklerin sınıf dışından erişilebilir ve değiştirilebilir olduğu anlamına gelir. Ad ve Soyad özellikleri string veri tipindedir, yani metin değerlerini tutar. Yas ve Numara özellikleri ise int veri tipindedir, yani tamsayı değerlerini tutar.
    }
}