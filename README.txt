1. Commitujemy działający kod. Nie należy commitować kodu, który się nie kompiluje.
2. Używamy znaczących nazw zmiennych. Zmienne nazwane x, y, z itp. są zabronione. Jedyna dopuszczalna możliwość, to stosowanie "i" w pętli for.
3. Każdy commit musi być stosownie opisany. Nie piszemy, co zmieniło się w kodzie, bo to można łatwo sprawdzić, lecz stosujemy opisy słowne tego, co funkcjonalnie zmieniło się w danej rewizji, np. "Dodano możliwość wyboru pliku konfiguracyjnego.".
3. Nie korzystamy z commit -a. Do commita dołączamy tylko te pliki, których zmiana związana jest z rozwijaną i opisaną w commicie funkcjonalnością.
4. Obowiązuje zasada: "funkcjonalność - branch". Rozpoczęcie pisania nowej funkcjonalności oznacza utworzenie nowej gałęzi.
5. Do mastera mergujemy jedynie zakończone funkcjonalności. Nie jest to jednoznaczne z usunięciem gałęzi związanej z daną funkcjonalnością, ponieważ nie mamy pewności, że funkcjonalność nie będzie w przyszłości poprawiana w razie potrzeby tudzież znalezienia błędu. Mastera traktujemy jako miejsce, gdzie znajduje się względnie przetestowana i działająca wersja projektu.
6. Merge do mastera robimy najpierw checkoutując się na master, a potem mergujemy wybraną gałąź. Nie odwrotnie.
7. W razie wątpliwości co zrobić w git, pytamy lub czytamy oficjalną książkę Pro Git (http://git-scm.com/book).