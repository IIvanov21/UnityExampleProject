using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    int a; //Stores integers/ whole numbers 1, 2, 500, 358
    double b; //Stores decimal point numbers but only does it 11.22, 11.5, 19.99 but it won't allow you to store something like 19.999
    float c; // Stores decimal point numbers 19.9564989
    char d; //Stores only a single character inside such as 'a' , 'b', 'c'
    string e;//Stores combination of character together i.e. words, sentences etc..
    bool f; // Stores true or false value

    const int i = 0; // Constant ensures that the value of your variable doesn't get changed throught the game.

    //Multiple variables declaration
    int a1=0, a2=15, a3=64, a4=138;

    /*int a1;
    int a2;
    int a3;
    int a4;*/

    //Consistent variable names
    //Good naming conventions
    int playerHealth;
    int playerScore;
    int health;
    int score;
    //Bad naming conventions
    int pH;
    int pS;
    int h;
    int s;

 
    // Start is called before the first frame update
    void Start()
    {
        a = 1;//Whole number
        b = 2.99;//Decimal to two points
        c = 3.456789f;//Decimal point number
        d = 'a';//Single character
        e = "Ivo";//Text inside strings is not case sensitive
        f = true;
        //f = false; //To repesent a false value !f or to represent a true f
        
        //When we run the program all of the code in here
        //will get exected only once
        Debug.Log("Hello World from the Start function!" + e);
        Debug.Log(a);

        string name = "Ivo";
        int age = 24;

        //Type casting with variables
        float decimalScore = 15.6f;
        Debug.Log(decimalScore);
        int intScore;
        intScore = (int)decimalScore;
        Debug.Log(intScore);

        string number = intScore.ToString();

        /*
         * Arithemic Opeartors
         * + Addition
         * - Subtraction
         * * Multiplication
         * / Division
         * % Modules
         * ++ Increment
         * -- Decrement
         */
        int k = 5;
        int l = 6;

        int addition = k + l ;
        int subtraction = k - l;
        int multiplication = k * l;
        int division = k / l;
        int modules = k % l;

        k++;//Takes the value stored inside k which is 5 and increments by 1 effectivly the value becomes 6
        k--;//Decreases the value by 1

        /*
         * Assigment operators
         * =  x = 5 or a = b + c
         * += x=5 x+=b+c
         * -=
         * *=
         * /=
         * %=
         */
        //+= example
        k += l;
        k = k + l;

        //-= example
        k -= l;
        k = k - l;

        /*
         * Comparison operators
         * == Equal to
         * != Not Equal to
         * > Greater than
         * <  Less than
         * >= Greater or Equal to
         * <= Less Than or Equal to
         */

        /*
         * Logical Operators
         * && Logical and name=="Ivo" && myAge==24
         * || Logical or  name=="Ivo" || myAge==24
         * ! Logical not  !f same as f == false
         */

        int ivoAge = 24;
        int chrisAge = 54;
        int chrisIvo = ivoAge * chrisAge;

        Debug.Log(chrisIvo);

        if (chrisAge < 30)
        {
            Debug.Log("Chris wishes to be young!");
        }
        else if (chrisAge > 30)
        {
            Debug.Log("We know Chris is old!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //IF our frame rate was 60 frames per second
        //our code in the Update function will get executed 60 times per second
        
        //Display a message from Update function into the console
        //Debug.Log("Hello World from the Update function!");
    }

    // Single line comments

    /*
     * Multiline comment
     */
}


