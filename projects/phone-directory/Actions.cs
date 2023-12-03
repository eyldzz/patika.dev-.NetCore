using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace phone_directory
{
    public class Actions
    {
        List<Person> person = new List<Person>();
        public Actions()
        {
            person.Add(new Person("Emre", "Yildiz", "5559992525"));
            person.Add(new Person("Mehmet", "Bulut", "9995555252"));
            person.Add(new Person("Emin", "Yildiz", "2525555999"));
            person.Add(new Person("Burak", "Kizilkaya", "5252555999"));
            person.Add(new Person("Murat", "Barbaros", "2525999555"));
        }

        public void AddPerson()
        {
            Console.Clear();
        InputfirstName:
            Console.Write("Kaydedilecek kişi adı: ");
            string firstName = Console.ReadLine();
            if (InputControl.IsNull(firstName))  // girilen verinin boş olup olmadığını kontrol eder
                goto InputfirstName;
        InputlastName:
            Console.Write("Kaydedilecek kişi soyadı: ");
            string lastName = Console.ReadLine();
            if (InputControl.IsNull(lastName))   // girilen verinin boş olup olmadığını kontrol eder
                goto InputlastName;
        InputphoneNum:
            Console.Write("Kaydedilecek kişi telefon numarası: ");
            string phoneNum = Console.ReadLine();
            if (InputControl.IsNull(phoneNum))   // girilen verinin boş olup olmadığını kontrol eder
                goto InputphoneNum;

            person.Add(new Person(firstName,lastName, phoneNum));   // person List'ine Person sınıfındaki propertylerle kayıt ekler
            Console.Clear();
            Console.WriteLine($"***** {firstName} kişisi kaydedildi *****\n");
        }

        public void DeletePerson()
        {
        head:
            Console.Clear();
            Console.Write("Silinecek kişinin adını veya soyadını giriniz: ");
            string deleteValue = Console.ReadLine();

            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].FirstName.Equals(deleteValue) || person[i].LastName.Equals(deleteValue))
                {
                    Console.WriteLine(person[i].FirstName + " adlı kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n): ");
                    string choice = Console.ReadLine();
                    if (choice == "y")
                    {
                        Console.WriteLine(person[i].FirstName + " Adlı kişi rehberden silinmiştir..");
                        person.RemoveAt(i);
                        break;
                    }
                    else if (choice == "n")
                    {
                        break;
                    }
                }
                if (i == person.Count - 1) // listenin sonuna gelindiğindiğinde kayıt bulunamadı demektir
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. tekrar denemek için 'y' çıkmak için herhangi bir tuşa basın");
                    string choice = Console.ReadLine();
                    if (choice == "y")
                        goto head;
                    else
                        break;
                }

            }

        }
        public void UpdatePerson()
        {
        head:
            Console.Clear();
            Console.Write("Güncellenecek kişinin ismini veya soyismini giriniz: ");
            string valueForUpdate = Console.ReadLine();
            for (int i = 0; i < person.Count; i++)
            {
                if (person[i].FirstName.Equals(valueForUpdate) || person[i].LastName.Equals(valueForUpdate))
                {
                    Console.WriteLine($"*****  Bulunan kişi  *****\nİsim: {person[i].FirstName}\nSoyisim: {person[i].LastName}\nTelefon numarası: {person[i].PhoneNum}\n");
                    Console.WriteLine("1- İsim Güncelle\n2- Soyisim Güncelle\n3- Telefon numarası Güncelle\n4- İptal için herhangi bir veri gir");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("Yeni ismi giriniz: ");
                        string newName = Console.ReadLine();
                        Console.Write(person[i].FirstName + " adlı kişinin ismi");
                        person[i].FirstName = newName;
                        Console.WriteLine(person[i].FirstName + " olarak güncellenmiştir");
                        break;
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Lütfen yeni soyadını  giriniz: ");
                        string newSurname = Console.ReadLine();
                        Console.Write(person[i].LastName + " adlı kişinin ismi ");
                        person[i].LastName = newSurname;
                        Console.WriteLine(person[i].LastName + " olarak güncellenmiştir");
                        break;
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Lütfen yeni numarayı giriniz: ");
                        string newNumber = Console.ReadLine();
                        Console.Write(person[i].PhoneNum + " adlı kişinin numarası ");
                        person[i].PhoneNum = newNumber;
                        Console.WriteLine(person[i].PhoneNum + " olarak güncellenmiştir");
                        break;
                    }
                    else
                        Console.Clear();
                        break;
                    
                }
                if (i == person.Count - 1)
                {
                    Console.Write("Aradığınız krtiterlere uygun veri rehberde bulunamadı.\nTekrar denemek için 'y' çıkmak için herhangi bir veri girişi yapın: ");
                    string choice = Console.ReadLine();
                    if (choice == "y")
                        goto head;
                    else
                        break;
                }

            }
        }
        public void ListPerson()
        {
        head:
            Console.Clear();
            Console.Write("1- A-Z listele\n2- Z-A listele\nSeçiminiz: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    var sorted = person.OrderBy(value => value.FirstName);
                    foreach (var item in sorted)
                    {
                        Console.WriteLine("\nAd                   : " + item.FirstName);
                        Console.WriteLine("Soyadı               : " + item.LastName);
                        Console.WriteLine("Telefon numarası     : " + item.PhoneNum);
                    }
                    Console.WriteLine("");
                    break;

                case 2:
                    var reversed = person.OrderBy(value => value.FirstName).Reverse();
                    foreach (var item in reversed)
                    {
                        Console.WriteLine("\nAd                   : " + item.FirstName);
                        Console.WriteLine("Soyadı               : " + item.LastName);
                        Console.WriteLine("Telefon numarası     : " + item.PhoneNum);
                    }
                    Console.WriteLine("");
                    break;
            }

        }


        public void SearchPerson()
        {
            Console.Clear();
            Console.Write("1- İsim veya soyisme göre ara\n2- Telefon numarasına göre ara\nSeçiminiz: ");
            int choice= int.Parse(Console.ReadLine());
            int cntrl = 0;
            switch (choice)
            {
                case 1:
                    
                    Console.Write("Aradığınız ismi veya soyismi giriniz: ");
                    string nameOrSurname = Console.ReadLine();
                    for (int i = 0; i < person.Count; i++)
                    {

                        if (person[i].FirstName.Equals(nameOrSurname) || person[i].LastName.Equals(nameOrSurname))
                        {
                            Console.WriteLine("\nAd                  : " + person[i].FirstName);
                            Console.WriteLine("Soyad               : " + person[i].LastName);
                            Console.WriteLine("Telefon Numarası    : " + person[i].PhoneNum + "\n");
                            cntrl++;

                        }
                        if(cntrl==0)
                        {
                            Console.WriteLine("\n*****  Aradığınız kişi rehberde bulunamadı  *****\n");
                            break;
                        }
                    }

                    break;

                case 2:
                    Console.Write("Aradığınız telefon numarasını giriniz: ");
                    string searchNum = Console.ReadLine();
                    for (int i = 0; i < person.Count; i++)
                    {
                        if (person[i].FirstName.Equals(searchNum))
                        {
                            Console.WriteLine("\nAd                  : " + person[i].FirstName);
                            Console.WriteLine("Soyad               : " + person[i].LastName);
                            Console.WriteLine("Telefon Numarası    : " + person[i].PhoneNum + "\n");
                            cntrl++;
                        }
                        if(cntrl==0)
                        {
                            Console.WriteLine("\n*****  Aradığınız numara rehberde bulunamadı  *****\n");break;
                        }
                    }



                    break;





            }

            

        }






    }
}
