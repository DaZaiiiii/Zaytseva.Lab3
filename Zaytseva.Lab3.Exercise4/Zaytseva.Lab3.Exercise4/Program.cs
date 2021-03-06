using System;

namespace Zaytseva.Lab3.Exercise4
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Дано натуральное число n(1 <= n <= 1199), определяющее возраст человека(в месяцах).
            //Выразить возраст в годах и месяцах, например, 21 год 10 месяцев, 52 года 1 месяц, 46 лет ровно и т. п.

            Console.WriteLine("Введите возраст  человека в месяцах, где 1 <= n <= 1199");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Возраст: " + n + " месяц");
            }
            else if (n >= 2 && n <= 4)
            {
                Console.WriteLine("Возраст: " + n + " месяца");
            }
            else if (n >= 5 && n <= 11)
            {
                Console.WriteLine("Возраст: " + n + " месяцев");
            }
            else if (n == 12 | n == 252 | n == 372 | n == 492 | n == 612 | n == 732 | n == 852 | n == 972 | n == 1092)
            {
                n = n / 12;
                Console.WriteLine("Возраст: " + n + " год");
            }
            else if (n == 24 | n == 36 | n == 48 | n == 264 | n == 276 | n == 288 | n == 384 | n == 396 | n == 408 | n == 504 | n == 516 | n == 528 | n == 624 | n == 636 | n == 648 | n == 744 | n == 756 | n == 768 | n == 864 | n == 876 | n == 888 | n == 984 | n == 996 | n == 1008 | n == 1104 | n == 1116 | n == 1128)
            {
                n = n / 12;
                Console.WriteLine("Возраст: " + n + " года");
            }
            else if (n == 13 | n == 253 | n == 373 | n == 493 | n == 613 | n == 733 | n == 853 | n == 973 | n == 1093)
            {
                int n1 = n / 12;
                int n2 = n % 12;
                Console.WriteLine("Возраст: " + n1 + " год " + n2 + " месяц");
            }
            else if (n >= 14 && n <= 16 | n >= 254 && n <= 256 | n >= 374 && n <= 376 | n >= 494 && n <= 496 | n >= 614 && n <= 616 | n >= 734 && n <= 736 | n >= 854 && n <= 856 | n >= 974 && n <= 976 | n >= 1094 && n <= 1096)
            {
                int n1 = n / 12;
                int n2 = n % 12;
                Console.WriteLine("Возраст: " + n1 + " год " + n2 + " месяца");
            }
            else if (n >= 17 && n <= 23 | n >= 257 && n <= 263 | n >= 377 && n <= 383 | n >= 497 && n <= 503 | n >= 617 && n <= 623 | n >= 737 && n <= 743 | n >= 857 && n <= 863 | n >= 977 && n <= 983 | n >= 1097 && n <= 1103)
            {
                int n1 = n / 12;
                int n2 = n % 12;
                Console.WriteLine("Возраст: " + n1 + " год " + n2 + " месяцев");
            }
            else if (n == 25 | n == 37 | n == 49 | n == 265 | n == 277 | n == 289 | n == 385 | n == 397 | n == 409 | n == 505 | n == 517 | n == 529 | n == 625 | n == 637 | n == 649 | n == 745 | n == 757 | n == 769 | n == 865 | n == 877 | n == 889 | n == 985 | n == 997 | n == 1009 | n == 1105 | n == 1117 | n == 1129)
            {
                int n1 = n / 12;
                int n2 = n % 12;
                Console.WriteLine("Возраст: " + n1 + " года " + n2 + " месяц");
            }
            else if (n >= 26 && n <= 28 | n >= 38 && n <= 40 | n >= 50 && n <= 52 | n >= 266 && n <= 268 | n >= 278 && n <= 280 | n >= 290 && n <= 292 | n >= 386 && n <= 388 | n >= 398 && n <= 400 | n >= 410 && n <= 412 | n >= 506 && n <= 508 | n >= 518 && n <= 520 | n >= 530 && n <= 532 | n >= 626 && n <= 628 | n >= 638 && n <= 640 | n >= 650 && n <= 652 | n >= 746 && n <= 748 | n >= 758 && n <= 760 | n >= 770 && n <= 772 | n >= 866 && n <= 868 | n >= 878 && n <= 880 | n >= 890 && n <= 892 | n >= 986 && n <= 988 | n >= 998 && n <= 1000 | n >= 1010 && n <= 1012 | n >= 1106 && n <= 1108 | n >= 1118 && n <= 1120 | n >= 1130 && n <= 1132)
            {
                int n1 = n / 12;
                int n2 = n % 12;
                Console.WriteLine("Возраст: " + n1 + " года " + n2 + " месяца");
            }
            else if (n>=29 && n<=35 | n>=41 && n<=47 | n >= 53 && n <=59 | n >= 269 && n <= 275 | n >= 281 && n <= 287 | n >= 293 && n <= 299 | n >= 389 && n <= 395 | n >= 401 && n <= 407 | n >= 413 && n <= 419 | n >= 509 && n <= 515 | n >= 521 && n <= 527 | n >= 533 && n <= 539 | n >= 629 && n <= 635 | n >= 541 && n <= 647 | n >= 653 && n <= 659 | n >= 749 && n <= 755 | n >= 761 && n <= 767 | n >= 773 && n <= 779 | n >= 869 && n <= 875 | n >= 881 && n <= 887 | n >= 893 && n <= 899 | n >= 989 && n <= 995 | n >= 1001 && n <= 1007 | n >= 1013 && n <= 1019 | n >= 1109 && n <= 1115 | n >= 1121 && n <= 1127 | n >= 1133 && n <= 1139)
            {
                int n1 = n / 12;
                int n2 = n % 12;
                Console.WriteLine("Возраст: " + n1 + " года " + n2 + " месяцев");
            }
            else if (n % 2 == 0)
            {
                int n1 = n / 12;
                Console.WriteLine("Возраст: " + n1 + " лет ");
            }
            else if (n==61|n==73|n==85|n==97|n==109|n==121|n==133|n==145|n==157|n==169|n==181|n==193|n==205|n==217|n==229|n==241|n==301|n==313|n==325|n==337|n==349|n==361|n==421|n==433|n==445|n==457|n==469|n==481|n==541|n==553|n==565|n==577|n==589|n==601|n==661|n==673|n==685|n==697|n==709|n==721|n==781|n==793|n==805|n==817|n==829|n==841|n==901|n==913|n==925|n==937|n==949|n==961|n==1021|n==1033|n==1045|n==1057|n==1069|n==1081|n==1141|n==1153|n==1165|n==1177|n==1189)
            {
                int n1 = n / 12;
                int n2 = n % 12;
                Console.WriteLine("Возраст: " + n1 + " лет " + n2 + " месяц");
            }
            else if (n>=62 && n<=64|n>=74 && n<=76|n>=86 && n<=88|n>=98 && n<=100|n>=110 && n<=112|n>=122 && n<=124|n>=134 && n<=136|n>=146 && n<=148|n>=158 && n<=160|n>=170 && n<=172|n>=182 && n<=184|n>=194 && n<=196|n>=206 && n<=208|n>=218 && n<=220|n>=230 && n<=232|n>=242 && n<=244|n>=302 && n<=304|n>=314 && n<=316|n>=326 && n<=328|n>=338 && n<=340|n>=350 && n<=352|n>=362 && n<=364|n>=422 && n<=424|n>=434 && n<=436|n>=446 && n<=448|n>=458 && n<=460|n>=470 && n<=472|n>=482 && n<=484|n>=542 && n<=544|n>=554 && n<=556|n>=566 && n<=568|n>=578 && n<=580|n>=590 && n<=592|n>=602 && n<=604|n>=662 && n<=664|n>=674 && n<=676|n>=686 && n<=688|n>=698 && n<=700|n>=710 && n<=712|n>=722 && n<=724|n>=782 && n<=784|n>=794 && n<=796|n>=806 && n<=808|n>=818 && n<=820|n>=830 && n<=832|n>=842 && n<=844|n>=902 && n<=904|n>=914 && n<=916|n>=926 && n<=928|n>=938 && n<=940|n>=950 && n<=952|n>=962 && n<=964|n>=1022 && n<=1024|n>=1034 && n<=1036|n>=1046 && n<=1048|n>=1058 && n<=1060|n>=1070 && n<=1072|n>=1082 && n<=1084|n>=1142 && n<=1144|n>=1154 && n<=1156|n>=1166 && n<=1168|n>=1178 && n<=1180|n>=1190 && n<=1192)
            {
                int n1 = n / 12;
                int n2 = n % 12;
                Console.WriteLine("Возраст: " + n1 + " лет " + n2 + " месяца");
            }
            else
            {
                int n1 = n / 12;
                int n2 = n % 12;
                Console.WriteLine("Возраст: " + n1 + " лет " + n2 + " месяцев");
            }

     }
       
}
