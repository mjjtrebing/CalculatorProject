using System;
using System.Collections;


namespace CalculatorProject
{
    internal class OperatorHandler
    {


        ArrayList holder;
        String var;
        public OperatorHandler()
        {
            holder = new ArrayList();
            var = "hello everyone im in a calc";
        }
        public String getVar()
        {
            return var;
        }
        
    }//THERE IS ROOM FOR THIS TO BE AN ARRAY SINCE THERE IS ONLY EVER 3 ENTITIES IN THE ARRAY//

    /*current plan: whenever someone hits a number it adds to the display box, BUT when they
    when they hit an operator it searches the array to make sure there are no other operator functions to perform
    after it sees there are none to perform, it adds the current number to the array list as a string, it also adds the operator to the array list as a string but with a new index.
    At this point the screen is whiped and a new number can be put in. at this point if another operator is hit  the array list is searched and then performs the operating. 
    EX: [12],[+][3][/][5][3]
    15->[15][/][5][=][3]
    */
}