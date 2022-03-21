using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "2044-et írunk, és a valóság elég ronda egy hely. Az emberiség nagy részéhez hasonlóan a gimnazista Wade Watts is azt a kiutat látja zord környezetéből, hogy bejelentkezik az OASIS-ba, a világméretű virtuális utópiába, ahol az avatárján keresztül mindenki szabadon tanulhat, dolgozhat, és szórakozhat. Ugyancsak az emberiség nagy részéhez hasonlóan Wade is arról álmodozik, hogy ő találja meg elsőként a virtuális világ elrejtett kincsét. A szimuláció tervezőjeként ismert James Halliday ugyanis ördögi feladványt hagyott maga után, amelynek leggyorsabb megfejtője szédületes vagyonra és hatalomra tehet szert.A Halliday által kifundált feladatok sikeres teljesítéséhez a popkultúra megszállott ismeretére van szükség, Wade pedig éppúgy otthon van a Gyalog galoppban, mint a Pac-Manben, a Rush életművében vagy az animékben. Amikor a tizennyolc éves srác hosszú évek kitartó munkája után megoldja az első feladványt, hirtelen a figyelem középpontjába kerül, és ez életveszélybe sodorja. Egyes játékosok ugyanis még a gyilkosságig is hajlandóak elmenni a mesés nyeremény megszerzéséért.", "https://s06.static.libri.hu/cover/e2/7/2625545_5.jpg", 9.99m, "Ready Player One" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Az 1984 (eredeti címén Nineteen Eighty-Four) egy szatirikus politikai regény és szerelmi történet George Orwelltől. Olyan disztópia (negatív utópia), amelyben a felügyelő állam tökéletes alkalmazkodást követel a polgároktól hazugságokkal, félelemkeltéssel és kegyetlen büntetésekkel. Az 1949-ben kiadott mű Orwell legnépszerűbb munkája, és az „orwelli” jelzőt ennek világára használjuk. Sok nyelvre lefordították; magyarul először a „Magyar Október” Szabadsajtó nevű szamizdatkiadó adta ki Antal György fordításában, 1984-ben, majd Szíjgyártó László fordításában az újvidéki Forum Könyvkiadónál 1986-ban, az Európa Könyvkiadónál pedig 1989-ben.", "https://s03.static.libri.hu/cover/a2/b/6051555_5.jpg", 12.99m, "1984" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "A Galaxis útikalauz stopposoknak című sorozatot (eredeti angol címén The Hitchhiker’s Guide to the Galaxy) először Douglas Adams rádiójátékaként ismerte meg a közönség, amelyet 1978-ban a BBC 4 rádió sugárzott fejezetenkénti folytatásokban. 1979 és 1992 között Adams ötrészes regényfolyamot írt, majd 2009-ben kiadták az Eoin Colfer által írt hatodik részt. 1981-ben televíziós sorozat, 1984-ben számítógépes játék, 1993 és 1996 között képregény és 2005-ben mozifilm is készült belőle, melynek forgatókönyvírója és egyik producere maga Douglas Adams volt. 2004–2005 folyamán a regény 3., 4. és 5. részének története alapján The Hitchhiker's Guide to the Galaxy Tertiary to Quintessential Phases címmel egy újabb, 14 részes rádiójátékot sugárzott a BBC 4. A sikeres regénysorozatot több mint harminc nyelvre fordították le,[1] lemez, kazetta és CD formátumban is kiadták, valamint színházi előadásként is látható volt.", "https://book24.hu/img/boritok/Gabo/9789635661251.jpg", 14.99m, "Galaxis útikalauz stopposoknak" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
