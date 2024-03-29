
# RESOURCE YOKSA OLUŞTURSUN
    bool boolTemp = Directory.Exists(pathRESOURCES);
    if (!boolTemp) Directory.CreateDirectory(pathRESOURCES);

# KAYDEDİLECEK KONUM BİLGİSİ
    string tempPath = pathRESOURCES + isim;
    if (System.IO.File.Exists(tempPath)) { Debug.Log("Dosya bulunmaktadır"); }
    
# DOSYA YUKLEMEK
    "file:///D://SampleImage.png"

# DIŞARIDAN DOSYA ÇALIŞTIRMAK
    system.Diagnostics.Process.Start(textbox1.text);

# DOSYA YAZMAK
    System.IO.File.WriteAllBytes(write_path, www.downloadHandler.data);

# DOSYA NOKTA İLE AYIRMA
    string tempString = isim.Split('.')[0];
# DOSYA OLUŞTURMA DEĞİŞTİRME BİLGİLERİ
    /*public void setTarihBilgisi(string path)
    {
        System.IO.FileSystemInfo fsi = new FileInfo(path);
        File.SetCreationTime(path, new DateTime(1923, 10, 29, 20, 30, 00));
        string temp = String.Format("Dosya adı: {0}\nDosya oluşturuluş tarihi ve saati: {1}",fsi.FullName,fsi.CreationTime.ToString("yyyy-MM-dd HH:mm:ss"));
        Debug.Log(temp);
    }*/

    //KLASOR TARİHLERİ
    public DateTime getKlasorOlusturulmaTarihi(string path){ return Directory.GetCreationTime(path);}
    public void printKlasorOlusturulmaTarihi(string path){ Debug.Log(path + " klasorü oluşturulma tarihi: " + getKlasorOlusturulmaTarihi(path)); }

    public DateTime getKlasorSonErisimTarihi(string path) { return Directory.GetLastAccessTime(path); }
    public void printKlasorSonErisimTarihi(string path) { Debug.Log(path + " klasorü son erisim tarihi: " + getKlasorSonErisimTarihi(path)); }

    public DateTime getKlasorSonKayitTarihi(string path) { return Directory.GetLastWriteTime(path); }
    public void printKlasorSonKayitTarihi(string path) { Debug.Log(path + " klasorü son kayıt tarihi: " + getKlasorSonErisimTarihi(path)); }

    public void sampleKlasor(string path = "d:/fatman")
    {
        if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
        printKlasorOlusturulmaTarihi(path);
        printKlasorSonErisimTarihi(path);
        printKlasorSonKayitTarihi(path);
    }

    //DOSYA TARİHLERİ
    public DateTime getDosyaOlusturulmaTarihi(string path) { return File.GetCreationTime(path); }
    public void printDosyaOlusturulmaTarihi(string path) { Debug.Log(path + " dosyası oluşturulma tarihi: " + getDosyaOlusturulmaTarihi(path)); }

    public DateTime getDosyaSonErisimTarihi(string path) { return File.GetLastAccessTime(path); }
    public void printDosyaSonErisimTarihi(string path) { Debug.Log(path + " dosyası son erisim tarihi: " + getDosyaSonErisimTarihi(path)); }

    public DateTime getDosyaSonKayitTarihi(string path) { return File.GetLastWriteTime(path); }
    public void printDosyaSonKayitTarihi(string path) { Debug.Log(path + " dosyası son kayıt tarihi: " + getDosyaSonErisimTarihi(path)); }

    public void sampleDosya(string path = "d:/fatman.txt")
    {
        if (!File.Exists(path)) { FileStream fs = File.Create(path); }
        printDosyaOlusturulmaTarihi(path);
        printDosyaSonErisimTarihi(path);
        printDosyaSonKayitTarihi(path);
    }



