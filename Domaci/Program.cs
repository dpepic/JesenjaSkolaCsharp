/* Domaci za nedelju 30.10 -- 6.11
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
