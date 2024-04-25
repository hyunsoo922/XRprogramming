using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Omok
    {
        static void Main(string[] args)
        {
            // 1. 게임판 배열로 만들기
            string[,] map =
            {
                {"┌ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┬ ","┐ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"├ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┼ ","┤ " },
                {"└ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┴ ","┘ " },
            };

            // 게임판 출력

            printMap();

            void printMap()
            {
                for (int i = 0; i < 19; i++)
                {
                    for (int j = 0; j < 19; j++)
                    {

                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            // 2. 흑돌, 백돌 턴을 만들어 제한하기
            string turn = "black";
            string black = "●";
            string white = "○";

            // 3. 화살표 키보드를 눌러서 게임판 배열내의 돌을 둘위치를 움직일수 있게 하기(돌이 놓아진 위치로 이동 불가)
            ConsoleKeyInfo arrow;
            string location = "■";
            int x = 0;
            int y = 0;
            // tempX, tempY, temp는 location이 위치를 이동한 후 게임 판을 원래 형태로 되돌리기 위함
            int tempX = 0;
            int tempY = 0;
            string temp = "┌ ";
            while (true)
            {
                arrow = Console.ReadKey(true);
                map[tempY, tempX] = temp;
                if (arrow.Key == ConsoleKey.RightArrow) // 우측 이동
                {
                    if (x != 19)
                    {
                        // 우측 끝벽 도착 시 우측 이동 불가
                        if(x == 18)
                        {
                            continue;
                        }
                        else if (map[y, x + 1] != black && map[y, x + 1] != white && x+1 < 19)
                        {
                            x++;
                            temp = map[y, x];
                            tempX = x;
                            tempY = y;
                        }
                    }
                }else if(arrow.Key == ConsoleKey.LeftArrow) // 좌측 이동
                {
                    if(x != 0)
                    {
                        if (map[y, x - 1] != black && map[y, x - 1] != white)
                        {
                            x--;
                            temp = map[y, x];
                            tempX = x;
                            tempY = y;
                        }
                    }
                }else if(arrow.Key == ConsoleKey.UpArrow)   // 위로 이동
                {
                    if(y != 0)
                    {
                        if (map[y - 1, x] != black && map[y - 1, x] != white)
                        {
                            y--;
                            temp = map[y, x];
                            tempX = x;
                            tempY = y;
                        }
                    }
                }else if(arrow.Key == ConsoleKey.DownArrow) // 아래로 이동
                {
                    if(y != 19)
                    {
                        // 하단 끝벽 도착시 아래로 아래로 이동 불가
                        if(y==18)
                        {
                            continue;
                        }
                        else if (map[y + 1, x] != black && map[y + 1, x] != white && y+1 <19)
                        {
                            y++;
                            temp = map[y, x];
                            tempX = x;
                            tempY = y;
                        }
                    }
                }
                map[y, x] = location;
                
                // 4. 스페이스바를 눌렀을 때 해당 위치에 돌을 둔다. 
                if(arrow.Key == ConsoleKey.Spacebar)
                {
                    // 5. 돌을 두었다면 다음 색상의 유저에게 턴을 넘긴다.
                        if (turn == "black")
                        {
                            map[y, x] = black;
                            // 초기위치로 변경
                            x = 0;
                            y = 0;
                            tempX = 0;
                            tempY = 0;
                            temp = "┌ ";
                            // 턴을 넘긴다.
                            turn = "white";
                        }
                        else if(turn == "white")
                        {
                            map[y, x] = white;
                            // 초기위치로 변경
                            x = 0;
                            y = 0;
                            tempX = 0;
                            tempY = 0;
                            temp = "┌ ";
                            // 턴을 넘긴다.
                            turn = "black";
                        }
                    

                }
                // 7. 검사 시 5개의 같은 색상의 돌이 일렬로 있으면 해당 색상의 돌을 가진 유저의 승리를 출력하며 게임을 종료한다.
                string winner = CheckWinner(map);
                if (winner != "")
                {
                    Console.WriteLine(winner + "의 승리!");
                    break;
                }



                Console.Clear();
                printMap();
            }
            // 6. 위에서 아래, 왼쪽에서 오른쪽, 우상단 에서 좌하단으로 좌상단에서 우하단으로 5개의 같은 색상의 돌이 있는지 검사
            static string CheckWinner(string[,] map)
            {
                int height = map.GetLength(0);
                int width = map.GetLength(1);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        // 현재 위치의 돌
                        string stone = map[y, x];
                        if (stone != "●" && stone != "○") // 돌이 아닌 경우 검사하지 않음
                            continue;

                        // 현재 돌의 주변을 검사
                        if (CheckDirection(map, x, y, 1, 0, stone) || // 수평
                            CheckDirection(map, x, y, 0, 1, stone) || // 수직
                            CheckDirection(map, x, y, 1, 1, stone) || // 우상단 -> 좌하단
                            CheckDirection(map, x, y, -1, 1, stone))   // 좌상단 -> 우하단
                        {
                            return stone == "●" ? "흑돌" : "백돌";  // 오목의 돌이 "●" true 이면 winner 흑돌 false 이면 winner 백돌
                        }
                    }
                }

                return "";
            }
            // 게임판, 검사 시작위치 x, 검사 시작위치 y, 움직일 방향 x, 움직일 방향 y, 돌의색
            static bool CheckDirection(string[,] map, int startX, int startY, int moveX, int moveY, string stone)
            {
                int count = 0;
                
                // 시작 위치부터 5칸까지 검사
                for (int i = 0; i < 5; i++)
                {
                    int x = startX + i * moveX;
                    int y = startY + i * moveY;

                    if (x < 0 || y < 0 || x >= map.GetLength(1) || y >= map.GetLength(0))
                        break;

                    if (map[y, x] == stone)
                    {
                        count++;
                        if (count == 5) // 오목 완성
                            return true; 
                    }
                    else // 해당 색의 돌이 연속되지 않음
                    {
                        break; 
                    }
                }

                return false;
            }


            
        }

    }
}