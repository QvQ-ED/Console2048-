using System;

namespace _01//相同的命名空间
{
    class Program
    {
         //消除类游戏做法
         //逻辑控制 与 显示（界面代码）松散耦合
         // 数据（位置） 
         //面向对象思想：分而治之 高内聚 低耦合
        static void Main(string[] args)
        {
           
            GameCore core = new GameCore();
            core.GenerateNumber();
            core.GenerateNumber();
          //显示界面
            DrawMap(core.Map);

            while (true)
            {
                //移动
                KeyDown(core);
                if (core.IsChange)
                {
                    core.GenerateNumber();
                    DrawMap(core.Map);
                }
            }
      }
        //只有静态的类才能调用静态的方法，main是静态的
        private static void DrawMap(int[,] map)
        {
            Console.Clear();
            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(map[r, c] + "\t");
                }
                Console.WriteLine();
            }
            //如果游戏结束  悔棋
        }

        private static void KeyDown(GameCore core)
        {
            switch (Console.ReadLine())
            {
                case "w":
                    core.Move(MoveDirection.Up);
                    break;
                case "s":
                    core.Move(MoveDirection.Down);
                    break;
                case "a":
                    core.Move(MoveDirection.Left);
                    break;
                case "d":
                    core.Move(MoveDirection.Right);
                    break;
            }
        }
    }
}
