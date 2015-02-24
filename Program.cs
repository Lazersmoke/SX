//  _________   _____________  ______________________  
//  \_____   \ /   _____/\   \/  /\____    /\_____   \ 
//     /   __/ \_____  \  \     /   /     /    /   __/ 
//    |   |    /        \ /     \  /     /_   |   |    
//    |___|   /_______  //___/\  \/_______ \  |___|    
//    <___>           \/       \_/        \/  <___>    
//           __________          ____  ___.__          
//           \______   \ ___.__. \   \/  /|__|         
//    ______  |    |  _/<   |  |  \     / |  |  ______ 
//   /_____/  |    |   \ \___  |  /     \ |  | /_____/ 
//            |______  / / ____| /___/\  \|__|         
//                   \/  \/            \_/             
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string f = args[0];
                string code = FCompiler(f);
            }
            else
            {
                Console.WriteLine("ERROR: No arguments detected!\nUsage is \"SXZC <file>\"");
            }
        }

        private static String FCompiler(string s)
        {
            String code = File.ReadAllText(s);
            //                                                  SX                  translated to
            code = code.Replace("哇", "import");//               wa                      import
            code = code.Replace("你", "input");//                ni                      input
            code = code.Replace("我", "print");//                wo                      print
            code = code.Replace("哈", "for");//                  ha                      for
            code = code.Replace("的", "from");//                 de                      from
            code = code.Replace("喲", "replace");//              yo                      replace
            code = code.Replace("因", "join");//                 yin                     join
            code = code.Replace("樣", "in");//                   yang                    in
            code = code.Replace("和", "for i in range");//       he                      for i in range
            code = code.Replace("及", "while");//                ji                      while
            code = code.Replace("卡", "math");//                 ka                      math
            code = code.Replace("死", "sys");//                  si                      sys
            code = code.Replace("木", "os");//                   mu                      os
            code = code.Replace("圖", "is");//                   tu                      is
            code = code.Replace("從", "main");//                 co                      main
            code = code.Replace("買", "Main");//                 mai                     Main
            code = code.Replace("那", "def");//                  na                      def
            code = code.Replace("其", "class");//                qi                      class
            code = code.Replace("狗", "not");//                  go                      not
            code = code.Replace("才", "+=1");//                  cai                     +=1
            code = code.Replace("開", "-=1");//                  kai                     -=1
            code = code.Replace("先", "while True:");//          xian                    while True:
            code = code.Replace("特", "True");//                 te                      True
            code = code.Replace("分", "False");//                fe                      False
            code = code.Replace("怒", "None");//                 nu                      None
            code = code.Replace("日", "def __init(self");//      ri                      def __init__(self
            code = code.Replace("送", "def __init__(self):");//  so                      def __init__(self):
            code = code.Replace("提", "iter");//                 ti                      iter
            code = code.Replace("去", "()");//                   qu                      ()
            code = code.Replace("品", "math.pi");//              poin                    math.pi
            code = code.Replace("（", "（");//                   （                      (
            code = code.Replace("）", ")");//                    ）                      )
            code = code.Replace("鞥", "eval");//                 eng                     eval
            code = code.Replace("@", "self");//                  @                       self
            code = code.Replace("怕", "open");//                 pa                      open
            code = code.Replace("爲", "range");//                we                      range
            code = code.Replace("熱", "len");//                  re                      len
            code = code.Replace("空", "float");//                ko                      float
            code = code.Replace("aint", "is not");//             aint                    is not
            code = code.Replace("重", "int");//                  cho                     int
            code = code.Replace("胡", "return");//               hu                      return
            code = code.Replace("哎", "lambada");//              ai                      lambada
            code = code.Replace("徐", "str");//                  xu                      str
            code = code.Replace("了", "else");//                 le                      else
            code = code.Replace("也", "elif");//                 ye                      elif
            code = code.Replace("值", "break");//                zhi                     break
            code = code.Replace("水", "pass");//                 shui                    pass
            File.WriteAllText(s+".py", code);
            return code;
        }

        private static String Compiler(string s)
        {
            String code = s;
            code = code.Replace("哇", "import");//               wa                      import
            code = code.Replace("你", "input");//                ni                      input
            code = code.Replace("我", "print");//                wo                      print
            code = code.Replace("哈", "for");//                  ha                      for
            code = code.Replace("的", "from");//                 de                      from
            code = code.Replace("喲", "replace");//              yo                      replace
            code = code.Replace("因", "join");//                 yin                     join
            code = code.Replace("樣", "in");//                   yang                    in
            code = code.Replace("和", "for i in range");//       he                      for i in range
            code = code.Replace("及", "while");//                ji                      while
            code = code.Replace("卡", "math");//                 ka                      math
            code = code.Replace("死", "sys");//                  si                      sys
            code = code.Replace("木", "os");//                   mu                      os
            code = code.Replace("圖", "is");//                   tu                      is
            code = code.Replace("從", "main");//                 co                      main
            code = code.Replace("買", "Main");//                 mai                     Main
            code = code.Replace("哇", "def");//                  wa                      def
            code = code.Replace("其", "class");//                qi                      class
            code = code.Replace("狗", "not");//                  go                      not
            code = code.Replace("才", "+=1");//                  cai                     +=1
            code = code.Replace("開", "-=1");//                  kai                     -=1
            code = code.Replace("先", "while True:");//          xian                    while True:
            code = code.Replace("特", "True");//                 te                      True
            code = code.Replace("分", "False");//                fe                      False
            code = code.Replace("怒", "None");//                 nu                      None
            code = code.Replace("日", "def __init(self");//      ri                      def __init__(self
            code = code.Replace("送", "def __init__(self):");//  so                      def __init__(self):
            code = code.Replace("提", "iter");//                 ti                      iter
            code = code.Replace("去", "()");//                   qu                      ()
            code = code.Replace("品", "math.pi");//              poin                    math.pi
            code = code.Replace("（", "（");//                   （                      (
            code = code.Replace("）", ")");//                    ）                      )
            code = code.Replace("鞥", "eval");//                 eng                     eval
            code = code.Replace("@", "self");//                  @                       self
            code = code.Replace("怕", "open");//                 pa                      open
            code = code.Replace("爲", "range");//                we                      range
            code = code.Replace("熱", "len");//                  re                      len
            code = code.Replace("空", "float");//                ko                      float
            code = code.Replace("aint", "is not");//             aint                    is not
            code = code.Replace("重", "int");//                  cho                     int
            code = code.Replace("胡", "return");//               hu                      return
            code = code.Replace("哎", "lambada");//              ai                      lambada
            code = code.Replace("徐", "str");//                  xu                      str
            code = code.Replace("了", "else");//                 le                      else
            code = code.Replace("也", "elif");//                 ye                      elif
            code = code.Replace("值", "break");//                zhi                     break
            code = code.Replace("水", "pass");//                 shui                    pass
            return code;
        }
    }
}
