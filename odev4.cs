using System;

class Node
{
    public int Veri;
    public Node Sonraki;

    public Node(int veri)
    {
        Veri = veri;
        Sonraki = null;
    }
}

class Kuyruk
{
    private Node Bas;
    private Node Son;

    public Kuyruk()
    {
        Bas = null;
        Son = null;
    }

    public void Ekle(int veri)
    {
        Node yeniNode = new Node(veri);

        if (Bas == null)
        {
            Bas = yeniNode;
            Son = yeniNode;
        }
        else
        {
            Son.Sonraki = yeniNode;
            Son = yeniNode;
        }

        Console.WriteLine("{0} değeri kuyruğa eklendi.", veri);
    }

    public void Sil()
    {
        if (Bas == null)
        {
            Console.WriteLine("Kuyruk boş.");
        }
        else
        {
            int silinenVeri = Bas.Veri;
            Bas = Bas.Sonraki;

            if (Bas == null)
                Son = null;

            Console.WriteLine("{0} değeri kuyruktan silindi.", silinenVeri);
        }
    }

    public void Goster()
    {
        if (Bas == null)
        {
            Console.WriteLine("Kuyruk boş.");
        }
        else
        {
            Console.WriteLine("Kuyruktaki elemanlar:");

            Node current = Bas;

            while (current != null)
            {
                Console.Write(current.Veri + " ");
                current = current.Sonraki;
            }

            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Kuyruk kuyruk = new Kuyruk();

        while (true)
        {
            Console.WriteLine("----- KUYRUK UYGULAMASI -----");
            Console.WriteLine("1. Ekle");
            Console.WriteLine("2. Sil");
            Console.WriteLine("3. Görüntüle");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminizi yapın: ");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.Write("Eklenecek değeri girin: ");
                    int eklenecekDeger = Convert.ToInt32(Console.ReadLine());
                    kuyruk.Ekle(eklenecekDeger);
                    break;
                case "2":
                    kuyruk.Sil();
                    break;
                case "3":
                    kuyruk.Goster();
                    break;
                case "4":
                    Console.WriteLine("Programdan çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Tekrar deneyin.");
                    break;
            }

            Console.WriteLine();
        }
    }
}