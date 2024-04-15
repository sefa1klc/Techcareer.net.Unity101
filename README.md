# Techcareer.net.Unity101
![solid](https://github.com/sefa1klc/Techcareer.net.Unity101/assets/79375624/5b63bd8f-a42a-440e-b5d0-31d3f9ea0c91)

**S - Tek Sorumluluk Prensibi (Single Responsibility Principle):** Bir sınıfın, fonksiyonun veya modülün yalnızca bir tek sorumluluğu olmalıdır. Bu, kodun daha modüler olmasını sağlar ve değişikliklerin diğer bileşenlere daha az etki etmesini sağlar.

**O - Açık Kapalı Prensibi (Open/Closed Principle):** Yazılım birimleri (sınıflar, modüller, fonksiyonlar vb.), genişletilebilir ancak değiştirilemez olmalıdır. Yani, mevcut kodu değiştirmeden yeni işlevsellik eklemek mümkün olmalıdır.

**L - Liskov Yerine Koyma Prensibi (Liskov Substitution Principle):** Alt sınıflar, üst sınıfların yerine geçebilmelidir, yani bir üst sınıf nesnesinin yerine alt sınıf nesnesi kullanıldığında herhangi bir sorun çıkmamalıdır.

**I - Arayüz Ayrımı Prensibi (Interface Segregation Principle):** Kullanıcıların ihtiyacı olmayan arayüzlerin bir sınıfa zorunlu olarak uygulanmaması gerektiğini belirtir. Bunun yerine, daha küçük, özelleştirilmiş arayüzler tercih edilmelidir.

**D - Bağımlılıkların Tersine Çevrilmesi Prensibi (Dependency Inversion Principle):** Yazılım birimleri yüksek seviyeli modüllere değil, düşük seviyeli modüllere bağlı olmalıdır. Ve detaylar soyutlamalar üzerinden bağımlı hale getirilmelidir.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![oop](https://github.com/sefa1klc/Techcareer.net.Unity101/assets/79375624/757265f5-95f4-4576-b1e9-03f1e21b28e1)

**Kapsülleme (Encapsulation):** Kapsülleme, veri ve işlevselliği bir araya getirerek bir nesnenin iç durumunu korumak için kullanılır. Bu, nesnelerin iç verilerine doğrudan erişimi kısıtlamak ve sadece belirli yöntemler aracılığıyla erişim sağlamak anlamına gelir.

**Kalıtım (Inheritance):** Kalıtım, bir sınıfın diğer bir sınıftan özelliklerini (alanlar ve yöntemler) miras alabilmesini sağlar. Bu, kodun yeniden kullanılabilirliğini artırır ve sınıflar arasında hiyerarşik ilişkiler oluşturur.

**Çok Biçimlilik (Polymorphism):** Çok biçimlilik, aynı isimdeki yöntemlerin farklı sınıflar tarafından farklı şekillerde uygulanabilmesini sağlar. Bu, aynı yönteme farklı nesneler üzerinden erişilirken farklı davranışların ortaya çıkmasına olanak tanır.

**Birlikte Kullanılabilirlik (Abstraction):** Soyutlama, sınıfların ve nesnelerin karmaşıklığını gizleyerek sadece önemli özellikleri ve işlevleri ortaya çıkarır. Bu, programlama sürecini basitleştirir ve kodun daha modüler ve yeniden kullanılabilir olmasını sağlar.

**Sınıflar ve Nesneler (Class and Objects):** Sınıflar, nesnelerin yapılarını ve davranışlarını tanımlamak için kullanılır. Nesneler, bu sınıfların örnekleridir ve gerçek dünyadaki varlıkları temsil ederler.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![052616_1018_CFundamenta15](https://github.com/sefa1klc/Techcareer.net.Unity101/assets/79375624/85d0e704-2165-4b16-8cef-b8f5bf049956)

**Enum Sınıfları (Enumeration Classes):** Enum sınıfları, belirli bir türdeki sabit değerlerin bir koleksiyonunu temsil eder. Örneğin, haftanın günleri gibi sıralı bir listeyi temsil etmek için kullanılabilirler. Enum sınıfları, sabitlerin okunabilirliğini artırır ve kodun daha anlaşılır olmasını sağlar.

> public record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}

**Kaydediciler (Records):** Kaydediciler, değiştirilemez veri yapılarıdır ve verileri saklamak ve almak için kullanılırlar. Bir kaydedici, genellikle verileri saklamak için kullanılan alanları içerir ve varsayılan olarak sabit ve değişmez bir yapıya sahiptir.

> public struct Point
{
    public int X;
    public int Y;
}

**Yapılar (Structs):** Yapılar, programlamada bir veri türüdür ve farklı türdeki verileri bir araya getirmek için kullanılır. Genellikle ilgili verileri gruplamak ve birbirine bağlamak için kullanılırlar. 



