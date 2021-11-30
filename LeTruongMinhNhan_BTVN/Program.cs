using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace LeTruongMinhNhan_BTVN
{
    class Player
    {
        public string Name;
        public string Team;
        public float Score;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;
            var listPlayer = new List<Player> {
            new Player { Name = "Anh", Team = "A", Score = 10 },
            new Player { Name = "Vân", Team = "A", Score = 25 },
            new Player { Name = "Sơn ", Team = "L", Score = 60 },
            new Player { Name = "Hải", Team = "L", Score = 20 },
            new Player { Name = "Dủng", Team = "A", Score = 40 },
            new Player { Name = "Vinh", Team = "L", Score = 30 },
            new Player { Name = "Ninh", Team = "L", Score = 50 },
            };
            // Câu 6
            var locNguoi = from P in listPlayer
                           where P.Team == "A" && P.Score > 25
                           select P;
            // Câu 7
            var sapXep = from P in listPlayer
                         orderby P.Score
                         select P;
            // Câu 8
            var Top = (from P in listPlayer
                       orderby P.Score descending
                       select P).Take(2);
            // Câu 9
            var DTBA = (from P in listPlayer
                        where P.Team == "A"
                        select P).Average(P => P.Score);

            var DTBL = (from P in listPlayer
                        where P.Team == "L"
                        select P).Average(P => P.Score);

            var x = from P in listPlayer
                    group P by P.Team ;
            // Câu 10
            string t = "n";
            var lietKe = from P in listPlayer
                           where P.Name.ToLower().Contains(t.ToLower())
                           select P;

            Console.WriteLine("Danh sách người chơi nhóm A có điểm Score > 25");
            foreach (Player pl in locNguoi)
            {
                Console.WriteLine($"Name:  {pl.Name}, Team:  {pl.Team}, Score:  {pl.Score} ");
            }

            Console.WriteLine("Sắp xếp các tên theo thứ tự điểm tăng dần");
            foreach (Player pl in sapXep)
            {
                Console.WriteLine($"Name:  {pl.Name}, Team:  {pl.Team}, Score:  {pl.Score} ");
            }

            Console.WriteLine("Hai người có điểm cao nhất");
            foreach (Player pl in Top)
            {
                Console.WriteLine($"Name:  {pl.Name}, Team:  {pl.Team}, Score:  {pl.Score} ");
            }


            foreach (var pl in x)
            {
                Console.WriteLine("Team Group: {0}", pl.Key);
                foreach (Player i in pl)
                {
                    Console.WriteLine("Player name  {0}", i.Name);
                }
            }

            Console.WriteLine("Điểm trung bình nhóm A: {0} ", DTBA);
            Console.WriteLine("Điểm trung bình nhóm L: {0} ", DTBL);

            Console.WriteLine("Tên người chơi chứa kí tự 'n' không phân biệt hoa thường");
            foreach (Player pl in lietKe)
            {
                Console.WriteLine($"Name:  {pl.Name}, Team:  {pl.Team}, Score:  {pl.Score} ");
            }

        }
    }
}
