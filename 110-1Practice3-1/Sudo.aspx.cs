using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice3_1
{
    public partial class Sudo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[,] ia_2DMap = new int[9, 9]{ { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                                             { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                                             { 1, 9, 8, 3, 4, 2, 5, 6, 7 },
                                             { 8, 5, 9, 7, 6, 1, 4, 2, 3 },
                                             { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                                             { 7, 1, 3, 9, 2, 4, 8, 5, 6 },
                                             { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                                             { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                                             { 3, 4, 5, 2, 8, 6, 1, 7, 9 } };
            if (mt_IsRowPass(ia_2DMap) == true && mt_IsColPass(ia_2DMap) == true && mt_IsGridPass(ia_2DMap) == true)
            {
                Response.Write("True");
            }
            else
            {
                Response.Write("False");
            }
        }
        public bool mt_IsRowPass(int[,] ia_2DMap)
        {
            bool b_ISSue = true;
            bool[] ba_Marked = new bool[9] { false, false, false, false, false, false, false, false, false };
            for (int c = 0; c < 9; c++)
            {
                for (int b = 0; b < 9; b++)
                {
                    ba_Marked[b] = false;
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    if (ia_2DMap[c, i].Equals(String.Empty) == false)
                    {
                        ba_Marked[i] = true;
                    }
                    else
                    {
                        b_ISSue = false;
                        break;
                    }
                    
                    for (int a = 0; a < 9; a++)
                    {
                        int x = ia_2DMap[c, a];
                        for (int b = a + 1; b < 9; b++)
                        {
                            if (x != ia_2DMap[c, b])
                            {
                                continue;
                            }
                            else
                            {
                                b_ISSue = false;
                                break;
                            }
                        }
                    }
                }
            }
            return b_ISSue;
        }


        public bool mt_IsColPass(int[,] ia_2DMap)
        {
            bool b_ISSue = true;
            for (int i = 0; i < 9; i++)
            {
                
                for (int a = 0; a < 9; a++)
                {
                    int x = ia_2DMap[a, i];
                    for (int b = a + 1; b < 9; b++)
                    {
                        if (x != ia_2DMap[b, i])
                        {
                            continue;
                        }
                        else
                        {
                            b_ISSue = false;
                            break;
                        }
                    }
                }
            }
            return b_ISSue;
        }

        public bool mt_IsGridPass(int[,] ia_2DMap)
        {
            bool b_ISSue = true;
            for (int g = 0; g <= 6; g += 3)
            {
                for (int a = 0; a < 3; a++)
                {
                    int x = ia_2DMap[g, a];
                    for (int b = a + 1; b < 3; b++)
                    {
                        if (x != ia_2DMap[g, b] && x != ia_2DMap[g + 1, b] && x != ia_2DMap[g + 2, b])
                        {
                            continue;
                        }
                        else
                        {
                            b_ISSue = false;
                            break;
                        }
                    }
                }
                for (int a = 3; a <= 6; a++)
                {
                    int y = ia_2DMap[g, a];
                    for (int b = a + 1; b < 6; b++)
                    {
                        if (y != ia_2DMap[g, b] && y != ia_2DMap[g + 1, b] && y != ia_2DMap[g + 2, b])
                        {
                            continue;
                        }
                        else
                        {
                            b_ISSue = false;
                            break;
                        }
                    }
                }
                for (int a = 6; a < 9; a++)
                {
                    int z = ia_2DMap[g, a];
                    for (int b = a + 1; b < 6; b++)
                    {
                        if (z != ia_2DMap[g, b] && z != ia_2DMap[g + 1, b] && z != ia_2DMap[g + 2, b])
                        {
                            continue;
                        }
                        else
                        {
                            b_ISSue = false;
                            break;
                        }
                    }
                }
            }
            return b_ISSue;
        }
    }
}