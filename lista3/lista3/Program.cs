internal class program
{
    static void showMenu()
    {
        Console.WriteLine("-------Meniu-------");
        Console.WriteLine("1.Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
        Console.WriteLine("2.Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. ");
        Console.WriteLine("3.Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). ");
        Console.WriteLine("4.Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.");
        Console.WriteLine("5.Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.");
        Console.WriteLine("6.Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. ");
        Console.WriteLine("7.Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
        Console.WriteLine("8.Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.");
        Console.WriteLine("9.Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.");
        Console.WriteLine("10.Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. ");
        Console.WriteLine("11.Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).");
        Console.WriteLine("12.Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.");
        Console.WriteLine("13.Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.");
        Console.WriteLine("14.Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului).");
        Console.WriteLine("15.Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.");
        Console.WriteLine("16.Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
        Console.WriteLine("17.Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.");
        Console.WriteLine("18.Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x.");
        Console.WriteLine("19.Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).");
        Console.WriteLine("20.Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem.");
        Console.WriteLine("21.Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). \n");
        Console.WriteLine("22.Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat.");
        Console.WriteLine("23.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. \n");
        Console.WriteLine("24.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).");
        Console.WriteLine("25.(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. ");
        Console.WriteLine("26.Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. ");
        Console.WriteLine("27. Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. \n");
        Console.WriteLine("28.Quicksort. Sortati un vector folosind metoda QuickSort. \n");
        Console.WriteLine("29.MergeSort. Sortati un vector folosind metoda MergeSort.\n");
        Console.WriteLine("30.Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima.");
        Console.WriteLine("31.(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara).");
        Console.WriteLine("0. Inchideti meniul");
    }


    static void problema1()
    {
        int n = int.Parse(Console.ReadLine());
        int[] vector = new int[n];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int x  = int.Parse(Console.ReadLine());
            sum += x;
        }
        Console.WriteLine("Suma elementelor este: " + sum);

    }

    static void problema2()
    {
        int n = int.Parse(Console.ReadLine());
        int[] vector = new int[n];
        int k = int.Parse(Console.ReadLine());
        int result = -1;

        for (int i = 0; i < n; i++)
        {
            vector[i] = int.Parse(Console.ReadLine());
            if (vector[i] == k)
            {
                result = i;
                break;
            }
        }
        Console.WriteLine("Prima pozitia a valori k in vector este: " + result);
    }


    static void problema3()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        int min = int.MaxValue;
        int max = int.MinValue;
        int minIndex = -1, maxIndex = -1;

        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
            if (v[i] < min)
            {
                min = v[i];
                minIndex = i;
            }
            if (v[i] > max)
            {
                max = v[i];
                maxIndex = i;
            }
        }
        Console.WriteLine("Cel mai mic element este pe pozitia: " + minIndex);
        Console.WriteLine("Cel mai mare element este pe pozitia: " + maxIndex);
    }

    static void problema4()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        int min = int.MaxValue;
        int max = int.MinValue;
        int minCount = 0, maxCount = 0;

        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
            if (v[i] < min)
            {
                min = v[i];
                minCount = 1;
            }
            else if (v[i] == min)
                minCount++;
            if (v[i] > max)
            {
                max = v[i];
                maxCount = 1;
            }
            else if (v[i] == max)
                maxCount++;
        }
        Console.WriteLine("Cel mai mic element este : " + min + " si apare de " + minCount + " ori.");
        Console.WriteLine("Cel mai mare element este : " + max + " si apare de " + maxCount + " ori.");
    }

    static void problema5()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        int e = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
        }
        for (int i = n - 1; i >= k; i--)
            v[i + 1] = v[i];

        v[k] = e;

        Console.WriteLine("Vectorul dupa inserare este: ");
        for (int i = 0; i < n + 1; i++)
            Console.Write(v[i] + " ");

    }

    static void problema6()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
        }

        for (int i = k; i < n - 1; i++)
            v[i] = v[i + 1];

        Console.WriteLine("Vectorul dupa eliminarea valorii este: ");
        for (int i = 0; i < n - 1; i++)
            Console.Write(v[i] + " ");
    }

    static void problema7()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n / 2; i++)
        {
            int temp = v[i];
            v[i] = v[n - i - 1];
            v[n - i - 1] = temp;
        }

        Console.WriteLine("Vectorul inversat este: ");
        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");
    }

    static void problema8()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int temp = v[0];
        for (int i = 0; i < n - 1; i++)
            v[i] = v[i + 1];
        v[n - 1] = temp;

        Console.WriteLine("Vectorul este: ");
        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");
    }

    static void problema9()
    {

    }

    static void problema10()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        int k = int.Parse(Console.ReadLine());
        int left = 0, right = n - 1, result = -1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (v[mid] == k)
            {
                result = mid;
                break;
            }
            else if (v[mid] < k)
                left = mid + 1;
            else
                right = mid - 1;
        }
        Console.WriteLine("Pozitia lui k este: " + result);
    }

    static void problema11()
    {

    }

    static void problema12()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (v[j] < v[minIndex])
                    minIndex = j;
            }
            int temp = v[minIndex];
            v[minIndex] = v[i];
            v[i] = temp;
        }

        Console.WriteLine("Vectorul sortat este: ");
        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");

    }

    static void problema13()
    {
        int n = int.Parse(Console.ReadLine());
        int[] vector = new int[n];

        for (int i = 0; i < n; i++)
            vector[i] = int.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            int current = vector[i];
            int j = i - 1;

            while (j >= 0 && current < vector[j])
            {
                vector[j + 1] = vector[j];
                j--;
            }

            vector[j + 1] = current;
        }

        Console.WriteLine("Vectorul sortat este: ");
        for (int i = 0; i < n; i++)
            Console.Write(vector[i] + " ");

    }

    static void problema14()
    {

    }

    static void problema15()
    {

    }
    static void problema16()
    {

    }
    static void problema17()
    {

    }
    static void problema18()
    {

    }
    static void problema19()
    {

    }
    static void problema20()
    {

    }

    static void problema21()
    {

    }

    static void problema22()
    {

    }

    static void problema23()
    {

    }

    static void problema24()
    {

    }

    static void problema25()
    {

    }

    static void problema26()
    {

    }

    static void problema27()
    {

    }

    static void problema28()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        Quicksort(v, 0, n - 1);

        Console.WriteLine("Vectorul sortat este: ");
        for (int i = 0; i < n; i++)
            Console.Write(v[i] + " ");

    }

    public static void Quicksort(int[] v, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = partition(v, left, right);
            Quicksort(v, left, pivotIndex - 1);
            Quicksort(v, pivotIndex + 1, right);
        }
    }

    private static int partition(int[] v, int left, int right)
    {
        int pivot = v[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (v[j] <= pivot)
            {
                i++;
                int temp = v[i];
                v[i] = v[j];
                v[j] = temp;
            }
        }

        int temp1 = v[i + 1];
        v[i + 1] = v[right];
        v[right] = temp1;
        return i + 1;
    }

    static void problema29()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];

        for (int i = 0; i < n; i++)
            v[i] = int.Parse(Console.ReadLine());

        MergeSort(v, 0, v.Length - 1);

        foreach (var i in v)
        {
            Console.Write(i + " ");
        }
    }

    static void MergeSort(int[] v, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(v, left, middle);
            MergeSort(v, middle + 1, right);

            Merge(v, left, middle, right);
        }
    }

    static void Merge(int[] v, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int z = 0; z < n1; z++)
        {
            L[z] = v[left + z];
        }
        for (int y = 0; y < n2; y++)
        {
            R[y] = v[middle + 1 + y];
        }

        int i = 0;
        int j = 0;
        int k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                v[k] = L[i];
                i++;
            }
            else
            {
                v[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            v[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            v[k] = R[j];
            j++;
            k++;
        }
    }

    static void problema30()
    {

    }

    static void problema31()
    {

    }

    static void menu()
    {
        int option = 1;
        while (option != 0)
        {
            Console.WriteLine("Dati optiunea: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        problema1();
                        break;
                    }
                case 2:
                    {
                        problema2();
                        break;
                    }
                case 3:
                    {
                        problema3();
                        break;
                    }
                case 4:
                    {
                        problema4();
                        break;
                    }
                case 5:
                    {
                        problema5();
                        break;
                    }
                case 6:
                    {
                        problema6();
                        break;
                    }
                case 7:
                    {
                        problema7();
                        break;
                    }
                case 8:
                    {
                        problema8();
                        break;
                    }
                case 9:
                    {
                        problema9();
                        break;
                    }
                case 10:
                    {
                        problema10();
                        break;
                    }
                case 11:
                    {
                        problema11();
                        break;
                    }
                case 12:
                    {
                        problema12();
                        break;
                    }
                case 13:
                    {
                        problema13();
                        break;
                    }
                case 14:
                    {
                        problema14();
                        break;
                    }
                case 15:
                    {
                        problema15();
                        break;
                    }
                case 16:
                    {
                        problema16();
                        break;
                    }
                case 17:
                    {
                        problema17();
                        break;
                    }

                case 18:
                    {
                        problema18();
                        break;
                    }
                case 19:
                    {
                        problema19();
                        break;
                    }
                case 20:
                    {
                        problema20();
                        break;
                    }
                case 21:
                    {
                        problema21();
                        break;
                    }
                case 22:
                    {
                        problema22();
                        break;
                    }
                case 23:
                    {
                        problema23();
                        break;
                    }
                case 24:
                    {
                        problema24();
                        break;
                    }
                case 25:
                    {
                        problema25();
                        break;
                    }
                case 26:
                    {
                        problema26();
                        break;
                    }

                case 27:
                    {
                        problema27();
                        break;
                    }
                case 28:
                    {
                        problema28();
                        break;
                    }
                case 29:
                    {
                        problema29();
                        break;
                    }
                case 30:
                    {
                        problema30();
                        break;
                    }

                case 31:
                    {
                        problema31();
                        break;
                    }
                case 0:
                    {
                        option = 0;
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Optiune inexistenta! Reincercati!");
                        break;
                    }

            }
        }
    }
    static void Main(string[] args)
    {
        showMenu();
        menu();
    }

}

