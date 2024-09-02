# CircleConnect

Bu API, kullanıcıların yerel topluluklar oluşturmasını, katılmasını ve etkinlikler düzenlemesini sağlayan bir platform sunmaktadır. 

Topluluklar belirli bir tema veya ilgi alanı etrafında toplanabilir (örneğin, programlama, spor, kitap kulüpleri). Kullanıcılar, toplulukların detaylarını görebilir, etkinliklere katılabilir, sohbet edebilir ve anlık bildirimler alabilirler.

![image](https://github.com/user-attachments/assets/3b4b0def-bf03-43e2-9e91-07abfe2d9c29)


### Teknolojik Detaylar
-	Veritabanı: <a href="https://www.mysql.com/">MySQL</a>, topluluklar, etkinlikler ve kullanıcı profillerini saklamak için kullanılır.
-	Bildirim Sistemi: Anlık bildirimler için <a href="https://redis.io/">Redis</a> Pub/Sub kullanılır.
-	Docker: <a href="https://www.docker.com/">Docker</a> kullanarak API'nin farklı ortamlarda kolayca dağıtımı sağlanır.
-	<a href="https://dotnet.microsoft.com/en-us/">.NET Core</a>: API'nin geliştirilmesinde kullanılır, performans ve esneklik için tercih edilir.


### Özellikler
- Topluluk Oluşturma
- Toplulukların Keşfi
- Etkinlik Düzenleme
- Sohbet ve İletişim
- Anlık Bildirim ve Güncellemeler
