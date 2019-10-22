/* Domaci za nedelju 21.10 -- 27.10
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
