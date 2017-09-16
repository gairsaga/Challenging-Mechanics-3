using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenging_Mechanics_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // adding variable for coding
            bool answer;
            int number1 = 10, number2 = 15, number3 = 5, number4 = 75, number5 = 3;
            //question 1
            answer = 5 < 10 && 4 > 2;
            //question 2
            answer = 6 < 10 && 56 < 64;
            //question 3
            answer = 5 < 10 && 54 == 54.0;
            //question 4
            answer = 60 > 10 && 98 <= 120;
            //question 5
            answer = !(200 > 10 && 5 > 68);
            //question 6
            answer = 100.0 > 200.00 && 56 == 68;
            //quesstion 7
            answer = 3 == 3 || 56 > 25;
            //question 8
            answer = 16 == 64 || 56 <= 35;
            //question 9
            answer = 10 == 2*5 || 45 == 54;
            //question 10
            answer = !(16 != 16) || 13 != 35;
            //question 11 
            answer = 20 != 20.0001 || 50 == 34;
            //question 12  
            answer = 3 <= 4 ^ 40 > 50;
            //question 13 
            answer = 13 <= 67 ^ 67 != 67.0;
            //question 14 
            answer = 15 <= 98.0 && 13 < 30 && 14 >= 3;
            // question 15 
            answer = 25 >= 10 || 20 >= 13 || 2 * 8 >= 10;
            // question 16
            answer = 10 * 100 >= 10 * 5 && 3 * 100 >= 30 * 10 && 12 * 12 <= 13 * 13;
            // question 17
            answer = 12 > 6 && 56 < 193 || 45 > 43;
            // question 18  
            answer = 23 < 64 || 34 != 25 && 35 < 56;
            // question 19 
            answer = 93 != 14 ^ 34 < 15 || 56 > 29;
            // question 20 12 is greater than 4 AND 15 is greater than 25 OR 16 is less than 83 AND 73 is not equal to 23 
            answer = 12 > 4 && 15 > 25 || 16 < 83 & 773 != 23;


            //If (else)  Statements  with logic operators question 21-35
            //21
            if (4 > 1 && 5 > 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //22
            if (11.6 > 11.5 && 35 < 109) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //23
            if (number2 < 21 && number2 > 15.5) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //24
            if (11 > 5 && 42 > 34) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //25
            if (10 > -29 && 64 < 155) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //26
            if (11.6 > 11.5 && 10 > -29) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //27
            if (number1 > 1 && 19 > number1) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //28
            if (!(19 > number1 && number2 < 32))
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //29
            if (number3 < 32 && number1 > 1) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //30
            if (number3 == 5 || number3 == 75) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //31
            if (number3 != 5 || number5 > 17) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //32
            if (number1 != 33 || number5 > 17) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //33
            if (number5 != 1 ^ number2 != 16) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //34
            if (number3 != 1 && number3 != 4 && number3 != 8) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //35
            if (number4 != 81 || number4 != 81 || number4 != 10) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

            //Nested If Statements question 36-45
            //36
            if (4 > 1 && 5 > 1)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //37
            if (62 < 124 && 43 > 40) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //38
            if (2437 != 1 && 5 > 10.6) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //39
            if (14 == 14.0 && 16 > 10) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //40
            if (number1 >= 2 && number1 <= 11)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //41
            if (14 >= number2 && number2 <= 38) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //42
            if (number3 != 19 && 13 != number3) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //43
            if (number4 != 25 && number4 != 97) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //44
            if (number5 > -21 && number5 != 91) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //45
            if (number1 != 25 && number2 != number3) 
            {
                answer = true;
            }
            else
            {
                answer = false;
            }


            // If-elseif  Statements question 46-50

            //46
            if (number1 > 1 && number1 < 12 ) 
                {
                answer = true;
            } else  if (number1 >= 12 && number1 < 23)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //47
            if (number2 > -134 && number2 < 0) 
            {
                answer = true;
            } else  if (number2 >= 10 || number2 == 4)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            //48
            if (number3 == 19 || number3 == 13)
            {
                answer = true;
            }
            else if (number3 == 12 || number3 < 2) 
            {
                answer = true;
            }
            else
            {
            //49
            if (number4 < 10 ^ number4 == 4)
            {
                    answer = true;
            }
             else if (!(number4 >= 14 && number4 < 17)) 
            {
                    answer = true;
            }
             else
                {
            //50
            if (number5 > 83 && number4 < 12) 
            {
                        answer = true;
            }
            else if (!(number3 >= 12 || number2 < 23)) 
            {
                        answer = true;
            }
            else
            {

















                    }
    }
}
