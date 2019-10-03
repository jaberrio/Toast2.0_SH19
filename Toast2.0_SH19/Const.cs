using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toast2._0_SH19
{
    public static class Const
    {
        enum S { PLUS = 1, MINUS = -1 };
        enum E { JOY = 0, FEAR = 1, DISG = 2, SURP = 3, SAD = 4, ANG = 5 };

        public static string[] emoS = new string[] {
            "Joy",      //0
            "Fear",     //1
            "Disgust",  //2
            "Surprise", //3
            "Sadness",  //4
            "Anger" };  //5
        public static string[] bigS = new string[] {
            "Neurotic",
            "Agreeable",
            "Open",
            "Extrovert",
            "Conscientious" };

        public static double[] weights = {
            0.54d,      //Joy
            0.88d,      //Fear
            0.84d,      //Disgust
            0.86d,      //Surprise
            0.87d,      //Sadness
            0.98d };    //Anger
            
        public static double[] logicWeight = new double[]
        {
            //Logic Pair of Emotion Index, Weighed Value, and Additon
            //Use Weighted value of ZERO to an entry for no input
            
            /*Neurotic*/    (int)E.FEAR ,0.5d,
            (int)S.PLUS,    (int)E.SAD  ,0.9d,
            (int)S.PLUS,    (int)E.ANG  ,0.5d,
            (int)S.PLUS,               0,0,
            
            /*Agreeable*/   (int)E.JOY  ,1.0d,
            (int)S.MINUS,   (int)E.DISG ,0.5d,
            (int)S.MINUS,   (int)E.ANG  ,0.4d,
            (int)S.PLUS,               0,0,
        
            /*Open*/        (int)E.SURP ,1.0d,
            (int)S.MINUS,   (int)E.DISG ,0.5d,
            (int)S.MINUS,   (int)E.FEAR ,0.4d,
            (int)S.PLUS,    (int)E.JOY  ,0.3d,
        
            /*Extrovert*/   (int)E.JOY  ,0.7d,
            (int)S.PLUS,    (int)E.SURP ,0.8d,
            (int)S.MINUS,   (int)E.SAD  ,0.4d,
            (int)S.MINUS,   (int)E.FEAR ,1.0d,
        
            /*Conscitious*/ (int)E.JOY  ,1.0d,
            (int)S.PLUS,    (int)E.DISG ,0.8d,
            (int)S.MINUS,   (int)E.ANG  ,0.2d,
            (int)S.PLUS,               0,0      };
    }

    

}
