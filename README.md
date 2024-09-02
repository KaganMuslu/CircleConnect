# CircleConnect

Bu API, kullanıcıların yerel topluluklar oluşturmasını, katılmasını ve etkinlikler düzenlemesini sağlayan bir platform sunmaktadır. 

Topluluklar belirli bir tema veya ilgi alanı etrafında toplanabilir (örneğin, programlama, spor, kitap kulüpleri). Kullanıcılar, toplulukların detaylarını görebilir, etkinliklere katılabilir, sohbet edebilir ve anlık bildirimler alabilirler.

###Teknolojik Detaylar
-	Veritabanı: MySQL, topluluklar, etkinlikler ve kullanıcı profillerini saklamak için kullanılır.
-	Bildirim Sistemi: Anlık bildirimler için Redis Pub/Sub kullanılır.
-	Docker: Docker kullanarak API'nin farklı ortamlarda kolayca dağıtımı sağlanır.
-	.NET Core: API'nin geliştirilmesinde kullanılır, performans ve esneklik için tercih edilir.
