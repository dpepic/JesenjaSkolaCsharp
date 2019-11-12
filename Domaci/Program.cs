/* Domaci za nedelju 11.11 -- 17.11
 * Projektni zadatk -- Pogadjanje reci
 * 
 * Imacemo fajl sa hrpom reci (najlakse da rec bude
 * po redu, no kako god zelite :) )
 * 
 * Kada se aplikacija upali, prikazemo korisniku
 * meni iz koga moze da pogadja rec, vidi top listu 
 * bodova i, naravnom izadje :) .
 * 
 * Ako izabere pogadjanje reci, uzima se nasumicno
 * rec iz naseg dokumenta. Prikaze se koliko slova ima,
 * npr. ako je rec "test" prikaze se _ _ _ _
 * Korisnik u tom momenmtu moze da unese slovo ili
 * da proba da pogodi rec. Ako unese jedno slovo
 * moramo da proverimo da li ga rec sadrzi. Npr,
 * ako je uneo 't' sada treba da se prikaze
 * t _ _ t
 * Posto je string niz karaktera, ovu pretragu najlakse
 * obavite sa jednom for petljom, jer ako je 
 * string rec vi imate svako pravo da kazete rec[0] da
 * vidite prvo slovo. A predlazem for zato sto vam 
 * treba indeks da bi znali gde da upisete slova
 * u ovaj string koji prikazujete korisniku.
 * 
 * Racuna se broj pokusaja za pogodak. Kada
 * korisnik pogodi rec treba da proverimo top listu, 
 * koja se sastoji od 5 najboljih,
 * ako na njoj ima jos mesta, ili ako je korisnik
 * pobedio neki skor, treba da mu ponudimo da upise
 * ime i da ga stavimo na mesto koje mu pripada
 * 
 * Top listu najbrzih cuvamo u fajlu
 * da bi ostala i kada ugasimo aplikaciju :)
 * 
 * 
 * 
 * 
 * Domaci za nedelju 30.10 -- 6.11
 *  Projektni zadatak -- POS (point of sales)
 *  
 *  Cilj nam je da napravimo program gde korisnik
 *  moze da unese artikal, i da izda racune sa tim
 *  artiklima
 *  Imenik vam je referentan primer za sve sto ovde
 *  radimo :)
 *  
 *  Specifikacija:
 *  --Pri pokretanju dobija meni, gde bira izmedju
 *    unosa artikla, pregleda artikla i izdavanja racuna
 *    
 *   --Po izboru unosa artikla, trazi se sifra, naziv
 *     i cena. To smestamo u listu tuplova za artikle
 *     
 *   --Izlistavanje artikala radi tacno to, prikazuje
 *     sve artikle koje je korisnik uneo
 *   --Izdavanje racuna trazi od korisnika da unese
 *     sifru i kolicinu artikla.
 *        --Treba pretraziti listu za tim artiklom, 
 *          i ako postoji uneti ga u neki tuple za racun
 *          (npr naziv artikla, kolicina i cena (cena ovde je cena artikla*kolicina :))
 *          --Pita se korisnik da li dodaje jos artikala, i ako 
 *          treba jos vracamo se nazad, ako ne prikazuje se
 *          racun sa artiklima na njemu i total za racun
 *    --Dodatni izazovi:
 *      --Uklanjanje artikla
 *      --Pracenje kolicine
 *              +Artikli bi imali i navedeno koliko ima na stanju,
 *              pa ako pokusamo da izdamo racun za artikal koga nema dovoljno
 *              na stanju, to ne sme da se dozvoli
 *              +Po izdavanju racuna, kolicina artikla
 *              se umanjuje
 *      --Upisivanje artikala u fajl 
 * 
 * 
 * 
 * 
 * Domaci za nedelju 21.10 -- 27.10
 * 
 * FizzBuzz 
 * ----------
 * Standardan test na intervjuima :) 
 * -Korisnik treba da unese broj.
 * -Treba stampati sve brojeve od 1 do broja koji je korisnik izabrao
 *      -Ako je neki od brojeva deljiv sa tri pisemo Fizz, npr 3 -- Fizz
 *      -Ako je neki broj deljiv sa pet pisemo Buzz, npr 20 -- Buzz
 *      -Ako je neki broj deljiv i sa pet i sa tri pisemo FizzBuzz, npr 15 -- FizzBuzz
 *      
 * Fibonacci
 * -----------
 * Fibonacijev niz je jako cest u prirodi. Semena suncokreta su rasporedjenja po njemu, 
 * generacije pcela su organizovana po njemu... :) mi cemo da napravimo program koji ga
 * racuna.
 * 
 * Korisnik kaze koliko elemenata treba da racunamo.
 * Fibonacijev niz izgleda ovako:
 * 0 1 1 2 3 5 8 13 21 34...              
 * Svaki clan se racuna tako sto saberemo dva clana pre njega. 1 + 1 = 2, pa 1 + 2 = 3, pa 2 + 3 = 5...
 * 
 * Sifriranje
 * ------------
 * Korisnik otkuca poruku i izabere broj. 
 * Poruku sifriramo tako sto svako slovo "pomerimo" za broj koji je korisnik izabrao
 * Saveti:
 *      -string je niz karaktera, pa mozemo lagano da prodjemo kroz njega sa foreach petljom
 *      -prazan prostor, tacke, zareze, sve sem slova necemo da menjamno
 *      -paziti na kraj abecede, z + 2 treba da izadje na b a ne neki levi karakter :) 
 * Dodatni izazov:
 *      -Opcija da desifrira tekst
 *      -Sifriran string ne samo prikazati nego ga sacuvati u neku promenljivu
 *      
 * Pravougaonik
 * ------------
 * Korisnik izabere duzinu i sirinu, mi "crtamo" pravougaonik na ekranu.
 * Primer, za 3x4 bi bilo
 *      ++++
 *      +  +
 *      ++++
 * 
 * Kolatzov zakljucak 
 * -----------
 * Trazimo od korisnika da unese pozitivan broj. 
 * Po Kolatzovom zakljucku, ako krenemo od tog broja i radimo sledece postupke:
 *      --Ako je broj paran, delimo ga sa dva
 *      --Ako je broj neparan, mnozimo ga sa tri i dodajemo jedan
 *      --Eventualno rezultat ce biti 1.
 */
