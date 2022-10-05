namespace BubbleShort
{
    class Program
    {
        //Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];
        //Deklarasi variable int untuk menyimpan banyaknya data pada array
        private int n;
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                {
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 element.\n");
                }
                Console.WriteLine("");
                Console.WriteLine("------------------------");
                Console.WriteLine("Masukkan elemen array ");
                Console.WriteLine("------------------------");

                //Pengguna memasukkan elemen pada array
                for (int i = 0; i < n ; i++)
                {
                    Console.Write("<" + (i + i) + "> ");
                    string s1 = Console.ReadLine();
                    a[i] = Int32.Parse(s1);
                }
            }
            public void display()
            {

            }
        }
    }
}