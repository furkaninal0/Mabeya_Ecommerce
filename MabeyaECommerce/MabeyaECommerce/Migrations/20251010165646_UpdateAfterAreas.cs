using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MabeyaECommerce.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAfterAreas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "provinceId" },
                values: new object[,]
                {
                    { 1, "ALADAĞ", 1 },
                    { 2, "CEYHAN", 1 },
                    { 3, "ÇUKUROVA", 1 },
                    { 4, "FEKE", 1 },
                    { 5, "İMAMOĞLU", 1 },
                    { 6, "KARAİSALI", 1 },
                    { 7, "KARATAŞ", 1 },
                    { 8, "KOZAN", 1 },
                    { 9, "POZANTI", 1 },
                    { 10, "SAİMBEYLİ", 1 },
                    { 11, "SARIÇAM", 1 },
                    { 12, "SEYHAN", 1 },
                    { 13, "TUFANBEYLİ", 1 },
                    { 14, "YUMURTALIK", 1 },
                    { 15, "YÜREĞİR", 1 },
                    { 16, "ADIYAMAN MERKEZ", 2 },
                    { 17, "BESNİ", 2 },
                    { 18, "ÇELİKHAN", 2 },
                    { 19, "GERGER", 2 },
                    { 20, "GÖLBAŞI", 2 },
                    { 21, "KAHTA", 2 },
                    { 22, "SAMSAT", 2 },
                    { 23, "SİNCİK", 2 },
                    { 24, "TUT", 2 },
                    { 25, "AFYON MERKEZ", 3 },
                    { 26, "BAŞMAKÇI", 3 },
                    { 27, "BAYAT", 3 },
                    { 28, "BOLVADİN", 3 },
                    { 29, "ÇAY", 3 },
                    { 30, "ÇOBANLAR", 3 },
                    { 31, "DAZKIRI", 3 },
                    { 32, "DİNAR", 3 },
                    { 33, "EMİRDAĞ", 3 },
                    { 34, "EVCİLER", 3 },
                    { 35, "HOCALAR", 3 },
                    { 36, "İHSANİYE", 3 },
                    { 37, "İSCEHİSAR", 3 },
                    { 38, "KIZILÖREN", 3 },
                    { 39, "SANDIKLI", 3 },
                    { 40, "SİNCANLI", 3 },
                    { 41, "SULTANDAĞI", 3 },
                    { 42, "ŞUHUT", 3 },
                    { 43, "AĞRI MERKEZ", 4 },
                    { 44, "DİYADİN", 4 },
                    { 45, "DOĞUBAYAZIT", 4 },
                    { 46, "ELEŞKİRT", 4 },
                    { 47, "HAMUR", 4 },
                    { 48, "PATNOS", 4 },
                    { 49, "TAŞLIÇAY", 4 },
                    { 50, "TUTAK", 4 },
                    { 51, "AMASYA MERKEZ", 5 },
                    { 52, "GÖYNÜCEK", 5 },
                    { 53, "GÜMÜŞHACIKÖY", 5 },
                    { 54, "HAMAMÖZÜ", 5 },
                    { 55, "MERZİFON", 5 },
                    { 56, "SULUOVA", 5 },
                    { 57, "TAŞOVA", 5 },
                    { 58, "AKYURT", 6 },
                    { 59, "ALTINDAĞ", 6 },
                    { 60, "ANKARA", 6 },
                    { 61, "AYAŞ", 6 },
                    { 62, "BALÂ", 6 },
                    { 63, "BEYPAZARI", 6 },
                    { 64, "ÇAMLIDERE", 6 },
                    { 65, "ÇANKAYA", 6 },
                    { 66, "ÇUBUK", 6 },
                    { 67, "ELMADAĞ", 6 },
                    { 68, "ETİMESGUT", 6 },
                    { 69, "EVREN", 6 },
                    { 70, "GÖLBAŞI", 6 },
                    { 71, "GÜDÜL", 6 },
                    { 72, "HAYMANA", 6 },
                    { 73, "KALECİK", 6 },
                    { 74, "KAZAN", 6 },
                    { 75, "KEÇİÖREN", 6 },
                    { 76, "KIZILCAHAMAM", 6 },
                    { 77, "MAMAK", 6 },
                    { 78, "NALLIHAN", 6 },
                    { 79, "POLATLI", 6 },
                    { 80, "PURSAKLAR", 6 },
                    { 81, "SİNCAN", 6 },
                    { 82, "ŞEREFLİKOÇHİSAR", 6 },
                    { 83, "YENİMAHALLE", 6 },
                    { 84, "AKSEKİ", 7 },
                    { 85, "AKSU/ANTALYA", 7 },
                    { 86, "ALANYA", 7 },
                    { 87, "ANTALYA MERKEZ", 7 },
                    { 88, "DÖŞEMEALTI", 7 },
                    { 89, "ELMALI", 7 },
                    { 90, "FİNİKE", 7 },
                    { 91, "GAZİPAŞA", 7 },
                    { 92, "GÜNDOĞMUŞ", 7 },
                    { 93, "İBRADI", 7 },
                    { 94, "KALE", 7 },
                    { 95, "KAŞ", 7 },
                    { 96, "KEMER", 7 },
                    { 97, "KEPEZ", 7 },
                    { 98, "KONYAALTI", 7 },
                    { 99, "KORKUTELİ", 7 },
                    { 100, "KUMLUCA", 7 },
                    { 101, "MANAVGAT", 7 },
                    { 102, "MURATPAŞA", 7 },
                    { 103, "SERİK", 7 },
                    { 104, "ARDANUÇ", 8 },
                    { 105, "ARHAVİ", 8 },
                    { 106, "ARTVİN MERKEZ", 8 },
                    { 107, "BORÇKA", 8 },
                    { 108, "HOPA", 8 },
                    { 109, "MURGUL", 8 },
                    { 110, "ŞAVŞAT", 8 },
                    { 111, "YUSUFELİ", 8 },
                    { 112, "AYDIN MERKEZ", 9 },
                    { 113, "BOZDOĞAN", 9 },
                    { 114, "BUHARKENT", 9 },
                    { 115, "ÇİNE", 9 },
                    { 116, "DİDİM (YENİHİSAR)", 9 },
                    { 117, "GERMENCİK", 9 },
                    { 118, "İNCİRLİOVA", 9 },
                    { 119, "KARACASU", 9 },
                    { 120, "KARPUZLU", 9 },
                    { 121, "KOÇARLI", 9 },
                    { 122, "KÖŞK", 9 },
                    { 123, "KUŞADASI", 9 },
                    { 124, "KUYUCAK", 9 },
                    { 125, "NAZİLLİ", 9 },
                    { 126, "SÖKE", 9 },
                    { 127, "SULTANHİSAR", 9 },
                    { 128, "YENİPAZAR", 9 },
                    { 129, "AYVALIK", 10 },
                    { 130, "BALIKESİR MERKEZ", 10 },
                    { 131, "BALYA", 10 },
                    { 132, "BANDIRMA", 10 },
                    { 133, "BİGADİÇ", 10 },
                    { 134, "BURHANİYE", 10 },
                    { 135, "DURSUNBEY", 10 },
                    { 136, "EDREMİT", 10 },
                    { 137, "ERDEK", 10 },
                    { 138, "GÖMEÇ", 10 },
                    { 139, "GÖNEN", 10 },
                    { 140, "HAVRAN", 10 },
                    { 141, "İVRİNDİ", 10 },
                    { 142, "KEPSUT", 10 },
                    { 143, "MANYAS", 10 },
                    { 144, "MARMARA", 10 },
                    { 145, "SAVAŞTEPE", 10 },
                    { 146, "SINDIRGI", 10 },
                    { 147, "SUSURLUK", 10 },
                    { 148, "BİLECİK MERKEZ", 11 },
                    { 149, "BOZÜYÜK", 11 },
                    { 150, "GÖLPAZARI", 11 },
                    { 151, "İNHİSAR", 11 },
                    { 152, "OSMANELİ", 11 },
                    { 153, "PAZARYERİ", 11 },
                    { 154, "SÖĞÜT", 11 },
                    { 155, "YENİPAZAR", 11 },
                    { 156, "ADAKLI", 12 },
                    { 157, "BİNGÖL MERKEZ", 12 },
                    { 158, "GENÇ", 12 },
                    { 159, "KARLIOVA", 12 },
                    { 160, "KİĞI", 12 },
                    { 161, "SOLHAN", 12 },
                    { 162, "YAYLADERE", 12 },
                    { 163, "YEDİSU", 12 },
                    { 164, "ADİLCEVAZ", 13 },
                    { 165, "AHLAT", 13 },
                    { 166, "BİTLİS MERKEZ", 13 },
                    { 167, "GÜROYMAK", 13 },
                    { 168, "HİZAN", 13 },
                    { 169, "MUTKİ", 13 },
                    { 170, "TATVAN", 13 },
                    { 171, "BOLU MERKEZ", 14 },
                    { 172, "DÖRTDİVAN", 14 },
                    { 173, "GEREDE", 14 },
                    { 174, "GÖYNÜK", 14 },
                    { 175, "KIBRISCIK", 14 },
                    { 176, "MENGEN", 14 },
                    { 177, "MUDURNU", 14 },
                    { 178, "SEBEN", 14 },
                    { 179, "YENİÇAĞA", 14 },
                    { 180, "AĞLASUN", 15 },
                    { 181, "ALTINYAYLA", 15 },
                    { 182, "BUCAK", 15 },
                    { 183, "BURDUR MERKEZ", 15 },
                    { 184, "ÇAVDIR", 15 },
                    { 185, "ÇELTİKÇİ", 15 },
                    { 186, "GÖLHİSAR", 15 },
                    { 187, "KARAMANLI", 15 },
                    { 188, "KEMER", 15 },
                    { 189, "TEFENNİ", 15 },
                    { 190, "YEŞİLOVA", 15 },
                    { 191, "BURSA MERKEZ", 16 },
                    { 192, "BÜYÜKORHAN", 16 },
                    { 193, "GEMLİK", 16 },
                    { 194, "GÜRSU", 16 },
                    { 195, "HARMANCIK", 16 },
                    { 196, "İNEGÖL", 16 },
                    { 197, "İZNİK", 16 },
                    { 198, "KARACABEY", 16 },
                    { 199, "KELES", 16 },
                    { 200, "KESTEL", 16 },
                    { 201, "MUDANYA", 16 },
                    { 202, "MUSTAFA KEMAL PAŞA", 16 },
                    { 203, "NİLÜFER", 16 },
                    { 204, "ORHANELİ", 16 },
                    { 205, "ORHANGAZİ", 16 },
                    { 206, "OSMANGAZİ", 16 },
                    { 207, "YENİŞEHİR", 16 },
                    { 208, "YILDIRIM", 16 },
                    { 209, "AYVACIK", 17 },
                    { 210, "BAYRAMİÇ", 17 },
                    { 211, "BİGA", 17 },
                    { 212, "BOZCAADA", 17 },
                    { 213, "ÇAN", 17 },
                    { 214, "ÇANAKKALE MERKEZ", 17 },
                    { 215, "ECEABAT", 17 },
                    { 216, "EZİNE", 17 },
                    { 217, "GELİBOLU", 17 },
                    { 218, "GÖKÇEADA (İMROZ)", 17 },
                    { 219, "LAPSEKİ", 17 },
                    { 220, "YENİCE", 17 },
                    { 221, "ATKARACALAR", 18 },
                    { 222, "BAYRAMÖREN", 18 },
                    { 223, "ÇANKIRI MERKEZ", 18 },
                    { 224, "ÇERKEŞ", 18 },
                    { 225, "ELDİVAN", 18 },
                    { 226, "ILGAZ", 18 },
                    { 227, "KIZILIRMAK", 18 },
                    { 228, "KORGUN", 18 },
                    { 229, "KURŞUNLU", 18 },
                    { 230, "ORTA", 18 },
                    { 231, "ŞABANÖZÜ", 18 },
                    { 232, "YAPRAKLI", 18 },
                    { 233, "ALACA", 19 },
                    { 234, "BAYAT", 19 },
                    { 235, "BOĞAZKALE", 19 },
                    { 236, "ÇORUM MERKEZ", 19 },
                    { 237, "DODURGA", 19 },
                    { 238, "İSKİLİP", 19 },
                    { 239, "KARGI", 19 },
                    { 240, "LAÇİN", 19 },
                    { 241, "MECİTÖZÜ", 19 },
                    { 242, "OĞUZLAR", 19 },
                    { 243, "ORTAKÖY", 19 },
                    { 244, "OSMANCIK", 19 },
                    { 245, "SUNGURLU", 19 },
                    { 246, "UĞURLUDAĞ", 19 },
                    { 247, "ACIPAYAM", 20 },
                    { 248, "AKKÖY", 20 },
                    { 249, "BABADAĞ", 20 },
                    { 250, "BAKLAN", 20 },
                    { 251, "BEKİLLİ", 20 },
                    { 252, "BEYAĞAÇ", 20 },
                    { 253, "BOZKURT", 20 },
                    { 254, "BULDAN", 20 },
                    { 255, "ÇAL", 20 },
                    { 256, "ÇAMELİ", 20 },
                    { 257, "ÇARDAK", 20 },
                    { 258, "ÇİVRİL", 20 },
                    { 259, "DENİZLİ MERKEZ", 20 },
                    { 260, "GÜNEY", 20 },
                    { 261, "HONAZ", 20 },
                    { 262, "KALE", 20 },
                    { 263, "SARAYKÖY", 20 },
                    { 264, "SERİNHİSAR", 20 },
                    { 265, "TAVAS", 20 },
                    { 266, "BAĞLAR", 21 },
                    { 267, "BİSMİL", 21 },
                    { 268, "ÇERMİK", 21 },
                    { 269, "ÇINAR", 21 },
                    { 270, "ÇÜNGÜŞ", 21 },
                    { 271, "DİCLE", 21 },
                    { 272, "DİYARBAKIR MERKEZ", 21 },
                    { 273, "EĞİL", 21 },
                    { 274, "ERGANİ", 21 },
                    { 275, "HANİ", 21 },
                    { 276, "HAZRO", 21 },
                    { 277, "KAYAPINAR", 21 },
                    { 278, "KOCAKÖY", 21 },
                    { 279, "KULP", 21 },
                    { 280, "LİCE", 21 },
                    { 281, "SİLVAN", 21 },
                    { 282, "SUR", 21 },
                    { 283, "YENİŞEHİR/DİYARBAKIR", 21 },
                    { 284, "EDİRNE MERKEZ", 22 },
                    { 285, "ENEZ", 22 },
                    { 286, "HAVSA", 22 },
                    { 287, "İPSALA", 22 },
                    { 288, "KEŞAN", 22 },
                    { 289, "LALAPAŞA", 22 },
                    { 290, "MERİÇ", 22 },
                    { 291, "SÜLOĞLU", 22 },
                    { 292, "UZUNKÖPRÜ", 22 },
                    { 293, "AĞIN", 23 },
                    { 294, "ALACAKAYA", 23 },
                    { 295, "ARICAK", 23 },
                    { 296, "BASKİL", 23 },
                    { 297, "ELAZIĞ MERKEZ", 23 },
                    { 298, "KARAKOÇAN", 23 },
                    { 299, "KEBAN", 23 },
                    { 300, "KOVANCILAR", 23 },
                    { 301, "MADEN", 23 },
                    { 302, "PALU", 23 },
                    { 303, "SİVRİCE", 23 },
                    { 304, "ÇAYIRLI", 24 },
                    { 305, "ERZİNCAN MERKEZ", 24 },
                    { 306, "İLİÇ", 24 },
                    { 307, "KEMAH", 24 },
                    { 308, "KEMALİYE", 24 },
                    { 309, "OTLUKBELİ", 24 },
                    { 310, "REFAHİYE", 24 },
                    { 311, "TERCAN", 24 },
                    { 312, "ÜZÜMLÜ", 24 },
                    { 313, "AŞKALE", 25 },
                    { 314, "ÇAT", 25 },
                    { 315, "ERZURUM MERKEZ", 25 },
                    { 316, "HINIS", 25 },
                    { 317, "HORASAN", 25 },
                    { 318, "ILICA", 25 },
                    { 319, "İSPİR", 25 },
                    { 320, "KARAÇOBAN", 25 },
                    { 321, "KARAYAZI", 25 },
                    { 322, "KÖPRÜKÖY", 25 },
                    { 323, "NARMAN", 25 },
                    { 324, "OLTU", 25 },
                    { 325, "OLUR", 25 },
                    { 326, "PALANDÖKEN", 25 },
                    { 327, "PASİNLER", 25 },
                    { 328, "PAZARYOLU", 25 },
                    { 329, "ŞENKAYA", 25 },
                    { 330, "TEKMAN", 25 },
                    { 331, "TORTUM", 25 },
                    { 332, "UZUNDERE", 25 },
                    { 333, "YAKUTİYE", 25 },
                    { 334, "ALPU", 26 },
                    { 335, "BEYLİKOVA", 26 },
                    { 336, "ÇİFTELER", 26 },
                    { 337, "ESKİŞEHİR MERKEZ", 26 },
                    { 338, "GÜNYÜZÜ", 26 },
                    { 339, "HAN", 26 },
                    { 340, "İNÖNÜ", 26 },
                    { 341, "MAHMUDİYE", 26 },
                    { 342, "MİHALGAZİ", 26 },
                    { 343, "MİHALIÇÇIK", 26 },
                    { 344, "ODUNPAZARI", 26 },
                    { 345, "SARICAKAYA", 26 },
                    { 346, "SEYİTGAZİ", 26 },
                    { 347, "SİVRİHİSAR", 26 },
                    { 348, "TEPEBAŞI", 26 },
                    { 349, "ARABAN", 27 },
                    { 350, "GAZİANTEP MERKEZ", 27 },
                    { 351, "İSLAHİYE", 27 },
                    { 352, "KARKAMIŞ", 27 },
                    { 353, "NİZİP", 27 },
                    { 354, "NURDAĞI", 27 },
                    { 355, "OĞUZELİ", 27 },
                    { 356, "ŞAHİNBEY", 27 },
                    { 357, "ŞEHİTKAMİL", 27 },
                    { 358, "YAVUZELİ", 27 },
                    { 359, "ALUCRA", 28 },
                    { 360, "BULANCAK", 28 },
                    { 361, "ÇAMOLUK", 28 },
                    { 362, "ÇANAKÇI", 28 },
                    { 363, "DERELİ", 28 },
                    { 364, "DOĞANKENT", 28 },
                    { 365, "ESPİYE", 28 },
                    { 366, "EYNESİL", 28 },
                    { 367, "GİRESUN MERKEZ", 28 },
                    { 368, "GÖRELE", 28 },
                    { 369, "GÜCE", 28 },
                    { 370, "KEŞAP", 28 },
                    { 371, "PİRAZİZ", 28 },
                    { 372, "ŞEBİNKARAHİSAR", 28 },
                    { 373, "TİREBOLU", 28 },
                    { 374, "YAĞLIDERE", 28 },
                    { 375, "GÜMÜŞHANE MERKEZ", 29 },
                    { 376, "KELKİT", 29 },
                    { 377, "KÖSE", 29 },
                    { 378, "KÜRTÜN", 29 },
                    { 379, "ŞİRAN", 29 },
                    { 380, "TORUL", 29 },
                    { 381, "ÇUKURCA", 30 },
                    { 382, "HAKKARİ MERKEZ", 30 },
                    { 383, "ŞEMDİNLİ", 30 },
                    { 384, "YÜKSEKOVA", 30 },
                    { 385, "ALTINÖZÜ", 31 },
                    { 386, "BELEN", 31 },
                    { 387, "DÖRTYOL", 31 },
                    { 388, "ERZİN", 31 },
                    { 389, "HASSA", 31 },
                    { 390, "HATAY MERKEZ", 31 },
                    { 391, "İSKENDERUN", 31 },
                    { 392, "KIRIKHAN", 31 },
                    { 393, "KUMLU", 31 },
                    { 394, "REYHANLI", 31 },
                    { 395, "SAMANDAĞ", 31 },
                    { 396, "YAYLADAĞI", 31 },
                    { 397, "AKSU", 32 },
                    { 398, "ATABEY", 32 },
                    { 399, "EĞİRDİR", 32 },
                    { 400, "GELENDOST", 32 },
                    { 401, "GÖNEN", 32 },
                    { 402, "ISPARTA MERKEZ", 32 },
                    { 403, "KEÇİBORLU", 32 },
                    { 404, "SENİRKENT", 32 },
                    { 405, "SÜTÇÜLER", 32 },
                    { 406, "ŞARKİKARAAĞAÇ", 32 },
                    { 407, "ULUBORLU", 32 },
                    { 408, "YALVAÇ", 32 },
                    { 409, "YENİŞARBADEMLİ", 32 },
                    { 410, "AKDENİZ", 33 },
                    { 411, "ANAMUR", 33 },
                    { 412, "AYDINCIK", 33 },
                    { 413, "BOZYAZI", 33 },
                    { 414, "ÇAMLIYAYLA", 33 },
                    { 415, "ERDEMLİ", 33 },
                    { 416, "GÜLNAR", 33 },
                    { 417, "İÇEL MERKEZ", 33 },
                    { 418, "MEZİTLİ", 33 },
                    { 419, "MUT", 33 },
                    { 420, "SİLİFKE", 33 },
                    { 421, "TARSUS", 33 },
                    { 422, "TOROSLAR", 33 },
                    { 423, "YENİŞEHİR/MERSİN", 33 },
                    { 424, "ADALAR", 34 },
                    { 425, "ARNAVUTKÖY", 34 },
                    { 426, "ATAŞEHİR", 34 },
                    { 427, "AVCILAR", 34 },
                    { 428, "BAĞCILAR", 34 },
                    { 429, "BAHÇELİEVLER", 34 },
                    { 430, "BAKIRKÖY", 34 },
                    { 431, "BAŞAKŞEHİR", 34 },
                    { 432, "BAYRAMPAŞA", 34 },
                    { 433, "BEŞİKTAŞ", 34 },
                    { 434, "BEYKOZ", 34 },
                    { 435, "BEYLİKDÜZÜ", 34 },
                    { 436, "BEYOĞLU", 34 },
                    { 437, "BÜYÜKÇEKMECE", 34 },
                    { 438, "ÇATALCA", 34 },
                    { 439, "ÇEKMEKÖY", 34 },
                    { 440, "EMİNÖNÜ", 34 },
                    { 441, "ESENLER", 34 },
                    { 442, "ESENYURT", 34 },
                    { 443, "EYÜP", 34 },
                    { 444, "FATİH", 34 },
                    { 445, "GAZİOSMANPAŞA", 34 },
                    { 446, "GÜNGÖREN", 34 },
                    { 447, "İSTANBUL MERKEZ", 34 },
                    { 448, "KADIKÖY", 34 },
                    { 449, "KAĞITHANE", 34 },
                    { 450, "KARTAL", 34 },
                    { 451, "KÜÇÜKÇEKMECE", 34 },
                    { 452, "MALTEPE", 34 },
                    { 453, "PENDİK", 34 },
                    { 454, "SANCAKTEPE", 34 },
                    { 455, "SARIYER", 34 },
                    { 456, "SİLİVRİ", 34 },
                    { 457, "SULTANBEYLİ", 34 },
                    { 458, "SULTANGAZİ", 34 },
                    { 459, "ŞİLE", 34 },
                    { 460, "ŞİŞLİ", 34 },
                    { 461, "TUZLA", 34 },
                    { 462, "ÜMRANİYE", 34 },
                    { 463, "ÜSKÜDAR", 34 },
                    { 464, "ZEYTİNBURNU", 34 },
                    { 465, "ALİAĞA", 35 },
                    { 466, "BALÇOVA", 35 },
                    { 467, "BAYINDIR", 35 },
                    { 468, "BAYRAKLI", 35 },
                    { 469, "BERGAMA", 35 },
                    { 470, "BEYDAĞ", 35 },
                    { 471, "BORNOVA", 35 },
                    { 472, "BUCA", 35 },
                    { 473, "ÇEŞME", 35 },
                    { 474, "ÇİĞLİ", 35 },
                    { 475, "DİKİLİ", 35 },
                    { 476, "FOÇA", 35 },
                    { 477, "GAZİEMİR", 35 },
                    { 478, "GÜZELBAHÇE", 35 },
                    { 479, "İZMİR MERKEZ", 35 },
                    { 480, "KARABAĞLAR", 35 },
                    { 481, "KARABURUN", 35 },
                    { 482, "KARŞIYAKA", 35 },
                    { 483, "KEMALPAŞA", 35 },
                    { 484, "KINIK", 35 },
                    { 485, "KİRAZ", 35 },
                    { 486, "KONAK", 35 },
                    { 487, "MENDERES", 35 },
                    { 488, "MENEMEN", 35 },
                    { 489, "NARLIDERE", 35 },
                    { 490, "ÖDEMİŞ", 35 },
                    { 491, "SEFERİHİSAR", 35 },
                    { 492, "SELÇUK", 35 },
                    { 493, "TİRE", 35 },
                    { 494, "TORBALI", 35 },
                    { 495, "URLA", 35 },
                    { 496, "AKYAKA", 36 },
                    { 497, "ARPAÇAY", 36 },
                    { 498, "DİGOR", 36 },
                    { 499, "KAĞIZMAN", 36 },
                    { 500, "KARS MERKEZ", 36 },
                    { 501, "SARIKAMIŞ", 36 },
                    { 502, "SELİM", 36 },
                    { 503, "SUSUZ", 36 },
                    { 504, "ABANA", 37 },
                    { 505, "AĞLI", 37 },
                    { 506, "ARAÇ", 37 },
                    { 507, "AZDAVAY", 37 },
                    { 508, "BOZKURT", 37 },
                    { 509, "CİDE", 37 },
                    { 510, "ÇATALZEYTİN", 37 },
                    { 511, "DADAY", 37 },
                    { 512, "DEVREKÂNİ", 37 },
                    { 513, "DOĞANYURT", 37 },
                    { 514, "HANÖNÜ", 37 },
                    { 515, "İHSANGAZİ", 37 },
                    { 516, "İNEBOLU", 37 },
                    { 517, "KASTAMONU MERKEZ", 37 },
                    { 518, "KÜRE", 37 },
                    { 519, "PINARBAŞI", 37 },
                    { 520, "SEYDİLER", 37 },
                    { 521, "ŞENPAZAR", 37 },
                    { 522, "TAŞKÖPRÜ", 37 },
                    { 523, "TOSYA", 37 },
                    { 524, "AKKIŞLA", 38 },
                    { 525, "BÜNYAN", 38 },
                    { 526, "DEVELİ", 38 },
                    { 527, "FELAHİYE", 38 },
                    { 528, "HACILAR", 38 },
                    { 529, "İNCESU", 38 },
                    { 530, "KAYSERİ MERKEZ", 38 },
                    { 531, "KOCASİNAN", 38 },
                    { 532, "MELİKGAZİ", 38 },
                    { 533, "ÖZVATAN", 38 },
                    { 534, "PINARBAŞI", 38 },
                    { 535, "SARIOĞLAN", 38 },
                    { 536, "SARIZ", 38 },
                    { 537, "TALAS", 38 },
                    { 538, "TOMARZA", 38 },
                    { 539, "YAHYALI", 38 },
                    { 540, "YEŞİLHİSAR", 38 },
                    { 541, "BABAESKİ", 39 },
                    { 542, "DEMİRKÖY", 39 },
                    { 543, "KIRKLARELİ MERKEZ", 39 },
                    { 544, "KOFÇAZ", 39 },
                    { 545, "LÜLEBURGAZ", 39 },
                    { 546, "PEHLİVANKÖY", 39 },
                    { 547, "PINARHİSAR", 39 },
                    { 548, "VİZE", 39 },
                    { 549, "AKÇAKENT", 40 },
                    { 550, "AKPINAR", 40 },
                    { 551, "BOZTEPE", 40 },
                    { 552, "ÇİÇEKDAĞI", 40 },
                    { 553, "KAMAN", 40 },
                    { 554, "KIRŞEHİR MERKEZ", 40 },
                    { 555, "MUCUR", 40 },
                    { 556, "BAŞİSKELE", 41 },
                    { 557, "ÇAYIROVA", 41 },
                    { 558, "DARICA", 41 },
                    { 559, "DERİNCE", 41 },
                    { 560, "DİLOVASI", 41 },
                    { 561, "GEBZE", 41 },
                    { 562, "GÖLCÜK", 41 },
                    { 563, "İZMİT", 41 },
                    { 564, "KANDIRA", 41 },
                    { 565, "KARAMÜRSEL", 41 },
                    { 566, "KARTEPE", 41 },
                    { 567, "KOCAELİ MERKEZ (İZMİT)", 41 },
                    { 568, "KÖRFEZ", 41 },
                    { 569, "AHIRLI", 42 },
                    { 570, "AKÖREN", 42 },
                    { 571, "AKŞEHİR", 42 },
                    { 572, "ALTINEKİN", 42 },
                    { 573, "BEYŞEHİR", 42 },
                    { 574, "BOZKIR", 42 },
                    { 575, "CİHANBEYLİ", 42 },
                    { 576, "ÇELTİK", 42 },
                    { 577, "ÇUMRA", 42 },
                    { 578, "DERBENT", 42 },
                    { 579, "DEREBUCAK", 42 },
                    { 580, "DOĞANHİSAR", 42 },
                    { 581, "EMİRGAZİ", 42 },
                    { 582, "EREĞLİ", 42 },
                    { 583, "GÜNEYSINIR", 42 },
                    { 584, "HADIM", 42 },
                    { 585, "HALKAPINAR", 42 },
                    { 586, "HÜYÜK", 42 },
                    { 587, "ILGIN", 42 },
                    { 588, "KADINHANI", 42 },
                    { 589, "KARAPINAR", 42 },
                    { 590, "KARATAY", 42 },
                    { 591, "KONYA MERKEZ", 42 },
                    { 592, "KULU", 42 },
                    { 593, "MERAM", 42 },
                    { 594, "SARAYÖNÜ", 42 },
                    { 595, "SELÇUKLU", 42 },
                    { 596, "SEYDİŞEHİR", 42 },
                    { 597, "TAŞKENT", 42 },
                    { 598, "TUZLUKÇU", 42 },
                    { 599, "YALIHÜYÜK", 42 },
                    { 600, "YUNAK", 42 },
                    { 601, "ALTINTAŞ", 43 },
                    { 602, "ASLANAPA", 43 },
                    { 603, "ÇAVDARHİSAR", 43 },
                    { 604, "DOMANİÇ", 43 },
                    { 605, "DUMLUPINAR", 43 },
                    { 606, "EMET", 43 },
                    { 607, "GEDİZ", 43 },
                    { 608, "HİSARCIK", 43 },
                    { 609, "KÜTAHYA MERKEZ", 43 },
                    { 610, "PAZARLAR", 43 },
                    { 611, "SİMAV", 43 },
                    { 612, "ŞAPHANE", 43 },
                    { 613, "TAVŞANLI", 43 },
                    { 614, "AKÇADAĞ", 44 },
                    { 615, "ARAPGİR", 44 },
                    { 616, "ARGUVAN", 44 },
                    { 617, "BATTALGAZİ", 44 },
                    { 618, "DARENDE", 44 },
                    { 619, "DOĞANŞEHİR", 44 },
                    { 620, "DOĞANYOL", 44 },
                    { 621, "HEKİMHAN", 44 },
                    { 622, "KALE", 44 },
                    { 623, "KULUNCAK", 44 },
                    { 624, "MALATYA MERKEZ", 44 },
                    { 625, "PÜTÜRGE", 44 },
                    { 626, "YAZIHAN", 44 },
                    { 627, "YEŞİLYURT", 44 },
                    { 628, "AHMETLİ", 45 },
                    { 629, "AKHİSAR", 45 },
                    { 630, "ALAŞEHİR", 45 },
                    { 631, "DEMİRCİ", 45 },
                    { 632, "GÖLMARMARA", 45 },
                    { 633, "GÖRDES", 45 },
                    { 634, "KIRKAĞAÇ", 45 },
                    { 635, "KÖPRÜBAŞI", 45 },
                    { 636, "KULA", 45 },
                    { 637, "MANİSA MERKEZ", 45 },
                    { 638, "SALİHLİ", 45 },
                    { 639, "SARIGÖL", 45 },
                    { 640, "SARUHANLI", 45 },
                    { 641, "SELENDİ", 45 },
                    { 642, "SOMA", 45 },
                    { 643, "TURGUTLU", 45 },
                    { 644, "AFŞİN", 46 },
                    { 645, "ANDIRIN", 46 },
                    { 646, "ÇAĞLIYANCERİT", 46 },
                    { 647, "EKİNÖZÜ", 46 },
                    { 648, "ELBİSTAN", 46 },
                    { 649, "GÖKSUN", 46 },
                    { 650, "KAHRAMANMARAŞ MERKEZ", 46 },
                    { 651, "NURHAK", 46 },
                    { 652, "PAZARCIK", 46 },
                    { 653, "TÜRKOĞLU", 46 },
                    { 654, "DARGEÇİT", 47 },
                    { 655, "DERİK", 47 },
                    { 656, "KIZILTEPE", 47 },
                    { 657, "MARDİN MERKEZ", 47 },
                    { 658, "MAZIDAĞI", 47 },
                    { 659, "MİDYAT", 47 },
                    { 660, "NUSAYBİN", 47 },
                    { 661, "ÖMERLİ", 47 },
                    { 662, "SAVUR", 47 },
                    { 663, "YEŞİLLİ", 47 },
                    { 664, "BODRUM", 48 },
                    { 665, "DALAMAN", 48 },
                    { 666, "DATÇA", 48 },
                    { 667, "FETHİYE", 48 },
                    { 668, "KAVAKLIDERE", 48 },
                    { 669, "KÖYCEĞİZ", 48 },
                    { 670, "MARMARİS", 48 },
                    { 671, "MİLAS", 48 },
                    { 672, "MUĞLA MERKEZ", 48 },
                    { 673, "ORTACA", 48 },
                    { 674, "ULA", 48 },
                    { 675, "YATAĞAN", 48 },
                    { 676, "BULANIK", 49 },
                    { 677, "HASKÖY", 49 },
                    { 678, "KORKUT", 49 },
                    { 679, "MALAZGİRT", 49 },
                    { 680, "MUŞ MERKEZ", 49 },
                    { 681, "VARTO", 49 },
                    { 682, "ACIGÖL", 50 },
                    { 683, "AVANOS", 50 },
                    { 684, "DERİNKUYU", 50 },
                    { 685, "GÜLŞEHİR", 50 },
                    { 686, "HACIBEKTAŞ", 50 },
                    { 687, "KOZAKLI", 50 },
                    { 688, "NEVŞEHİR MERKEZ", 50 },
                    { 689, "ÜRGÜP", 50 },
                    { 690, "ALTUNHİSAR", 51 },
                    { 691, "BOR", 51 },
                    { 692, "ÇAMARDI", 51 },
                    { 693, "ÇİFTLİK", 51 },
                    { 694, "NİĞDE MERKEZ", 51 },
                    { 695, "ULUKIŞLA", 51 },
                    { 696, "AKKUŞ", 52 },
                    { 697, "AYBASTI", 52 },
                    { 698, "ÇAMAŞ", 52 },
                    { 699, "ÇATALPINAR", 52 },
                    { 700, "ÇAYBAŞI", 52 },
                    { 701, "FATSA", 52 },
                    { 702, "GÖLKÖY", 52 },
                    { 703, "GÜLYALI", 52 },
                    { 704, "GÜRGENTEPE", 52 },
                    { 705, "İKİZCE", 52 },
                    { 706, "KABADÜZ", 52 },
                    { 707, "KABATAŞ", 52 },
                    { 708, "KORGAN", 52 },
                    { 709, "KUMRU", 52 },
                    { 710, "MESUDİYE", 52 },
                    { 711, "ORDU MERKEZ", 52 },
                    { 712, "PERŞEMBE", 52 },
                    { 713, "ULUBEY", 52 },
                    { 714, "ÜNYE", 52 },
                    { 715, "ARDEŞEN", 53 },
                    { 716, "ÇAMLIHEMŞİN", 53 },
                    { 717, "ÇAYELİ", 53 },
                    { 718, "DEREPAZARI", 53 },
                    { 719, "FINDIKLI", 53 },
                    { 720, "GÜNEYSU", 53 },
                    { 721, "HEMŞİN", 53 },
                    { 722, "İKİZDERE", 53 },
                    { 723, "İYİDERE", 53 },
                    { 724, "KALKANDERE", 53 },
                    { 725, "PAZAR", 53 },
                    { 726, "RİZE MERKEZ", 53 },
                    { 727, "ADAPAZARI", 54 },
                    { 728, "AKYAZI", 54 },
                    { 729, "ARİFİYE", 54 },
                    { 730, "ERENLER", 54 },
                    { 731, "FERİZLİ", 54 },
                    { 732, "GEYVE", 54 },
                    { 733, "HENDEK", 54 },
                    { 734, "KARAPÜRÇEK", 54 },
                    { 735, "KARASU", 54 },
                    { 736, "KAYNARCA", 54 },
                    { 737, "KOCAALİ", 54 },
                    { 738, "PAMUKOVA", 54 },
                    { 739, "SAKARYA MERKEZ (ADAPAZARI)", 54 },
                    { 740, "SAPANCA", 54 },
                    { 741, "SERDİVAN", 54 },
                    { 742, "SÖĞÜTLÜ", 54 },
                    { 743, "TARAKLI", 54 },
                    { 744, "ALAÇAM", 55 },
                    { 745, "ASARCIK", 55 },
                    { 746, "ATAKUM", 55 },
                    { 747, "AYVACIK", 55 },
                    { 748, "BAFRA", 55 },
                    { 749, "CANİK", 55 },
                    { 750, "ÇARŞAMBA", 55 },
                    { 751, "HAVZA", 55 },
                    { 752, "İLKADIM", 55 },
                    { 753, "KAVAK", 55 },
                    { 754, "LADİK", 55 },
                    { 755, "ONDOKUZMAYIS", 55 },
                    { 756, "SALIPAZARI", 55 },
                    { 757, "SAMSUN MERKEZ", 55 },
                    { 758, "TEKKEKÖY", 55 },
                    { 759, "TERME", 55 },
                    { 760, "VEZİRKÖPRÜ", 55 },
                    { 761, "YAKAKENT", 55 },
                    { 762, "AYDINLAR", 56 },
                    { 763, "BAYKAN", 56 },
                    { 764, "ERUH", 56 },
                    { 765, "KURTALAN", 56 },
                    { 766, "PERVARİ", 56 },
                    { 767, "SİİRT MERKEZ", 56 },
                    { 768, "ŞİRVAN", 56 },
                    { 769, "AYANCIK", 57 },
                    { 770, "BOYABAT", 57 },
                    { 771, "DİKMEN", 57 },
                    { 772, "DURAĞAN", 57 },
                    { 773, "ERFELEK", 57 },
                    { 774, "GERZE", 57 },
                    { 775, "SARAYDÜZÜ", 57 },
                    { 776, "SİNOP MERKEZ", 57 },
                    { 777, "TÜRKELİ", 57 },
                    { 778, "AKINCILAR", 58 },
                    { 779, "ALTINYAYLA", 58 },
                    { 780, "DİVRİĞİ", 58 },
                    { 781, "DOĞANŞAR", 58 },
                    { 782, "GEMEREK", 58 },
                    { 783, "GÖLOVA", 58 },
                    { 784, "GÜRÜN", 58 },
                    { 785, "HAFİK", 58 },
                    { 786, "İMRANLI", 58 },
                    { 787, "KANGAL", 58 },
                    { 788, "KOYULHİSAR", 58 },
                    { 789, "SİVAS MERKEZ", 58 },
                    { 790, "SUŞEHRİ", 58 },
                    { 791, "ŞARKIŞLA", 58 },
                    { 792, "ULAŞ", 58 },
                    { 793, "YILDIZELİ", 58 },
                    { 794, "ZARA", 58 },
                    { 795, "ÇERKEZKÖY", 59 },
                    { 796, "ÇORLU", 59 },
                    { 797, "HAYRABOLU", 59 },
                    { 798, "MALKARA", 59 },
                    { 799, "MARMARAEREĞLİSİ", 59 },
                    { 800, "MURATLI", 59 },
                    { 801, "SARAY", 59 },
                    { 802, "ŞARKÖY", 59 },
                    { 803, "TEKİRDAĞ MERKEZ", 59 },
                    { 804, "ALMUS", 60 },
                    { 805, "ARTOVA", 60 },
                    { 806, "BAŞÇİFTLİK", 60 },
                    { 807, "ERBAA", 60 },
                    { 808, "NİKSAR", 60 },
                    { 809, "PAZAR", 60 },
                    { 810, "REŞADİYE", 60 },
                    { 811, "SULUSARAY", 60 },
                    { 812, "TOKAT MERKEZ", 60 },
                    { 813, "TURHAL", 60 },
                    { 814, "YEŞİLYURT", 60 },
                    { 815, "ZİLE", 60 },
                    { 816, "AKÇAABAT", 61 },
                    { 817, "ARAKLI", 61 },
                    { 818, "ARSİN", 61 },
                    { 819, "BEŞİKDÜZÜ", 61 },
                    { 820, "ÇARŞIBAŞI", 61 },
                    { 821, "ÇAYKARA", 61 },
                    { 822, "DERNEKPAZARI", 61 },
                    { 823, "DÜZKÖY", 61 },
                    { 824, "HAYRAT", 61 },
                    { 825, "KÖPRÜBAŞI", 61 },
                    { 826, "MAÇKA", 61 },
                    { 827, "OF", 61 },
                    { 828, "SÜRMENE", 61 },
                    { 829, "ŞALPAZARI", 61 },
                    { 830, "TONYA", 61 },
                    { 831, "TRABZON MERKEZ", 61 },
                    { 832, "VAKFIKEBİR", 61 },
                    { 833, "YOMRA", 61 },
                    { 834, "ÇEMİŞGEZEK", 62 },
                    { 835, "HOZAT", 62 },
                    { 836, "MAZGİRT", 62 },
                    { 837, "NAZIMİYE", 62 },
                    { 838, "OVACIK", 62 },
                    { 839, "PERTEK", 62 },
                    { 840, "PÜLÜMÜR", 62 },
                    { 841, "TUNCELİ MERKEZ", 62 },
                    { 842, "AKÇAKALE", 63 },
                    { 843, "BİRECİK", 63 },
                    { 844, "BOZOVA", 63 },
                    { 845, "CEYLANPINAR", 63 },
                    { 846, "HALFETİ", 63 },
                    { 847, "HARRAN", 63 },
                    { 848, "HİLVAN", 63 },
                    { 849, "SİVEREK", 63 },
                    { 850, "SURUÇ", 63 },
                    { 851, "ŞANLIURFA MERKEZ", 63 },
                    { 852, "VİRANŞEHİR", 63 },
                    { 853, "BANAZ", 64 },
                    { 854, "EŞME", 64 },
                    { 855, "KARAHALLI", 64 },
                    { 856, "SİVASLI", 64 },
                    { 857, "ULUBEY", 64 },
                    { 858, "UŞAK MERKEZ", 64 },
                    { 859, "BAHÇESARAY", 65 },
                    { 860, "BAŞKALE", 65 },
                    { 861, "ÇALDIRAN", 65 },
                    { 862, "ÇATAK", 65 },
                    { 863, "EDREMİT", 65 },
                    { 864, "ERCİŞ", 65 },
                    { 865, "GEVAŞ", 65 },
                    { 866, "GÜRPINAR", 65 },
                    { 867, "MURADİYE", 65 },
                    { 868, "ÖZALP", 65 },
                    { 869, "SARAY", 65 },
                    { 870, "VAN MERKEZ", 65 },
                    { 871, "AKDAĞMADENİ", 66 },
                    { 872, "AYDINCIK", 66 },
                    { 873, "BOĞAZLIYAN", 66 },
                    { 874, "ÇANDIR", 66 },
                    { 875, "ÇAYIRALAN", 66 },
                    { 876, "ÇEKEREK", 66 },
                    { 877, "KADIŞEHRİ", 66 },
                    { 878, "SARAYKENT", 66 },
                    { 879, "SARIKAYA", 66 },
                    { 880, "SORGUN", 66 },
                    { 881, "ŞEFAATLİ", 66 },
                    { 882, "YENİFAKILI", 66 },
                    { 883, "YERKÖY", 66 },
                    { 884, "YOZGAT MERKEZ", 66 },
                    { 885, "ALAPLI", 67 },
                    { 886, "ÇAYCUMA", 67 },
                    { 887, "DEVREK", 67 },
                    { 888, "EREĞLİ", 67 },
                    { 889, "GÖKÇEBEY", 67 },
                    { 890, "ZONGULDAK MERKEZ", 67 },
                    { 891, "AĞAÇÖREN", 68 },
                    { 892, "AKSARAY MERKEZ", 68 },
                    { 893, "ESKİL", 68 },
                    { 894, "GÜLAĞAÇ", 68 },
                    { 895, "GÜZELYURT", 68 },
                    { 896, "ORTAKÖY", 68 },
                    { 897, "SARIYAHŞİ", 68 },
                    { 898, "AYDINTEPE", 69 },
                    { 899, "BAYBURT MERKEZ", 69 },
                    { 900, "DEMİRÖZÜ", 69 },
                    { 901, "AYRANCI", 70 },
                    { 902, "BAŞYAYLA", 70 },
                    { 903, "ERMENEK", 70 },
                    { 904, "KARAMAN MERKEZ", 70 },
                    { 905, "KÂZIMKARABEKİR", 70 },
                    { 906, "SARIVELİLER", 70 },
                    { 907, "BAHŞİLİ", 71 },
                    { 908, "BALIŞEYH", 71 },
                    { 909, "ÇELEBİ", 71 },
                    { 910, "DELİCE", 71 },
                    { 911, "KARAKEÇİLİ", 71 },
                    { 912, "KESKİN", 71 },
                    { 913, "KIRIKKALE MERKEZ", 71 },
                    { 914, "SULAKYURT", 71 },
                    { 915, "YAHŞİHAN", 71 },
                    { 916, "BATMAN MERKEZ", 72 },
                    { 917, "BEŞİRİ", 72 },
                    { 918, "GERCÜŞ", 72 },
                    { 919, "HASANKEYF", 72 },
                    { 920, "KOZLUK", 72 },
                    { 921, "SASON", 72 },
                    { 922, "BEYTÜŞŞEBAP", 73 },
                    { 923, "CİZRE", 73 },
                    { 924, "GÜÇLÜKONAK", 73 },
                    { 925, "İDİL", 73 },
                    { 926, "SİLOPİ", 73 },
                    { 927, "ŞIRNAK MERKEZ", 73 },
                    { 928, "ULUDERE", 73 },
                    { 929, "AMASRA", 74 },
                    { 930, "BARTIN MERKEZ", 74 },
                    { 931, "KURUCAŞİLE", 74 },
                    { 932, "ULUS", 74 },
                    { 933, "ARDAHAN MERKEZ", 75 },
                    { 934, "ÇILDIR", 75 },
                    { 935, "DAMAL", 75 },
                    { 936, "GÖLE", 75 },
                    { 937, "HANAK", 75 },
                    { 938, "POSOF", 75 },
                    { 939, "ARALIK", 76 },
                    { 940, "IĞDIR MERKEZ", 76 },
                    { 941, "KARAKOYUNLU", 76 },
                    { 942, "TUZLUCA", 76 },
                    { 943, "ALTINOVA", 77 },
                    { 944, "ARMUTLU", 77 },
                    { 945, "ÇINARCIK", 77 },
                    { 946, "ÇİFTLİKKÖY", 77 },
                    { 947, "TERMAL", 77 },
                    { 948, "YALOVA MERKEZ", 77 },
                    { 949, "EFLÂNİ", 78 },
                    { 950, "ESKİPAZAR", 78 },
                    { 951, "KARABÜK MERKEZ", 78 },
                    { 952, "OVACIK", 78 },
                    { 953, "SAFRANBOLU", 78 },
                    { 954, "YENİCE", 78 },
                    { 955, "ELBEYLİ", 79 },
                    { 956, "KİLİS MERKEZ", 79 },
                    { 957, "MUSABEYLİ", 79 },
                    { 958, "POLATELİ", 79 },
                    { 959, "BAHÇE", 80 },
                    { 960, "DÜZİÇİ", 80 },
                    { 961, "HASANBEYLİ", 80 },
                    { 962, "KADİRLİ", 80 },
                    { 963, "OSMANİYE MERKEZ", 80 },
                    { 964, "SUMBAS", 80 },
                    { 965, "TOPRAKKALE", 80 },
                    { 966, "AKÇAKOCA", 81 },
                    { 967, "CUMAYERİ", 81 },
                    { 968, "ÇİLİMLİ", 81 },
                    { 969, "DÜZCE MERKEZ", 81 },
                    { 970, "GÖLYAKA", 81 },
                    { 971, "GÜMÜŞOVA", 81 },
                    { 972, "KAYNAŞLI", 81 },
                    { 973, "YIĞILCA", 81 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "User");
        }
    }
}
