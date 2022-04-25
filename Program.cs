using System;

class Program
{
    static void Main(string[] args)
    {
        //Erişim Belirteçleri 
        // private 
        // public 
        // Internal
        // Protected
        Calısan calısan1 = new Calısan();
        Console.WriteLine("********************");
        Telefon emreTelefon = new Telefon();
        emreTelefon.Islemci = "Ios";
        emreTelefon.Model = "Iphone 7";
        emreTelefon.SeriNo = 11111;
        emreTelefon.ekranaYazdırTelefon();
        Console.WriteLine("********************");
        Calısan calısan2 = new Calısan("Sefa","Koca",1112345,"Garson");
        calısan2.ekranaYazdırCalısan();
        Console.WriteLine("********************");
        Telefon sefaTelefon = new Telefon("Android","Galaxy",123123);
        sefaTelefon.ekranaYazdırTelefon();

    }
}

class Calısan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;    
    public void ekranaYazdırCalısan()
    {
        Console.WriteLine("Calısanın Adı : {0}",Ad);
        Console.WriteLine("Calısanın Soyadı : {0}",Soyad);
        Console.WriteLine("Calısanın Numarası : {0}",No);
        Console.WriteLine("Calısanın Departmanı : {0}",Departman);
    }
    public Calısan(string _Ad, string _Soyad, int _No, string _Departman)
    {
        Ad = _Ad;
        Soyad = _Soyad;
        No = _No;
        Departman = _Departman; 
    }
    public Calısan(){}
}
class Telefon
{
    public string Islemci;
    public string Model;
    public int SeriNo;
    public void ekranaYazdırTelefon()
    {
        Console.WriteLine("Telefonun İşlemcisi : {0}",Islemci);
        Console.WriteLine("Telefonun Modeli : {0}",Model);
        Console.WriteLine("Telefonun Seri Numarası : {0}",SeriNo);
    }
    public Telefon(){}
    public Telefon(string işlemci,string model, int seriNo)
    {
        Islemci = işlemci;
        Model = model;
        SeriNo = seriNo;
    }
}
