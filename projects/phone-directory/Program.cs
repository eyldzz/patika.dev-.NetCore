using System.Data;
using System.Transactions;

namespace phone_directory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Actions action = new Actions();


            bool tf=true;
            while(tf)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: \n");
                Console.WriteLine("1- Yeni telefon numarası kaydet\n" + "2- Varolan telefon numarasını sil\n" + "3- Varolan telefon numarasını güncelle\n" + "4- Telefon rehberini listele\n" + "5- Rehberde arama yap\n");
                Console.Write("Seçiminiz: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num >= 1 && num <= 5)
                    {
                        switch (num)
                        {
                            case 1:
                                action.AddPerson();
                                break;
                            case 2:
                                action.DeletePerson();
                                break;
                            case 3:
                                action.UpdatePerson();
                                break;
                            case 4:
                                action.ListPerson();
                                break;
                            case 5:
                                action.SearchPerson();
                                break;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n*****  1-5 arası sayı giriniz  *****\n");
                    }
                        
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n*****  sadece sayı girişi yapınız  *****\n");
                }

            } 
            
        }
    }
}