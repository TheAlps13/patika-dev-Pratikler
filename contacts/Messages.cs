namespace contacts
{
    public struct Messages
    {
        public const string SelectOperation = "Lütfen yapmak istediğiniz işlemi seçiniz :)\n*******************************************\n(1) Yeni Kişi Ekle\n(2) Varolan Kişiyi Sil\n(3) Varolan Kişiyi Güncelle\n(4) Rehberi Listele\n(5) Rehberde Arama Yap\n(6) Çıkış";
        public const string EnterName = "Lütfen isim giriniz             :";
        public const string EnterSurname = "Lütfen soyisim giriniz          :";
        public const string EnterPhoneNmb = "Lütfen telefon numarası giriniz :";
        public const string EnterNameOrSurnameToRmv = "Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz :";
        public const string NotFound = "\nAradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n";
        public const string EndRemove = "* Silmeyi sonlandırmak için : (1)";
        public const string TryAgain = "* Yeniden denemek için       : (2)";
        public const string ConfirmRmv = "isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)";
        public const string EnterNameOrSurnameToUpdate = "Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz :";
        public const string EnterNameOrSurnameToSearch = "Lütfen numarasını aramak istediğiniz kişinin adını ya da soyadını giriniz :";
        public const string EnterNumbToSearch = "Lütfen numarasını aramak istediğiniz kişinin telefon numarasını giriniz :";
        public const string EndUpdate = "* Güncellemeyi sonlandırmak için    : (1)";
        public const string SearchType = "Arama yapmak istediğiniz tipi seçiniz.\n********************************************** \nİsim veya soyisime göre arama yapmak için: (1) \nTelefon numarasına göre arama yapmak için: (2)";
        public const string SearchWithName = "İsim veya soyisime göre arama yapmak için: (1)";
        public const string SearchWithNmb = "Telefon numarasına göre arama yapmak için: (2)";
        public const string SearchResult = "\nArama Sonuçlarınız :\n";
        public const string EndSearch = "* Aramayı sonlandırmak için    : (1)";
        public const string Name = "İsim :";
        public const string Surname = "Soyisim :";
        public const string PhoneNmb = "Telefon Numarası :";
        public const string Asteriks = "**********************************************";
        public const string SelectionError = "\nHata ! Girişiniz seçenekler dahilinde bir sayı olmalı.\n";
        public const string ContactList = "\nTelefon Rehberi\n**********************************************";
        public const string AddSuccess = "\nKişi başarıyla rehbere eklendi\n";
        public const string RmvSuccess = "\nNumara silme işlemi başarıyla gerçekleşti\n";
        public const string UpdateSuccess = "\nNumara güncelleme işlemi başarıyla gerçekleşti" + "\n";
        public const string EmptyFieldErr = "\nHata ! Bilgiler boş bırakılamaz\n";
        public const string NothingToShow = "\nGösterilecek veri bulunamadı...\n";
        public const string ErrMissingInfo = "\nHata ! Herhangi bir değeri eksik girdiniz, tekrar deneyiniz\n";
    }
}