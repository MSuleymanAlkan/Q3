# Q3
 1. Öncelikle iskambil kartı olarak kullanmak için CardType ve CardValue adlarıyla iki adet enum oluşturdum.
 2. Card.cs classında enumları kullanarak bir kart yapısı oluşturdum.
 3. Sonrasında oluşturduğum card türünde bir liste yapısı kullanarak bütün iskambil destesini oluşturduğum Deck classının construturunda implemente ettim ve elimizde 52 kartlık bir liste oluştu.
 
Devam Eden Aşamalarda;
 1. Öncelikle IPlayer adında bir interface ve bu interface'i temel alarak Player adında bir class oluşturacağım.
 2. Sonrasında Player classından iki adet player oluşturacağım.
 3. cardList'ten random bir kart çekerek playerların score'larını ekleyeceğim.
 4. Bu aşamada playerların scorelarına eklenecek kartların cardValuelar'ı Jack, Queen veya King ise 10 puan, Ace ise kullanıcı isteğine göre 1 veya 10 puan, diğer kartlardan biri ise kartın puanı eklenir.
 5. Kart puanı 21 i geçen kullanıcı oyunu kaybedecektir.
 6. İsteyen kullanıcı sıra kendine geldiğinde kart çekmeyi bırakıp diğer kullanıcıyı bekleyebilir.
