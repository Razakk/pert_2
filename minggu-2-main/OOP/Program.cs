using System;

// Encapsulation
public class Mahasiswa
{
    private string nama;
    private string jurusan;
    private int umur;
    private int nim;

    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public string Jurusan
    {
        get { return jurusan; }
        set { jurusan = value; }
    }

    public int Umur
    {
        get { return umur; }
        set { umur = value; }
    }

    public int Nim
    {
        get { return nim; }
        set { nim = value; }
    }

    public void Profile()
    {
        Console.WriteLine("\n====== Encapsulation ======");
        Console.WriteLine($"Hai, nama saya {Nama}, saya berumur {Umur} tahun, jurusan saya adalah {Jurusan} dan NIM saya {Nim}.");
    }
}

// Inheritance
public class MahasiswaS2 : Mahasiswa
{
    public void TambahGelar(string gelar)
    {
        Console.WriteLine("\n====== Inheritance ======");
        Console.WriteLine($"Nama saya {Nama}, dan gelar saya adalah {gelar}");
    }
}

// Abstraction
public abstract class Hewan
{
    public abstract void Bernapas();
}

// Abstraction
public class Manusia : Hewan
{
    public override void Bernapas()
    {
        Console.WriteLine("\n====== Abstraction ======");
        Console.WriteLine("Manusia bernapas dengan menghirup dan menghembuskan udara.");
    }
}

// Polymorphism
public class Dosen : Mahasiswa
{
    public void Mengajar(string mataKuliah)
    {
        Console.WriteLine("\n====== Polymorphism ======");
        Console.WriteLine($"Nama saya {Nama}, mengajar mata kuliah {mataKuliah}");
    }
}

class Program
{
    static void Main()
    {
        // Encapsulation
        Mahasiswa mahasiswa = new Mahasiswa();
        mahasiswa.Nama = "Kevin";
        mahasiswa.Umur = 19;
        mahasiswa.Jurusan = "Informatika";
        mahasiswa.Nim = 22114870;
        mahasiswa.Profile();

        // Inheritance
        MahasiswaS2 mahasiswaS2 = new MahasiswaS2();
        mahasiswaS2.Nama = "Zeta";
        mahasiswaS2.Umur = 20;
        mahasiswaS2.Jurusan = "Sistem Informasi";
        mahasiswaS2.Nim = 20114870;
        mahasiswaS2.TambahGelar("sarjana");
        mahasiswaS2.Profile();

        // Abstraction
        Hewan manusia = new Manusia();
        manusia.Bernapas();

        // Polymorphism
        Dosen dosen = new Dosen();
        dosen.Nama = "Jing Liu";
        dosen.Umur = 29;
        dosen.Mengajar("Pemrograman C#");
        dosen.Profile();
    }
}
